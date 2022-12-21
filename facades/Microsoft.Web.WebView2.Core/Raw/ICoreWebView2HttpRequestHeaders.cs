using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[Guid("E86CAC0E-5523-465C-B536-8FB9FC8C8C60")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ICoreWebView2HttpRequestHeaders
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.LPWStr)]
    string GetHeader([In][MarshalAs(UnmanagedType.LPWStr)] string name);

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2HttpHeadersCollectionIterator GetHeaders([In][MarshalAs(UnmanagedType.LPWStr)] string name);

    [MethodImpl(MethodImplOptions.InternalCall)]
    int Contains([In][MarshalAs(UnmanagedType.LPWStr)] string name);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void SetHeader([In][MarshalAs(UnmanagedType.LPWStr)] string name, [In][MarshalAs(UnmanagedType.LPWStr)] string value);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void RemoveHeader([In][MarshalAs(UnmanagedType.LPWStr)] string name);

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2HttpHeadersCollectionIterator GetIterator();
}
