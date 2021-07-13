using Microsoft.CodeAnalysis;

namespace WinFormsComInterop.SourceGenerator
{
    internal class StructMarshaller : Marshaller
    {
        public override string UnmanagedTypeName => $"{Type.Name}_native";
        public override void ConvertToUnmanagedParameter(IndentedStringBuilder builder)
        {
            if (Index == -1)
            {
                builder.AppendLine($"{UnmanagedTypeName} {Name};");
                return;
            }

            if (RefKind == RefKind.None)
            {
                builder.AppendLine($"{UnmanagedTypeName} {LocalVariable} = default;");
                int i = 0;
                foreach (var fieldSymbol in Type.GetMembers().OfType<IFieldSymbol>())
                {
                    if (fieldSymbol.IsStatic)
                    {
                        continue;
                    }

                    var marshaller = Context.CreateFieldMarshaller(fieldSymbol, LocalVariable, i);
                    builder.AppendLine($"var {marshaller.Name} = {Name}.{fieldSymbol.Name};");
                    marshaller.ConvertToUnmanagedParameter(builder);
                    builder.AppendLine($"{LocalVariable}.{fieldSymbol.Name} = {marshaller.LocalVariable};");
                    i++;
                }
            }
        }

        public override void PinParameter(IndentedStringBuilder builder)
        {
            if (RefKind == RefKind.Out || RefKind == RefKind.Ref || RefKind == RefKind.In)
            {
                builder.AppendLine($"fixed ({TypeName}* {LocalVariable} = &{Name})");
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
