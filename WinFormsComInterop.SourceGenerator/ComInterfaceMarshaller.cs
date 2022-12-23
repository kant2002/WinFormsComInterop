using Microsoft.CodeAnalysis;
using System;

namespace WinFormsComInterop.SourceGenerator
{
    class ComInterfaceMarshaller : Marshaller
    {
        public override string UnmanagedTypeName => "System.IntPtr";

        public override void DeclareLocalParameter(IndentedStringBuilder builder)
        {
            if (RefKind == RefKind.None)
            {
                builder.AppendLine($"var {LocalVariable} = {Name} == System.IntPtr.Zero ? null : ({FormatTypeName()})Marshal.GetObjectForIUnknown({Name});");
            }
            else if (RefKind == RefKind.In || RefKind == RefKind.Ref)
            {
                builder.AppendLine($"var {LocalVariable} = *{Name} == System.IntPtr.Zero ? null : ({FormatTypeName()})Marshal.GetObjectForIUnknown(*{Name});");
            }
            else
            {
                builder.AppendLine($"{TypeName} {LocalVariable};");
            }
        }

        public override void MarshalOutputParameter(IndentedStringBuilder builder)
        {
            //this.Type.
            if (RefKind == RefKind.Ref || RefKind == RefKind.Out)
            {
                builder.AppendLine($"*{Name} = {LocalVariable} == null ? System.IntPtr.Zero : {Context.MarshalSupportClassName}.GetIUnknownForObject({LocalVariable});");
            }
        }

        public override string GetReturnDeclaration()
        {
            return $"System.IntPtr* {Name}";
        }

        public override string GetParameterInvocation()
        {
            if (Index == -1)
            {
                return $"{Name} == System.IntPtr.Zero ? null : ({FormatTypeName()})Marshal.GetObjectForIUnknown({Name})";
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

        public override void GetReturnValue(IndentedStringBuilder builder, string invocationExpression)
        {
            if (Type.SpecialType == SpecialType.System_Object)
            {
                builder.AppendLine($"*retVal = {Context.MarshalSupportClassName}.GetIUnknownForObject({invocationExpression});");
                return;
            }

            var guidString = Type.GetTypeGuid();
            if (guidString == null)
            {
                builder.AppendLine($"throw new System.InvalidOperationException(\"No Guid attribute on the interface.\");");
                return;
            }

            builder.AppendLine($"var retValManaged = {invocationExpression};");
            builder.AppendLine($"if (retValManaged != null)");
            builder.AppendLine("{");
            builder.PushIndent();
            builder.AppendLine($"var retValLocal = {Context.MarshalSupportClassName}.GetIUnknownForObject(retValManaged);");
            builder.AppendLine($"var targetInterface = new System.Guid(\"{guidString}\");");
            builder.AppendLine("try");
            builder.AppendLine("{");
            builder.PushIndent();
            builder.AppendLine($"var hrResult = Marshal.QueryInterface(retValLocal, ref targetInterface, out *retVal);");
            builder.AppendLine($"if (hrResult < 0)");
            builder.AppendLine("{");
            builder.PushIndent();
            builder.AppendLine($"Marshal.ThrowExceptionForHR(hrResult);");
            builder.PopIndent();
            builder.AppendLine("}");
            builder.PopIndent();
            builder.AppendLine("}");
            builder.AppendLine("finally");
            builder.AppendLine("{");
            builder.PushIndent();
            builder.AppendLine($"Marshal.Release(retValLocal);");
            builder.PopIndent();
            builder.AppendLine("}");
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

            if (Type.SpecialType == SpecialType.System_Object)
            {
                builder.AppendLine($"var {LocalVariable} = {Name} == null ? System.IntPtr.Zero : {Context.MarshalSupportClassName}.GetIUnknownForObject({Name});");
                return;
            }

            var guidString = Type.GetTypeGuid();
            if (guidString == null)
            {
                builder.AppendLine($"{UnmanagedTypeName} {LocalVariable} = default;");
                builder.AppendLine($"throw new System.InvalidOperationException(\"No Guid attribute on the interface.\");");
                return;
            }

            builder.AppendLine($"System.IntPtr {LocalVariable};");
            builder.AppendLine($"if ({Name} == null)");
            builder.AppendLine("{");
            builder.PushIndent();
            builder.AppendLine($"{LocalVariable} = System.IntPtr.Zero;");
            builder.PopIndent();
            builder.AppendLine("}");
            builder.AppendLine("else");
            builder.AppendLine("{");
            builder.PushIndent();
            builder.AppendLine($"var {LocalVariable}_unk = {Context.MarshalSupportClassName}.GetIUnknownForObject({Name});");
            builder.AppendLine($"var local_{Name}_IID = new System.Guid(\"{guidString}\");");
            builder.AppendLine($"result = Marshal.QueryInterface({LocalVariable}_unk, ref local_{Name}_IID, out {LocalVariable});");
            builder.AppendLine($"if (result != 0)");
            builder.AppendLine("{");
            builder.PushIndent();
            builder.AppendLine($"Marshal.ThrowExceptionForHR(result);");
            builder.PopIndent();
            builder.AppendLine("}");
            builder.PopIndent();
            builder.AppendLine("}");
            builder.AppendLine();
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

        public override string GetUnmanagedReturnValue()
        {
            return $"&{Name}";
        }

        public override void UnmarshalParameter(IndentedStringBuilder builder)
        {
            if (RefKind == RefKind.Out || RefKind == RefKind.Ref)
            {
                builder.AppendLine($"{Name} = {LocalVariable} == System.IntPtr.Zero ? null : ({TypeName})Marshal.GetObjectForIUnknown({LocalVariable});");
            }
        }
    }
}
