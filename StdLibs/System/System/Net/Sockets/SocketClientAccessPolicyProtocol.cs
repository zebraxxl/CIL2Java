using System;
using System.ComponentModel;

namespace System.Net.Sockets
{
    [ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    [EditorBrowsableAttribute(EditorBrowsableState.Never)]
    public enum SocketClientAccessPolicyProtocol : int
    {
        Tcp = 0,
        Http = 1
    }
}
