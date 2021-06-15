using Microsoft.CodeAnalysis;

namespace WinFormsComInterop.SourceGenerator
{
    internal class BlittableStructMarshaller : Marshaller
    {
        public override void ConvertToUnmanagedParameter(IndentedStringBuilder builder)
        {
            builder.AppendLine($"fixed ({TypeName}* {LocalVariable} = &{Name})");
        }

        public override string GetUnmanagedParameterInvocation()
        {
            switch (RefKind)
            {
                default:
                    return LocalVariable;
            }
        }
    }
}
