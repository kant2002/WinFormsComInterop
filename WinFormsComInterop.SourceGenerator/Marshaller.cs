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

        public virtual string GetParameterDeclaration()
        {
            if (RefKind != RefKind.None)
            {
                return $"{FormatTypeName()}* {Name}";
            }

            return $"{FormatTypeName()} {Name}";
        }

        public virtual void DeclareLocalParameter(IndentedStringBuilder builder)
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
    }
}
