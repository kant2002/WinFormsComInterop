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
            if (RefKind != RefKind.None)
            {
                return $"&{LocalVariable}";
            }

            return $"({UnmanagedTypeName}){Name}";
        }

        public override void GetReturnValue(IndentedStringBuilder builder, string invocationExpression)
        {
            base.GetReturnValue(builder, $"({UnmanagedTypeName}){invocationExpression}");
        }

        public override string GetUnmanagedReturnValue()
        {
            return $"&{Name}";
        }

        public override void ConvertToUnmanagedParameter(IndentedStringBuilder builder)
        {
            if (Index == -1)
            {
                builder.AppendLine($"{UnmanagedTypeName} {Name};");
            }

            if (RefKind == RefKind.Out || RefKind == RefKind.Ref)
            {
                builder.AppendLine($"{UnmanagedTypeName} {LocalVariable};");
            }
        }

        public override void UnmarshalParameter(IndentedStringBuilder builder)
        {
            if (RefKind == RefKind.Out || RefKind == RefKind.Ref)
            {
                builder.AppendLine($"{Name} = ({FormatTypeName()}){LocalVariable};");
            }
        }
    }
}
