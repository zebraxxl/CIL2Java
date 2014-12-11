using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
    /// <summary>Contributes an interception sink at the context boundary on the client end of a remoting call.</summary>
    [ComVisibleAttribute(true)]
    public interface IContributeClientContextSink
    {
        /// <summary>Takes the first sink in the chain of sinks composed so far, and then chains its message sink in front of the chain already formed.</summary><returns>The composite sink chain.</returns><param name="nextSink">The chain of sinks composed so far. </param>
        [SecurityCriticalAttribute()]
        IMessageSink GetClientContextSink(IMessageSink nextSink);
        
        
    }
}
