using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Channels
{
    /// <summary>Provides functionality for a stack of client channel sinks that must be invoked during an asynchronous message response decoding.</summary>
    [ComVisibleAttribute(true)]
    public interface IClientChannelSinkStack : IClientResponseChannelSinkStack
    {
        /// <summary>Pushes the specified sink and information associated with it onto the sink stack.</summary><param name="sink">The sink to push onto the sink stack. </param><param name="state">Information generated on the request side that is needed on the response side. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        void Push(IClientChannelSink sink, object state);
        
        
        /// <summary>Pops the information associated with all the sinks from the sink stack up to and including the specified sink.</summary><returns>Information generated on the request side and associated with the specified sink.</returns><param name="sink">The sink to remove and return from the sink stack. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        object Pop(IClientChannelSink sink);
        
        
    }
}
