using System.Runtime.InteropServices;
using System;
using System.Security;

namespace System.Runtime.Serialization
{
    /// <summary>Assists formatters in selection of the serialization surrogate to delegate the serialization or deserialization process to.</summary>
    [ComVisibleAttribute(true)]
    public class SurrogateSelector : ISurrogateSelector
    {
    
        public SurrogateSelector()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a surrogate to the list of checked surrogates.</summary><param name="type">The <see cref="T:System.Type" /> for which the surrogate is required.</param><param name="context">The context-specific data. </param><param name="surrogate">The surrogate to call for this type. </param><exception cref="T:System.ArgumentNullException">The <paramref name="type" /> or <paramref name="surrogate" /> parameter is null. </exception><exception cref="T:System.ArgumentException">A surrogate already exists for this type and context. </exception>
        public virtual void AddSurrogate(Type type, StreamingContext context, ISerializationSurrogate surrogate)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds the specified <see cref="T:System.Runtime.Serialization.ISurrogateSelector" /> that can handle a particular object type to the list of surrogates.</summary><param name="selector">The surrogate selector to add. </param><exception cref="T:System.ArgumentNullException">The <paramref name="selector" /> parameter is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">The selector is already on the list of selectors. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        [SecurityCriticalAttribute()]
        public virtual void ChainSelector(ISurrogateSelector selector)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public virtual ISurrogateSelector GetNextSelector()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, ref ISurrogateSelector selector)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the surrogate associated with a given type.</summary><param name="type">The <see cref="T:System.Type" /> for which to remove the surrogate. </param><param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> for the current surrogate. </param><exception cref="T:System.ArgumentNullException">The <paramref name="type" /> parameter is null. </exception>
        public virtual void RemoveSurrogate(Type type, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
