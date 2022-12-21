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
    public unsafe partial class WebView2ComWrapper : WinFormsComWrappers
    {
        static ComWrappers.ComInterfaceEntry* coreWebView2EnvironmentOptionsEntry;
        static ComWrappers.ComInterfaceEntry* coreWebView2CreateCoreWebView2EnvironmentCompletedHandlerEntry;
        static ComWrappers.ComInterfaceEntry* coreWebView2CreateCoreWebView2ControllerCompletedHandlerEntry;

        internal static Guid IID_ICoreWebView2Environment = new Guid("B96D755E-0319-4E92-A296-23436F46A1FC");
        internal static Guid IID_ICoreWebView2EnvironmentOptions = new Guid("2FDE08A8-1E9A-4766-8C05-95A9CEB9D1C5");
        internal static Guid IID_ICoreWebView2EnvironmentOptions2 = new Guid("FF85C98A-1BA7-4A6B-90C8-2B752C89E9E2");
        internal static Guid IID_ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler = new Guid("4E8A3389-C9D8-4BD2-B6B5-124FEE6CC14D");
        internal static Guid IID_ICoreWebView2CreateCoreWebView2ControllerCompletedHandler = new Guid("6C4819F3-C9B7-4260-8127-C9F5BDE7F68C");

        static WebView2ComWrapper()
        {
            coreWebView2EnvironmentOptionsEntry = CreateCoreWebView2EnvironmentOptionsEntry();
            coreWebView2CreateCoreWebView2EnvironmentCompletedHandlerEntry = CreateCoreWebView2CreateCoreWebView2EnvironmentCompletedHandlerEntry();
            coreWebView2CreateCoreWebView2ControllerCompletedHandlerEntry = CreateCoreWebView2CreateCoreWebView2ControllerCompletedHandlerEntry();
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

            return base.ComputeVtables(obj, flags, out count);
        }

        protected override object CreateObject(IntPtr externalComObject, CreateObjectFlags flags)
        {
            if (Marshal.QueryInterface(externalComObject, ref IID_ICoreWebView2Environment, out var coreWebView2EnvironmentPtr) >= 0)
            {
                Marshal.Release(coreWebView2EnvironmentPtr);
                return new ICoreWebView2EnvironmentWrapper(externalComObject);
            }

            return base.CreateObject(externalComObject, flags);
        }
    }
}
