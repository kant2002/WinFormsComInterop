using Microsoft.CodeAnalysis;

namespace WinFormsComInterop.SourceGenerator
{
    abstract class Marshaller
    {
        public string Name { get; set; }
        public ITypeSymbol Type { get; set; }

        public int Index { get; set; }

        public RefKind RefKind { get; set; }

        public string TypeAlias { get; set; }

        public string TypeName => FormatTypeName();

        public virtual string UnmanagedTypeName
        {
            get
            {
                return FormatTypeName();
            }
        }

        public virtual string GetUnmanagedParameterDeclaration()
        {
            if (RefKind != RefKind.None)
            {
                return $"{UnmanagedTypeName}* {Name}";
            }

            return $"{UnmanagedTypeName} {Name}";
        }

        public virtual string GetManagedParameterDeclaration()
        {
            return $"{FormatTypeName()} {Name}";
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

        public virtual void ConvertToUnmanagedParameter(IndentedStringBuilder builder)
        {
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
            return Name;
        }
    }
}
