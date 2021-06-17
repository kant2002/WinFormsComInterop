extern alias primitives;
extern alias drawing;
#if USE_WPF
extern alias winbase;
extern alias presentation;
#endif
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WinFormsComInterop
{
    [ComCallableWrapper(typeof(primitives::Interop.Ole32.IStream))]
    [ComCallableWrapper(typeof(drawing::Interop.Ole32.IStream))]
    [ComCallableWrapper(typeof(primitives::Interop.UiaCore.IRawElementProviderSimple))]
    [ComCallableWrapper(typeof(primitives::Interop.Ole32.IDropTarget))]
    [ComCallableWrapper(typeof(primitives::Interop.Ole32.IStorage))]
    [ComCallableWrapper(typeof(primitives::Interop.Richedit.IRichEditOleCallback))]
#if USE_WPF
    [ComCallableWrapper(typeof(winbase::MS.Win32.UnsafeNativeMethods.ITfContext))]
    [ComCallableWrapper(typeof(winbase::MS.Win32.UnsafeNativeMethods.IOleDropTarget))]
    [ComCallableWrapper(typeof(winbase::MS.Win32.UnsafeNativeMethods.ITfContextOwner))]
    [ComCallableWrapper(typeof(winbase::MS.Win32.UnsafeNativeMethods.ITfContextOwnerCompositionSink))]
    [ComCallableWrapper(typeof(winbase::MS.Win32.UnsafeNativeMethods.ITfTransitoryExtensionSink))]
#endif
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public unsafe partial class WinFormsComWrappers : ComWrappers
    {
        static ComWrappers.ComInterfaceEntry* wrapperEntry;
        static ComWrappers.ComInterfaceEntry* drawingStreamEntry;
        static ComWrappers.ComInterfaceEntry* primitivesStreamEntry;
        static ComWrappers.ComInterfaceEntry* oleDropTargetEntry;
        static ComWrappers.ComInterfaceEntry* storageEntry;
        static ComWrappers.ComInterfaceEntry* richEditOleCallbackEntry;
        static ComWrappers.ComInterfaceEntry* primitivesDropTargetEntry;
        static ComWrappers.ComInterfaceEntry* winbaseTfContextEntry;
        static ComWrappers.ComInterfaceEntry* presentationDefaultTextStoreEntry;

        internal static Guid IID_IRawElementProviderSimple = new Guid("D6DD68D1-86FD-4332-8666-9ABEDEA2D24C");

        internal static Guid IID_IOleWindow = new Guid("00000114-0000-0000-C000-000000000046");
        internal static Guid IID_IStream = new Guid("0000000C-0000-0000-C000-000000000046");
        internal static Guid IID_IPersistStream = new Guid("00000109-0000-0000-C000-000000000046");
        internal static Guid IID_IOleDropTarget = new Guid("00000122-0000-0000-C000-000000000046");
        internal static Guid IID_IPicture = new Guid("7BF80980-BF32-101A-8BBB-00AA00300CAB");
        internal static Guid IID_IStorage = new Guid("0000000B-0000-0000-C000-000000000046");
        internal static Guid IID_IRichEditOleCallback = new Guid("00020D03-0000-0000-C000-000000000046");
        internal static Guid IID_ITfContext = new Guid("aa80e7fd-2021-11d2-93e0-0060b067b86e");

        // This class only exposes IDispatch and the vtable is always the same.
        // The below isn't the most efficient but it is reasonable for prototyping.
        // If additional interfaces want to be exposed, add them here.
        static WinFormsComWrappers()
        {
            wrapperEntry = CreateGenericEntry();
            drawingStreamEntry = CreateDrawingStreamEntry();
            primitivesStreamEntry = CreatePrimitivesStreamEntry();
            
            primitivesDropTargetEntry = CreatePrimitivesDropTargetEntry();
            storageEntry = CreatePrimitivesIStorageEntry();
            richEditOleCallbackEntry = CreatePrimitivesIRichEditOleCallbackEntry();
#if USE_WPF
            oleDropTargetEntry = CreateOleDropTargetEntry();
            winbaseTfContextEntry = CreateWinbaseITfContextEntry();
            presentationDefaultTextStoreEntry = CreatePresentationDefaultTextStoreEntry();
#endif
        }

#if USE_WPF
        private static ComInterfaceEntry* CreateOleDropTargetEntry()
        {
            CreateWinbaseIOleDropTargetProxyVtbl(out var vtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry->IID = IID_IOleDropTarget;
            wrapperEntry->Vtable = vtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreatePresentationDefaultTextStoreEntry()
        {
            CreateWinbaseITfContextOwnerProxyVtbl(out var tfContextVtbl);
            CreateWinbaseITfContextOwnerCompositionSinkProxyVtbl(out var tfContextOwnerCompositionVtbl);
            CreateWinbaseITfTransitoryExtensionSinkProxyVtbl(out var tfTransitoryExtensionSinkVtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 3);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = new Guid("aa80e80c-2021-11d2-93e0-0060b067b86e");
            wrapperEntry[0].Vtable = tfContextVtbl;
            wrapperEntry[1].IID = new Guid("5F20AA40-B57A-4F34-96AB-3576F377CC79");
            wrapperEntry[1].Vtable = tfContextOwnerCompositionVtbl;
            wrapperEntry[2].IID = new Guid("a615096f-1c57-4813-8a15-55ee6e5a839c");
            wrapperEntry[2].Vtable = tfTransitoryExtensionSinkVtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreateWinbaseITfContextEntry()
        {
            CreateWinbaseITfContextProxyVtbl(out var vtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry->IID = IID_ITfContext;
            wrapperEntry->Vtable = vtbl;
            return wrapperEntry;
        }
#endif

        private static ComInterfaceEntry* CreatePrimitivesDropTargetEntry()
        {
            CreatePrimitivesIDropTargetProxyVtbl(out var vtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry->IID = IID_IOleDropTarget;
            wrapperEntry->Vtable = vtbl;
            return wrapperEntry;
        }

        private static ComInterfaceEntry* CreatePrimitivesIStorageEntry()
        {
            CreatePrimitivesIStorageProxyVtbl(out var vtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry->IID = IID_IStorage;
            wrapperEntry->Vtable = vtbl;
            return wrapperEntry;
        }

        private static ComInterfaceEntry* CreatePrimitivesIRichEditOleCallbackEntry()
        {
            CreatePrimitivesIRichEditOleCallbackProxyVtbl(out var vtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry->IID = IID_IRichEditOleCallback;
            wrapperEntry->Vtable = vtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreateGenericEntry()
        {
            CreatePrimitivesIRawElementProviderSimpleProxyVtbl(out var vtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry->IID = IID_IRawElementProviderSimple;
            wrapperEntry->Vtable = vtbl;
            return wrapperEntry;
        }

        private static ComInterfaceEntry* CreateDrawingStreamEntry()
        {
            CreateDrawingIStreamProxyVtbl(out var vtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry->IID = IID_IStream;
            wrapperEntry->Vtable = vtbl;
            return wrapperEntry;
        }

        private static ComInterfaceEntry* CreatePrimitivesStreamEntry()
        {
            CreatePrimitivesIStreamProxyVtbl(out var vtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry->IID = IID_IStream;
            wrapperEntry->Vtable = vtbl;
            return wrapperEntry;
        }

        public static WinFormsComWrappers Instance { get; } = new WinFormsComWrappers();

        protected override unsafe ComInterfaceEntry* ComputeVtables(object obj, CreateComInterfaceFlags flags, out int count)
        {
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

            if (obj is primitives::Interop.Ole32.IStorage)
            {
                count = 1;
                return storageEntry;
            }

            if (obj is primitives::Interop.Richedit.IRichEditOleCallback)
            {
                count = 1;
                return richEditOleCallbackEntry;
            }

#if USE_WPF
            if (obj is winbase::MS.Win32.UnsafeNativeMethods.IOleDropTarget)
            {
                count = 1;
                return oleDropTargetEntry;
            }

            if (obj is winbase::MS.Win32.UnsafeNativeMethods.ITfContext)
            {
                count = 1;
                return winbaseTfContextEntry;
            }

            if (obj is presentation::System.Windows.Input.DefaultTextStore)
            {
                count = 3;
                return presentationDefaultTextStoreEntry;
            }
#endif

            count = 1;
            return wrapperEntry;
        }

        protected override object CreateObject(IntPtr externalComObject, CreateObjectFlags flags)
        {
            GetIUnknownImpl(out IntPtr fpQueryInteface, out IntPtr fpAddRef, out IntPtr fpRelease);
            if (((IntPtr*)((IntPtr*)externalComObject)[0])[0] == fpQueryInteface)
            {
                return ComWrappers.ComInterfaceDispatch.GetInstance<object>((ComWrappers.ComInterfaceDispatch*)externalComObject);
            }

            return new IExternalObject(externalComObject);
        }

        protected override void ReleaseObjects(System.Collections.IEnumerable objects)
        {
        }
    }
}
