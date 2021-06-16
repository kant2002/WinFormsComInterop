using Microsoft.CodeAnalysis;

namespace WinFormsComInterop.SourceGenerator
{
    internal class StringMarshaller : Marshaller
    {
        public string LocalVariable => $"local_{Index}";
        public override string UnmanagedTypeName => "System.IntPtr";

        public override void DeclareLocalParameter(IndentedStringBuilder builder)
        {
            builder.AppendLine($"var {LocalVariable} = Marshal.PtrToStringUni({Name});");
        }

        public override string GetParameterInvocation()
        {
            return LocalVariable;
        }

        public override string GetUnmanagedParameterInvocation()
        {
            switch (RefKind)
            {
                case RefKind.Out:
                    return $"&{LocalVariable}";
                case RefKind.Ref:
                    return $"&{LocalVariable}";
                case RefKind.In:
                    return $"&{LocalVariable}";
                default:
                    return LocalVariable;
            }
        }

        public override void ConvertToUnmanagedParameter(IndentedStringBuilder builder)
        {
            if (RefKind == RefKind.Out)
            {
                builder.AppendLine($"{UnmanagedTypeName} {LocalVariable};");
                return;
            }

            builder.AppendLine($"var {LocalVariable} = Marshal.StringToCoTaskMemUni({Name});");
        }

        public override void UnmarshalParameter(IndentedStringBuilder builder)
        {
            if (RefKind == RefKind.Out || RefKind == RefKind.Ref)
            {
                builder.AppendLine($"{Name} = Marshal.PtrToStringUni({LocalVariable});");
            }
        }
    }
}
