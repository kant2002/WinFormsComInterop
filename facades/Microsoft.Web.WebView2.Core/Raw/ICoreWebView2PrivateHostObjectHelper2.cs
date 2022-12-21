using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("A791A659-3AD9-41C3-9C7E-768FCC233666")]
public interface ICoreWebView2PrivateHostObjectHelper2
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    int IsAsyncMethod([In][MarshalAs(UnmanagedType.Struct)] ref object @object, [In][MarshalAs(UnmanagedType.LPWStr)] string methodName, [In] int parameterCount);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void SetAsyncMethodContinuation([In][MarshalAs(UnmanagedType.Struct)] ref object @object, [In][MarshalAs(UnmanagedType.LPWStr)] string methodName, [In] int parameterCount, [In][MarshalAs(UnmanagedType.Struct)] ref object methodResult, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrivateHostObjectAsyncMethodContinuation continuation);
}
