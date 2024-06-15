using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("F8B289CB-421C-4A9A-97CC-2870B0AC1798")]
public interface ICoreWebView2PrivatePartialController
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_KeyPressed([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrivateKeyPressedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_KeyPressed([In] EventRegistrationToken token);

    [DispId(1610678274)]
    int IsBrowserHitTransparent
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }
}