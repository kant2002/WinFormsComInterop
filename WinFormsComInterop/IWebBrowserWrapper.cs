extern alias primitives;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop;

#if !NET8_0_OR_GREATER
[RuntimeCallableWrapper(typeof(primitives::Interop.Mshtml.IWebBrowser2))]
[RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IOleControl))]
[RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IOleInPlaceObject))]
[RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IOleObject))]
[RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IOleInPlaceActiveObject))]
[RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IConnectionPointContainer))]
[System.Runtime.Versioning.SupportedOSPlatform("windows")]
public partial class IWebBrowserWrapper
{
    public readonly IntPtr instance;

    public IWebBrowserWrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~IWebBrowserWrapper()
    {
        Marshal.Release(this.instance);
    }
}
#endif
