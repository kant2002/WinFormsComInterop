using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("653C2959-BB3A-4377-8632-B58ADA4E66C4")]
public interface ICoreWebView2DevToolsProtocolEventReceivedEventArgs
{
    [DispId(1610678272)]
    string ParameterObjectAsJson
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }
}
