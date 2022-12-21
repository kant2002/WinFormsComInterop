using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
//[CompilerGenerated]
//[TypeIdentifier("26D34152-879F-4065-BEA2-3DAA2CFADFB8", "Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_PHYSICAL_KEY_STATUS")]
public struct COREWEBVIEW2_PHYSICAL_KEY_STATUS
{
    public uint RepeatCount;

    public uint ScanCode;

    public int IsExtendedKey;

    public int IsMenuKeyDown;

    public int WasKeyDown;

    public int IsKeyReleased;
}
