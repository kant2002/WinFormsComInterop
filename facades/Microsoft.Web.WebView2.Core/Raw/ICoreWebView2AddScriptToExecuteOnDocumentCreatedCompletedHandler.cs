using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("B99369F3-9B11-47B5-BC6F-8E7895FCEA17")]
public interface ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Error)] int errorCode, [In][MarshalAs(UnmanagedType.LPWStr)] string id);
}
