namespace WinFormsComInterop.SourceGenerator
{
    using Microsoft.CodeAnalysis;

    internal static class RoslynExtensions
    {
        internal static bool IsEnum(this ITypeSymbol type)
        {
            return type.BaseType?.Name == "Enum";
        }
    }
}
