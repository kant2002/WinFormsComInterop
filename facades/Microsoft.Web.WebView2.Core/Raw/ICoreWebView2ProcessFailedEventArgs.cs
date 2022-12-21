using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[Guid("8155A9A4-1474-4A86-8CAE-151B0FA6B8CA")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ICoreWebView2ProcessFailedEventArgs
{
    [DispId(1610678272)]
    COREWEBVIEW2_PROCESS_FAILED_KIND ProcessFailedKind
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }
}
