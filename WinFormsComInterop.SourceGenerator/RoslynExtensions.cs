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

        internal static string FormatType(this ITypeSymbol type, string? typeAlias)
        {
            if (string.IsNullOrWhiteSpace(typeAlias))
            {
                return type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
            }

            return $"{typeAlias}::{type.ToDisplayString()}";
        }

        internal static string? GetTypeGuid(this ITypeSymbol type)
        {
            var attributeData = type.GetAttributes().FirstOrDefault(_ => _.AttributeClass?.ToDisplayString() == "System.Runtime.InteropServices.GuidAttribute");
            if (attributeData == null)
            {
                if (type.ToDisplayString() == "System.Runtime.InteropServices.ComTypes.IEnumString")
                {
                    return "00000101-0000-0000-C000-000000000046";
                }

                if (type.ToDisplayString() == "System.Runtime.InteropServices.ComTypes.IStream")
                {
                    return "0000000C-0000-0000-C000-000000000046";
                }

                return null;
            }

            var guidString = attributeData.ConstructorArguments.FirstOrDefault();
            return (string?)guidString.Value;
        }
    }
}
