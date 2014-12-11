using System.Runtime.InteropServices;
using System;

namespace System.Reflection
{
    /// <summary>Represents a named argument of a custom attribute in the reflection-only context.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public struct CustomAttributeNamedArgument
    {
    
        /// <summary>Gets the attribute member that would be used to set the named argument.</summary><returns>The attribute member that would be used to set the named argument.</returns>
        public MemberInfo MemberInfo
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structure that can be used to obtain the type and value of the current named argument.</summary><returns>A structure that can be used to obtain the type and value of the current named argument.</returns>
        public CustomAttributeTypedArgument TypedValue
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the attribute member that would be used to set the named argument.</summary><returns>The name of the attribute member that would be used to set the named argument.</returns>
        public string MemberName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the named argument is a field.</summary><returns>true if the named argument is a field; otherwise, false.</returns>
        public bool IsField
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Tests whether two <see cref="T:System.Reflection.CustomAttributeNamedArgument" /> structures are equivalent.</summary><returns>true if the two <see cref="T:System.Reflection.CustomAttributeNamedArgument" /> structures are equal; otherwise, false.</returns><param name="left">The structure to the left of the equality operator.</param><param name="right">The structure to the right of the equality operator.</param>
        /// <summary>Tests whether two <see cref="T:System.Reflection.CustomAttributeNamedArgument" /> structures are equivalent.</summary><returns>true if the two <see cref="T:System.Reflection.CustomAttributeNamedArgument" /> structures are equal; otherwise, false.</returns><param name="left">The structure to the left of the equality operator.</param><param name="right">The structure to the right of the equality operator.</param>
        public static bool operator ==(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Tests whether two <see cref="T:System.Reflection.CustomAttributeNamedArgument" /> structures are different.</summary><returns>true if the two <see cref="T:System.Reflection.CustomAttributeNamedArgument" /> structures are different; otherwise, false.</returns><param name="left">The structure to the left of the inequality operator.</param><param name="right">The structure to the right of the inequality operator.</param>
        /// <summary>Tests whether two <see cref="T:System.Reflection.CustomAttributeNamedArgument" /> structures are different.</summary><returns>true if the two <see cref="T:System.Reflection.CustomAttributeNamedArgument" /> structures are different; otherwise, false.</returns><param name="left">The structure to the left of the inequality operator.</param><param name="right">The structure to the right of the inequality operator.</param>
        public static bool operator !=(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.CustomAttributeNamedArgument" /> class, which represents the specified field or property of the custom attribute, and specifies the value of the field or property.</summary><param name="memberInfo">A field or property of the custom attribute. The new <see cref="T:System.Reflection.CustomAttributeNamedArgument" /> object represents this member and its value.</param><param name="value">The value of the field or property of the custom attribute.</param><exception cref="T:System.ArgumentNullException"><paramref name="memberInfo" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="memberInfo" /> is not a field or property of the custom attribute.</exception>
        public CustomAttributeNamedArgument(MemberInfo memberInfo, object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.CustomAttributeNamedArgument" /> class, which represents the specified field or property of the custom attribute, and specifies a <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> object that describes the type and value of the field or property.</summary><param name="memberInfo">A field or property of the custom attribute. The new <see cref="T:System.Reflection.CustomAttributeNamedArgument" /> object represents this member and its value.</param><param name="typedArgument">An object that describes the type and value of the field or property.</param><exception cref="T:System.ArgumentNullException"><paramref name="memberInfo" /> is null.</exception>
        public CustomAttributeNamedArgument(MemberInfo memberInfo, CustomAttributeTypedArgument typedArgument)
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
        
        
        /// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> equals the type and value of this instance; otherwise, false.</returns><param name="obj">An object to compare with this instance, or null.</param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
