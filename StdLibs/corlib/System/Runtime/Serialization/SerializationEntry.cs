using System.Runtime.InteropServices;
using System;

namespace System.Runtime.Serialization
{
    /// <summary>Holds the value, <see cref="T:System.Type" />, and name of a serialized object. </summary>
    [ComVisibleAttribute(true)]
    public struct SerializationEntry
    {
    
        /// <summary>Gets the value contained in the object.</summary><returns>The value contained in the object.</returns>
        public object Value
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the object.</summary><returns>The name of the object.</returns>
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Type" /> of the object.</summary><returns>The <see cref="T:System.Type" /> of the object.</returns>
        public Type ObjectType
        {
            get { throw new NotImplementedException(); }
        }
    
    
    }
}
