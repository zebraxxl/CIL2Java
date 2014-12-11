using System;

namespace System.Runtime.CompilerServices
{
    /// <summary>Indicates that a field should be treated as containing a fixed number of elements of the specified primitive type. This class cannot be inherited. </summary>
    [AttributeUsageAttribute(AttributeTargets.Field, Inherited = false)]
    public sealed class FixedBufferAttribute : Attribute
    {
    
        /// <summary>Gets the type of the elements contained in the fixed buffer. </summary><returns>The type of the elements.</returns>
        public Type ElementType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of elements in the fixed buffer. </summary><returns>The number of elements in the fixed buffer.</returns>
        public int Length
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.FixedBufferAttribute" /> class. </summary><param name="elementType">The type of the elements contained in the buffer.</param><param name="length">The number of elements in the buffer.</param>
        public FixedBufferAttribute(Type elementType, int length)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
