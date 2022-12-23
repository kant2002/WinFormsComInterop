extern alias primitives;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop;

[RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IDropTarget))]
[System.Runtime.Versioning.SupportedOSPlatform("windows")]
partial class IDropTargetWrapper
{
    internal readonly IntPtr instance;

    public IDropTargetWrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~IDropTargetWrapper()
    {
        Marshal.Release(this.instance);
    }
}
