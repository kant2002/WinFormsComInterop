using Microsoft.CodeAnalysis;
using System;

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

                    var marshaller = Context.CreateFieldMarshaller(fieldSymbol, Type, LocalVariable, i);
                    builder.AppendLine($"var {marshaller.Name} = {Name}.{fieldSymbol.Name};");
                    marshaller.ConvertToUnmanagedParameter(builder);
                    builder.AppendLine($"{LocalVariable}.{fieldSymbol.Name} = {marshaller.LocalVariable};");
                    i++;
                }
            }
        }
        public override void DeclareLocalParameter(IndentedStringBuilder builder)
        {
            if (Index == -1)
            {
                //builder.AppendLine($"{UnmanagedTypeName} {Name};");
                return;
            }

            if (RefKind == RefKind.None)
            {
                builder.AppendLine($"{TypeName} {LocalVariable} = default;");
                int i = 0;
                foreach (var fieldSymbol in Type.GetMembers().OfType<IFieldSymbol>())
                {
                    if (fieldSymbol.IsStatic)
                    {
                        continue;
                    }

                    var marshaller = Context.CreateFieldMarshaller(fieldSymbol, LocalVariable, i);
                    builder.AppendLine($"var {marshaller.Name} = {Name}.{fieldSymbol.Name};");
                    marshaller.UnmarshalParameter(builder);
                    builder.AppendLine($"{LocalVariable}.{fieldSymbol.Name} = {marshaller.LocalVariable};");
                    i++;
                }
            }

            if (RefKind == RefKind.Out)
            {
                builder.AppendLine($"{TypeName} {LocalVariable};");
            }
        }
        public override void MarshalOutputParameter(IndentedStringBuilder builder)
        {
            if (RefKind == RefKind.Ref || RefKind == RefKind.Out)
            {
                int i = 0;
                foreach (var fieldSymbol in Type.GetMembers().OfType<IFieldSymbol>())
                {
                    if (fieldSymbol.IsStatic)
                    {
                        continue;
                    }

                    var marshaller = Context.CreateFieldMarshaller(fieldSymbol, Type, LocalVariable, i);
                    builder.AppendLine($"var {marshaller.Name} = {LocalVariable}.{fieldSymbol.Name};");
                    marshaller.ConvertToUnmanagedParameter(builder);
                    if (MethodGenerationContext.IsBlittableType(fieldSymbol.Type))
                    {
                        builder.AppendLine($"{Name}->{fieldSymbol.Name} = {marshaller.Name};");
                    }
                    else
                    {
                        builder.AppendLine($"{Name}->{fieldSymbol.Name} = {marshaller.LocalVariable};");
                    }

                    i++;
                }
            }
        }

        public override string GetParameterInvocation()
        {
            if (Index == -1)
            {
                throw new Exception();
                //return $"{Name} == System.IntPtr.Zero ? null : ({FormatTypeName()})Marshal.PtrToStringUni({Name})";
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

        public override void PinParameter(IndentedStringBuilder builder)
        {
            if (RefKind == RefKind.Out || RefKind == RefKind.Ref || RefKind == RefKind.In)
            {
                // builder.AppendLine($"var handle_{Index} = System.Runtime.InteropServices.GCHandle.Alloc({Name}, System.Runtime.InteropServices.GCHandleType.Pinned);");
                // builder.AppendLine($"{TypeName}* {LocalVariable} = GCHandle.ToIntPtr(handle_{Index});");
                // builder.AppendLine("try");
                // builder.AppendLine("{");
                // builder.PushIndent();
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
