using System.Runtime.InteropServices;
using System.Security;
using System.Collections;

namespace System.Runtime.Remoting.Channels
{
    /// <summary>Stores a collection of headers used in the channel sinks.</summary>
    [ComVisibleAttribute(true)]
    public interface ITransportHeaders
    {
        /// <summary>Gets or sets a transport header associated with the given key.</summary><returns>A transport header associated with the given key.</returns><param name="key">The key the requested transport header is associated with. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
        object this[object key]
        {
            get;
            set;
        }
    
    
        [SecurityCriticalAttribute()]
        IEnumerator GetEnumerator();
        
        
    }
}
