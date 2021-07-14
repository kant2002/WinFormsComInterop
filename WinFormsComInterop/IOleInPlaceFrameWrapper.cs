extern alias primitives;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop
{
    [RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IOleInPlaceFrame))]
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    partial class IOleInPlaceFrameWrapper
    {
        internal readonly IntPtr instance;

        public IOleInPlaceFrameWrapper(IntPtr instance)
        {
            this.instance = instance;
            Marshal.AddRef(instance);
        }

        ~IOleInPlaceFrameWrapper()
        {
            Marshal.Release(this.instance);
        }
    }
}
