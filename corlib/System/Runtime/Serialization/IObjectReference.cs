using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Serialization
{
    /// <summary>Indicates that the current interface implementer is a reference to another object.</summary>
    [ComVisibleAttribute(true)]
    public interface IObjectReference
    {
        /// <summary>Returns the real object that should be deserialized, rather than the object that the serialized stream specifies.</summary><returns>Returns the actual object that is put into the graph.</returns><param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> from which the current object is deserialized. </param><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. The call will not work on a medium trusted server.</exception>
        [SecurityCriticalAttribute()]
        object GetRealObject(StreamingContext context);
        
        
    }
}
