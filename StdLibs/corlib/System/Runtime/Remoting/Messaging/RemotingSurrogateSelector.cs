using System.Security;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System;

namespace System.Runtime.Remoting.Messaging
{
    /// <summary>Selects the remoting surrogate that can be used to serialize an object that derives from a <see cref="T:System.MarshalByRefObject" />.</summary>
    [SecurityCriticalAttribute()]
    [ComVisibleAttribute(true)]
    public class RemotingSurrogateSelector : ISurrogateSelector
    {
    
        /// <summary>Gets or sets the <see cref="T:System.Runtime.Remoting.Messaging.MessageSurrogateFilter" /> delegate for the current instance of the <see cref="T:System.Runtime.Remoting.Messaging.RemotingSurrogateSelector" />.</summary><returns>The <see cref="T:System.Runtime.Remoting.Messaging.MessageSurrogateFilter" /> delegate for the current instance of the <see cref="T:System.Runtime.Remoting.Messaging.RemotingSurrogateSelector" />.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public MessageSurrogateFilter Filter
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public RemotingSurrogateSelector()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the object at the root of the object graph.</summary><param name="obj">The object at the root of the object graph. </param><exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public void SetRootObject(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public object GetRootObject()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds the specified <see cref="T:System.Runtime.Serialization.ISurrogateSelector" /> to the surrogate selector chain.</summary><param name="selector">The next <see cref="T:System.Runtime.Serialization.ISurrogateSelector" /> to examine. </param>
        [SecurityCriticalAttribute()]
        public virtual void ChainSelector(ISurrogateSelector selector)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, ref ISurrogateSelector ssout)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public virtual ISurrogateSelector GetNextSelector()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void UseSoapFormat()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
