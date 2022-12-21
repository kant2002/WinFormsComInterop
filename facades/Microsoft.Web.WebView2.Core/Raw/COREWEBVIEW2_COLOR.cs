using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
//[TypeIdentifier("26D34152-879F-4065-BEA2-3DAA2CFADFB8", "Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_COLOR")]
public struct COREWEBVIEW2_COLOR
{
    public byte A;

    public byte R;

    public byte G;

    public byte B;
}
