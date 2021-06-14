using Microsoft.CodeAnalysis;

namespace WinFormsComInterop.SourceGenerator
{
    internal class EnumMarshaller : Marshaller
    {
        public override string UnmanagedTypeName => "int";
        public override string GetUnmanagedParameterDeclaration()
        {
            return $"int {Name}";
        }

        public override string GetParameterInvocation()
        {
            return $"({FormatTypeName()}){Name}";
        }

        public override string GetUnmanagedParameterInvocation()
        {
            return $"({UnmanagedTypeName}){Name}";
        }

        public override void GetReturnValue(IndentedStringBuilder builder, string invocationExpression)
        {
            base.GetReturnValue(builder, $"({UnmanagedTypeName}){invocationExpression}");
        }
    }
}
