using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WinFormsComInterop
{
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    internal struct ComVariant : IDisposable
    {
        [DllImport("olaut32.dll")]
        private static extern int VariantClear(IntPtr pVar);

        public ComVariant(object value)
        {
            // This is the size of the largest field in a VARIANT, the decVal field.
            // Since VARIANT is a union, all other data types will fit in this size.
            Handle = Marshal.AllocCoTaskMem(sizeof(ushort) + sizeof(byte) * 2 + sizeof(uint) + sizeof(ulong));
            if (value != null) Marshal.GetNativeVariantForObject(value, Handle);
        }

        public IntPtr Handle;

        public object Value => Marshal.GetObjectForNativeVariant(Handle);

        public void Dispose()
        {
            VariantClear(Handle);
            Marshal.FreeCoTaskMem(Handle);
        }
    }
}
