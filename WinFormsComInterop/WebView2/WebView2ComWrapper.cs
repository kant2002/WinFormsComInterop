extern alias webview2;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WinFormsComInterop.WebView2;
using static System.Runtime.InteropServices.ComWrappers;

namespace WinFormsComInterop.WebView2
{
    [ComCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions))]
    [ComCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions2))]
    [ComCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler))]
    [ComCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CreateCoreWebView2ControllerCompletedHandler))]
    [ComCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivateHostObjectHelper))]
    [ComCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivateHostObjectHelper2))]
    [ComCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2MoveFocusRequestedEventHandler))]
    [ComCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2AcceleratorKeyPressedEventHandler))]
    [ComCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ZoomFactorChangedEventHandler))]
    [ComCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationCompletedEventHandler))]
    [ComCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationStartingEventHandler))]
    [ComCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2SourceChangedEventHandler))]
    [ComCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebMessageReceivedEventHandler))]
    [ComCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ContentLoadingEventHandler))]
    [ComCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ProcessFailedEventHandler))]
    [ComCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceRequestedEventHandler))]
    [ComCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NewWindowRequestedEventHandler))]
    [ComCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler))]
    [ComCallableWrapper(typeof(System.Runtime.InteropServices.ComTypes.IStream))]
    public unsafe partial class WebView2ComWrapper : WinFormsComWrappers
    {
        static ComWrappers.ComInterfaceEntry* coreWebView2EnvironmentOptionsEntry;
        static ComWrappers.ComInterfaceEntry* coreWebView2CreateCoreWebView2EnvironmentCompletedHandlerEntry;
        static ComWrappers.ComInterfaceEntry* coreWebView2CreateCoreWebView2ControllerCompletedHandlerEntry;
        static ComWrappers.ComInterfaceEntry* coreWebView2PrivateHostObjectHelperEntry;
        static ComWrappers.ComInterfaceEntry* coreWebView2MoveFocusRequestedEventHandlerEntry;
        static ComWrappers.ComInterfaceEntry* coreWebView2AcceleratorKeyPressedEventHandlerEntry;
        static ComWrappers.ComInterfaceEntry* coreWebView2ZoomFactorChangedEventHandlerEntry;
        static ComWrappers.ComInterfaceEntry* coreWebView2NavigationCompletedEventHandlerEntry;
        static ComWrappers.ComInterfaceEntry* coreWebView2NavigationStartingEventHandlerEntry;
        static ComWrappers.ComInterfaceEntry* coreWebView2SourceChangedEventHandlerEntry;
        static ComWrappers.ComInterfaceEntry* coreWebView2WebMessageReceivedEventHandlerEntry;
        static ComWrappers.ComInterfaceEntry* coreWebView2ContentLoadingEventHandlerEntry;
        static ComWrappers.ComInterfaceEntry* coreWebView2ProcessFailedEventHandlerEntry;
        static ComWrappers.ComInterfaceEntry* coreWebView2WebResourceRequestedEventHandlerEntry;
        static ComWrappers.ComInterfaceEntry* coreWebView2NewWindowRequestedEventHandlerEntry;
        static ComWrappers.ComInterfaceEntry* coreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandlerEntry;
        static ComWrappers.ComInterfaceEntry* managedStreamEntry;

        internal static Guid IID_ICoreWebView2 = new Guid("76ECEACB-0462-4D94-AC83-423A6793775E");
        internal static Guid IID_ICoreWebView2Controller = new Guid("4D00C0D1-9434-4EB6-8078-8697A560334F");
        internal static Guid IID_ICoreWebView2Settings = new Guid("E562E4F0-D7FA-43AC-8D71-C05150499F00");
        internal static Guid IID_ICoreWebView2MoveFocusRequestedEventHandler = new Guid("69035451-6DC7-4CB8-9BCE-B2BD70AD289F");
        internal static Guid IID_ICoreWebView2AcceleratorKeyPressedEventHandler = new Guid("B29C7E28-FA79-41A8-8E44-65811C76DCB2");
        internal static Guid IID_ICoreWebView2ZoomFactorChangedEventHandler = new Guid("B52D71D6-C4DF-4543-A90C-64A3E60F38CB");
        internal static Guid IID_ICoreWebView2NavigationCompletedEventHandler = new Guid("D33A35BF-1C49-4F98-93AB-006E0533FE1C");
        internal static Guid IID_ICoreWebView2NavigationStartingEventHandler = new Guid("9ADBE429-F36D-432B-9DDC-F8881FBD76E3");
        internal static Guid IID_ICoreWebView2SourceChangedEventHandler = new Guid("3C067F9F-5388-4772-8B48-79F7EF1AB37C");
        internal static Guid IID_ICoreWebView2WebMessageReceivedEventHandler = new Guid("57213F19-00E6-49FA-8E07-898EA01ECBD2");
        internal static Guid IID_ICoreWebView2ContentLoadingEventHandler = new Guid("364471E7-F2BE-4910-BDBA-D72077D51C4B");
        internal static Guid IID_ICoreWebView2ProcessFailedEventHandler = new Guid("79E0AEA4-990B-42D9-AA1D-0FCC2E5BC7F1");
        internal static Guid IID_ICoreWebView2WebResourceRequestedEventHandler = new Guid("AB00B74C-15F1-4646-80E8-E76341D25D71");
        internal static Guid IID_ICoreWebView2NewWindowRequestedEventHandler = new Guid("D4C185FE-C81C-4989-97AF-2D3FA7AB5651");
        internal static Guid IID_ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler = new Guid("B99369F3-9B11-47B5-BC6F-8E7895FCEA17");
        internal static Guid IID_ICoreWebView2Environment = new Guid("B96D755E-0319-4E92-A296-23436F46A1FC");
        internal static Guid IID_ICoreWebView2EnvironmentOptions = new Guid("2FDE08A8-1E9A-4766-8C05-95A9CEB9D1C5");
        internal static Guid IID_ICoreWebView2EnvironmentOptions2 = new Guid("FF85C98A-1BA7-4A6B-90C8-2B752C89E9E2");
        internal static Guid IID_ICoreWebView2PrivateHostObjectHelper = new Guid("1656D586-E714-4092-9C76-014647940EFF");
        internal static Guid IID_ICoreWebView2PrivateHostObjectHelper2 = new Guid("A791A659-3AD9-41C3-9C7E-768FCC233666");
        internal static Guid IID_ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler = new Guid("4E8A3389-C9D8-4BD2-B6B5-124FEE6CC14D");
        internal static Guid IID_ICoreWebView2CreateCoreWebView2ControllerCompletedHandler = new Guid("6C4819F3-C9B7-4260-8127-C9F5BDE7F68C");
        internal static Guid IID_ICoreWebView2NavigationStartingEventArgs = new Guid("5B495469-E119-438A-9B18-7604F25F2E49");
        internal static Guid IID_ICoreWebView2WebResourceRequestedEventArgs = new Guid("453E667F-12C7-49D4-BE6D-DDBE7956F57A");
        internal static Guid IID_ICoreWebView2WebResourceRequest = new Guid("97055CD4-512C-4264-8B5F-E3F446CEA6A5");
        internal static Guid IID_ICoreWebView2WebResourceResponse = new Guid("AAFCC94F-FA27-48FD-97DF-830EF75AAEC9");
        internal static Guid IID_ICoreWebView2SourceChangedEventArgs = new Guid("31E0E545-1DBA-4266-8914-F63848A1F7D7");
        internal static Guid IID_ICoreWebView2ContentLoadingEventArgs = new Guid("0C8A1275-9B6B-4901-87AD-70DF25BAFA6E");
        internal static Guid IID_ICoreWebView2NavigationCompletedEventArgs = new Guid("30D68B7D-20D9-4752-A9CA-EC8448FBB5C1");
        internal static Guid IID_ICoreWebView2AcceleratorKeyPressedEventArgs = new Guid("9F760F8A-FB79-42BE-9990-7B56900FA9C7");
        internal static Guid IID_ICoreWebView2WebMessageReceivedEventArgs = new Guid("0F99A40C-E962-4207-9E92-E3D542EFF849");

        static WebView2ComWrapper()
        {
            coreWebView2EnvironmentOptionsEntry = CreateCoreWebView2EnvironmentOptionsEntry();
            coreWebView2CreateCoreWebView2EnvironmentCompletedHandlerEntry = CreateCoreWebView2CreateCoreWebView2EnvironmentCompletedHandlerEntry();
            coreWebView2CreateCoreWebView2ControllerCompletedHandlerEntry = CreateCoreWebView2CreateCoreWebView2ControllerCompletedHandlerEntry();
            coreWebView2PrivateHostObjectHelperEntry = CreateCoreWebView2PrivateHostObjectHelperEntry();
            coreWebView2MoveFocusRequestedEventHandlerEntry = CreateCoreWebView2MoveFocusRequestedEventHandlerEntry();
            coreWebView2AcceleratorKeyPressedEventHandlerEntry = CreateCoreWebView2AcceleratorKeyPressedEventHandlerEntry();
            coreWebView2ZoomFactorChangedEventHandlerEntry = CreateCoreWebView2ZoomFactorChangedEventHandlerEntry();
            coreWebView2NavigationCompletedEventHandlerEntry = CreateCoreWebView2NavigationCompletedEventHandlerEntry();
            coreWebView2NavigationStartingEventHandlerEntry = CreateCoreWebView2NavigationStartingEventHandlerEntry();
            coreWebView2SourceChangedEventHandlerEntry = CreateCoreWebView2SourceChangedEventHandlerEntry();
            coreWebView2WebMessageReceivedEventHandlerEntry = CreateCoreWebView2WebMessageReceivedEventHandlerEntry();
            coreWebView2ContentLoadingEventHandlerEntry = CreateCoreWebView2ContentLoadingEventHandlerEntry();
            coreWebView2ProcessFailedEventHandlerEntry = CreateCoreWebView2ProcessFailedEventHandlerEntry();
            coreWebView2WebResourceRequestedEventHandlerEntry = CreateCoreWebView2WebResourceRequestedEventHandlerEntry();
            coreWebView2NewWindowRequestedEventHandlerEntry = CreateCoreWebView2NewWindowRequestedEventHandlerEntry();
            coreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandlerEntry = CreateCoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandlerEntry();
            managedStreamEntry = CreateManagedStreamEntry();
        }
        private static ComInterfaceEntry* CreateCoreWebView2EnvironmentOptionsEntry()
        {
            CreateWebview2ICoreWebView2EnvironmentOptionsProxyVtbl(out var coreWebView2EnvironmentOptionVtbl);
            CreateWebview2ICoreWebView2EnvironmentOptions2ProxyVtbl(out var coreWebView2EnvironmentOption2Vtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 2);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = IID_ICoreWebView2EnvironmentOptions;
            wrapperEntry[0].Vtable = coreWebView2EnvironmentOptionVtbl;
            wrapperEntry[1].IID = IID_ICoreWebView2EnvironmentOptions2;
            wrapperEntry[1].Vtable = coreWebView2EnvironmentOption2Vtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreateCoreWebView2CreateCoreWebView2EnvironmentCompletedHandlerEntry()
        {
            CreateWebview2ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandlerProxyVtbl(out var coreWebView2CreateCoreEnvironmentCompletedHandlerVtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = IID_ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler;
            wrapperEntry[0].Vtable = coreWebView2CreateCoreEnvironmentCompletedHandlerVtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreateCoreWebView2CreateCoreWebView2ControllerCompletedHandlerEntry()
        {
            CreateWebview2ICoreWebView2CreateCoreWebView2ControllerCompletedHandlerProxyVtbl(out var coreWebView2CreateCoreControllerCompletedHandlerVtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = IID_ICoreWebView2CreateCoreWebView2ControllerCompletedHandler;
            wrapperEntry[0].Vtable = coreWebView2CreateCoreControllerCompletedHandlerVtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreateCoreWebView2PrivateHostObjectHelperEntry()
        {
            CreateWebview2ICoreWebView2PrivateHostObjectHelperProxyVtbl(out var coreWebView2EnvironmentOptionVtbl);
            CreateWebview2ICoreWebView2PrivateHostObjectHelper2ProxyVtbl(out var coreWebView2EnvironmentOption2Vtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 2);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = IID_ICoreWebView2PrivateHostObjectHelper;
            wrapperEntry[0].Vtable = coreWebView2EnvironmentOptionVtbl;
            wrapperEntry[1].IID = IID_ICoreWebView2PrivateHostObjectHelper2;
            wrapperEntry[1].Vtable = coreWebView2EnvironmentOption2Vtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreateCoreWebView2MoveFocusRequestedEventHandlerEntry()
        {
            CreateWebview2ICoreWebView2MoveFocusRequestedEventHandlerProxyVtbl(out var coreWebView2MoveFocusRequestedEventHandlerVtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = IID_ICoreWebView2MoveFocusRequestedEventHandler;
            wrapperEntry[0].Vtable = coreWebView2MoveFocusRequestedEventHandlerVtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreateCoreWebView2AcceleratorKeyPressedEventHandlerEntry()
        {
            CreateWebview2ICoreWebView2AcceleratorKeyPressedEventHandlerProxyVtbl(out var coreWebView2AcceleratorKeyPressedEventHandlerVtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = IID_ICoreWebView2AcceleratorKeyPressedEventHandler;
            wrapperEntry[0].Vtable = coreWebView2AcceleratorKeyPressedEventHandlerVtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreateCoreWebView2ZoomFactorChangedEventHandlerEntry()
        {
            CreateWebview2ICoreWebView2ZoomFactorChangedEventHandlerProxyVtbl(out var coreWebView2ZoomFactorChangedEventHandlerVtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = IID_ICoreWebView2ZoomFactorChangedEventHandler;
            wrapperEntry[0].Vtable = coreWebView2ZoomFactorChangedEventHandlerVtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreateCoreWebView2NavigationCompletedEventHandlerEntry()
        {
            CreateWebview2ICoreWebView2NavigationCompletedEventHandlerProxyVtbl(out var coreWebView2NavigationCompletedEventHandlerVtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = IID_ICoreWebView2NavigationCompletedEventHandler;
            wrapperEntry[0].Vtable = coreWebView2NavigationCompletedEventHandlerVtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreateCoreWebView2NavigationStartingEventHandlerEntry()
        {
            CreateWebview2ICoreWebView2NavigationStartingEventHandlerProxyVtbl(out var coreWebView2NavigationStartingEventHandlerVtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = IID_ICoreWebView2NavigationStartingEventHandler;
            wrapperEntry[0].Vtable = coreWebView2NavigationStartingEventHandlerVtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreateCoreWebView2SourceChangedEventHandlerEntry()
        {
            CreateWebview2ICoreWebView2SourceChangedEventHandlerProxyVtbl(out var coreWebView2SourceChangedEventHandlerVtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = IID_ICoreWebView2SourceChangedEventHandler;
            wrapperEntry[0].Vtable = coreWebView2SourceChangedEventHandlerVtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreateCoreWebView2WebMessageReceivedEventHandlerEntry()
        {
            CreateWebview2ICoreWebView2WebMessageReceivedEventHandlerProxyVtbl(out var coreWebView2WebMessageReceivedEventHandlerVtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = IID_ICoreWebView2WebMessageReceivedEventHandler;
            wrapperEntry[0].Vtable = coreWebView2WebMessageReceivedEventHandlerVtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreateCoreWebView2ContentLoadingEventHandlerEntry()
        {
            CreateWebview2ICoreWebView2ContentLoadingEventHandlerProxyVtbl(out var coreWebView2ContentLoadingEventHandlerVtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = IID_ICoreWebView2ContentLoadingEventHandler;
            wrapperEntry[0].Vtable = coreWebView2ContentLoadingEventHandlerVtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreateCoreWebView2ProcessFailedEventHandlerEntry()
        {
            CreateWebview2ICoreWebView2ProcessFailedEventHandlerProxyVtbl(out var coreWebView2ProcessFailedEventHandlerVtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = IID_ICoreWebView2ProcessFailedEventHandler;
            wrapperEntry[0].Vtable = coreWebView2ProcessFailedEventHandlerVtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreateCoreWebView2WebResourceRequestedEventHandlerEntry()
        {
            CreateWebview2ICoreWebView2WebResourceRequestedEventHandlerProxyVtbl(out var coreWebView2WebResourceRequestedEventHandlerVtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = IID_ICoreWebView2WebResourceRequestedEventHandler;
            wrapperEntry[0].Vtable = coreWebView2WebResourceRequestedEventHandlerVtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreateCoreWebView2NewWindowRequestedEventHandlerEntry()
        {
            CreateWebview2ICoreWebView2NewWindowRequestedEventHandlerProxyVtbl(out var coreWebView2NewWindowRequestedEventHandlerVtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = IID_ICoreWebView2NewWindowRequestedEventHandler;
            wrapperEntry[0].Vtable = coreWebView2NewWindowRequestedEventHandlerVtbl;
            return wrapperEntry;
        }
        private static ComInterfaceEntry* CreateCoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandlerEntry()
        {
            CreateWebview2ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandlerProxyVtbl(out var coreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandlerVtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry[0].IID = IID_ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler;
            wrapperEntry[0].Vtable = coreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandlerVtbl;
            return wrapperEntry;
        }

        private static ComInterfaceEntry* CreateManagedStreamEntry()
        {
            CreateIStreamProxyVtblFix(out var vtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 1);
            var wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry->IID = IID_IStream;
            wrapperEntry->Vtable = vtbl;
            return wrapperEntry;
        }
        public static new WebView2ComWrapper Instance { get; } = new WebView2ComWrapper();

        protected override unsafe ComInterfaceEntry* ComputeVtables(object obj, CreateComInterfaceFlags flags, out int count)
        {
            if (obj is webview2::Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions.RawOptions)
            {
                count = 2;
                return coreWebView2EnvironmentOptionsEntry;
            }

            if (obj is webview2::Microsoft.Web.WebView2.Core.CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler)
            {
                count = 1;
                return coreWebView2CreateCoreWebView2EnvironmentCompletedHandlerEntry;
            }

            if (obj is webview2::Microsoft.Web.WebView2.Core.CoreWebView2CreateCoreWebView2ControllerCompletedHandler)
            {
                count = 1;
                return coreWebView2CreateCoreWebView2ControllerCompletedHandlerEntry;
            }

            if (obj is webview2::Microsoft.Web.WebView2.Core.CoreWebView2PrivateHostObjectHelper.RawHelper)
            {
                count = 2;
                return coreWebView2PrivateHostObjectHelperEntry;
            }

            if (obj is webview2::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusRequestedEventHandler)
            {
                count = 1;
                return coreWebView2MoveFocusRequestedEventHandlerEntry;
            }

            if (obj is webview2::Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventHandler)
            {
                count = 1;
                return coreWebView2AcceleratorKeyPressedEventHandlerEntry;
            }

            if (obj is webview2::Microsoft.Web.WebView2.Core.CoreWebView2ZoomFactorChangedEventHandler)
            {
                count = 1;
                return coreWebView2ZoomFactorChangedEventHandlerEntry;
            }

            if (obj is webview2::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventHandler)
            {
                count = 1;
                return coreWebView2NavigationCompletedEventHandlerEntry;
            }

            if (obj is webview2::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventHandler)
            {
                count = 1;
                return coreWebView2NavigationStartingEventHandlerEntry;
            }

            if (obj is webview2::Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventHandler)
            {
                count = 1;
                return coreWebView2SourceChangedEventHandlerEntry;
            }

            if (obj is webview2::Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventHandler)
            {
                count = 1;
                return coreWebView2WebMessageReceivedEventHandlerEntry;
            }

            if (obj is webview2::Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventHandler)
            {
                count = 1;
                return coreWebView2ContentLoadingEventHandlerEntry;
            }

            if (obj is webview2::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventHandler)
            {
                count = 1;
                return coreWebView2ProcessFailedEventHandlerEntry;
            }

            if (obj is webview2::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestedEventHandler)
            {
                count = 1;
                return coreWebView2WebResourceRequestedEventHandlerEntry;
            }

            if (obj is webview2::Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventHandler)
            {
                count = 1;
                return coreWebView2NewWindowRequestedEventHandlerEntry;
            }

            if (obj is webview2::Microsoft.Web.WebView2.Core.CoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler)
            {
                count = 1;
                return coreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandlerEntry;
            }

            if (obj is webview2::Microsoft.Web.WebView2.Core.ManagedIStream)
            {
                count = 1;
                return managedStreamEntry;
            }

            return base.ComputeVtables(obj, flags, out count);
        }

        protected override object CreateObject(IntPtr externalComObject, CreateObjectFlags flags)
        {
            if (Marshal.QueryInterface(externalComObject, ref IID_ICoreWebView2Environment, out var coreWebView2EnvironmentPtr) >= 0)
            {
                Marshal.Release(coreWebView2EnvironmentPtr);
                return new ICoreWebView2EnvironmentWrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_ICoreWebView2Controller, out var coreWebView2ControllerPtr) >= 0)
            {
                Marshal.Release(coreWebView2ControllerPtr);
                return new ICoreWebView2ControllerWrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_ICoreWebView2, out var coreWebView2Ptr) >= 0)
            {
                Marshal.Release(coreWebView2Ptr);
                return new ICoreWebView2Wrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_ICoreWebView2Settings, out var coreWebView2SettingsPtr) >= 0)
            {
                Marshal.Release(coreWebView2SettingsPtr);
                return new ICoreWebView2SettingsWrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_ICoreWebView2NavigationStartingEventArgs, out var coreWebView2NavigationStartingEventArgsPtr) >= 0)
            {
                Marshal.Release(coreWebView2NavigationStartingEventArgsPtr);
                return new ICoreWebView2NavigationStartingEventArgsWrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_ICoreWebView2NavigationCompletedEventArgs, out var coreWebView2NavigationCompletedEventArgsPtr) >= 0)
            {
                Marshal.Release(coreWebView2NavigationCompletedEventArgsPtr);
                return new ICoreWebView2NavigationCompletedEventArgsWrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_ICoreWebView2WebResourceRequestedEventArgs, out var coreWebView2WebResourceRequestedEventArgsPtr) >= 0)
            {
                Marshal.Release(coreWebView2WebResourceRequestedEventArgsPtr);
                return new ICoreWebView2WebResourceRequestedEventArgsWrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_ICoreWebView2WebResourceRequest, out var coreWebView2WebResourceRequestPtr) >= 0)
            {
                Marshal.Release(coreWebView2WebResourceRequestPtr);
                return new ICoreWebView2WebResourceRequestWrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_ICoreWebView2WebResourceResponse, out var coreWebView2WebResourceResponsePtr) >= 0)
            {
                Marshal.Release(coreWebView2WebResourceResponsePtr);
                return new ICoreWebView2WebResourceResponseWrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_ICoreWebView2SourceChangedEventArgs, out var coreWebView2SourceChangedEventArgsPtr) >= 0)
            {
                Marshal.Release(coreWebView2SourceChangedEventArgsPtr);
                return new ICoreWebView2SourceChangedEventArgsWrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_ICoreWebView2ContentLoadingEventArgs, out var coreWebView2ContentLoadingEventArgsPtr) >= 0)
            {
                Marshal.Release(coreWebView2ContentLoadingEventArgsPtr);
                return new ICoreWebView2ContentLoadingEventArgsWrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_ICoreWebView2AcceleratorKeyPressedEventArgs, out var coreWebView2AcceleratorKeyPressedEventArgsPtr) >= 0)
            {
                Marshal.Release(coreWebView2AcceleratorKeyPressedEventArgsPtr);
                return new ICoreWebView2AcceleratorKeyPressedEventArgsWrapper(externalComObject);
            }

            if (Marshal.QueryInterface(externalComObject, ref IID_ICoreWebView2WebMessageReceivedEventArgs, out var coreWebView2WebMessageReceivedEventArgsPtr) >= 0)
            {
                Marshal.Release(coreWebView2WebMessageReceivedEventArgsPtr);
                return new ICoreWebView2WebMessageReceivedEventArgsWrapper(externalComObject);
            }

            return base.CreateObject(externalComObject, flags);
        }
        internal static void CreateIStreamProxyVtblFix(out System.IntPtr vtbl)
        {
            var vtblRaw = (System.IntPtr*)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(global::WinFormsComInterop.WebView2.WebView2ComWrapper), sizeof(System.IntPtr) * 14);
            GetIUnknownImpl(out vtblRaw[0], out vtblRaw[1], out vtblRaw[2]);

            vtblRaw[3] = (System.IntPtr)(delegate* unmanaged<System.IntPtr, byte*, int, nint, int>)&IStreamProxy.ReadFix;
            vtblRaw[4] = (System.IntPtr)(delegate* unmanaged<System.IntPtr, byte*, int, nint, int>)&IStreamProxy.Write;
            vtblRaw[5] = (System.IntPtr)(delegate* unmanaged<System.IntPtr, long, int, nint, int>)&IStreamProxy.Seek;
            vtblRaw[6] = (System.IntPtr)(delegate* unmanaged<System.IntPtr, long, int>)&IStreamProxy.SetSize;
            vtblRaw[7] = (System.IntPtr)(delegate* unmanaged<System.IntPtr, System.IntPtr, long, nint, nint, int>)&IStreamProxy.CopyTo;
            vtblRaw[8] = (System.IntPtr)(delegate* unmanaged<System.IntPtr, int, int>)&IStreamProxy.Commit;
            vtblRaw[9] = (System.IntPtr)(delegate* unmanaged<System.IntPtr, int>)&IStreamProxy.Revert;
            vtblRaw[10] = (System.IntPtr)(delegate* unmanaged<System.IntPtr, long, long, int, int>)&IStreamProxy.LockRegion;
            vtblRaw[11] = (System.IntPtr)(delegate* unmanaged<System.IntPtr, long, long, int, int>)&IStreamProxy.UnlockRegion;
            vtblRaw[12] = (System.IntPtr)(delegate* unmanaged<System.IntPtr, STATSTG_native*, int, int>)&IStreamProxy.Stat;
            vtblRaw[13] = (System.IntPtr)(delegate* unmanaged<System.IntPtr, System.IntPtr*, int>)&IStreamProxy.Clone;

            vtbl = (System.IntPtr)vtblRaw;
        }
    }
    unsafe partial class IStreamProxy
    {
        [System.Runtime.InteropServices.UnmanagedCallersOnly]
        public static int ReadFix(System.IntPtr thisPtr, byte* pv, int cb, nint pcbRead)
        {
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<global::System.Runtime.InteropServices.ComTypes.IStream>((ComInterfaceDispatch*)thisPtr);
                var local_0 = new byte[cb];
                inst.Read(local_0, cb, pcbRead);
                local_0.CopyTo(new Span<byte>(pv, cb));
            }
            catch (System.Exception __e)
            {
                return __e.HResult;
            }

            return 0; // S_OK;
        }
    }
}
