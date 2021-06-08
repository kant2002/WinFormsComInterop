using Microsoft.CodeAnalysis;

namespace WinFormsComInterop.SourceGenerator
{
    internal class EnumMarshaller : Marshaller
    {
        public override string GetParameterDeclaration()
        {
            return $"int {ParameterSymbol.Name}";
        }

        public override string GetParameterInvocation()
        {
            return $"({ParameterSymbol.Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)}){ParameterSymbol.Name}";
        }
    }
}
