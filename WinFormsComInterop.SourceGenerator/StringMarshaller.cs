using System;
using System.Collections.Generic;
using System.Text;

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
            return LocalVariable;
        }

        public override void ConvertToUnmanagedParameter(IndentedStringBuilder builder)
        {
            builder.AppendLine($"var {LocalVariable} = Marshal.StringToCoTaskMemUni({Name});");
        }
    }
}
