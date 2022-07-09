// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Immutable;
using System.Composition;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslynator.CodeFixes;
using Roslynator.CSharp.Refactorings;

namespace Roslynator.CSharp.CodeFixes
{
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(NormalizeNamespaceScopeStyleCodeFixProvider))]
    [Shared]
    public sealed class NormalizeNamespaceScopeStyleCodeFixProvider : BaseCodeFixProvider
    {
        public override ImmutableArray<string> FixableDiagnosticIds
        {
            get { return ImmutableArray.Create(DiagnosticIdentifiers.NormalizeNamespaceScopeStyle); }
        }

        public override FixAllProvider GetFixAllProvider()
        {
            return null;
        }

        public override async Task RegisterCodeFixesAsync(CodeFixContext context)
        {
            SyntaxNode root = await context.GetSyntaxRootAsync().ConfigureAwait(false);

            if (!TryFindFirstAncestorOrSelf(root, context.Span, out NamespaceDeclarationSyntax namespaceDeclaration))
                return;

            string title = ChangeNamespaceStyleRefactoring.GetTitle();

            CodeAction codeAction = CodeAction.Create(
                title,
                ct => ChangeNamespaceStyleRefactoring.RefactorAsync(context.Document, namespaceDeclaration, ct),
                GetEquivalenceKey(DiagnosticIdentifiers.DeclareEachTypeInSeparateFile));

            context.RegisterCodeFix(codeAction, context.Diagnostics);
        }
    }
}
