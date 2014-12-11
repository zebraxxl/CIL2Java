using System.Runtime.InteropServices;
using System;

namespace System.Runtime.Remoting.Channels
{
    /// <summary>Indicates the status of the server message processing.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum ServerProcessing : int
    {
        /// <summary>The server synchronously processed the message.</summary>
        Complete = 0,
        /// <summary>The message was dispatched and no response can be sent.</summary>
        OneWay = 1,
        /// <summary>The call was dispatched asynchronously, which indicates that the sink must store response data on the stack for later processing.</summary>
        Async = 2
    }
}
