using Microsoft.CodeAnalysis;

namespace WinFormsComInterop.SourceGenerator
{
    abstract class Marshaller
    {
        public IParameterSymbol ParameterSymbol { get; internal set; }

        public string Name => ParameterSymbol.Name;
        public ITypeSymbol Type => ParameterSymbol.Type;

        public virtual string GetParameterDeclaration()
        {
            if (ParameterSymbol.RefKind != RefKind.None)
            {
                return $"{Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)}* {Name}";
            }

            return $"{Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)} {Name}";
        }

        public virtual void DeclareLocalParameter(IndentedStringBuilder builder)
        {
        }

        public virtual string GetParameterInvocation()
        {
            switch (ParameterSymbol.RefKind)
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
