using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0C8A1275-9B6B-4901-87AD-70DF25BAFA6E")]
public interface ICoreWebView2ContentLoadingEventArgs
{
    [DispId(1610678272)]
    int IsErrorPage
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678273)]
    ulong NavigationId
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }
}
