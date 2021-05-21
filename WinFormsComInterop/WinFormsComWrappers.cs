using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Interop.UiaCore;

namespace WinFormsComInterop
{
    public unsafe class WinFormsComWrappers : ComWrappers
    {
        static ComWrappers.ComInterfaceEntry* wrapperEntry;

        internal static Guid IRawElementProviderSimple_GUID = typeof(IRawElementProviderSimple).GUID;

        internal static Guid IID_IOleWindow = new Guid("00000114-0000-0000-C000-000000000046");

        // This class only exposes IDispatch and the vtable is always the same.
        // The below isn't the most efficient but it is reasonable for prototyping.
        // If additional interfaces want to be exposed, add them here.
        static WinFormsComWrappers()
        {
            var vtblRaw = (IntPtr*)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(IntPtr) * 7);
            GetIUnknownImpl(out vtblRaw[0], out vtblRaw[1], out vtblRaw[2]);

            vtblRaw[3] = Marshal.GetFunctionPointerForDelegate(IRawElementProviderSimpleVtbl.pGetProviderOptions);
            vtblRaw[4] = Marshal.GetFunctionPointerForDelegate(IRawElementProviderSimpleVtbl.pGetPatternProvider);
            vtblRaw[5] = Marshal.GetFunctionPointerForDelegate(IRawElementProviderSimpleVtbl.pGetPropertyValue);
            vtblRaw[6] = Marshal.GetFunctionPointerForDelegate(IRawElementProviderSimpleVtbl.pHostRawElementProvider);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 2);
            wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry->IID = IRawElementProviderSimple_GUID;
            wrapperEntry->Vtable = (IntPtr)vtblRaw;
        }

        public static WinFormsComWrappers Instance { get; } = new WinFormsComWrappers();

        protected override unsafe ComInterfaceEntry* ComputeVtables(object obj, CreateComInterfaceFlags flags, out int count)
        {
            // count = 0;
            // return null;
            count = 1;
            return wrapperEntry;
        }

        protected override object CreateObject(IntPtr externalComObject, CreateObjectFlags flags)
        {
            // Return NULL works,
            //return null;
            GetIUnknownImpl(out IntPtr fpQueryInteface, out IntPtr fpAddRef, out IntPtr fpRelease);
            if (((IntPtr*)((IntPtr*)externalComObject)[0])[0] == fpQueryInteface)
            {
                return ComWrappers.ComInterfaceDispatch.GetInstance<object>((ComWrappers.ComInterfaceDispatch*)externalComObject);
            }

            // Return object does not works yet.
            return new IExternalObject(externalComObject);
        }

        protected override void ReleaseObjects(System.Collections.IEnumerable objects)
        {
        }
    }
}
