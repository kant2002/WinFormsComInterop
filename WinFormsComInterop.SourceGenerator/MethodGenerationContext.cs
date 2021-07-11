namespace WinFormsComInterop.SourceGenerator
{
    using Microsoft.CodeAnalysis;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;

    internal class MethodGenerationContext
    {
        public IMethodSymbol Method { get; set; }
        public bool PreserveSignature { get; set; }
        public int ComSlotNumber { get; set; }

        public ITypeSymbol WrapperClass { get; internal set; }

        internal WrapperGenerationContext Context { get; set; }

        internal IList<Marshaller> Marshallers => Method.Parameters.Select(_ => CreateMarshaller(_)).ToList();

        public string? GetAlias(ITypeSymbol type) => Context.GetAlias(type);

        public string UnmanagedDelegateSignature
        {
            get
            {
                var preserveSignature = PreserveSignature;
                var returnMarshaller = CreateReturnMarshaller();
                var marshallers = Marshallers;
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
            var marshalAsAttribute = parameterSymbol.GetAttributes()
                .FirstOrDefault(_ => _.AttributeClass?.ToDisplayString() == "System.Runtime.InteropServices.MarshalAsAttribute"
                    || _.AttributeClass?.ToDisplayString() == "System.Runtime.InteropServices.CustomMarshalAsAttribute");
            UnmanagedType? unmanagedType = null;
            if (marshalAsAttribute != null)
            {
                unmanagedType = (UnmanagedType)(int)marshalAsAttribute.ConstructorArguments[0].Value!;
            }

            return CreateMarshaller(parameterSymbol, unmanagedType, this);
        }

        public Marshaller CreateReturnMarshaller()
        {
            var marshalAsAttribute = Method.GetReturnTypeAttributes()
                .FirstOrDefault(_ => _.AttributeClass?.ToDisplayString() == "System.Runtime.InteropServices.MarshalAsAttribute");
            UnmanagedType? unmanagedType = null;
            if (marshalAsAttribute != null)
            {
                unmanagedType = (UnmanagedType)(int)marshalAsAttribute.ConstructorArguments[0].Value!;
            }

            return CreateReturnMarshaller(Method.ReturnType, unmanagedType, this);
        }

        private Marshaller CreateMarshaller(IParameterSymbol parameterSymbol, UnmanagedType? unmanagedType, MethodGenerationContext context)
        {
            Marshaller marshaller = CreateMarshaller(parameterSymbol.Type, unmanagedType);
            marshaller.Name = parameterSymbol.Name == "string" ? "@string" : parameterSymbol.Name;
            marshaller.Type = parameterSymbol.Type;
            marshaller.RefKind = parameterSymbol.RefKind;
            marshaller.Index = parameterSymbol.Ordinal;
            marshaller.TypeAlias = context.GetAlias(parameterSymbol.Type);
            marshaller.Context = context;
            return marshaller;
        }

        private Marshaller CreateReturnMarshaller(ITypeSymbol parameterSymbol, UnmanagedType? unmanagedType, MethodGenerationContext context)
        {
            Marshaller marshaller = CreateMarshaller(parameterSymbol, unmanagedType);
            marshaller.Name = "retVal";
            marshaller.Type = parameterSymbol;
            marshaller.RefKind = RefKind.None;
            marshaller.Index = -1;
            marshaller.TypeAlias = context.GetAlias(parameterSymbol);
            marshaller.Context = context;
            return marshaller;
        }

        private Marshaller CreateMarshaller(ITypeSymbol parameterSymbol, UnmanagedType? unmanagedType)
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

            if (parameterSymbol.TypeKind == TypeKind.Interface)
            {
                return new ComInterfaceMarshaller();
            }

            if (parameterSymbol.SpecialType == SpecialType.System_Object)
            {
                switch (unmanagedType)
                {
                    case UnmanagedType.IUnknown:
                    case UnmanagedType.Interface:
                    case UnmanagedType.IDispatch:
                        return new ComInterfaceMarshaller();
                    default:
                        return new VariantMarshaller();
                }
            }

            return new BlittableMarshaller();
        }
    }
}
