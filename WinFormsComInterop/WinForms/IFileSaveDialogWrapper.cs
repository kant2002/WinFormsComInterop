extern alias primitives;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop.WinForms;

[RuntimeCallableWrapper(typeof(primitives::Interop.Shell32.IFileSaveDialog))]
[System.Runtime.Versioning.SupportedOSPlatform("windows")]
partial class IFileSaveDialogWrapper
{
    internal readonly IntPtr instance;

    public IFileSaveDialogWrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~IFileSaveDialogWrapper()
    {
        Marshal.Release(this.instance);
    }
}
