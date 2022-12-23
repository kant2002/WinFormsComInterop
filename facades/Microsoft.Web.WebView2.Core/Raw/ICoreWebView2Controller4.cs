using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("97D418D5-A426-4E49-A151-E1A10F327D9E")]
public interface ICoreWebView2Controller4 : ICoreWebView2Controller3
{
    void _VtblGap1_33();

    [DispId(1610874880)]
    int AllowExternalDrop
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
