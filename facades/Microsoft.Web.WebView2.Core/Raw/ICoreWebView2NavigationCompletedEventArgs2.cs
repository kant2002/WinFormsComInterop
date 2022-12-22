using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("FDF8B738-EE1E-4DB2-A329-8D7D7B74D792")]
public interface ICoreWebView2NavigationCompletedEventArgs2 : ICoreWebView2NavigationCompletedEventArgs
{
    void _VtblGap1_3();

    [DispId(1610743808)]
    int HttpStatusCode
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }
}