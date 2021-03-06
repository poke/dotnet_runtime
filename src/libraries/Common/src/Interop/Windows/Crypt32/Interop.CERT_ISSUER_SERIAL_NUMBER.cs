// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Crypt32
    {
        [StructLayout(LayoutKind.Sequential)]
        internal struct CERT_ISSUER_SERIAL_NUMBER
        {
            internal DATA_BLOB Issuer;
            internal DATA_BLOB SerialNumber;
        }
    }
}
