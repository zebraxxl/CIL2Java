using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Channels
{
    /// <summary>Provides required functions and properties for the sender channels.</summary>
    [ComVisibleAttribute(true)]
    public interface IChannelSender : IChannel
    {
        [SecurityCriticalAttribute()]
        IMessageSink CreateMessageSink(string url, object remoteChannelData, ref string objectURI);
        
        
    }
}
