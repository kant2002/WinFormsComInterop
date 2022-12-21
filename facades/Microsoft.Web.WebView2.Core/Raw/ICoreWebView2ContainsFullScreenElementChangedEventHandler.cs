using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[Guid("E45D98B1-AFEF-45BE-8BAF-6C7728867F73")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ICoreWebView2ContainsFullScreenElementChangedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2 sender, [In][MarshalAs(UnmanagedType.IUnknown)] object args);
}
