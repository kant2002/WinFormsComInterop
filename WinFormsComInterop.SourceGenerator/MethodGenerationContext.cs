namespace WinFormsComInterop.SourceGenerator
{
    using Microsoft.CodeAnalysis;

    internal class MethodGenerationContext
    {
        public IMethodSymbol Method { get; set; }
        public bool PreserveSignature { get; set; }

        internal WrapperGenerationContext Context { get; set; }

        public string GetAlias(INamedTypeSymbol type) => Context.GetAlias(type);
    }
}
