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
        public override string UnmanagedTypeName
        {
            get
            {
                if (ElementType.TypeKind == TypeKind.Interface)
                {
                    return "System.IntPtr*";
                }

                return ElementType.FormatType(TypeAlias) + "*";
            }
        }

        public override void DeclareLocalParameter(IndentedStringBuilder builder)
        {
            builder.AppendLine($"var {LocalVariable} = new System.Span<{ElementType.FormatType(TypeAlias)}>({Name}, 1).ToArray();");
        }

        public override string GetParameterInvocation()
        {
            return LocalVariable;
        }

        public override void PinParameter(IndentedStringBuilder builder)
        {
            if (RefKind == RefKind.None)
            {
                if (ElementType.TypeKind == TypeKind.Interface)
                {
                    builder.AppendLine($"System.IntPtr[] {LocalVariable}_arr = new System.IntPtr[{Name}.Length];");
                    builder.AppendLine($"for (int {LocalVariable}_cnt = 0; {LocalVariable}_cnt < {Name}.Length; {LocalVariable}_cnt++)");
                    builder.AppendLine("{");
                    builder.PushIndent();
                    builder.AppendLine("throw new System.NotImplementedException();");
                    builder.PopIndent();
                    builder.AppendLine("}");
                    builder.AppendLine();
                    builder.AppendLine($"fixed ({UnmanagedTypeName} {LocalVariable} = {LocalVariable}_arr)");
                    return;
                }

                builder.AppendLine($"fixed ({UnmanagedTypeName} {LocalVariable} = {Name})");
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
