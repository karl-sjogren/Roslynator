﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslynator.CSharp.Extensions;
using Roslynator.CSharp.Refactorings.ReplaceMethodWithProperty;
using Roslynator.Extensions;
using Roslynator.Rename;
using Roslynator.Text.Extensions;

namespace Roslynator.CSharp.Refactorings
{
    internal static class MethodDeclarationRefactoring
    {
        public static async Task ComputeRefactoringsAsync(RefactoringContext context, MethodDeclarationSyntax methodDeclaration)
        {
            if (methodDeclaration.Span.Contains(context.Span))
            {
                if (context.IsRefactoringEnabled(RefactoringIdentifiers.MarkMemberAsStatic)
                    && MarkMemberAsStaticRefactoring.CanRefactor(methodDeclaration))
                {
                    context.RegisterRefactoring(
                        "Mark method as static",
                        cancellationToken => MarkMemberAsStaticRefactoring.RefactorAsync(context.Document, methodDeclaration, cancellationToken));
                }

                await ChangeMethodReturnTypeToVoidRefactoring.ComputeRefactoringAsync(context, methodDeclaration).ConfigureAwait(false);
            }

            if (context.IsRefactoringEnabled(RefactoringIdentifiers.MarkContainingClassAsAbstract)
                && methodDeclaration.HeaderSpan().Contains(context.Span))
            {
                MarkContainingClassAsAbstractRefactoring.ComputeRefactoring(context, methodDeclaration);
            }

            if (context.IsRefactoringEnabled(RefactoringIdentifiers.ReplaceMethodWithProperty)
                && methodDeclaration.HeaderSpan().Contains(context.Span)
                && ReplaceMethodWithPropertyRefactoring.CanRefactor(methodDeclaration))
            {
                context.RegisterRefactoring(
                    $"Replace '{methodDeclaration.Identifier.ValueText}' with property",
                    cancellationToken => ReplaceMethodWithPropertyRefactoring.RefactorAsync(context.Document, methodDeclaration, cancellationToken));
            }

            if (context.IsRefactoringEnabled(RefactoringIdentifiers.UseExpressionBodiedMember)
                && methodDeclaration.Body?.Span.Contains(context.Span) == true
                && context.SupportsCSharp6
                && UseExpressionBodiedMemberRefactoring.CanRefactor(methodDeclaration))
            {
                context.RegisterRefactoring(
                    "Use expression-bodied member",
                    cancellationToken => UseExpressionBodiedMemberRefactoring.RefactorAsync(context.Document, methodDeclaration, cancellationToken));
            }

            if (context.IsRefactoringEnabled(RefactoringIdentifiers.MakeMemberAbstract)
                && methodDeclaration.HeaderSpan().Contains(context.Span)
                && MakeMemberAbstractRefactoring.CanRefactor(methodDeclaration))
            {
                context.RegisterRefactoring(
                    "Make method abstract",
                    cancellationToken => MakeMemberAbstractRefactoring.RefactorAsync(context.Document, methodDeclaration, cancellationToken));
            }

            if (context.IsRefactoringEnabled(RefactoringIdentifiers.MakeMemberVirtual)
                && methodDeclaration.HeaderSpan().Contains(context.Span))
            {
                MakeMemberVirtualRefactoring.ComputeRefactoring(context, methodDeclaration);
            }

            if (context.IsRefactoringEnabled(RefactoringIdentifiers.CopyDocumentationCommentFromBaseMember)
                && methodDeclaration.HeaderSpan().Contains(context.Span))
            {
                await CopyDocumentationCommentFromBaseMemberRefactoring.ComputeRefactoringAsync(context, methodDeclaration).ConfigureAwait(false);
            }

            if (context.IsRefactoringEnabled(RefactoringIdentifiers.RenameMethodAccordingToTypeName))
                await RenameMethodAccoringToTypeNameAsync(context, methodDeclaration).ConfigureAwait(false);
        }

        private static async Task RenameMethodAccoringToTypeNameAsync(
            RefactoringContext context,
            MethodDeclarationSyntax methodDeclaration)
        {
            TypeSyntax returnType = methodDeclaration.ReturnType;

            if (returnType?.IsVoid() == false)
            {
                SyntaxToken identifier = methodDeclaration.Identifier;

                if (context.Span.IsEmptyAndContainedInSpanOrBetweenSpans(identifier))
                {
                    SemanticModel semanticModel = await context.GetSemanticModelAsync().ConfigureAwait(false);

                    IMethodSymbol methodSymbol = semanticModel.GetDeclaredSymbol(methodDeclaration, context.CancellationToken);

                    ITypeSymbol typeSymbol = GetType(returnType, semanticModel, context.CancellationToken);

                    if (typeSymbol != null)
                    {
                        string newName = Identifier.CreateName(typeSymbol);

                        if (!string.IsNullOrEmpty(newName))
                        {
                            newName = "Get" + newName;

                            if (methodSymbol.IsAsync)
                                newName += "Async";

                            if (!string.Equals(identifier.ValueText, newName, StringComparison.Ordinal))
                            {
                                bool isUnique = await Identifier.IsUniqueMemberNameAsync(
                                    methodSymbol,
                                    newName,
                                    context.Solution,
                                    context.CancellationToken).ConfigureAwait(false);

                                if (isUnique)
                                {
                                    context.RegisterRefactoring(
                                       $"Rename method to '{newName}'",
                                       cancellationToken => Renamer.RenameSymbolAsync(context.Document, methodSymbol, newName, cancellationToken));
                                }
                            }
                        }
                    }
                }
            }
        }

        private static ITypeSymbol GetType(
            TypeSyntax returnType,
            SemanticModel semanticModel,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var returnTypeSymbol = semanticModel.GetTypeSymbol(returnType, cancellationToken) as INamedTypeSymbol;

            if (returnTypeSymbol != null)
            {
                INamedTypeSymbol taskSymbol = semanticModel.GetTypeByMetadataName(MetadataNames.System_Threading_Tasks_Task);

                if (taskSymbol != null)
                {
                    if (returnTypeSymbol.Equals(taskSymbol))
                        return null;

                    INamedTypeSymbol taskOfTSymbol = semanticModel.GetTypeByMetadataName(MetadataNames.System_Threading_Tasks_Task_T);

                    if (taskOfTSymbol != null
                        && returnTypeSymbol.ConstructedFrom.Equals(taskOfTSymbol))
                    {
                        return returnTypeSymbol.TypeArguments[0];
                    }
                }
            }

            return returnTypeSymbol;
        }
    }
}