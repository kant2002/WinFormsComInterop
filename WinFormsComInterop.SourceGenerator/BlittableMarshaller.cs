using Microsoft.CodeAnalysis;

namespace WinFormsComInterop.SourceGenerator
{
    internal class BlittableMarshaller : Marshaller
    {
        public override void ConvertToUnmanagedParameter(IndentedStringBuilder builder)
        {
            if (Index == -1 && Type.SpecialType != SpecialType.System_Void)
            {
                builder.AppendLine($"{UnmanagedTypeName} {Name};");
                return;
            }
        }

        public override void PinParameter(IndentedStringBuilder builder)
        {
            if (RefKind == RefKind.Out || RefKind == RefKind.Ref || RefKind == RefKind.In)
            {
                builder.AppendLine($"fixed ({TypeName}* {LocalVariable} = &{Name})");
            }
        }

        public override string GetUnmanagedParameterInvocation()
        {
            return RefKind switch
            {
                RefKind.Out => LocalVariable,
                RefKind.Ref => LocalVariable,
                RefKind.In => LocalVariable,
                _ => Name,
            };
        }
    }
}
