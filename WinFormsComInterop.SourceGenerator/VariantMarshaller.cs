using Microsoft.CodeAnalysis;
using System;

namespace WinFormsComInterop.SourceGenerator
{
    class VariantMarshaller : Marshaller
    {
        public override string UnmanagedTypeName => "WinFormsComInterop.InteropServices.Variant";

        public override string UnmanagedParameterTypeName => Index == -1 ? UnmanagedTypeName : "WinFormsComInterop.InteropServices.Variant*";

        public override string GetReturnDeclaration()
        {
            return $"WinFormsComInterop.InteropServices.Variant* {Name}";
        }

        public override void GetReturnValue(IndentedStringBuilder builder, string invocationExpression)
        {
            builder.AppendLine($"object retValTemp = {invocationExpression};");
            builder.AppendLine($"Marshal.GetNativeVariantForObject(retValTemp, (System.IntPtr)retVal);");
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

            builder.AppendLine($"WinFormsComInterop.InteropServices.Variant {LocalVariable} = new WinFormsComInterop.InteropServices.Variant();");
            builder.AppendLine($"Marshal.GetNativeVariantForObject({Name}, (System.IntPtr)(WinFormsComInterop.InteropServices.Variant*)&{LocalVariable});");
            //throw new NotImplementedException($"{Context.Method.ToDisplayString()} {TypeName} {Name}");
        }

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
                builder.AppendLine($"Marshal.GetNativeVariantForObject({LocalVariable}, (System.IntPtr){Name});");
            }
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
                    return $"&{LocalVariable}";
            }
        }

        public override void UnmarshalParameter(IndentedStringBuilder builder)
        {
            if (RefKind == RefKind.Out || RefKind == RefKind.Ref)
            {
                builder.AppendLine($"{Name} = MarshalSupport.GetObjectForNativeVariant((System.IntPtr)(WinFormsComInterop.InteropServices.Variant*)&{LocalVariable});");
            }
        }

        public override string GetParameterInvocation()
        {
            if (Index == -1)
            {
                return $"MarshalSupport.GetObjectForNativeVariant((System.IntPtr)(WinFormsComInterop.InteropServices.Variant*)&{Name})";
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
    }
}
