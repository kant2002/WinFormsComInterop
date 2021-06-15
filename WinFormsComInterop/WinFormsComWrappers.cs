extern alias primitives;
extern alias drawing;
#if USE_WPF
extern alias winbase;
#endif
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static primitives::Interop;
using static primitives::Interop.UiaCore;

namespace WinFormsComInterop
{
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public unsafe class WinFormsComWrappers : ComWrappers
    {
        static ComWrappers.ComInterfaceEntry* wrapperEntry;
        static ComWrappers.ComInterfaceEntry* drawingStreamEntry;
        static ComWrappers.ComInterfaceEntry* primitivesStreamEntry;
        static ComWrappers.ComInterfaceEntry* oleDropTargetEntry;
        static ComWrappers.ComInterfaceEntry* primitivesDropTargetEntry;

        internal static Guid IID_IRawElementProviderSimple = new Guid("D6DD68D1-86FD-4332-8666-9ABEDEA2D24C");

        internal static Guid IID_IOleWindow = new Guid("00000114-0000-0000-C000-000000000046");
        internal static Guid IID_IStream = new Guid("0000000C-0000-0000-C000-000000000046");
        internal static Guid IID_IPersistStream = new Guid("00000109-0000-0000-C000-000000000046");
        internal static Guid IID_IOleDropTarget = new Guid("00000122-0000-0000-C000-000000000046");
        internal static Guid IID_IPicture = new Guid("7BF80980-BF32-101A-8BBB-00AA00300CAB");

        // This class only exposes IDispatch and the vtable is always the same.
        // The below isn't the most efficient but it is reasonable for prototyping.
        // If additional interfaces want to be exposed, add them here.
        static WinFormsComWrappers()
        {
            wrapperEntry = CreateGenericEntry();
            drawingStreamEntry = CreateDrawingStreamEntry();
            primitivesStreamEntry = CreatePrimitivesStreamEntry();
            primitivesDropTargetEntry = CreatePrimitivesDropTargetEntry();
#if USE_WPF
            oleDropTargetEntry = CreateOleDropTargetEntry();
#endif
        }

#if USE_WPF
        private static ComInterfaceEntry* CreateOleDropTargetEntry()
        {
            CreateIOleDropTargetVtbl(out var vtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 2);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry->IID = IID_IOleDropTarget;
            wrapperEntry->Vtable = vtbl;
            return wrapperEntry;
        }

        private static void CreateIOleDropTargetVtbl(out IntPtr vtbl)
        {
            var vtblRaw = (IntPtr*)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(IntPtr) * 7);
            GetIUnknownImpl(out vtblRaw[0], out vtblRaw[1], out vtblRaw[2]);

            vtblRaw[3] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr, int, long, int*, int>)&WinBaseOleDropTarget.OleDragEnter;
            vtblRaw[4] = (IntPtr)(delegate* unmanaged<IntPtr, int, long, int*, int>)&WinBaseOleDropTarget.OleDragOver;
            vtblRaw[5] = (IntPtr)(delegate* unmanaged<IntPtr, int>)&WinBaseOleDropTarget.OleDragLeave;
            vtblRaw[6] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr, int, long, int*, int>)&WinBaseOleDropTarget.OleDrop;

            vtbl = (IntPtr)vtblRaw;
        }
#endif

        private static ComInterfaceEntry* CreatePrimitivesDropTargetEntry()
        {
            CreatePrimitivesIDropTargetVtbl(out var vtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 2);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry->IID = IID_IOleDropTarget;
            wrapperEntry->Vtable = vtbl;
            return wrapperEntry;
        }

        private static void CreatePrimitivesIDropTargetVtbl(out IntPtr vtbl)
        {
            var vtblRaw = (IntPtr*)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(IntPtr) * 7);
            GetIUnknownImpl(out vtblRaw[0], out vtblRaw[1], out vtblRaw[2]);

            vtblRaw[3] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr, uint, System.Drawing.Point, uint*, int>)&PrimitivesIDropTargetVtbl.DragEnter;
            vtblRaw[4] = (IntPtr)(delegate* unmanaged<IntPtr, uint, System.Drawing.Point, uint*, int>)&PrimitivesIDropTargetVtbl.DragOver;
            vtblRaw[5] = (IntPtr)(delegate* unmanaged<IntPtr, int>)&PrimitivesIDropTargetVtbl.DragLeave;
            vtblRaw[6] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr, uint, System.Drawing.Point, uint*, int>)&PrimitivesIDropTargetVtbl.Drop;

            vtbl = (IntPtr)vtblRaw;
        }
        private static ComInterfaceEntry* CreateGenericEntry()
        {
            CreateIRawElementProviderSimpleVtbl(out var vtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 2);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry->IID = IID_IRawElementProviderSimple;
            wrapperEntry->Vtable = vtbl;
            return wrapperEntry;
        }

        private static ComInterfaceEntry* CreateDrawingStreamEntry()
        {
            CreateIDrawingStreamSimpleVtbl(out var vtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 2);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry->IID = IID_IStream;
            wrapperEntry->Vtable = vtbl;
            return wrapperEntry;
        }

        private static ComInterfaceEntry* CreatePrimitivesStreamEntry()
        {
            CreatePrimitivesIStreamSimpleVtbl(out var vtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 2);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry->IID = IID_IStream;
            wrapperEntry->Vtable = vtbl;
            return wrapperEntry;
        }

        private static void CreateIRawElementProviderSimpleVtbl(out IntPtr vtbl)
        {
            var vtblRaw = (IntPtr*)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(IntPtr) * 7);
            GetIUnknownImpl(out vtblRaw[0], out vtblRaw[1], out vtblRaw[2]);

            vtblRaw[3] = (IntPtr)(delegate* unmanaged<IntPtr, int*, int>)&PrimitivesIRawElementProviderSimpleProxy.get_ProviderOptions;
            vtblRaw[4] = (IntPtr)(delegate* unmanaged<IntPtr, int, IntPtr*, int>)&PrimitivesIRawElementProviderSimpleProxy.GetPatternProvider;
            vtblRaw[5] = (IntPtr)(delegate* unmanaged<IntPtr, int, IntPtr*, int>)&PrimitivesIRawElementProviderSimpleProxy.GetPropertyValue;
            vtblRaw[6] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr*, int>)&PrimitivesIRawElementProviderSimpleProxy.get_HostRawElementProvider;

            vtbl = (IntPtr)vtblRaw;
        }

        private static void CreateIDrawingStreamSimpleVtbl(out IntPtr vtbl)
        {
            var vtblRaw = (IntPtr*)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(IntPtr) * 14);
            GetIUnknownImpl(out vtblRaw[0], out vtblRaw[1], out vtblRaw[2]);

            vtblRaw[3] = (IntPtr)(delegate* unmanaged<IntPtr, byte*, uint, uint*, int>)&DrawingIStreamVtbl.Read;
            vtblRaw[4] = (IntPtr)(delegate* unmanaged<IntPtr, byte*, uint, uint*, int>)&DrawingIStreamVtbl.Write;
            vtblRaw[5] = (IntPtr)(delegate* unmanaged<IntPtr, long, int, ulong*, int>)&DrawingIStreamVtbl.Seek;
            vtblRaw[6] = (IntPtr)(delegate* unmanaged<IntPtr, ulong, int>)&DrawingIStreamVtbl.SetSize;
            vtblRaw[7] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr, ulong, ulong*, ulong*, int>)&DrawingIStreamVtbl.CopyTo;
            vtblRaw[8] = (IntPtr)(delegate* unmanaged<IntPtr, uint, int>)&DrawingIStreamVtbl.Commit;
            vtblRaw[9] = (IntPtr)(delegate* unmanaged<IntPtr, int>)&DrawingIStreamVtbl.Revert;
            vtblRaw[10] = (IntPtr)(delegate* unmanaged<IntPtr, ulong, ulong, uint, int>)&DrawingIStreamVtbl.LockRegion;
            vtblRaw[11] = (IntPtr)(delegate* unmanaged<IntPtr, ulong, ulong, uint, int>)&DrawingIStreamVtbl.UnlockRegion;
            vtblRaw[12] = (IntPtr)(delegate* unmanaged<IntPtr, drawing::Interop.Ole32.STATSTG*, drawing::Interop.Ole32.STATFLAG, int>)&DrawingIStreamVtbl.Stat;
            vtblRaw[13] = (IntPtr)(delegate* unmanaged<IntPtr, int>)&DrawingIStreamVtbl.Clone;

            vtbl = (IntPtr)vtblRaw;
        }

        private static void CreatePrimitivesIStreamSimpleVtbl(out IntPtr vtbl)
        {
            var vtblRaw = (IntPtr*)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(IntPtr) * 14);
            GetIUnknownImpl(out vtblRaw[0], out vtblRaw[1], out vtblRaw[2]);

            vtblRaw[3] = (IntPtr)(delegate* unmanaged<IntPtr, byte*, uint, uint*, int>)&PrimitivesIStreamProxy.Read;
            vtblRaw[4] = (IntPtr)(delegate* unmanaged<IntPtr, byte*, uint, uint*, int>)&PrimitivesIStreamProxy.Write;
            vtblRaw[5] = (IntPtr)(delegate* unmanaged<IntPtr, long, int, ulong*, int>)&PrimitivesIStreamProxy.Seek;
            vtblRaw[6] = (IntPtr)(delegate* unmanaged<IntPtr, ulong, int>)&PrimitivesIStreamProxy.SetSize;
            vtblRaw[7] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr, ulong, ulong*, ulong*, int>)&PrimitivesIStreamProxy.CopyTo;
            vtblRaw[8] = (IntPtr)(delegate* unmanaged<IntPtr, int, int>)&PrimitivesIStreamProxy.Commit;
            vtblRaw[9] = (IntPtr)(delegate* unmanaged<IntPtr, int>)&PrimitivesIStreamProxy.Revert;
            vtblRaw[10] = (IntPtr)(delegate* unmanaged<IntPtr, ulong, ulong, uint, int>)&PrimitivesIStreamProxy.LockRegion;
            vtblRaw[11] = (IntPtr)(delegate* unmanaged<IntPtr, ulong, ulong, uint, int>)&PrimitivesIStreamProxy.UnlockRegion;
            vtblRaw[12] = (IntPtr)(delegate* unmanaged<IntPtr, primitives::Interop.Ole32.STATSTG*, int, int>)&PrimitivesIStreamProxy.Stat;
            vtblRaw[13] = (IntPtr)(delegate* unmanaged<IntPtr, System.IntPtr*, int >)&PrimitivesIStreamProxy.Clone;

            vtbl = (IntPtr)vtblRaw;
        }

        public static WinFormsComWrappers Instance { get; } = new WinFormsComWrappers();

        protected override unsafe ComInterfaceEntry* ComputeVtables(object obj, CreateComInterfaceFlags flags, out int count)
        {
            // count = 0;
            // return null;
            if (obj is drawing::Interop.Ole32.IStream)
            {
                count = 1;
                return drawingStreamEntry;
            }

            if (obj is primitives::Interop.Ole32.IStream)
            {
                count = 1;
                return primitivesStreamEntry;
            }


            if (obj is primitives::Interop.Ole32.IDropTarget)
            {
                count = 1;
                return primitivesDropTargetEntry;
            }

#if USE_WPF
            if (obj is winbase::MS.Win32.UnsafeNativeMethods.IOleDropTarget)
            {
                count = 1;
                return oleDropTargetEntry;
            }
#endif

            var interfaces = obj.GetType().GetInterfaces();
            if (interfaces.Length == 1 && interfaces[0].GUID.ToString() == "0000000C-0000-0000-C000-000000000046")
            {
                count = 1;
                return drawingStreamEntry;
            }

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
