using System.Security;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
    /// <summary>Provides a base implementation for channel sinks that want to expose a dictionary interface to their properties.</summary>
    [SecurityCriticalAttribute()]
    [ComVisibleAttribute(true)]
    public abstract class BaseChannelSinkWithProperties : BaseChannelObjectWithProperties
    {
        protected BaseChannelSinkWithProperties()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
