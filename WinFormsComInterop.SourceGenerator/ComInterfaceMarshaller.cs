using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsComInterop.SourceGenerator
{
    class ComInterfaceMarshaller : Marshaller
    {
        public string LocalVariable => $"local_{Index}";
        public override string GetParameterDeclaration()
        {
            return $"System.IntPtr {Name}";
        }

        public override void DeclareLocalParameter(IndentedStringBuilder builder)
        {
            builder.AppendLine($"var {LocalVariable} = ComInterfaceDispatch.GetInstance<{Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)}>((ComInterfaceDispatch*){Name});");
        }

        public override string GetParameterInvocation()
        {
            return LocalVariable;
        }
    }
}
