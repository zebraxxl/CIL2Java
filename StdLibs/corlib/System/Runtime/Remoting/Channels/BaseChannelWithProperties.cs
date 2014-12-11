using System.Runtime.InteropServices;
using System.Security;
using System.Collections;

namespace System.Runtime.Remoting.Channels
{
    /// <summary>Provides a base implementation for channels that want to expose a dictionary interface to their properties.</summary>
    [ComVisibleAttribute(true)]
    [SecurityCriticalAttribute()]
    public abstract class BaseChannelWithProperties : BaseChannelObjectWithProperties
    {
        /// <summary>Indicates the top channel sink in the channel sink stack.</summary>
        protected IChannelSinkBase SinksWithProperties;
    
        /// <summary>Gets a <see cref="T:System.Collections.IDictionary" /> of the channel properties associated with the current channel object.</summary><returns>A <see cref="T:System.Collections.IDictionary" /> of the channel properties associated with the current channel object.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
        public override IDictionary Properties
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected BaseChannelWithProperties()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
