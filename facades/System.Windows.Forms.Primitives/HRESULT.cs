// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#if NET8_0_OR_GREATER
namespace Windows.Win32.Foundation
{

    using global::System.CodeDom.Compiler;
    using global::System.Diagnostics;
    using global::System.Globalization;
    using global::System.Runtime.InteropServices;
    using global::System;
    using Windows.Win32.Foundation;

    [DebuggerDisplay("{Value}")]
    [GeneratedCode("Microsoft.Windows.CsWin32", "0.3.36-beta+6a5076f50a")]
    internal readonly struct HRESULT : IEquatable<HRESULT>
    {
        public static readonly HRESULT COR_E_ARGUMENT = (HRESULT)(-2147024809);

        public static readonly HRESULT TLBX_E_LIBNOTREGISTERED = (HRESULT)(-2146234011);

        public static readonly HRESULT COR_E_MISSINGFIELD = (HRESULT)(-2146233071);

        public static readonly HRESULT COR_E_MISSINGMEMBER = (HRESULT)(-2146233070);

        public static readonly HRESULT COR_E_MISSINGMETHOD = (HRESULT)(-2146233069);

        public static readonly HRESULT COR_E_NOTSUPPORTED = (HRESULT)(-2146233067);

        public static readonly HRESULT COR_E_OVERFLOW = (HRESULT)(-2146233066);

        public static readonly HRESULT COR_E_INVALIDOLEVARIANTTYPE = (HRESULT)(-2146233039);

        public static readonly HRESULT COR_E_SAFEARRAYTYPEMISMATCH = (HRESULT)(-2146233037);

        public static readonly HRESULT COR_E_TARGETINVOCATION = (HRESULT)(-2146232828);

        public static readonly HRESULT COR_E_OBJECTDISPOSED = (HRESULT)(-2146232798);

        internal readonly int Value;

        internal static readonly HRESULT CLIPBRD_E_BAD_DATA = (HRESULT)(-2147221037);

        internal static readonly HRESULT DISP_E_ARRAYISLOCKED = (HRESULT)(-2147352563);

        internal static readonly HRESULT DISP_E_BADINDEX = (HRESULT)(-2147352565);

        internal static readonly HRESULT DISP_E_BADPARAMCOUNT = (HRESULT)(-2147352562);

        internal static readonly HRESULT DISP_E_BADVARTYPE = (HRESULT)(-2147352568);

        internal static readonly HRESULT DISP_E_BADCALLEE = (HRESULT)(-2147352560);

        internal static readonly HRESULT DISP_E_BUFFERTOOSMALL = (HRESULT)(-2147352557);

        internal static readonly HRESULT DISP_E_DIVBYZERO = (HRESULT)(-2147352558);

        internal static readonly HRESULT DISP_E_EXCEPTION = (HRESULT)(-2147352567);

        internal static readonly HRESULT DISP_E_MEMBERNOTFOUND = (HRESULT)(-2147352573);

        internal static readonly HRESULT DISP_E_NONAMEDARGS = (HRESULT)(-2147352569);

        internal static readonly HRESULT DISP_E_NOTACOLLECTION = (HRESULT)(-2147352559);

        internal static readonly HRESULT DISP_E_OVERFLOW = (HRESULT)(-2147352566);

        internal static readonly HRESULT DISP_E_PARAMNOTFOUND = (HRESULT)(-2147352572);

        internal static readonly HRESULT DISP_E_PARAMNOTOPTIONAL = (HRESULT)(-2147352561);

        internal static readonly HRESULT DISP_E_TYPEMISMATCH = (HRESULT)(-2147352571);

        internal static readonly HRESULT DISP_E_UNKNOWNINTERFACE = (HRESULT)(-2147352575);

        internal static readonly HRESULT DISP_E_UNKNOWNLCID = (HRESULT)(-2147352564);

        internal static readonly HRESULT DISP_E_UNKNOWNNAME = (HRESULT)(-2147352570);

        internal static readonly HRESULT DRAGDROP_E_ALREADYREGISTERED = (HRESULT)(-2147221247);

        internal static readonly HRESULT DRAGDROP_E_NOTREGISTERED = (HRESULT)(-2147221248);

        internal static readonly HRESULT DRAGDROP_S_CANCEL = (HRESULT)262401;

        internal static readonly HRESULT DRAGDROP_S_DROP = (HRESULT)262400;

        internal static readonly HRESULT DRAGDROP_S_USEDEFAULTCURSORS = (HRESULT)262402;

        internal static readonly HRESULT DV_E_DVASPECT = (HRESULT)(-2147221397);

        internal static readonly HRESULT DV_E_FORMATETC = (HRESULT)(-2147221404);

        internal static readonly HRESULT DV_E_TYMED = (HRESULT)(-2147221399);

        internal static readonly HRESULT E_ABORT = (HRESULT)(-2147467260);

        internal static readonly HRESULT E_FAIL = (HRESULT)(-2147467259);

        internal static readonly HRESULT E_INVALIDARG = (HRESULT)(-2147024809);

        internal static readonly HRESULT E_NOINTERFACE = (HRESULT)(-2147467262);

        internal static readonly HRESULT E_NOTIMPL = (HRESULT)(-2147467263);

        internal static readonly HRESULT E_OUTOFMEMORY = (HRESULT)(-2147024882);

        internal static readonly HRESULT E_POINTER = (HRESULT)(-2147467261);

        internal static readonly HRESULT HTTP_E_STATUS_UNEXPECTED = (HRESULT)(-2145845247);

        internal static readonly HRESULT HTTP_E_STATUS_UNEXPECTED_REDIRECTION = (HRESULT)(-2145845245);

        internal static readonly HRESULT HTTP_E_STATUS_UNEXPECTED_CLIENT_ERROR = (HRESULT)(-2145845244);

        internal static readonly HRESULT HTTP_E_STATUS_UNEXPECTED_SERVER_ERROR = (HRESULT)(-2145845243);

        internal static readonly HRESULT HTTP_E_STATUS_AMBIGUOUS = (HRESULT)(-2145844948);

        internal static readonly HRESULT HTTP_E_STATUS_MOVED = (HRESULT)(-2145844947);

        internal static readonly HRESULT HTTP_E_STATUS_REDIRECT = (HRESULT)(-2145844946);

        internal static readonly HRESULT HTTP_E_STATUS_REDIRECT_METHOD = (HRESULT)(-2145844945);

        internal static readonly HRESULT HTTP_E_STATUS_NOT_MODIFIED = (HRESULT)(-2145844944);

        internal static readonly HRESULT HTTP_E_STATUS_USE_PROXY = (HRESULT)(-2145844943);

        internal static readonly HRESULT HTTP_E_STATUS_REDIRECT_KEEP_VERB = (HRESULT)(-2145844941);

        internal static readonly HRESULT HTTP_E_STATUS_BAD_REQUEST = (HRESULT)(-2145844848);

        internal static readonly HRESULT HTTP_E_STATUS_DENIED = (HRESULT)(-2145844847);

        internal static readonly HRESULT HTTP_E_STATUS_PAYMENT_REQ = (HRESULT)(-2145844846);

        internal static readonly HRESULT HTTP_E_STATUS_FORBIDDEN = (HRESULT)(-2145844845);

        internal static readonly HRESULT HTTP_E_STATUS_NOT_FOUND = (HRESULT)(-2145844844);

        internal static readonly HRESULT HTTP_E_STATUS_BAD_METHOD = (HRESULT)(-2145844843);

        internal static readonly HRESULT HTTP_E_STATUS_NONE_ACCEPTABLE = (HRESULT)(-2145844842);

        internal static readonly HRESULT HTTP_E_STATUS_PROXY_AUTH_REQ = (HRESULT)(-2145844841);

        internal static readonly HRESULT HTTP_E_STATUS_REQUEST_TIMEOUT = (HRESULT)(-2145844840);

        internal static readonly HRESULT HTTP_E_STATUS_CONFLICT = (HRESULT)(-2145844839);

        internal static readonly HRESULT HTTP_E_STATUS_GONE = (HRESULT)(-2145844838);

        internal static readonly HRESULT HTTP_E_STATUS_LENGTH_REQUIRED = (HRESULT)(-2145844837);

        internal static readonly HRESULT HTTP_E_STATUS_PRECOND_FAILED = (HRESULT)(-2145844836);

        internal static readonly HRESULT HTTP_E_STATUS_REQUEST_TOO_LARGE = (HRESULT)(-2145844835);

        internal static readonly HRESULT HTTP_E_STATUS_URI_TOO_LONG = (HRESULT)(-2145844834);

        internal static readonly HRESULT HTTP_E_STATUS_UNSUPPORTED_MEDIA = (HRESULT)(-2145844833);

        internal static readonly HRESULT HTTP_E_STATUS_RANGE_NOT_SATISFIABLE = (HRESULT)(-2145844832);

        internal static readonly HRESULT HTTP_E_STATUS_EXPECTATION_FAILED = (HRESULT)(-2145844831);

        internal static readonly HRESULT HTTP_E_STATUS_SERVER_ERROR = (HRESULT)(-2145844748);

        internal static readonly HRESULT HTTP_E_STATUS_NOT_SUPPORTED = (HRESULT)(-2145844747);

        internal static readonly HRESULT HTTP_E_STATUS_BAD_GATEWAY = (HRESULT)(-2145844746);

        internal static readonly HRESULT HTTP_E_STATUS_SERVICE_UNAVAIL = (HRESULT)(-2145844745);

        internal static readonly HRESULT HTTP_E_STATUS_GATEWAY_TIMEOUT = (HRESULT)(-2145844744);

        internal static readonly HRESULT HTTP_E_STATUS_VERSION_NOT_SUP = (HRESULT)(-2145844743);

        internal static readonly HRESULT S_OK = (HRESULT)0;

        internal static readonly HRESULT INPLACE_E_NOTOOLSPACE = (HRESULT)(-2147221087);

        internal static readonly HRESULT OLE_E_ADVISENOTSUPPORTED = (HRESULT)(-2147221501);

        internal static readonly HRESULT OLE_E_INVALIDRECT = (HRESULT)(-2147221491);

        internal static readonly HRESULT OLE_E_NOCONNECTION = (HRESULT)(-2147221500);

        internal static readonly HRESULT OLE_E_PROMPTSAVECANCELLED = (HRESULT)(-2147221492);

        internal static readonly HRESULT REGDB_E_CLASSNOTREG = (HRESULT)(-2147221164);

        internal static readonly HRESULT RPC_E_CHANGED_MODE = (HRESULT)(-2147417850);

        internal static readonly HRESULT S_FALSE = (HRESULT)1;

        internal static readonly HRESULT STG_E_FILENOTFOUND = (HRESULT)(-2147287038);

        internal static readonly HRESULT STG_E_INVALIDFLAG = (HRESULT)(-2147286785);

        internal static readonly HRESULT STG_E_INVALIDFUNCTION = (HRESULT)(-2147287039);

        internal static readonly HRESULT STG_E_INVALIDPOINTER = (HRESULT)(-2147287031);

        internal static readonly HRESULT TBS_E_INTERNAL_ERROR = (HRESULT)(-2144845823);

        internal static readonly HRESULT TBS_E_BAD_PARAMETER = (HRESULT)(-2144845822);

        internal static readonly HRESULT TBS_E_INVALID_OUTPUT_POINTER = (HRESULT)(-2144845821);

        internal static readonly HRESULT TBS_E_INVALID_CONTEXT = (HRESULT)(-2144845820);

        internal static readonly HRESULT TBS_E_INSUFFICIENT_BUFFER = (HRESULT)(-2144845819);

        internal static readonly HRESULT TBS_E_IOERROR = (HRESULT)(-2144845818);

        internal static readonly HRESULT TBS_E_INVALID_CONTEXT_PARAM = (HRESULT)(-2144845817);

        internal static readonly HRESULT TBS_E_SERVICE_NOT_RUNNING = (HRESULT)(-2144845816);

        internal static readonly HRESULT TBS_E_TOO_MANY_TBS_CONTEXTS = (HRESULT)(-2144845815);

        internal static readonly HRESULT TBS_E_TOO_MANY_RESOURCES = (HRESULT)(-2144845814);

        internal static readonly HRESULT TBS_E_SERVICE_START_PENDING = (HRESULT)(-2144845813);

        internal static readonly HRESULT TBS_E_PPI_NOT_SUPPORTED = (HRESULT)(-2144845812);

        internal static readonly HRESULT TBS_E_COMMAND_CANCELED = (HRESULT)(-2144845811);

        internal static readonly HRESULT TBS_E_BUFFER_TOO_LARGE = (HRESULT)(-2144845810);

        internal static readonly HRESULT TBS_E_TPM_NOT_FOUND = (HRESULT)(-2144845809);

        internal static readonly HRESULT TBS_E_SERVICE_DISABLED = (HRESULT)(-2144845808);

        internal static readonly HRESULT TBS_E_NO_EVENT_LOG = (HRESULT)(-2144845807);

        internal static readonly HRESULT TBS_E_ACCESS_DENIED = (HRESULT)(-2144845806);

        internal static readonly HRESULT TBS_E_PROVISIONING_NOT_ALLOWED = (HRESULT)(-2144845805);

        internal static readonly HRESULT TBS_E_PPI_FUNCTION_UNSUPPORTED = (HRESULT)(-2144845804);

        internal static readonly HRESULT TBS_E_OWNERAUTH_NOT_FOUND = (HRESULT)(-2144845803);

        internal static readonly HRESULT TBS_E_PROVISIONING_INCOMPLETE = (HRESULT)(-2144845802);

        internal static readonly HRESULT TYPE_E_BADMODULEKIND = (HRESULT)(-2147317571);

        internal static readonly HRESULT VIEW_E_DRAW = (HRESULT)(-2147221184);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal bool Succeeded => Value >= 0;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal bool Failed => Value < 0;

        public static HRESULT HRESULT_FROM_WIN32(WIN32_ERROR error)
        {
            return new HRESULT((int)(error & (WIN32_ERROR)65535u) | -2147024896);
        }

        public static implicit operator HRESULT(Exception ex)
        {
            return (HRESULT)ex.HResult;
        }

        public void AssertSuccess()
        {
        }

        internal HRESULT(int value)
        {
            Value = value;
        }

        public static implicit operator int(HRESULT value)
        {
            return value.Value;
        }

        public static explicit operator HRESULT(int value)
        {
            return new HRESULT(value);
        }

        public static bool operator ==(HRESULT left, HRESULT right)
        {
            return left.Value == right.Value;
        }

        public static bool operator !=(HRESULT left, HRESULT right)
        {
            return !(left == right);
        }

        public bool Equals(HRESULT other)
        {
            return Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (obj is HRESULT)
            {
                HRESULT other = (HRESULT)obj;
                return Equals(other);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "0x{0:X8}", Value);
        }

        public static implicit operator uint(HRESULT value)
        {
            return (uint)value.Value;
        }

        public static explicit operator HRESULT(uint value)
        {
            return new HRESULT((int)value);
        }

        internal HRESULT ThrowOnFailure(IntPtr errorInfo = 0)
        {
            Marshal.ThrowExceptionForHR(Value, errorInfo);
            return this;
        }

        internal string ToString(string format, IFormatProvider formatProvider)
        {
            uint value = (uint)Value;
            return value.ToString(format, formatProvider);
        }
    }
}
#endif

public static partial class Interop
{
    public enum HRESULT : int
    {
        S_OK = 0,
        S_FALSE = 1,
        DRAGDROP_S_DROP = 0x00040100,
        DRAGDROP_S_CANCEL = 0x00040101,
        DRAGDROP_S_USEDEFAULTCURSORS = 0x00040102,
        DISP_E_MEMBERNOTFOUND = unchecked((int)0x80020003),
        DISP_E_PARAMNOTFOUND = unchecked((int)0x80020004),
        DISP_E_UNKNOWNNAME = unchecked((int)0x80020006),
        DISP_E_EXCEPTION = unchecked((int)0x80020009),
        DISP_E_UNKNOWNLCID = unchecked((int)0x8002000C),
        TYPE_E_BADMODULEKIND = unchecked((int)0x800288BD),
        E_NOTIMPL = unchecked((int)0x80004001),
        E_NOINTERFACE = unchecked((int)0x80004002),
        E_POINTER = unchecked((int)0x80004003),
        E_ABORT = unchecked((int)0x80004004),
        E_FAIL = unchecked((int)0x80004005),
        OLE_E_ADVISENOTSUPPORTED = unchecked((int)0x80040003),
        OLE_E_NOCONNECTION = unchecked((int)0x80040004),
        OLE_E_PROMPTSAVECANCELLED = unchecked((int)0x8004000C),
        OLE_E_INVALIDRECT = unchecked((int)0x8004000D),
        DV_E_FORMATETC = unchecked((int)0x80040064),
        DV_E_TYMED = unchecked((int)0x80040069),
        DV_E_DVASPECT = unchecked((int)0x8004006B),
        DRAGDROP_E_NOTREGISTERED = unchecked((int)0x80040100),
        DRAGDROP_E_ALREADYREGISTERED = unchecked((int)0x80040101),
        VIEW_E_DRAW = unchecked((int)0x80040140),
        INPLACE_E_NOTOOLSPACE = unchecked((int)0x800401A1),
        STG_E_INVALIDFUNCTION = unchecked((int)0x80030001L),
        STG_E_FILENOTFOUND = unchecked((int)0x80030002),
        STG_E_ACCESSDENIED = unchecked((int)0x80030005),
        STG_E_INVALIDPARAMETER = unchecked((int)0x80030057),
        STG_E_INVALIDFLAG = unchecked((int)0x800300FF),
        E_OUTOFMEMORY = unchecked((int)0x8007000E),
        E_ACCESSDENIED = unchecked((int)0x80070005L),
        E_INVALIDARG = unchecked((int)0x80070057),
        ERROR_CANCELLED = unchecked((int)0x800704C7),
        RPC_E_CHANGED_MODE = unchecked((int)0x80010106),
    }
}

internal static class HResultExtensions
{
    public static bool Succeeded(this Interop.HRESULT hr) => hr >= 0;

    public static bool Failed(this Interop.HRESULT hr) => hr < 0;
}
