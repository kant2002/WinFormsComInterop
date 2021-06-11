using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WinFormsComInterop.SourceGenerator
{
    internal class WrapperGenerationContext
    {
        private readonly GeneratorExecutionContext context;
        private Dictionary<string, string> aliasMap = new();

        public WrapperGenerationContext(GeneratorExecutionContext context)
        {
            this.context = context;
            BuildAliasMap();
        }

        private void BuildAliasMap()
        {
            foreach (var metadataReference in this.context.Compilation.References)
            {
                if (metadataReference.Display == null)
                {
                    continue;
                }

                if (metadataReference.Properties.Aliases != null && metadataReference.Properties.Aliases.Length > 0)
                {
                    foreach (var alias in metadataReference.Properties.Aliases)
                    {
                        aliasMap.Add(Path.GetFileNameWithoutExtension(metadataReference.Display), alias);
                    }
                }
            }
        }

        public string GetAlias(INamedTypeSymbol type)
        {
            if (type == null)
            {
                return null;
            }

            if (this.aliasMap.TryGetValue(type.ContainingAssembly.Name, out var alias))
                return alias;

            return null;
        }

        public MethodGenerationContext CreateMethodGenerationContext(
            IMethodSymbol method, bool preserveSignature)
        {
            var methodContext = new MethodGenerationContext
            {
                Method = method,
                PreserveSignature = preserveSignature,
                Context = this,
            };
            return methodContext;
        }

        internal void AddSource(INamedTypeSymbol classType, INamedTypeSymbol interfaceTypeSymbol, SourceText sourceText)
        {
            var aliasSymbol = GetAlias(interfaceTypeSymbol);
            var typesuffix = interfaceTypeSymbol.FormatType(aliasSymbol).Replace(".", "_").Replace("::", "_");
            context.AddSource($"{classType.ToDisplayString().Replace(".", "_")}_{typesuffix}_comcallablewrapper.cs", sourceText);
        }
    }
}
