using System.Runtime.InteropServices;
using System.Security;
using System;

namespace System.Runtime.Serialization
{
    /// <summary>Indicates a serialization surrogate selector class.</summary>
    [ComVisibleAttribute(true)]
    public interface ISurrogateSelector
    {
        /// <summary>Specifies the next <see cref="T:System.Runtime.Serialization.ISurrogateSelector" /> for surrogates to examine if the current instance does not have a surrogate for the specified type and assembly in the specified context.</summary><param name="selector">The next surrogate selector to examine. </param><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        [SecurityCriticalAttribute()]
        void ChainSelector(ISurrogateSelector selector);
        
        
        [SecurityCriticalAttribute()]
        ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, ref ISurrogateSelector selector);
        
        
        [SecurityCriticalAttribute()]
        ISurrogateSelector GetNextSelector();
        
        
    }
}
