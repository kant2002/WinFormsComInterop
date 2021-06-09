extern alias winbase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsComInterop
{
    unsafe partial class IExternalObject:
        winbase::MS.Win32.UnsafeNativeMethods.IOleDropTarget
    {
        int winbase::MS.Win32.UnsafeNativeMethods.IOleDropTarget.OleDragEnter(object pDataObj, int grfKeyState, long pt, ref int pdwEffect)
        {
            throw new NotImplementedException();
        }

        int winbase::MS.Win32.UnsafeNativeMethods.IOleDropTarget.OleDragOver(int grfKeyState, long pt, ref int pdwEffect)
        {
            throw new NotImplementedException();
        }

        int winbase::MS.Win32.UnsafeNativeMethods.IOleDropTarget.OleDragLeave()
        {
            throw new NotImplementedException();
        }

        int winbase::MS.Win32.UnsafeNativeMethods.IOleDropTarget.OleDrop(object pDataObj, int grfKeyState, long pt, ref int pdwEffect)
        {
            throw new NotImplementedException();
        }
    }
}
