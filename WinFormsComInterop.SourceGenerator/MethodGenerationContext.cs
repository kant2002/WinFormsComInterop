namespace WinFormsComInterop.SourceGenerator
{
    using Microsoft.CodeAnalysis;

    internal class MethodGenerationContext
    {
        public IMethodSymbol Method { get; set; }
        public bool PreserveSignature { get; set; }

        public string Alias { get; set; }
    }
}
