using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;


[ComImport]
[CompilerGenerated]
[Guid("03C5FF5A-9B45-4A88-881C-89A9F328619C")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ICoreWebView2HttpResponseHeaders
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void AppendHeader([In][MarshalAs(UnmanagedType.LPWStr)] string name, [In][MarshalAs(UnmanagedType.LPWStr)] string value);

    [MethodImpl(MethodImplOptions.InternalCall)]
    int Contains([In][MarshalAs(UnmanagedType.LPWStr)] string name);

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.LPWStr)]
    string GetHeader([In][MarshalAs(UnmanagedType.LPWStr)] string name);

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2HttpHeadersCollectionIterator GetHeaders([In][MarshalAs(UnmanagedType.LPWStr)] string name);

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2HttpHeadersCollectionIterator GetIterator();
}

