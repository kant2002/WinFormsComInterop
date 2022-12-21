using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2C94DD56-E252-40A1-BA7E-B19417B26A60")]
public interface ICoreWebView2Private
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void AddHostObjectHelper([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrivateHostObjectHelper helper);
}
