using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Web.WebView2.Core.Raw;


[ComImport]
[Guid("76ECEACB-0462-4D94-AC83-423A6793775E")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ICoreWebView2
{
    /*[DispId(1610678272)]
    ICoreWebView2Settings Settings
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.Interface)]
        get;
    }

    [DispId(1610678273)]
    string Source
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void Navigate([In][MarshalAs(UnmanagedType.LPWStr)] string uri);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void NavigateToString([In][MarshalAs(UnmanagedType.LPWStr)] string htmlContent);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_NavigationStarting([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_NavigationStarting([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_ContentLoading([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ContentLoadingEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_ContentLoading([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_SourceChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2SourceChangedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_SourceChanged([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_HistoryChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2HistoryChangedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_HistoryChanged([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_NavigationCompleted([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2NavigationCompletedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_NavigationCompleted([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_FrameNavigationStarting([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_FrameNavigationStarting([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_FrameNavigationCompleted([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2NavigationCompletedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_FrameNavigationCompleted([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_ScriptDialogOpening([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ScriptDialogOpeningEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_ScriptDialogOpening([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_PermissionRequested([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PermissionRequestedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_PermissionRequested([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_ProcessFailed([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ProcessFailedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_ProcessFailed([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void AddScriptToExecuteOnDocumentCreated([In][MarshalAs(UnmanagedType.LPWStr)] string javaScript, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void RemoveScriptToExecuteOnDocumentCreated([In][MarshalAs(UnmanagedType.LPWStr)] string id);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void ExecuteScript([In][MarshalAs(UnmanagedType.LPWStr)] string javaScript, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExecuteScriptCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void CapturePreview([In] COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, [In][MarshalAs(UnmanagedType.Interface)] IStream imageStream, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2CapturePreviewCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void Reload();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void PostWebMessageAsJson([In][MarshalAs(UnmanagedType.LPWStr)] string webMessageAsJson);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void PostWebMessageAsString([In][MarshalAs(UnmanagedType.LPWStr)] string webMessageAsString);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_WebMessageReceived([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebMessageReceivedEventHandler handler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_WebMessageReceived([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void CallDevToolsProtocolMethod([In][MarshalAs(UnmanagedType.LPWStr)] string methodName, [In][MarshalAs(UnmanagedType.LPWStr)] string parametersAsJson, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler);

    [DispId(1610678306)]
    uint BrowserProcessId
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678307)]
    int CanGoBack
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678308)]
    int CanGoForward
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void GoBack();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void GoForward();

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2DevToolsProtocolEventReceiver GetDevToolsProtocolEventReceiver([In][MarshalAs(UnmanagedType.LPWStr)] string eventName);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void Stop();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_NewWindowRequested([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2NewWindowRequestedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_NewWindowRequested([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_DocumentTitleChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2DocumentTitleChangedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_DocumentTitleChanged([In] EventRegistrationToken token);

    [DispId(1610678317)]
    string DocumentTitle
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void AddHostObjectToScript([In][MarshalAs(UnmanagedType.LPWStr)] string name, [In][MarshalAs(UnmanagedType.Struct)] ref object @object);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void RemoveHostObjectFromScript([In][MarshalAs(UnmanagedType.LPWStr)] string name);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void OpenDevToolsWindow();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_ContainsFullScreenElementChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ContainsFullScreenElementChangedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_ContainsFullScreenElementChanged([In] EventRegistrationToken token);

    [DispId(1610678323)]
    int ContainsFullScreenElement
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_WebResourceRequested([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebResourceRequestedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_WebResourceRequested([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void AddWebResourceRequestedFilter([In][MarshalAs(UnmanagedType.LPWStr)] string uri, [In] COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void RemoveWebResourceRequestedFilter([In][MarshalAs(UnmanagedType.LPWStr)] string uri, [In] COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_WindowCloseRequested([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2WindowCloseRequestedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_WindowCloseRequested([In] EventRegistrationToken token);*/
}