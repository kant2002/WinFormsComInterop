extern alias drawing;
using System;
using System.IO;
using System.Runtime.InteropServices;
using static drawing::Interop;
using static System.Runtime.InteropServices.ComWrappers;

namespace WinFormsComInterop
{
    public unsafe static class IStreamVtbl
    {
        [UnmanagedCallersOnly]
        public static int Read(IntPtr thisPtr, byte* pv, uint cb, uint* pcbRead)
        {
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<Ole32.IStream>((ComInterfaceDispatch*)thisPtr);
                inst.Read(pv, cb, pcbRead);
            }
            catch (Exception e)
            {
                return e.HResult;
            }

            return 0; // S_OK;
        }

        [UnmanagedCallersOnly]
        public static int Write(IntPtr thisPtr, byte* pv, uint cb, uint* pcbWritten)
        {
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<Ole32.IStream>((ComInterfaceDispatch*)thisPtr);
                inst.Write(pv, cb, pcbWritten);
            }
            catch (Exception e)
            {
                return e.HResult;
            }

            return 0; // S_OK;
        }

        [UnmanagedCallersOnly]
        public static int Seek(IntPtr thisPtr, long dlibMove, SeekOrigin dwOrigin, ulong* plibNewPosition)
        {
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<object>((ComInterfaceDispatch*)thisPtr);
                ((Ole32.IStream)inst).Seek(dlibMove, dwOrigin, plibNewPosition);
            }
            catch (Exception e)
            {
                return e.HResult;
            }

            return 0; // S_OK;
        }

        [UnmanagedCallersOnly]
        public static int SetSize(IntPtr thisPtr, ulong libNewSize)
        {
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<Ole32.IStream>((ComInterfaceDispatch*)thisPtr);
                inst.SetSize(libNewSize);
            }
            catch (Exception e)
            {
                return e.HResult;
            }

            return 0; // S_OK;
        }

        [UnmanagedCallersOnly]
        public static int CopyTo(IntPtr thisPtr, IntPtr pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<Ole32.IStream>((ComInterfaceDispatch*)thisPtr);
                var targetStream = ComInterfaceDispatch.GetInstance<Ole32.IStream>((ComInterfaceDispatch*)pstm);
                inst.CopyTo(targetStream, cb, pcbRead, pcbWritten);
            }
            catch (Exception e)
            {
                return e.HResult;
            }

            return 0; // S_OK;
        }

        [UnmanagedCallersOnly]
        public static int Commit(IntPtr thisPtr, uint grfCommitFlags)
        {
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<Ole32.IStream>((ComInterfaceDispatch*)thisPtr);
                inst.Commit(grfCommitFlags);
            }
            catch (Exception e) { return e.HResult; }
            return 0;
        }

        [UnmanagedCallersOnly]
        public static int Revert(IntPtr thisPtr)
        {
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<Ole32.IStream>((ComInterfaceDispatch*)thisPtr);
                inst.Revert();
            }
            catch (Exception e)
            {
                return e.HResult;
            }
            return 0;
        }

        [UnmanagedCallersOnly]
        public static int LockRegion(IntPtr thisPtr, ulong libOffset, ulong cb, uint dwLockType)
        {
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<Ole32.IStream>((ComInterfaceDispatch*)thisPtr);
                return (int)inst.LockRegion(libOffset, cb, dwLockType);
            }
            catch (Exception e) { return e.HResult; }
        }

        [UnmanagedCallersOnly]
        public static int UnlockRegion(IntPtr thisPtr, ulong libOffset, ulong cb, uint dwLockType)
        {
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<Ole32.IStream>((ComInterfaceDispatch*)thisPtr);
                return (int)inst.UnlockRegion(libOffset, cb, dwLockType);
            }
            catch (Exception e) { return e.HResult; }
        }

        [UnmanagedCallersOnly]
        public static int Stat(IntPtr thisPtr, Ole32.STATSTG* pstatstg, Ole32.STATFLAG grfStatFlag)
        {
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<Ole32.IStream>((ComInterfaceDispatch*)thisPtr);
                inst.Stat(out *pstatstg, grfStatFlag);
            }
            catch (Exception e) { return e.HResult; }
            return 0;
        }

        [UnmanagedCallersOnly]
        public static int Clone(IntPtr thisPtr)
        {
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<Ole32.IStream>((ComInterfaceDispatch*)thisPtr);
                inst.Clone();
            }
            catch (Exception e) { return e.HResult; }
            return 0;
        }
    }
}
