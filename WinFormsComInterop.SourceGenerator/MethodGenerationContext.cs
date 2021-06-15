namespace WinFormsComInterop.SourceGenerator
{
    using Microsoft.CodeAnalysis;
    using System.Linq;

    internal class MethodGenerationContext
    {
        public IMethodSymbol Method { get; set; }
        public bool PreserveSignature { get; set; }
        public int ComSlotNumber { get; set; }

        internal WrapperGenerationContext Context { get; set; }

        public string? GetAlias(ITypeSymbol type) => Context.GetAlias(type);

        public string UnmanagedDelegateSignature
        {
            get
            {
                var preserveSignature = PreserveSignature;
                var returnMarshaller = CreateReturnMarshaller(Method.ReturnType);
                var marshallers = Method.Parameters.Select(_ =>
                {
                    var marshaller = CreateMarshaller(_);
                    return marshaller;
                });
                var parametersList = marshallers.Select(_ => $"{_.UnmanagedParameterTypeName}").ToList();
                parametersList.Insert(0, "System.IntPtr");
                if (!preserveSignature)
                {
                    if (Method.ReturnType.SpecialType != SpecialType.System_Void)
                    {
                        parametersList.Add(returnMarshaller.UnmanagedParameterTypeName + "*");
                        parametersList.Add("int");
                    }
                    else
                    {
                        parametersList.Add("int");
                    }
                }
                else
                {
                    parametersList.Add(returnMarshaller.UnmanagedParameterTypeName);
                }

                return $"delegate* unmanaged<{string.Join(", ", parametersList)}>";
            }
        }
        public Marshaller CreateMarshaller(IParameterSymbol parameterSymbol)
        {
            return CreateMarshaller(parameterSymbol, this);
        }
        public Marshaller CreateReturnMarshaller(ITypeSymbol parameterSymbol) => CreateReturnMarshaller(parameterSymbol, this);

        private Marshaller CreateMarshaller(IParameterSymbol parameterSymbol, MethodGenerationContext context)
        {
            Marshaller marshaller = CreateMarshaller(parameterSymbol.Type);
            marshaller.Name = parameterSymbol.Name;
            marshaller.Type = parameterSymbol.Type;
            marshaller.RefKind = parameterSymbol.RefKind;
            marshaller.Index = parameterSymbol.Ordinal;
            marshaller.TypeAlias = context.GetAlias(parameterSymbol.Type);
            return marshaller;
        }

        private Marshaller CreateReturnMarshaller(ITypeSymbol parameterSymbol, MethodGenerationContext context)
        {
            Marshaller marshaller = CreateMarshaller(parameterSymbol);
            marshaller.Name = "retVal";
            marshaller.Type = parameterSymbol;
            marshaller.RefKind = RefKind.None;
            marshaller.Index = -1;
            marshaller.TypeAlias = context.GetAlias(parameterSymbol);
            return marshaller;
        }

        private Marshaller CreateMarshaller(ITypeSymbol parameterSymbol)
        {
            if (parameterSymbol.IsEnum() || parameterSymbol.TypeKind == TypeKind.Enum)
            {
                return new EnumMarshaller();
            }

            if (parameterSymbol.SpecialType == SpecialType.System_String)
            {
                return new StringMarshaller();
            }

            if (parameterSymbol is IArrayTypeSymbol)
            {
                return new ArrayMarshaller();
            }

            if (parameterSymbol.TypeKind == TypeKind.Struct && parameterSymbol.SpecialType == SpecialType.None)
            {
                return new BlittableStructMarshaller();
            }

            if (parameterSymbol.TypeKind == TypeKind.Interface || parameterSymbol.SpecialType == SpecialType.System_Object)
            {
                return new ComInterfaceMarshaller();
            }

            return new BlittableMarshaller();
        }
    }
}
