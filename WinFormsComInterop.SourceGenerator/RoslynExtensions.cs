namespace WinFormsComInterop.SourceGenerator
{
    using Microsoft.CodeAnalysis;
    using System.Linq;

    internal static class RoslynExtensions
    {
        internal static bool IsEnum(this ITypeSymbol type)
        {
            return type.BaseType?.Name == "Enum";
        }

        internal static string FormatType(this ITypeSymbol type, string typeAlias)
        {
            if (string.IsNullOrWhiteSpace(typeAlias))
            {
                return type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
            }

            return $"{typeAlias}::{type.ToDisplayString()}";
        }

        internal static string GetTypeGuid(this ITypeSymbol type)
        {
            var attributeData = type.GetAttributes().FirstOrDefault(_ => _.AttributeClass?.Name == "GuidAttribute");
            if (attributeData == null)
            {
                return null;
            }

            var guidString = attributeData.ConstructorArguments.FirstOrDefault();
            return (string)guidString.Value;
        }
    }
}
