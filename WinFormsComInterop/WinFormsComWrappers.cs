using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Interop;
using static Interop.OleAut32;
using static Interop.UiaCore;
using static System.Runtime.InteropServices.ComWrappers;

[assembly: System.Runtime.CompilerServices.IgnoresAccessChecksToAttribute("System.Windows.Forms.Primitives")]

namespace System.Runtime.CompilerServices
{
    public class IgnoresAccessChecksToAttribute: Attribute
    {
        public IgnoresAccessChecksToAttribute(string assemblyName)
        {
            this.AssemblyName = assemblyName;
        }

        public string AssemblyName { get; }
    }
}

namespace WinFormsComInterop
{
    struct VtblPtr
    {
        public IntPtr Vtbl;
    }

    public struct IUnknownVtbl
    {
        public IntPtr QueryInterface;
        public IntPtr AddRef;
        public IntPtr Release;
    }

    public unsafe struct IRawElementProviderSimpleVtbl
    {
        public IUnknownVtbl IUnknownImpl;
        public IntPtr ProviderOptions;
        public IntPtr GetPatternProvider;
        public IntPtr GetPropertyValue;
        public IntPtr HostRawElementProvider;

        public delegate int _GetProviderOptions(IntPtr thisPtr, out ProviderOptions i);
        public delegate int _GetPatternProvider(IntPtr thisPtr, UIA patternId, [MarshalAs(UnmanagedType.IUnknown)]out object i);
        public delegate int _GetPropertyValue(IntPtr thisPtr, UIA patternId, out object i);
        public delegate int _HostRawElementProvider(
            IntPtr thisPtr,
            [MarshalAs(UnmanagedType.IUnknown)]out IRawElementProviderSimple i);
        
        public static _GetProviderOptions pGetProviderOptions = new _GetProviderOptions(GetProviderOptionsInternal);
        public static _GetPatternProvider pGetPatternProvider = new _GetPatternProvider(GetPatternProviderInternal);
        public static _GetPropertyValue pGetPropertyValue = new _GetPropertyValue(GetPropertyValueInternal);
        public static _HostRawElementProvider pHostRawElementProvider = new _HostRawElementProvider(HostRawElementProviderInternal);

        public static int GetProviderOptionsInternal(IntPtr thisPtr, out ProviderOptions i)
        {
            i = 0;
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<IRawElementProviderSimple>((ComInterfaceDispatch*)thisPtr);
                i = inst.ProviderOptions;
            }
            catch (Exception e)
            {
                return e.HResult;
            }
            return 0; // S_OK;
        }
        public static int HostRawElementProviderInternal(IntPtr thisPtr, out IRawElementProviderSimple i)
        {
            i = null;
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<IRawElementProviderSimple>((ComInterfaceDispatch*)thisPtr);
                i = inst.HostRawElementProvider;
            }
            catch (Exception e)
            {
                return e.HResult;
            }
            return 0; // S_OK;
        }
        public static int GetPatternProviderInternal(IntPtr thisPtr, UIA patternId, out object i)
        {
            i = 0;
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<IRawElementProviderSimple>((ComInterfaceDispatch*)thisPtr);
                i = inst.GetPatternProvider(patternId);
            }
            catch (Exception e)
            {
                return e.HResult;
            }
            return 0; // S_OK;
        }
        public static int GetPropertyValueInternal(IntPtr thisPtr, UIA patternId, out object i)
        {
            i = 0;
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<IRawElementProviderSimple>((ComInterfaceDispatch*)thisPtr);
                i = inst.GetPropertyValue(patternId);
            }
            catch (Exception e)
            {
                return e.HResult;
            }
            return 0; // S_OK;
        }
    }

    class IExternalObject : Accessibility.IAccessible, Interop.OleAut32.IEnumVariant
    {
        private struct IExternalObjectVftbl
        {
            public IntPtr QueryInterface;
            public _AddRef AddRef;
            public _Release Release;
        }

        private delegate int _AddRef(IntPtr This);
        private delegate int _Release(IntPtr This);

        private readonly IntPtr instance;
        private readonly IExternalObjectVftbl vtable;

        public IExternalObject(IntPtr instance)
        {
            var inst = Marshal.PtrToStructure<VtblPtr>(instance);
            this.vtable = Marshal.PtrToStructure<IExternalObjectVftbl>(inst.Vtbl);
            this.instance = instance;
        }

        ~IExternalObject()
        {
            if (this.instance != IntPtr.Zero)
            {
                this.vtable.Release(this.instance);
            }
        }

        public void accSelect(int flagsSelect, object varChild)
        {
            throw new NotImplementedException();
        }

        public void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild)
        {
            throw new NotImplementedException();
        }

        public object accNavigate(int navDir, object varStart)
        {
            throw new NotImplementedException();
        }

        public object accHitTest(int xLeft, int yTop)
        {
            throw new NotImplementedException();
        }

        public void accDoDefaultAction(object varChild)
        {
            throw new NotImplementedException();
        }

        public object accParent => throw new NotImplementedException();

        public int accChildCount => throw new NotImplementedException();

        object Accessibility.IAccessible.get_accChild(object index) => throw new NotImplementedException();
        string Accessibility.IAccessible.get_accName(object index) => throw new NotImplementedException();
        void Accessibility.IAccessible.set_accName(object index, string value) => throw new NotImplementedException();
        string Accessibility.IAccessible.get_accValue(object index) => throw new NotImplementedException();
        void Accessibility.IAccessible.set_accValue(object index, string value) => throw new NotImplementedException();

        string Accessibility.IAccessible.get_accDescription(object index) => throw new NotImplementedException();

        object Accessibility.IAccessible.get_accRole(object index) => throw new NotImplementedException();
        object Accessibility.IAccessible.get_accState(object index) => throw new NotImplementedException();
        string Accessibility.IAccessible.get_accHelp(object index) => throw new NotImplementedException();


        public int accHelpTopic => throw new NotImplementedException();
        int Accessibility.IAccessible.get_accHelpTopic(out string topic, object index) => throw new NotImplementedException();

        string Accessibility.IAccessible.get_accKeyboardShortcut(object index) => throw new NotImplementedException();

        public object accFocus => throw new NotImplementedException();

        public object accSelection => throw new NotImplementedException();

        string Accessibility.IAccessible.get_accDefaultAction(object index) => throw new NotImplementedException();

        unsafe HRESULT IEnumVariant.Next(uint celt, IntPtr rgVar, uint* pCeltFetched)
        {
            throw new NotImplementedException();
        }

        HRESULT IEnumVariant.Skip(uint celt)
        {
            throw new NotImplementedException();
        }

        HRESULT IEnumVariant.Reset()
        {
            throw new NotImplementedException();
        }

        HRESULT IEnumVariant.Clone(IEnumVariant[] ppEnum)
        {
            throw new NotImplementedException();
        }
    }


    public unsafe class WinFormsComWrappers : ComWrappers
    {
        static readonly ComWrappers.ComInterfaceEntry* wrapperEntry;

        // This class only exposes IDispatch and the vtable is always the same.
        // The below isn't the most efficient but it is reasonable for prototyping.
        // If additional interfaces want to be exposed, add them here.
        static WinFormsComWrappers()
        {
            wrapperEntry = EnsureInit();
        }

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
            if (wrapperEntry == IntPtr.Zero.ToPointer())
            {
                // wrapperEntry = EnsureInit();
            }

            count = 1;
            return wrapperEntry;
        }

        protected override object CreateObject(IntPtr externalComObject, CreateObjectFlags flags)
        {
            return new IExternalObject(externalComObject);
        }

        protected override void ReleaseObjects(System.Collections.IEnumerable objects)
        {
        }
    }
}
