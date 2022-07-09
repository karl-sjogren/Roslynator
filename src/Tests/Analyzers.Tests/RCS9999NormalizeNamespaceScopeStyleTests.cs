// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Roslynator.CSharp.CodeFixes;
using Roslynator.Testing.CSharp;
using Xunit;

namespace Roslynator.CSharp.Analysis.Tests
{
    public class RCS9999PNormalizeNamespaceScopeStyleTests : AbstractCSharpDiagnosticVerifier<NormalizeNamespaceScopeStyleAnalyzer, NormalizeNamespaceScopeStyleCodeFixProvider>
    {
        public override DiagnosticDescriptor Descriptor { get; } = DiagnosticRules.NormalizeNamespaceScopeStyle;

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.NormalizeNamespaceScopeStyle)]
        public async Task Test_PreferFileScope_BlockScopedNamespace()
        {
            await VerifyDiagnosticAndFixAsync(@"
using System;

[|namespace Foo
{
    public class Bar
    {

    }
}|]
", @"
using System;

namespace Foo;

public class Bar
{

}
", options: Options.AddConfigOption("dotnet_diagnostic.RCS9999.severity", "suggestion").AddConfigOption(ConfigOptionKeys.NamespaceScopeStyle, "file"));
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.NormalizeNamespaceScopeStyle)]
        public async Task Test_PreferFileScope_FileScopedNamespace()
        {
            await VerifyNoDiagnosticAsync(@"
using System;

namespace Foo;

public class Bar
{

}
", options: Options.AddConfigOption("dotnet_diagnostic.RCS9999.severity", "suggestion").AddConfigOption(ConfigOptionKeys.NamespaceScopeStyle, "file"));
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.NormalizeNamespaceScopeStyle)]
        public async Task Test_PreferBlockScope_FileScopedNamespace()
        {
            await VerifyDiagnosticAsync(@"
using System;

[|namespace Foo;

public class Bar
{

}|]
", options: Options.AddConfigOption("dotnet_diagnostic.RCS9999.severity", "suggestion").AddConfigOption(ConfigOptionKeys.NamespaceScopeStyle, "block"));
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.NormalizeNamespaceScopeStyle)]
        public async Task Test_PreferBlockScope_BlockScopedNamespace()
        {
            await VerifyNoDiagnosticAsync(@"
using System;

namespace Foo
{
    public class Bar
    {

    }
}
", options: Options.AddConfigOption("dotnet_diagnostic.RCS9999.severity", "suggestion").AddConfigOption(ConfigOptionKeys.NamespaceScopeStyle, "block"));
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.NormalizeNamespaceScopeStyle)]
        public async Task Test_NestedNamespaces()
        {
            await VerifyDiagnosticAsync(@"
using System;

[|namespace Foo
{
    [|namespace Bar
    {
        public class Baz
        {

        }
    }|]
}|]
", options: Options.AddConfigOption("dotnet_diagnostic.RCS9999.severity", "suggestion").AddConfigOption(ConfigOptionKeys.NamespaceScopeStyle, "file"));
        }
    }
}
