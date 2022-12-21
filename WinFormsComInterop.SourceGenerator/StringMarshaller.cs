using Microsoft.CodeAnalysis;
using System;

namespace WinFormsComInterop.SourceGenerator
{
    internal class StringMarshaller : Marshaller
    {
        public override string UnmanagedTypeName => "System.IntPtr";

        public override void DeclareLocalParameter(IndentedStringBuilder builder)
        {
            if (RefKind == RefKind.None || RefKind == RefKind.In || RefKind == RefKind.Ref)
            {
                builder.AppendLine($"var {LocalVariable} = Marshal.PtrToStringUni({Name});");
            }
            else
            {
                builder.AppendLine($"{TypeName} {LocalVariable};");
            }
        }

        public override void MarshalOutputParameter(IndentedStringBuilder builder)
        {
            if (RefKind == RefKind.Ref || RefKind == RefKind.Out)
            {
                builder.AppendLine($"*{Name} = {LocalVariable} == null ? System.IntPtr.Zero : Marshal.StringToCoTaskMemUni({LocalVariable});");
            }
        }

        public override string GetParameterInvocation()
        {
            if (Index == -1)
            {
                return $"{Name} == System.IntPtr.Zero ? null : ({FormatTypeName()})Marshal.PtrToStringUni({Name})";
            }

            return RefKind switch
            {
                RefKind.None => LocalVariable,
                RefKind.In => $"in {LocalVariable}",
                RefKind.Out => $"out {LocalVariable}",
                RefKind.Ref => $"ref {LocalVariable}",
                _ => throw new NotImplementedException("GetParameterInvocation"),
            };
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

        public override void GetReturnValue(IndentedStringBuilder builder, string invocationExpression)
        {
            builder.AppendLine($"var retValManaged = {invocationExpression};");
            builder.AppendLine($"if (retValManaged != null)");
            builder.AppendLine("{");
            builder.PushIndent();
            builder.AppendLine("*retVal = Marshal.StringToCoTaskMemUni(retValManaged);");
            builder.PopIndent();
            builder.AppendLine("}");
            builder.AppendLine("else");
            builder.AppendLine("{");
            builder.PushIndent();
            builder.AppendLine("*retVal = System.IntPtr.Zero;");
            builder.PopIndent();
            builder.AppendLine("}");
        }

        public override void ConvertToUnmanagedParameter(IndentedStringBuilder builder)
        {
            if (Index == -1)
            {
                builder.AppendLine($"{UnmanagedTypeName} {Name};");
                return;
            }

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

            if (RefKind != RefKind.Out && Index != -1)
            {
                builder.AppendLine($"Marshal.FreeCoTaskMem({LocalVariable});");
            }
        }
    }
}
