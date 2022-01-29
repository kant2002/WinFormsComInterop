extern alias primitives;
extern alias forms;
#if NET5_0
extern alias drawing;
#endif
#if USE_WPF
extern alias winbase;
extern alias presentation;
#endif
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WinFormsComInterop
{
#if NET5_0
    [ComCallableWrapper(typeof(drawing::Interop.Ole32.IStream))]
#endif
    [ComCallableWrapper(typeof(primitives::Interop.Ole32.IStream))]
    [ComCallableWrapper(typeof(primitives::Interop.Ole32.IServiceProvider))]
    [ComCallableWrapper(typeof(primitives::Interop.UiaCore.IRawElementProviderSimple))]
    //[ComCallableWrapper(typeof(primitives::Interop.UiaCore.IAccessibleEx))]
    [ComCallableWrapper(typeof(primitives::Interop.Ole32.IDropTarget))]
    [ComCallableWrapper(typeof(primitives::Interop.Ole32.IStorage))]
    [ComCallableWrapper(typeof(primitives::Interop.Richedit.IRichEditOleCallback))]
    [ComCallableWrapper(typeof(primitives::Interop.Ole32.IOleControlSite))]
    [ComCallableWrapper(typeof(primitives::Interop.Ole32.IOleInPlaceSite))]
    [ComCallableWrapper(typeof(primitives::Interop.Ole32.IOleContainer))]
    [ComCallableWrapper(typeof(primitives::Interop.Ole32.IOleClientSite))]
    [ComCallableWrapper(typeof(primitives::Interop.Ole32.IOleInPlaceFrame))]
    [ComCallableWrapper(typeof(primitives::Interop.Mshtml.IDocHostUIHandler))]
    [ComCallableWrapper(typeof(primitives::Interop.SHDocVw.DWebBrowserEvents2))]
    [ComCallableWrapper(typeof(primitives::Interop.Ole32.ISimpleFrameSite))]
    [ComCallableWrapper(typeof(primitives::Interop.Ole32.IPropertyNotifySink))]
    [ComCallableWrapper(typeof(primitives::Interop.Shell32.IFileDialogEvents))]
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
#if NET5_0
        static ComWrappers.ComInterfaceEntry* drawingStreamEntry;
#endif
        static ComWrappers.ComInterfaceEntry* accessibleObjectEntry;
        static ComWrappers.ComInterfaceEntry* primitivesStreamEntry;
        static ComWrappers.ComInterfaceEntry* storageEntry;
        static ComWrappers.ComInterfaceEntry* richEditOleCallbackEntry;
        static ComWrappers.ComInterfaceEntry* primitivesDropTargetEntry;
        static ComWrappers.ComInterfaceEntry* formsWebBrowserSiteEntry; 
        static ComWrappers.ComInterfaceEntry* formsWebBrowserContainerEntry;
        static ComWrappers.ComInterfaceEntry* formsWebBrowserEventEntry;
        static ComWrappers.ComInterfaceEntry* formsFileDialogEventsEntry;
#if USE_WPF
        static ComWrappers.ComInterfaceEntry* oleDropTargetEntry;
        static ComWrappers.ComInterfaceEntry* winbaseTfContextEntry;
        static ComWrappers.ComInterfaceEntry* presentationDefaultTextStoreEntry;
#endif

        internal static Guid IID_IAccessible = new Guid("618736E0-3C3D-11CF-810C-00AA00389B71");
        internal static Guid IID_IRawElementProviderSimple = new Guid("D6DD68D1-86FD-4332-8666-9ABEDEA2D24C");
        internal static Guid IID_IServiceProvider = new Guid("6D5140C1-7436-11CE-8034-00AA006009FA");
        internal static Guid IID_IEnumVariant = new Guid("00020404-0000-0000-C000-000000000046");

        internal static Guid IID_IOleWindow = new Guid("00000114-0000-0000-C000-000000000046");
        internal static Guid IID_IStream = new Guid("0000000C-0000-0000-C000-000000000046");
        internal static Guid IID_IPersistStream = new Guid("00000109-0000-0000-C000-000000000046");
        internal static Guid IID_IOleDropTarget = new Guid("00000122-0000-0000-C000-000000000046");
        internal static Guid IID_IPicture = new Guid("7BF80980-BF32-101A-8BBB-00AA00300CAB");
        internal static Guid IID_IStorage = new Guid("0000000B-0000-0000-C000-000000000046");
        internal static Guid IID_IRichEditOleCallback = new Guid("00020D03-0000-0000-C000-000000000046");
        internal static Guid IID_IDocHostUIHandler = new Guid("BD3F23C0-D43E-11CF-893B-00AA00BDCE1A");
        internal static Guid IID_IOleControlSite = new Guid("B196B289-BAB4-101A-B69C-00AA00341D07");
        internal static Guid IID_IOleInPlaceSite = new Guid("00000119-0000-0000-C000-000000000046");
        internal static Guid IID_IOleClientSite = new Guid("00000118-0000-0000-C000-000000000046");
        internal static Guid IID_IOleContainer = new Guid("0000011B-0000-0000-C000-000000000046");
        internal static Guid IID_IOleInPlaceFrame = new Guid("00000116-0000-0000-C000-000000000046");
        internal static Guid IID_IWebBrowser2 = new Guid("D30C1661-CDAF-11d0-8A3E-00C04FC9E26E");
        internal static Guid IID_IConnectionPoint = new Guid("B196B286-BAB4-101A-B69C-00AA00341D07");
        internal static Guid IID_DWebBrowserEvents2 = new Guid("34A715A0-6587-11D0-924A-0020AFC7AC4D");
        internal static Guid IID_ISimpleFrameSite = new Guid("742B0E01-14E6-101B-914E-00AA00300CAB");
        internal static Guid IID_IPropertyNotifySink = new Guid("9BFBBC02-EFF1-101A-84ED-00AA00341D07");
        internal static Guid IID_IFileOpenDialog = new Guid("d57c7288-d4ad-4768-be02-9d969532d960");
        internal static Guid IID_IFileSaveDialog = new Guid("84bccd23-5fde-4cdb-aea4-af64b83d78ab");
        internal static Guid IID_IFileDialogEvents = new Guid("973510DB-7D7F-452B-8975-74A85828D354");
        internal static Guid IID_IDropTarget = new Guid("00000122-0000-0000-C000-000000000046");
        internal static Guid IID_IOleInPlaceActiveObject = new Guid("00000117-0000-0000-C000-000000000046");
        internal static Guid IID_IHTMLDocument4 = new Guid("3050F69A-98B5-11CF-BB82-00AA00BDCE0B");
        internal static Guid IID_IHTMLLocation = new Guid("163BB1E0-6E00-11CF-837A-48DC04C10000");

        internal static Guid IID_ITfContext = new Guid("aa80e7fd-2021-11d2-93e0-0060b067b86e");

        // This class only exposes IDispatch and the vtable is always the same.
        // The below isn't the most efficient but it is reasonable for prototyping.
        // If additional interfaces want to be exposed, add them here.
        static WinFormsComWrappers()
        {
#if NET5_0
            drawingStreamEntry = CreateDrawingStreamEntry();
#endif
            accessibleObjectEntry = CreateAccessibleObjectEntry();
            primitivesStreamEntry = CreatePrimitivesStreamEntry();
            
            primitivesDropTargetEntry = CreatePrimitivesDropTargetEntry();
            storageEntry = CreatePrimitivesIStorageEntry();
            richEditOleCallbackEntry = CreatePrimitivesIRichEditOleCallbackEntry();
            formsWebBrowserSiteEntry = CreateWebBrowserSiteEntry();
            formsWebBrowserContainerEntry = CreateWebBrowserContainerEntry();
            formsWebBrowserEventEntry = CreateWebBrowserEventEntry();
            formsFileDialogEventsEntry = CreateFileDialogEventsEntry();
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
        private static ComInterfaceEntry* CreateAccessibleObjectEntry()
        {
            CreatePrimitivesIRawElementProviderSimpleProxyVtbl(out var rawElementProviderSimpleVtbl);
            CreatePrimitivesIServiceProviderProxyVtbl(out var serviceProviderVtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 2);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = IID_IRawElementProviderSimple;
            wrapperEntry[0].Vtable = rawElementProviderSimpleVtbl;
            wrapperEntry[1].IID = IID_IServiceProvider;
            wrapperEntry[1].Vtable = serviceProviderVtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreateWebBrowserSiteEntry()
        {
            CreatePrimitivesIOleControlSiteProxyVtbl(out var oleControlSiteVtbl);
            CreatePrimitivesIDocHostUIHandlerProxyVtbl(out var docHostUIHandlerVtbl);
            CreatePrimitivesIOleInPlaceSiteProxyVtbl(out var oleInPlaceSiteVtbl);
            CreatePrimitivesIOleClientSiteProxyVtbl(out var oleClientSiteVtbl);
            CreatePrimitivesISimpleFrameSiteProxyVtbl(out var simpleFrameSiteVtbl);
            CreatePrimitivesIPropertyNotifySinkProxyVtbl(out var propertyNotifySinkVtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 6);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = IID_IOleControlSite;
            wrapperEntry[0].Vtable = oleControlSiteVtbl;
            wrapperEntry[1].IID = IID_IDocHostUIHandler;
            wrapperEntry[1].Vtable = docHostUIHandlerVtbl;
            wrapperEntry[2].IID = IID_IOleInPlaceSite;
            wrapperEntry[2].Vtable = oleInPlaceSiteVtbl;
            wrapperEntry[3].IID = IID_IOleClientSite;
            wrapperEntry[3].Vtable = oleClientSiteVtbl;
            wrapperEntry[4].IID = IID_ISimpleFrameSite;
            wrapperEntry[4].Vtable = simpleFrameSiteVtbl;
            wrapperEntry[5].IID = IID_IPropertyNotifySink;
            wrapperEntry[5].Vtable = propertyNotifySinkVtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreateWebBrowserContainerEntry()
        {
            CreatePrimitivesIOleContainerProxyVtbl(out var oleControlSiteVtbl);
            CreatePrimitivesIOleInPlaceFrameProxyVtbl(out var docHostUIHandlerVtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 2);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = IID_IOleContainer;
            wrapperEntry[0].Vtable = oleControlSiteVtbl;
            wrapperEntry[1].IID = IID_IOleInPlaceFrame;
            wrapperEntry[1].Vtable = docHostUIHandlerVtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreateWebBrowserEventEntry()
        {
            CreatePrimitivesDWebBrowserEvents2ProxyVtbl(out var oleControlSiteVtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = IID_DWebBrowserEvents2;
            wrapperEntry[0].Vtable = oleControlSiteVtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreateFileDialogEventsEntry()
        {
            CreatePrimitivesIFileDialogEventsProxyVtbl(out var oleControlSiteVtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = IID_IFileDialogEvents;
            wrapperEntry[0].Vtable = oleControlSiteVtbl;
            return wrapperEntry;
        }

#if NET5_0
        private static ComInterfaceEntry* CreateDrawingStreamEntry()
        {
            CreateDrawingIStreamProxyVtbl(out var vtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry->IID = IID_IStream;
            wrapperEntry->Vtable = vtbl;
            return wrapperEntry;
        }
#endif

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
#if NET5_0
            if (obj is drawing::Interop.Ole32.IStream)
            {
                count = 1;
                return drawingStreamEntry;
            }
#endif

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
            if (obj is forms::System.Windows.Forms.AccessibleObject)
            {
                count = 2;
                return accessibleObjectEntry;
            }

#if !NET7_0_OR_GREATER
            if (obj is forms::System.Windows.Forms.InternalAccessibleObject)
            {
                count = 2;
                return accessibleObjectEntry;
            }
#endif

            if (obj is forms::System.Windows.Forms.WebBrowser.WebBrowserSite)
            {
                count = 6;
                return formsWebBrowserSiteEntry;
            }

            if (obj is forms::System.Windows.Forms.WebBrowserContainer)
            {
                count = 2;
                return formsWebBrowserContainerEntry;
            }

            if (obj is forms::System.Windows.Forms.WebBrowser.WebBrowserEvent)
            {
                count = 1;
                return formsWebBrowserEventEntry;
            }

            if (obj is forms::System.Windows.Forms.FileDialog.VistaDialogEvents)
            {
                count = 1;
                return formsFileDialogEventsEntry;
            }

            throw new NotImplementedException();
        }

        protected override object CreateObject(IntPtr externalComObject, CreateObjectFlags flags)
        {
            if (Marshal.QueryInterface(externalComObject, ref IID_IAccessible, out var accessiblePtr) >= 0)
            {
                Marshal.Release(accessiblePtr);
                if (Marshal.QueryInterface(externalComObject, ref IID_IEnumVariant, out var accessibleEnumPtr) >= 0)
                {
                    Marshal.Release(accessibleEnumPtr);
                    return new IAccessibleEnumWrapper(externalComObject);
                }

                return new IAccessibleWrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_IPicture, out var picturePtr) >= 0)
            {
                Marshal.Release(picturePtr);
                return new IPictureWrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_IWebBrowser2, out var webBrowserPtr) >= 0)
            {
                Marshal.Release(webBrowserPtr);
                return new IWebBrowserWrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_IConnectionPoint, out var connectionPointPtr) >= 0)
            {
                Marshal.Release(connectionPointPtr);
                return new IConnectionPointWrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_IFileOpenDialog, out var fileOpenDialogPtr) >= 0)
            {
                Marshal.Release(fileOpenDialogPtr);
                return new IFileOpenDialogWrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_IFileSaveDialog, out var fileSaveDialogPtr) >= 0)
            {
                Marshal.Release(fileSaveDialogPtr);
                return new IFileSaveDialogWrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_IDropTarget, out var dropTargetPtr) >= 0)
            {
                Marshal.Release(dropTargetPtr);
                return new IDropTargetWrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_IHTMLDocument4, out var htmlDocumentPtr) >= 0)
            {
                Marshal.Release(htmlDocumentPtr);
                return new IHTMLDocument4Wrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_IHTMLLocation, out var htmlLocationPtr) >= 0)
            {
                Marshal.Release(htmlLocationPtr);
                return new IHTMLLocationWrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_IOleInPlaceActiveObject, out var inplaceActiveObjectPtr) >= 0)
            {
                Marshal.Release(inplaceActiveObjectPtr);
                return new IOleInPlaceActiveObjectWrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_IOleInPlaceFrame, out var inplaceFramePtr) >= 0)
            {
                Marshal.Release(inplaceFramePtr);
                return new IOleInPlaceFrameWrapper(externalComObject);
            }

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
