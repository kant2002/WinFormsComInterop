using Microsoft.CodeAnalysis;

namespace WinFormsComInterop.SourceGenerator
{
    internal class BlittableStructMarshaller : Marshaller
    {
        public override void ConvertToUnmanagedParameter(IndentedStringBuilder builder)
        {
            if (RefKind == RefKind.Out || RefKind == RefKind.Ref)
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
                _ => Name,
            };
        }
    }
}
