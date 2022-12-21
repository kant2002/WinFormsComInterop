using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("1656D586-E714-4092-9C76-014647940EFF")]
public interface ICoreWebView2PrivateHostObjectHelper
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    int IsMethodMember([In][MarshalAs(UnmanagedType.Struct)] ref object @object, [In][MarshalAs(UnmanagedType.LPWStr)] string memberName);
}