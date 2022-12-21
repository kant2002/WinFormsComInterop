using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("31E0E545-1DBA-4266-8914-F63848A1F7D7")]
public interface ICoreWebView2SourceChangedEventArgs
{
    [DispId(1610678272)]
    int IsNewDocument
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }
}
