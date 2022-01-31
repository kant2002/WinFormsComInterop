﻿using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using static WinFormsComInterop.SourceGenerator.Generator;

namespace WinFormsComInterop.SourceGenerator
{
    internal class WrapperGenerationContext
    {
        private readonly GeneratorExecutionContext context;
        private Dictionary<string, string> aliasMap = new();
        private StringBuilder debug = new StringBuilder();
        private Dictionary<string, MethodGenerationContext> contextCache = new();

        public WrapperGenerationContext(GeneratorExecutionContext context)
        {
            this.context = context;
            BuildAliasMap();
        }

        [Conditional("DEBUG")]
        public void AddDebugLine(string line)
        {
            debug.AppendLine("// " + line);
        }

        public string DebugOutput()
        {
            return debug.ToString();
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
                        var assemblySymbol = this.context.Compilation.GetAssemblyOrModuleSymbol(metadataReference);
                        aliasMap.Add(assemblySymbol!.Name, alias);
                    }
                }
            }
        }

        public string? GetAlias(ITypeSymbol type)
        {
            if (type is IPointerTypeSymbol pointerTypeSymbol)
            {
                type = pointerTypeSymbol.PointedAtType;
            }

            if (type is IArrayTypeSymbol arrayTypeSymbol)
            {
                type = arrayTypeSymbol.ElementType;
            }

            if (type is not INamedTypeSymbol)
            {
                return null;
            }

            if (type.ContainingAssembly == null)
            {
                return null;
            }

            if (this.aliasMap.TryGetValue(type.ContainingAssembly.Name, out var alias))
            {
                return alias;
            }

            return null;
        }

        public MethodGenerationContext CreateMethodGenerationContext(
            ClassDeclaration classSymbol, IMethodSymbol method, ref int comSlotNumber)
        {
            string key = $"{GetAlias(classSymbol.Type)}_{classSymbol.Type.ToDisplayString()}_{GetAlias(method.ContainingType)}_{method.ToDisplayString()}";
            if (contextCache.TryGetValue(key, out var existingContext))
            {
                return existingContext;
            }

            var preserveSigAttribute = method.GetAttributes().FirstOrDefault(ad =>
            {
                var attributeName = ad.AttributeClass?.ToDisplayString();
                return attributeName == "System.Runtime.InteropServices.PreserveSigAttribute"
                || attributeName == "PreserveSigAttribute";
            });
            var preserveSignature = preserveSigAttribute != null;
            preserveSignature |= (method.MethodImplementationFlags & System.Reflection.MethodImplAttributes.PreserveSig) == System.Reflection.MethodImplAttributes.PreserveSig;
            var methodContext = new MethodGenerationContext(method, classSymbol.Type, this)
            {
                PreserveSignature = preserveSignature,
                ComSlotNumber = comSlotNumber,
            };
            contextCache.Add(key, methodContext);
            comSlotNumber++;
            return methodContext;
        }

        internal void AddCCWSource(INamedTypeSymbol classType, INamedTypeSymbol interfaceTypeSymbol, SourceText sourceText)
        {
            var aliasSymbol = GetAlias(interfaceTypeSymbol);
            var typesuffix = interfaceTypeSymbol.FormatType(aliasSymbol).Replace(".", "_").Replace("::", "_");
            context.AddSource($"ccw_{classType.ToDisplayString().Replace(".", "_")}_{typesuffix}.cs", sourceText);
        }

        internal void AddRCWSource(INamedTypeSymbol classType, INamedTypeSymbol interfaceTypeSymbol, SourceText sourceText)
        {
            var aliasSymbol = GetAlias(interfaceTypeSymbol);
            var typesuffix = interfaceTypeSymbol.FormatType(aliasSymbol).Replace(".", "_").Replace("::", "_");
            context.AddSource($"rcw_{classType.ToDisplayString().Replace(".", "_")}_{typesuffix}.cs", sourceText);
        }

        internal void AddComWrapperSource(INamedTypeSymbol classType, SourceText sourceText)
        {
            context.AddSource($"{classType.ToDisplayString().Replace(".", "_")}_comwrappers.cs", sourceText);
        }
    }
}
