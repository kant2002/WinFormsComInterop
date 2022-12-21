using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[Guid("5B495469-E119-438A-9B18-7604F25F2E49")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ICoreWebView2NavigationStartingEventArgs
{
    [DispId(1610678272)]
    [return: MarshalAs(UnmanagedType.LPWStr)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    string get_uri();

    [DispId(1610678273)]
    int IsUserInitiated
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678274)]
    int IsRedirected
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678275)]
    ICoreWebView2HttpRequestHeaders RequestHeaders
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.Interface)]
        get;
    }

    [DispId(1610678276)]
    int Cancel
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }

    [DispId(1610678278)]
    ulong NavigationId
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }
}
