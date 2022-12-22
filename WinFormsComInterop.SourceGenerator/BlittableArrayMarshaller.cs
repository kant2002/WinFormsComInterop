using Microsoft.CodeAnalysis;
using System;

namespace WinFormsComInterop.SourceGenerator
{
    internal class BlittableArrayMarshaller : Marshaller
    {
        public ITypeSymbol ElementType => ((IArrayTypeSymbol)Type).ElementType;
        public override string UnmanagedTypeName
        {
            get
            {
                return ElementTypeName + "*";
            }
        }

        internal string ArrayFirstElementRefName => Name + "Ref";

        internal string ElementTypeName => ElementType.FormatType(TypeAlias);

        public override void DeclareLocalParameter(IndentedStringBuilder builder)
        {
            var indexParameter = Context.GetParameterByIndex(ArrayIndex);
            if (RefKind == RefKind.Out)
            {
                builder.AppendLine($"var {LocalVariable}_span = new System.Span<{ElementType.FormatType(TypeAlias)}>({Name}, 1).ToArray();");
                builder.AppendLine($"var {LocalVariable} = {LocalVariable}_span.ToArray();");
            }
            else if (RefKind == RefKind.In || RefKind == RefKind.None)
            {
                builder.AppendLine($"var {LocalVariable} = new System.Span<{ElementType.FormatType(TypeAlias)}>({Name}, (int){indexParameter.Name}).ToArray();");
            }
        }

        public override string GetParameterInvocation()
        {
            return LocalVariable;
        }

        public override void ConvertToUnmanagedParameter(IndentedStringBuilder builder)
        {
            if (RefKind == RefKind.None)
            {
                builder.AppendLine($"ref {ElementTypeName} {ArrayFirstElementRefName} = ref {Name} == null ? ref *({UnmanagedTypeName})0 : ref System.Runtime.InteropServices.MemoryMarshal.GetArrayDataReference({Name});");
            }
        }

        public override void PinParameter(IndentedStringBuilder builder)
        {
            if (RefKind == RefKind.None)
            {
                builder.AppendLine($"fixed ({UnmanagedTypeName} {LocalVariable} = &{ArrayFirstElementRefName})");
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
