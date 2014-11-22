using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
    /// <summary>Specifies that a field can be missing from a serialization stream so that the <see cref="T:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter" /> and the <see cref="T:System.Runtime.Serialization.Formatters.Soap.SoapFormatter" /> does not throw an exception. </summary>
    [AttributeUsageAttribute(AttributeTargets.Field, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class OptionalFieldAttribute : Attribute
    {
    
        /// <summary>This property is unused and is reserved.</summary><returns>This property is reserved.</returns>
        public int VersionAdded
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public OptionalFieldAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
