using Microsoft.CodeAnalysis;

namespace WinFormsComInterop.SourceGenerator
{
    internal class BlittableArrayMarshaller : Marshaller
    {
        public ITypeSymbol ElementType => ((IArrayTypeSymbol)Type).ElementType;
        public override string UnmanagedTypeName
        {
            get
            {
                return ElementType.FormatType(TypeAlias) + "*";
            }
        }

        public override void DeclareLocalParameter(IndentedStringBuilder builder)
        {
            builder.AppendLine($"var {LocalVariable} = new System.Span<{ElementType.FormatType(TypeAlias)}>({Name}, 1).ToArray();");
        }

        public override string GetParameterInvocation()
        {
            return LocalVariable;
        }

        public override void PinParameter(IndentedStringBuilder builder)
        {
            if (RefKind == RefKind.None)
            {
                builder.AppendLine($"fixed ({UnmanagedTypeName} {LocalVariable} = {Name})");
            }
        }

        public override string GetUnmanagedParameterInvocation()
        {
            return RefKind switch
            {
                RefKind.Out => LocalVariable,
                RefKind.Ref => LocalVariable,
                RefKind.In => LocalVariable,
                _ => LocalVariable,
            };
        }
    }
}
