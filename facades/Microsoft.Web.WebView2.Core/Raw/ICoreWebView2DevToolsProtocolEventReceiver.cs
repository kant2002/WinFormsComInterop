using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("B32CA51A-8371-45E9-9317-AF021D080367")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ICoreWebView2DevToolsProtocolEventReceiver
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_DevToolsProtocolEventReceived([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2DevToolsProtocolEventReceivedEventHandler handler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_DevToolsProtocolEventReceived([In] EventRegistrationToken token);
}