// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Roslynator.CSharp.CodeStyle;

namespace Roslynator.CSharp.Analysis
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public sealed class NormalizeNamespaceScopeStyleAnalyzer : BaseDiagnosticAnalyzer
    {
        private static ImmutableArray<DiagnosticDescriptor> _supportedDiagnostics;

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                if (_supportedDiagnostics.IsDefault)
                    Immutable.InterlockedInitialize(ref _supportedDiagnostics, DiagnosticRules.NormalizeNamespaceScopeStyle);

                return _supportedDiagnostics;
            }
        }

        public override void Initialize(AnalysisContext context)
        {
            base.Initialize(context);

            context.RegisterSyntaxNodeAction(f => AnalyzeNamespaceDeclaration(f), SyntaxKind.NamespaceDeclaration);
            context.RegisterSyntaxNodeAction(f => AnalyzeNamespaceDeclaration(f), SyntaxKind.FileScopedNamespaceDeclaration);
        }

        private void AnalyzeNamespaceDeclaration(SyntaxNodeAnalysisContext context)
        {
            var scopeStyle = GetPreferredNamespaceScopeStyle(context);
            if (scopeStyle == NamespaceScopeStyle.Disabled)
                return;

            if (scopeStyle == NamespaceScopeStyle.BlockScope && context.Node is NamespaceDeclarationSyntax)
                return;

            if (scopeStyle == NamespaceScopeStyle.FileScope && context.Node is FileScopedNamespaceDeclarationSyntax)
                return;

            DiagnosticHelpers.ReportDiagnostic(
                context,
                DiagnosticRules.NormalizeNamespaceScopeStyle,
                context.Node,
                scopeStyle == NamespaceScopeStyle.BlockScope ? "Change namespace declaration to block scoped." : "Change namespace declaration to file scoped.");
        }

        private NamespaceScopeStyle GetPreferredNamespaceScopeStyle(SyntaxNodeAnalysisContext context)
        {
            var configOptions = context.GetConfigOptions();
            if (ConfigOptions.TryGetValue(configOptions, ConfigOptions.NamespaceScopeStyle, out string rawValue))
            {
                if (string.Equals(rawValue, ConfigOptionValues.NamespaceScopeStyle_Block, StringComparison.OrdinalIgnoreCase))
                {
                    return NamespaceScopeStyle.BlockScope;
                }
                else if (string.Equals(rawValue, ConfigOptionValues.NamespaceScopeStyle_File, StringComparison.OrdinalIgnoreCase))
                {
                    return NamespaceScopeStyle.FileScope;
                }
            }

            return NamespaceScopeStyle.Disabled;
        }

        private enum NamespaceScopeStyle
        {
            FileScope,
            BlockScope,
            Disabled
        }
    }
}
