using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.Remoting.Messaging;
using System;

namespace System.Runtime.Remoting.Contexts
{
    /// <summary>Contributes an object-specific interception sink on the server end of a remoting call.</summary>
    [ComVisibleAttribute(true)]
    public interface IContributeObjectSink
    {
        /// <summary>Chains the message sink of the provided server object in front of the given sink chain.</summary><returns>The composite sink chain.</returns><param name="obj">The server object which provides the message sink that is to be chained in front of the given chain. </param><param name="nextSink">The chain of sinks composed so far. </param>
        [SecurityCriticalAttribute()]
        IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink);
        
        
    }
}
