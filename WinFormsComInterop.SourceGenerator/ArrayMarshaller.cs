using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsComInterop.SourceGenerator
{
    internal class ArrayMarshaller : Marshaller
    {
        public string LocalVariable => $"local_{Index}";
        public ITypeSymbol ElementType => ((IArrayTypeSymbol)Type).ElementType;
        public override string UnmanagedTypeName => ElementType.FormatType(TypeAlias) + "*";

        public override void DeclareLocalParameter(IndentedStringBuilder builder)
        {
            builder.AppendLine($"var {LocalVariable} = new System.Span<{ElementType.FormatType(TypeAlias)}>({Name}, 1).ToArray();");
        }

        public override string GetParameterInvocation()
        {
            return LocalVariable;
        }
    }
}
