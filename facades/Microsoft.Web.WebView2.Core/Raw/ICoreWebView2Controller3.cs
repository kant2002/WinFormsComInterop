using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[Guid("F9614724-5D2B-41DC-AEF7-73D62B51543B")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ICoreWebView2Controller3 : ICoreWebView2Controller2
{
    void _VtblGap1_25();

    [DispId(1610809344)]
    double RasterizationScale
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }

    [DispId(1610809346)]
    int ShouldDetectMonitorScaleChanges
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_RasterizationScaleChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2RasterizationScaleChangedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_RasterizationScaleChanged([In] EventRegistrationToken token);

    [DispId(1610809350)]
    COREWEBVIEW2_BOUNDS_MODE BoundsMode
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
