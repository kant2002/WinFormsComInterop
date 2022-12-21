using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("C10E7F7B-B585-46F0-A623-8BEFBF3E4EE0")]
public interface ICoreWebView2Deferral
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Complete();
}
