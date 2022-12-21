using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[Guid("30D68B7D-20D9-4752-A9CA-EC8448FBB5C1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ICoreWebView2NavigationCompletedEventArgs
{
    [DispId(1610678272)]
    int IsSuccess
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678273)]
    COREWEBVIEW2_WEB_ERROR_STATUS WebErrorStatus
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678274)]
    ulong NavigationId
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }
}