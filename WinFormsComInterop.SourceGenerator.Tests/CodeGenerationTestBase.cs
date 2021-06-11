namespace WinFormsComInterop.SourceGenerator.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Reflection;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class CodeGenerationTestBase
    {
        protected string GetGeneratedOutput(string source, NullableContextOptions nullableContextOptions)
        {
            var fakeCode = @"
public interface ICloneable
{
    void Clone();
}
";
            var fakeCompilation = CSharpCompilation.Create(
                "drawing",
                new SyntaxTree[] { CSharpSyntaxTree.ParseText(fakeCode) },
                null,
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary, nullableContextOptions: nullableContextOptions));
            
            var syntaxTree = CSharpSyntaxTree.ParseText(source);

            var references = new List<MetadataReference>();
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                if (!assembly.IsDynamic && !string.IsNullOrWhiteSpace(assembly.Location))
                {
                    references.Add(MetadataReference.CreateFromFile(
                        assembly.Location,
                        new MetadataReferenceProperties()));
                }
            }

            references.Add(fakeCompilation.ToMetadataReference().WithAliases(new[] { "drawing" }));

            var compilation = CSharpCompilation.Create(
                "foo",
                new SyntaxTree[] { syntaxTree },
                references,
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary, nullableContextOptions: nullableContextOptions));

            // var compileDiagnostics = compilation.GetDiagnostics();
            // Assert.IsFalse(compileDiagnostics.Any(d => d.Severity == DiagnosticSeverity.Error), "Failed: " + compileDiagnostics.FirstOrDefault()?.GetMessage());
            ISourceGenerator generator = new Generator();

            var driver = CSharpGeneratorDriver.Create(generator);
            driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var generateDiagnostics);
            Assert.IsFalse(generateDiagnostics.Any(d => d.Severity == DiagnosticSeverity.Error), "Failed: " + generateDiagnostics.FirstOrDefault()?.GetMessage());

            string output = outputCompilation.SyntaxTrees.Last().ToString();

            Console.WriteLine(output);

            return output;
        }
    }
}
