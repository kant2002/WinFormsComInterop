namespace WinFormsComInterop.SourceGenerator
{
    using Microsoft.CodeAnalysis;

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
    }
}
