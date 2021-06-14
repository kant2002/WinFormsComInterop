namespace WinFormsComInterop.SourceGenerator
{
    using Microsoft.CodeAnalysis;
    using System.Linq;

    internal class MethodGenerationContext
    {
        public IMethodSymbol Method { get; set; }
        public bool PreserveSignature { get; set; }
        public int ComSlotNumber { get; set; }

        internal WrapperGenerationContext Context { get; set; }

        public string GetAlias(INamedTypeSymbol type) => Context.GetAlias(type);

        public string UnmanagedDelegateSignature
        {
            get
            {
                var parametersList = string.Join(", ", Method.Parameters.Select(_ => $"{_.Type}"));
                return $"delegate* unmanaged<IntPtr, byte*, uint, uint*, {Method.ReturnType}>";
            }
        }
    }
}
