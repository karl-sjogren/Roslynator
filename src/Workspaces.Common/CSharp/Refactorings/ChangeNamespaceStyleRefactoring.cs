// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Roslynator.CSharp.Refactorings
{
    internal static class ChangeNamespaceStyleRefactoring
    {
        public static async Task<Solution> RefactorAsync(
            Document document,
            NamespaceDeclarationSyntax namespaceDeclaration,
            CancellationToken cancellationToken = default)
        {
            var root = await document.GetSyntaxRootAsync(cancellationToken).ConfigureAwait(false);

            var fileScopedNamespaceDeclaration = SyntaxFactory.FileScopedNamespaceDeclaration(namespaceDeclaration.Name);

            var syntaxNodes = new[]
            {
                fileScopedNamespaceDeclaration
            }.Concat(namespaceDeclaration.ChildNodes().Where(x => x is not IdentifierNameSyntax));

            var newRoot = root.InsertNodesBefore(namespaceDeclaration, syntaxNodes);

            var newNamespaceDeclaration = newRoot.ChildNodes().FirstOrDefault(x => x is NamespaceDeclarationSyntax);
            newRoot = newRoot.RemoveNode(newNamespaceDeclaration);

            document = document.WithSyntaxRoot(newRoot.WithFormatterAnnotation());

            return document.Solution();
        }

        public static string GetTitle()
        {
            return "Change to file scoped namespace";
        }
    }
}
