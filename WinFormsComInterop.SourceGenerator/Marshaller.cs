using Microsoft.CodeAnalysis;

namespace WinFormsComInterop.SourceGenerator
{
    abstract class Marshaller
    {
        public string Name { get; set; }
        public ITypeSymbol Type { get; set; }

        public int Index { get; set; }

        public RefKind RefKind { get; set; }

        public string? TypeAlias { get; set; }

        public string TypeName => FormatTypeName();

        internal MethodGenerationContext Context { get; set; }

        public virtual string UnmanagedTypeName
        {
            get
            {
                return FormatTypeName();
            }
        }

        public virtual string UnmanagedParameterTypeName
        {
            get
            {
                if (RefKind != RefKind.None)
                {
                    return $"{UnmanagedTypeName}*";
                }

                return UnmanagedTypeName;
            }
        }
        public string LocalVariable => $"local_{Index}";

        public virtual string GetUnmanagedParameterDeclaration()
        {
            return $"{UnmanagedParameterTypeName} {Name}";
        }

        public virtual string GetManagedParameterDeclaration()
        {
            switch (RefKind)
            {
                case RefKind.Out:
                    return $"out {FormatTypeName()} {Name}";
                case RefKind.Ref:
                    return $"ref {FormatTypeName()} {Name}";
                case RefKind.In:
                    return $"in {FormatTypeName()} {Name}";
                default:
                    return $"{FormatTypeName()} {Name}";
            }
        }

        public virtual string GetReturnDeclaration()
        {
            return $"{UnmanagedTypeName}* {Name}";
        }

        public virtual void GetReturnValue(IndentedStringBuilder builder, string invocationExpression)
        {
            builder.AppendLine($"*retVal = {invocationExpression};");
        }

        public virtual void DeclareLocalParameter(IndentedStringBuilder builder)
        {
        }

        public virtual void MarshalOutputParameter(IndentedStringBuilder builder)
        {
        }

        public virtual void ConvertToUnmanagedParameter(IndentedStringBuilder builder)
        {
        }

        public virtual void PinParameter(IndentedStringBuilder builder)
        {
        }

        public virtual string GetUnmanagedReturnValue()
        {
            return $"&{Name}";
        }

        protected string FormatTypeName()
        {
            return Type.FormatType(TypeAlias);
        }

        public virtual string GetParameterInvocation()
        {
            switch (RefKind)
            {
                case RefKind.Out:
                    return $"out *{Name}";
                case RefKind.Ref:
                    return $"ref *{Name}";
                case RefKind.In:
                    return $"in *{Name}";
                default:
                    return Name;
            }
        }

        public virtual string GetUnmanagedParameterInvocation()
        {
            switch (RefKind)
            {
                case RefKind.Out:
                    return $"&{Name}";
                case RefKind.Ref:
                    return $"&{Name}";
                case RefKind.In:
                    return $"&{Name}";
                default:
                    return Name;
            }
        }

        public virtual void UnmarshalParameter(IndentedStringBuilder builder)
        {
        }
    }
}
