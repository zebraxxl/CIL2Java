using System.Runtime.InteropServices;
using System.Security;

namespace System
{
    /// <summary>Provides the base class for value types.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public abstract class ValueType
    {
        /// <summary>Indicates whether this instance and a specified object are equal.</summary><returns>true if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, false.</returns><param name="obj">Another object to compare to. </param><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        protected ValueType()
        {
        }
    }
}
