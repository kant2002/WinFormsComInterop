using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormsComInterop.SourceGenerator
{
    class ComInterfaceMarshaller : Marshaller
    {
        public string LocalVariable => $"local_{Index}";

        public override string UnmanagedTypeName => "System.IntPtr";

        public override void DeclareLocalParameter(IndentedStringBuilder builder)
        {
            if (RefKind == RefKind.None || RefKind == RefKind.In || RefKind == RefKind.Ref)
            {
                builder.AppendLine($"var {LocalVariable} = ComInterfaceDispatch.GetInstance<{FormatTypeName()}>((ComInterfaceDispatch*){Name});");
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
                builder.AppendLine($"*{Name} = Marshal.GetIUnknownForObject({LocalVariable});");
            }
        }

        public override string GetReturnDeclaration()
        {
            return $"System.IntPtr* {Name}";
        }

        public override string GetParameterInvocation()
        {
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
                builder.AppendLine($"*retVal = Marshal.GetIUnknownForObject({invocationExpression});");
                return;
            }

            var guidString = Type.GetTypeGuid();
            if (guidString == null)
            {
                builder.AppendLine($"throw new InvalidOperationException(\"No Guid attribute on the interface.\");");
                return;
            }

            builder.AppendLine($"var retValManaged = {invocationExpression};");
            builder.AppendLine($"if (retValManaged != null)");
            builder.AppendLine("{");
            builder.PushIndent();
            builder.AppendLine($"var retValLocal = Marshal.GetIUnknownForObject(retValManaged);");
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
            var guidString = Type.GetTypeGuid();
            if (guidString == null)
            {
                builder.AppendLine($"throw new InvalidOperationException(\"No Guid attribute on the interface.\");");
                return;
            }

            builder.AppendLine($"var local_{Name}_IID = new System.Guid(\"{guidString}\");");
            builder.AppendLine($"result = Marshal.QueryInterface(this.instance, ref local_{Name}_IID, out var {LocalVariable});");
            builder.AppendLine($"if (result != 0)");
            builder.AppendLine("{");
            builder.PushIndent();
            builder.AppendLine($"Marshal.ThrowExceptionForHR(result);");
            builder.PopIndent();
            builder.AppendLine("}");
            builder.AppendLine();
        }

        public override string GetUnmanagedParameterInvocation()
        {
            return LocalVariable;
        }
    }
}
