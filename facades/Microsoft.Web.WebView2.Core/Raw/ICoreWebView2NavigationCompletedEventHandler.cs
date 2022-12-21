using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[Guid("D33A35BF-1C49-4F98-93AB-006E0533FE1C")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ICoreWebView2NavigationCompletedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2 sender, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2NavigationCompletedEventArgs args);
}
