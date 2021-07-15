namespace WinFormsComInterop.SourceGenerator
{
    using Microsoft.CodeAnalysis;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;

    internal sealed class MethodGenerationContext
    {
        public MethodGenerationContext(IMethodSymbol method, ITypeSymbol wrapperClass, WrapperGenerationContext context)
        {
            Method = method;
            WrapperClass = wrapperClass;
            Context = context;
        }

        public IMethodSymbol Method { get; }

        public ITypeSymbol WrapperClass { get; }

        internal WrapperGenerationContext Context { get; }
        public bool PreserveSignature { get; set; }
        public int ComSlotNumber { get; set; }

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

        private UnmanagedType? GetMarshalAs(System.Collections.Immutable.ImmutableArray<AttributeData> attributes)
        {
            var marshalAsAttribute = attributes
                .FirstOrDefault(_ => _.AttributeClass?.ToDisplayString() == "System.Runtime.InteropServices.MarshalAsAttribute"
                    || _.AttributeClass?.ToDisplayString() == "System.Runtime.InteropServices.CustomMarshalAsAttribute");
            UnmanagedType? unmanagedType = null;
            if (marshalAsAttribute != null)
            {
                unmanagedType = (UnmanagedType)(int)marshalAsAttribute.ConstructorArguments[0].Value!;
            }

            return unmanagedType;
        }

        public Marshaller CreateMarshaller(IParameterSymbol parameterSymbol)
        {
            var unmanagedType = GetMarshalAs(parameterSymbol.GetAttributes());
            return CreateMarshaller(parameterSymbol, unmanagedType, this);
        }

        public Marshaller CreateReturnMarshaller()
        {
            var unmanagedType = GetMarshalAs(Method.GetReturnTypeAttributes());
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

        public Marshaller CreateElementMarshaller(IArrayTypeSymbol arrayTypeSymbol, string prefix)
        {
            Marshaller marshaller = CreateMarshaller(arrayTypeSymbol.ElementType, null);
            marshaller.Name = "arrayItem";
            marshaller.Type = arrayTypeSymbol.ElementType;
            marshaller.RefKind = RefKind.None;
            marshaller.Index = 0;
            marshaller.LocalVariablePrefix = prefix;
            marshaller.TypeAlias = this.GetAlias(arrayTypeSymbol.ElementType);
            marshaller.Context = this;
            return marshaller;
        }

        public Marshaller CreateFieldMarshaller(IFieldSymbol fieldSymbol, string prefix, int index)
        {
            Marshaller marshaller = CreateMarshaller(fieldSymbol.Type, null);
            marshaller.Name = prefix + "_" + fieldSymbol.Name;
            marshaller.Type = fieldSymbol.Type;
            marshaller.RefKind = RefKind.None;
            marshaller.Index = index;
            marshaller.LocalVariablePrefix = prefix;
            marshaller.TypeAlias = this.GetAlias(fieldSymbol.Type);
            marshaller.Context = this;
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

            if (parameterSymbol is IArrayTypeSymbol arrayTypeSymbol)
            {
                if (IsBlittableType(arrayTypeSymbol.ElementType))
                {
                    return new BlittableArrayMarshaller();
                }
                else
                {
                    return new ArrayMarshaller();
                }
            }

            if (parameterSymbol.TypeKind == TypeKind.Struct && parameterSymbol.SpecialType == SpecialType.None)
            {
                if (IsBlittableType(parameterSymbol))
                    return new BlittableStructMarshaller();

                return new StructMarshaller();
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

        public static bool IsBlittableType(ITypeSymbol elementType)
        {
            if (elementType.TypeKind == TypeKind.Pointer)
            {
                return true;
            }

            if (elementType.TypeKind == TypeKind.Interface
                || elementType.TypeKind == TypeKind.Class
                || elementType.TypeKind == TypeKind.Delegate)
            {
                return false;
            }

            switch (elementType.SpecialType)
            {
                case SpecialType.System_Int32:
                case SpecialType.System_UInt32:
                case SpecialType.System_Int16:
                case SpecialType.System_UInt16:
                case SpecialType.System_Int64:
                case SpecialType.System_UInt64:
                case SpecialType.System_Boolean:
                case SpecialType.System_Byte:
                case SpecialType.System_SByte:
                case SpecialType.System_IntPtr:
                case SpecialType.System_UIntPtr:
                case SpecialType.System_Single:
                case SpecialType.System_Double:
                case SpecialType.System_Enum:
                    return true;
                case SpecialType.System_String:
                case SpecialType.System_Object:
                case SpecialType.System_Decimal:
                case SpecialType.System_Nullable_T:
                    return false;
            }

            if (elementType.TypeKind == TypeKind.Enum)
            {
                return true;
            }

            if (elementType is IArrayTypeSymbol arrayType)
            {
                return IsBlittableType(arrayType.ElementType);
            }

            if (elementType.TypeKind == TypeKind.Struct)
            {
                foreach (var fields in elementType.GetMembers().OfType<IFieldSymbol>())
                {
                    if (fields.IsStatic)
                    {
                        continue;
                    }

                    if (!IsBlittableType(fields.Type))
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }
    }
}
