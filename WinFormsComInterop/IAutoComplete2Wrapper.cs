extern alias primitives;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop
{
#if !NET7_0_OR_GREATER
    [RuntimeCallableWrapper(typeof(primitives::Interop.Shell32.IAutoComplete2))]
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    partial class IAutoComplete2Wrapper
    {
        internal readonly IntPtr instance;

        public IAutoComplete2Wrapper(IntPtr instance)
        {
            this.instance = instance;
            Marshal.AddRef(instance);
        }

        ~IAutoComplete2Wrapper()
        {
            Marshal.Release(this.instance);
        }
    }
#endif
}
