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
    }
}
