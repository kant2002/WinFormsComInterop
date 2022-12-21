using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[Guid("79E0AEA4-990B-42D9-AA1D-0FCC2E5BC7F1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ICoreWebView2ProcessFailedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2 sender, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ProcessFailedEventArgs args);
}
