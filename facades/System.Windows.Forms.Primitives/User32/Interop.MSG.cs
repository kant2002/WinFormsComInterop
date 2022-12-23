// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Drawing;
using System.Runtime.InteropServices;
//using System.Windows.Forms;

public static partial class Interop
{
    public static partial class User32
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct MSG
        {
            public IntPtr hwnd;
            public WM message;
            public IntPtr wParam;
            public IntPtr lParam;
            public uint time;
            public Point pt;
/* This does not affect shape of structure, so it's not important for COM interop generator.
            public static implicit operator Message(MSG msg)
                => new Message { HWnd = msg.hwnd, Msg = (int)msg.message, WParam = msg.wParam, LParam = msg.lParam };

            public static implicit operator MSG(Message message)
                => new MSG { hwnd = message.HWnd, message = (WM)message.Msg, wParam = message.WParam, lParam = message.LParam };
*/
        }
    }
}
