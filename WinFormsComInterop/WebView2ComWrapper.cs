extern alias webview2;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WinFormsComInterop
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

        internal static Guid IID_ICoreWebView2 = new Guid("76ECEACB-0462-4D94-AC83-423A6793775E");
        internal static Guid IID_ICoreWebView2Controller = new Guid("4D00C0D1-9434-4EB6-8078-8697A560334F");
        internal static Guid IID_ICoreWebView2MoveFocusRequestedEventHandler = new Guid("69035451-6DC7-4CB8-9BCE-B2BD70AD289F");
        internal static Guid IID_ICoreWebView2AcceleratorKeyPressedEventHandler = new Guid("B29C7E28-FA79-41A8-8E44-65811C76DCB2");
        internal static Guid IID_ICoreWebView2ZoomFactorChangedEventHandler = new Guid("B52D71D6-C4DF-4543-A90C-64A3E60F38CB");
        internal static Guid IID_ICoreWebView2NavigationCompletedEventHandler = new Guid("D33A35BF-1C49-4F98-93AB-006E0533FE1C");
        internal static Guid IID_ICoreWebView2Environment = new Guid("B96D755E-0319-4E92-A296-23436F46A1FC");
        internal static Guid IID_ICoreWebView2EnvironmentOptions = new Guid("2FDE08A8-1E9A-4766-8C05-95A9CEB9D1C5");
        internal static Guid IID_ICoreWebView2EnvironmentOptions2 = new Guid("FF85C98A-1BA7-4A6B-90C8-2B752C89E9E2");
        internal static Guid IID_ICoreWebView2PrivateHostObjectHelper = new Guid("1656D586-E714-4092-9C76-014647940EFF");
        internal static Guid IID_ICoreWebView2PrivateHostObjectHelper2 = new Guid("A791A659-3AD9-41C3-9C7E-768FCC233666");
        internal static Guid IID_ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler = new Guid("4E8A3389-C9D8-4BD2-B6B5-124FEE6CC14D");
        internal static Guid IID_ICoreWebView2CreateCoreWebView2ControllerCompletedHandler = new Guid("6C4819F3-C9B7-4260-8127-C9F5BDE7F68C");

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

            return base.CreateObject(externalComObject, flags);
        }
    }
}
