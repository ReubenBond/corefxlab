// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.InteropServices;

namespace System.IO.Pipelines.Networking.Windows.RIO.Internal.Winsock
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SocketAddress
    {
        public AddressFamilies Family;
        public ushort Port;
        public Ipv4InternetAddress IpAddress;
        public fixed byte Padding[8];
    }
}