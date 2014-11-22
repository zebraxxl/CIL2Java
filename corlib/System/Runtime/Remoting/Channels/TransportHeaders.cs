using System.Security;
using System.Runtime.InteropServices;
using System.Collections;

namespace System.Runtime.Remoting.Channels
{
    /// <summary>Stores a collection of headers used in the channel sinks.</summary>
    [Serializable]
    [SecurityCriticalAttribute()]
    [ComVisibleAttribute(true)]
    public class TransportHeaders : ITransportHeaders
    {
    
        /// <summary>Gets or sets a transport header that is associated with the given key.</summary><returns>A transport header that is associated with the given key, or null if the key was not found.</returns><param name="key">The <see cref="T:System.String" /> that the requested header is associated with. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public object this[object key]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public TransportHeaders()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public IEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
