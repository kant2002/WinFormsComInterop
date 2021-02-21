using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Interop.UiaCore;

namespace WinFormsComInterop
{
    struct VtblPtr
    {
        public IntPtr Vtbl;
    }


    public unsafe class WinFormsComWrappers : ComWrappers
    {
        static ComWrappers.ComInterfaceEntry* wrapperEntry;

        internal static Guid IRawElementProviderSimple_GUID = typeof(IRawElementProviderSimple).GUID;

        // This class only exposes IDispatch and the vtable is always the same.
        // The below isn't the most efficient but it is reasonable for prototyping.
        // If additional interfaces want to be exposed, add them here.
        static WinFormsComWrappers()
        {
            //var entry = EnsureInit();


            GetIUnknownImpl(out IntPtr fpQueryInteface, out IntPtr fpAddRef, out IntPtr fpRelease);

            var vtbl = new IRawElementProviderSimpleVtbl()
            {
                IUnknownImpl = new IUnknownVtbl()
                {
                    QueryInterface = fpQueryInteface,
                    AddRef = fpAddRef,
                    Release = fpRelease
                },
                ProviderOptions = Marshal.GetFunctionPointerForDelegate(IRawElementProviderSimpleVtbl.pGetProviderOptions),
                GetPatternProvider = Marshal.GetFunctionPointerForDelegate(IRawElementProviderSimpleVtbl.pGetPatternProvider),
                GetPropertyValue = Marshal.GetFunctionPointerForDelegate(IRawElementProviderSimpleVtbl.pGetPropertyValue),
                HostRawElementProvider = Marshal.GetFunctionPointerForDelegate(IRawElementProviderSimpleVtbl.pHostRawElementProvider)
            };
            var vtblRaw = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IRawElementProviderSimpleVtbl), sizeof(IRawElementProviderSimpleVtbl));
            Marshal.StructureToPtr(vtbl, vtblRaw, false);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IRawElementProviderSimpleVtbl), sizeof(ComInterfaceEntry));
            wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry->IID = IRawElementProviderSimple_GUID;
            wrapperEntry->Vtable = vtblRaw;

            //wrapperEntry = entry;
        }

        public static WinFormsComWrappers Instance { get; } = new WinFormsComWrappers();

        private static ComWrappers.ComInterfaceEntry* EnsureInit()
        {
            GetIUnknownImpl(out IntPtr fpQueryInteface, out IntPtr fpAddRef, out IntPtr fpRelease);

            var vtbl = new IRawElementProviderSimpleVtbl()
            {
                IUnknownImpl = new IUnknownVtbl()
                {
                    QueryInterface = fpQueryInteface,
                    AddRef = fpAddRef,
                    Release = fpRelease
                },
                ProviderOptions = Marshal.GetFunctionPointerForDelegate(IRawElementProviderSimpleVtbl.pGetProviderOptions),
                GetPatternProvider = Marshal.GetFunctionPointerForDelegate(IRawElementProviderSimpleVtbl.pGetPatternProvider),
                GetPropertyValue = Marshal.GetFunctionPointerForDelegate(IRawElementProviderSimpleVtbl.pGetPropertyValue),
                HostRawElementProvider = Marshal.GetFunctionPointerForDelegate(IRawElementProviderSimpleVtbl.pHostRawElementProvider)
            };
            var vtblRaw = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IRawElementProviderSimpleVtbl), sizeof(IRawElementProviderSimpleVtbl));
            Marshal.StructureToPtr(vtbl, vtblRaw, false);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(IRawElementProviderSimpleVtbl), sizeof(ComInterfaceEntry));
            var entry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            entry->IID = typeof(IRawElementProviderSimple).GUID;
            entry->Vtable = vtblRaw;
            return entry;
        }

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

            // Return object does not works yet.
            return new IMyExternalObject(externalComObject);
        }

        protected override void ReleaseObjects(System.Collections.IEnumerable objects)
        {
        }
    }
}
