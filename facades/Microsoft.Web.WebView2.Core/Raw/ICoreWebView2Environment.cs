using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[Guid("B96D755E-0319-4E92-A296-23436F46A1FC")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ICoreWebView2Environment
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void CreateCoreWebView2Controller(IntPtr ParentWindow, [MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2ControllerCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2WebResourceResponse CreateWebResourceResponse([In][MarshalAs(UnmanagedType.Interface)] IStream Content, [In] int StatusCode, [In][MarshalAs(UnmanagedType.LPWStr)] string ReasonPhrase, [In][MarshalAs(UnmanagedType.LPWStr)] string Headers);

    [DispId(1610678274)]
    string BrowserVersionString
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_NewBrowserVersionAvailable([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_NewBrowserVersionAvailable([In] EventRegistrationToken token);
}