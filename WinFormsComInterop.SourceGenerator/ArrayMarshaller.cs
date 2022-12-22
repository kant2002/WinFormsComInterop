using Microsoft.CodeAnalysis;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop.SourceGenerator
{
    internal class ArrayMarshaller : Marshaller
    {
        public ITypeSymbol ElementType => ((IArrayTypeSymbol)Type).ElementType;

        public Marshaller ElementMarshaller => Context.CreateElementMarshaller((IArrayTypeSymbol)Type, LocalVariable);
        public override string UnmanagedTypeName
        {
            get
            {
                return ElementMarshaller.UnmanagedTypeName + "*";
            }
        }

        public override void DeclareLocalParameter(IndentedStringBuilder builder)
        {
            builder.AppendLine($"var {LocalVariable}_length = 1;");
            builder.AppendLine($"var {LocalVariable} = new {ElementType.FormatType(TypeAlias)}[{LocalVariable}_length];");
            builder.AppendLine($"for (int {LocalVariable}_cnt = 0; {LocalVariable}_cnt < {LocalVariable}_length; {LocalVariable}_cnt++)");
            builder.AppendLine("{");
            builder.PushIndent();
            builder.AppendLine($"var arrayItem = {Name}[{LocalVariable}_cnt];");
            ElementMarshaller.DeclareLocalParameter(builder);
            builder.AppendLine($"{LocalVariable}[{LocalVariable}_cnt] = {ElementMarshaller.LocalVariable};");
            builder.PopIndent();
            builder.AppendLine("}");
            builder.AppendLine();
        }

        public override string GetParameterInvocation()
        {
            return LocalVariable;
        }

        public override void PinParameter(IndentedStringBuilder builder)
        {
            if (RefKind == RefKind.None)
            {
                // I should check for length, and allocate on heap for large numbers.
                builder.AppendLine($"System.Span<{ElementMarshaller.UnmanagedTypeName}> {LocalVariable}_arr = stackalloc {ElementMarshaller.UnmanagedTypeName}[{Name}.Length == 0 ? 1 : {Name}.Length];");
                builder.AppendLine($"for (int {LocalVariable}_cnt = 0; {LocalVariable}_cnt < {Name}.Length; {LocalVariable}_cnt++)");
                builder.AppendLine("{");
                builder.PushIndent();
                builder.AppendLine($"var arrayItem = {Name}[{LocalVariable}_cnt];");
                ElementMarshaller.ConvertToUnmanagedParameter(builder);
                builder.AppendLine($"{LocalVariable}_arr[{LocalVariable}_cnt] = {ElementMarshaller.LocalVariable};");
                builder.PopIndent();
                builder.AppendLine("}");
                builder.AppendLine();
                //builder.AppendLine($"{UnmanagedTypeName} {LocalVariable} = &{LocalVariable}_arr;");
                builder.AppendLine($"fixed ({UnmanagedTypeName} {LocalVariable} = {LocalVariable}_arr)");
            }
        }

        public override string GetUnmanagedParameterInvocation()
        {
            return RefKind switch
            {
                RefKind.Out => LocalVariable,
                RefKind.Ref => LocalVariable,
                RefKind.In => LocalVariable,
                _ => LocalVariable,
            };
        }
    }
}
