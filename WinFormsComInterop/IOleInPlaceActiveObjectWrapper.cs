extern alias primitives;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop;

[RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IOleInPlaceActiveObject))]
[RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IOleCommandTarget))]
[System.Runtime.Versioning.SupportedOSPlatform("windows")]
partial class IOleInPlaceActiveObjectWrapper
{
    internal readonly IntPtr instance;

    public IOleInPlaceActiveObjectWrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~IOleInPlaceActiveObjectWrapper()
    {
        Marshal.Release(this.instance);
    }
}
