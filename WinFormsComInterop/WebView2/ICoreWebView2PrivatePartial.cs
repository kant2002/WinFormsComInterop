extern alias webview2;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

// During this change https://www.fuget.org/packages/Microsoft.Web.WebView2/1.0.1462.37/lib/netcoreapp3.0/diff/1.0.1418.22/
// was introduced renaming, so I have to keep both old and new types on wrapper.
[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2C94DD56-E252-40A1-BA7E-B19417B26A60")]
[TypeIdentifier]
public interface ICoreWebView2PrivatePartial
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void AddHostObjectHelper([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrivateHostObjectHelper helper);
}
