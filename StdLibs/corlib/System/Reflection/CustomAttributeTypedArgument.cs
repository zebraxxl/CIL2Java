using System.Runtime.InteropServices;
using System;

namespace System.Reflection
{
    /// <summary>Represents an argument of a custom attribute in the reflection-only context, or an element of an array argument.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public struct CustomAttributeTypedArgument
    {
    
        /// <summary>Gets the type of the argument or of the array argument element.</summary><returns>A <see cref="T:System.Type" /> object representing the type of the argument or of the array element.</returns>
        public Type ArgumentType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value of the argument for a simple argument or for an element of an array argument; gets a collection of values for an array argument.</summary><returns>An object that represents the value of the argument or element, or a generic <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> of <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> objects that represent the values of an array-type argument.</returns>
        public object Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Tests whether two <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structures are equivalent.</summary><returns>true if the two <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structures are equal; otherwise, false.</returns><param name="left">The <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structure to the left of the equality operator.</param><param name="right">The <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structure to the right of the equality operator.</param>
        /// <summary>Tests whether two <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structures are equivalent.</summary><returns>true if the two <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structures are equal; otherwise, false.</returns><param name="left">The <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structure to the left of the equality operator.</param><param name="right">The <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structure to the right of the equality operator.</param>
        public static bool operator ==(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Tests whether two <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structures are different.</summary><returns>true if the two <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structures are different; otherwise, false.</returns><param name="left">The <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structure to the left of the inequality operator.</param><param name="right">The <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structure to the right of the inequality operator.</param>
        /// <summary>Tests whether two <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structures are different.</summary><returns>true if the two <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structures are different; otherwise, false.</returns><param name="left">The <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structure to the left of the inequality operator.</param><param name="right">The <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structure to the right of the inequality operator.</param>
        public static bool operator !=(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> class with the specified type and value.</summary><param name="argumentType">The type of the custom attribute argument.</param><param name="value">The value of the custom attribute argument.</param><exception cref="T:System.ArgumentNullException"><paramref name="argumentType" /> is null.</exception>
        public CustomAttributeTypedArgument(Type argumentType, object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> class with the specified value.</summary><param name="value">The value of the custom attribute argument.</param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null.</exception>
        public CustomAttributeTypedArgument(object value)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <returns>true if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, false.</returns><param name="obj">Another object to compare to. </param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
