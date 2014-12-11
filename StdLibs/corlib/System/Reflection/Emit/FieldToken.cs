using System.Runtime.InteropServices;
using System;

namespace System.Reflection.Emit
{
    /// <summary>The FieldToken struct is an object representation of a token that represents a field.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public struct FieldToken
    {
        /// <summary>The default FieldToken with <see cref="P:System.Reflection.Emit.FieldToken.Token" /> value 0.</summary>
        public static readonly FieldToken Empty;
    
        /// <summary>Retrieves the metadata token for this field.</summary><returns>Read-only. Retrieves the metadata token of this field.</returns>
        public int Token
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines if an object is an instance of FieldToken and is equal to this instance.</summary><returns>Returns true if <paramref name="obj" /> is an instance of FieldToken and is equal to this object; otherwise, false.</returns><param name="obj">The object to compare to this FieldToken. </param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the current instance is equal to the specified <see cref="T:System.Reflection.Emit.FieldToken" />.</summary><returns>true if the value of <paramref name="obj" /> is equal to the value of the current instance; otherwise, false.</returns><param name="obj">The <see cref="T:System.Reflection.Emit.FieldToken" /> to compare to the current instance.</param>
        public bool Equals(FieldToken obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.FieldToken" /> structures are equal.</summary><returns>true if <paramref name="a" /> is equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Reflection.Emit.FieldToken" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Reflection.Emit.FieldToken" /> to compare to <paramref name="a" />.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.FieldToken" /> structures are equal.</summary><returns>true if <paramref name="a" /> is equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Reflection.Emit.FieldToken" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Reflection.Emit.FieldToken" /> to compare to <paramref name="a" />.</param>
        public static bool operator ==(FieldToken a, FieldToken b)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.FieldToken" /> structures are not equal.</summary><returns>true if <paramref name="a" /> is not equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Reflection.Emit.FieldToken" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Reflection.Emit.FieldToken" /> to compare to <paramref name="a" />.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.FieldToken" /> structures are not equal.</summary><returns>true if <paramref name="a" /> is not equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Reflection.Emit.FieldToken" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Reflection.Emit.FieldToken" /> to compare to <paramref name="a" />.</param>
        public static bool operator !=(FieldToken a, FieldToken b)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
