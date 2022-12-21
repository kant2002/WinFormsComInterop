using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[Guid("C979903E-D4CA-4228-92EB-47EE3FA96EAB")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ICoreWebView2Controller2 : ICoreWebView2Controller
{
    void _VtblGap1_23();

    [DispId(1610743808)]
    COREWEBVIEW2_COLOR DefaultBackgroundColor
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
