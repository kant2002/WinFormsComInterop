extern alias primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsComInterop
{
    unsafe partial class IExternalObject
    {
        int primitives::Interop.Ole32.IPicture.Handle
        {
            get
            {
                Guid targetInterface = WinFormsComWrappers.IID_IPicture;
                var result = Marshal.QueryInterface(this.instance, ref targetInterface, out var persistStreamPtr);
                if (result != 0)
                {
                    throw new InvalidCastException();
                }

                int retVal;

                IntPtr* comDispatch = (IntPtr*)persistStreamPtr;
                IntPtr* vtbl = (IntPtr*)comDispatch[0];
                result = ((delegate* unmanaged<IntPtr, int*, int>)vtbl[3])(persistStreamPtr, &retVal);
                if (result != 0)
                {
                    Marshal.ThrowExceptionForHR(result);
                }

                return retVal;
            }
        }

        int primitives::Interop.Ole32.IPicture.hPal
        {
            get
            {
                Guid targetInterface = WinFormsComWrappers.IID_IPicture;
                var result = Marshal.QueryInterface(this.instance, ref targetInterface, out var persistStreamPtr);
                if (result != 0)
                {
                    throw new InvalidCastException();
                }

                int retVal;

                IntPtr* comDispatch = (IntPtr*)persistStreamPtr;
                IntPtr* vtbl = (IntPtr*)comDispatch[0];
                result = ((delegate* unmanaged<IntPtr, int*, int>)vtbl[4])(persistStreamPtr, &retVal);
                if (result != 0)
                {
                    Marshal.ThrowExceptionForHR(result);
                }

                return retVal;
            }
        }

        short primitives::Interop.Ole32.IPicture.Type
        {
            get
            {
                Guid targetInterface = WinFormsComWrappers.IID_IPicture;
                var result = Marshal.QueryInterface(this.instance, ref targetInterface, out var persistStreamPtr);
                if (result != 0)
                {
                    throw new InvalidCastException();
                }

                short retVal;

                IntPtr* comDispatch = (IntPtr*)persistStreamPtr;
                IntPtr* vtbl = (IntPtr*)comDispatch[0];
                result = ((delegate* unmanaged<IntPtr, short*, int>)vtbl[5])(persistStreamPtr, &retVal);
                if (result != 0)
                {
                    Marshal.ThrowExceptionForHR(result);
                }

                return retVal;
            }
        }

        int primitives::Interop.Ole32.IPicture.Width
        {
            get
            {
                Guid targetInterface = WinFormsComWrappers.IID_IPicture;
                var result = Marshal.QueryInterface(this.instance, ref targetInterface, out var persistStreamPtr);
                if (result != 0)
                {
                    throw new InvalidCastException();
                }

                int retVal;

                IntPtr* comDispatch = (IntPtr*)persistStreamPtr;
                IntPtr* vtbl = (IntPtr*)comDispatch[0];
                result = ((delegate* unmanaged<IntPtr, int*, int>)vtbl[6])(persistStreamPtr, &retVal);
                if (result != 0)
                {
                    Marshal.ThrowExceptionForHR(result);
                }

                return retVal;
            }
        }

        int primitives::Interop.Ole32.IPicture.Height
        {
            get
            {
                Guid targetInterface = WinFormsComWrappers.IID_IPicture;
                var result = Marshal.QueryInterface(this.instance, ref targetInterface, out var persistStreamPtr);
                if (result != 0)
                {
                    throw new InvalidCastException();
                }

                int retVal;

                IntPtr* comDispatch = (IntPtr*)persistStreamPtr;
                IntPtr* vtbl = (IntPtr*)comDispatch[0];
                result = ((delegate* unmanaged<IntPtr, int*, int>)vtbl[7])(persistStreamPtr, &retVal);
                if (result != 0)
                {
                    Marshal.ThrowExceptionForHR(result);
                }

                return retVal;
            }
        }
    }
}
