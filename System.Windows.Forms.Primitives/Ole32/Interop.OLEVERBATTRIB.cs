// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

public static partial class Interop
{
    public static partial class Ole32
    {
        [Flags]
        public enum OLEVERBATTRIB : uint
        {
            NEVERDIRTIES = 0x1,
            ONCONTAINERMENU = 0x2,
        }
    }
}
