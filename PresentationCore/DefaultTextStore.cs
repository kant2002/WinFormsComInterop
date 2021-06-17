using MS.Win32;
using System;

namespace System.Windows.Input
{
    public class DefaultTextStore : UnsafeNativeMethods.ITfContextOwner,
                                       UnsafeNativeMethods.ITfContextOwnerCompositionSink,
                                       UnsafeNativeMethods.ITfTransitoryExtensionSink
    {
        void UnsafeNativeMethods.ITfContextOwner.GetACPFromPoint(ref UnsafeNativeMethods.POINT point, UnsafeNativeMethods.GetPositionFromPointFlags flags, out int position)
        {
            throw new NotImplementedException();
        }

        void UnsafeNativeMethods.ITfContextOwner.GetTextExt(int start, int end, out UnsafeNativeMethods.RECT rect, out bool clipped)
        {
            throw new NotImplementedException();
        }

        void UnsafeNativeMethods.ITfContextOwner.GetScreenExt(out UnsafeNativeMethods.RECT rect)
        {
            throw new NotImplementedException();
        }

        void UnsafeNativeMethods.ITfContextOwner.GetStatus(out UnsafeNativeMethods.TS_STATUS status)
        {
            throw new NotImplementedException();
        }

        void UnsafeNativeMethods.ITfContextOwner.GetWnd(out IntPtr hwnd)
        {
            throw new NotImplementedException();
        }

        void UnsafeNativeMethods.ITfContextOwner.GetValue(ref Guid guidAttribute, out object varValue)
        {
            throw new NotImplementedException();
        }

        void UnsafeNativeMethods.ITfContextOwnerCompositionSink.OnStartComposition(UnsafeNativeMethods.ITfCompositionView view, out bool ok)
        {
            throw new NotImplementedException();
        }

        void UnsafeNativeMethods.ITfContextOwnerCompositionSink.OnUpdateComposition(UnsafeNativeMethods.ITfCompositionView view, UnsafeNativeMethods.ITfRange rangeNew)
        {
            throw new NotImplementedException();
        }

        void UnsafeNativeMethods.ITfContextOwnerCompositionSink.OnEndComposition(UnsafeNativeMethods.ITfCompositionView view)
        {
            throw new NotImplementedException();
        }

        void UnsafeNativeMethods.ITfTransitoryExtensionSink.OnTransitoryExtensionUpdated(UnsafeNativeMethods.ITfContext context, int ecReadOnly, UnsafeNativeMethods.ITfRange rangeResult, UnsafeNativeMethods.ITfRange rangeComposition, out bool fDeleteResultRange)
        {
            throw new NotImplementedException();
        }
    }
}
