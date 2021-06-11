using Microsoft.CodeAnalysis;

namespace WinFormsComInterop.SourceGenerator
{
    internal class EnumMarshaller : Marshaller
    {
        public override string GetParameterDeclaration()
        {
            return $"int {Name}";
        }

        public override string GetParameterInvocation()
        {
            return $"({FormatTypeName()}){Name}";
        }
    }
}
