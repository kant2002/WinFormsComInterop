using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("F9A2976E-D34E-44FC-ADEE-81B6B57CA914")]
public interface ICoreWebView2NewBrowserVersionAvailableEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2Environment sender, [In][MarshalAs(UnmanagedType.IUnknown)] object args);
}
