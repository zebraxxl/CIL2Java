using System.Runtime.InteropServices;
using System;

namespace System.Reflection.Emit
{
    /// <summary>Represents a token that represents a string.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public struct StringToken
    {
    
        /// <summary>Retrieves the metadata token for this string.</summary><returns>Read-only. Retrieves the metadata token of this string.</returns>
        public int Token
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Checks if the given object is an instance of StringToken and is equal to this instance.</summary><returns>true if <paramref name="obj" /> is an instance of StringToken and is equal to this object; otherwise, false.</returns><param name="obj">The object to compare with this StringToken. </param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the current instance is equal to the specified <see cref="T:System.Reflection.Emit.StringToken" />.</summary><returns>true if the value of <paramref name="obj" /> is equal to the value of the current instance; otherwise, false.</returns><param name="obj">The <see cref="T:System.Reflection.Emit.StringToken" /> to compare to the current instance.</param>
        public bool Equals(StringToken obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.StringToken" /> structures are equal.</summary><returns>true if <paramref name="a" /> is equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Reflection.Emit.StringToken" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Reflection.Emit.StringToken" /> to compare to <paramref name="a" />.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.StringToken" /> structures are equal.</summary><returns>true if <paramref name="a" /> is equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Reflection.Emit.StringToken" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Reflection.Emit.StringToken" /> to compare to <paramref name="a" />.</param>
        public static bool operator ==(StringToken a, StringToken b)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.StringToken" /> structures are not equal.</summary><returns>true if <paramref name="a" /> is not equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Reflection.Emit.StringToken" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Reflection.Emit.StringToken" /> to compare to <paramref name="a" />.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.StringToken" /> structures are not equal.</summary><returns>true if <paramref name="a" /> is not equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Reflection.Emit.StringToken" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Reflection.Emit.StringToken" /> to compare to <paramref name="a" />.</param>
        public static bool operator !=(StringToken a, StringToken b)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
