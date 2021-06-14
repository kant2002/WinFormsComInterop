extern alias primitives;
using System;
using System.Runtime.InteropServices;
using static primitives::Interop.UiaCore;
using static System.Runtime.InteropServices.ComWrappers;

namespace WinFormsComInterop
{
    [ComCallableWrapper(typeof(primitives::Interop.UiaCore.IRawElementProviderSimple))]
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public unsafe static class IRawElementProviderSimpleVtbl
    {
    }
}
