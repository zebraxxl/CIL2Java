using System.Runtime.InteropServices;
using System;

namespace System.Reflection.Emit
{
    /// <summary>The PropertyToken struct is an opaque representation of the Token returned by the metadata to represent a property.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public struct PropertyToken
    {
        /// <summary>The default PropertyToken with <see cref="P:System.Reflection.Emit.PropertyToken.Token" /> value 0.</summary>
        public static readonly PropertyToken Empty;
    
        /// <summary>Retrieves the metadata token for this property.</summary><returns>Read-only. Retrieves the metadata token for this instance.</returns>
        public int Token
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Checks if the given object is an instance of PropertyToken and is equal to this instance.</summary><returns>true if <paramref name="obj" /> is an instance of PropertyToken and equals the current instance; otherwise, false.</returns><param name="obj">The object to this object. </param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the current instance is equal to the specified <see cref="T:System.Reflection.Emit.PropertyToken" />.</summary><returns>true if the value of <paramref name="obj" /> is equal to the value of the current instance; otherwise, false.</returns><param name="obj">The <see cref="T:System.Reflection.Emit.PropertyToken" /> to compare to the current instance.</param>
        public bool Equals(PropertyToken obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.PropertyToken" /> structures are equal.</summary><returns>true if <paramref name="a" /> is equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Reflection.Emit.PropertyToken" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Reflection.Emit.PropertyToken" /> to compare to <paramref name="a" />.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.PropertyToken" /> structures are equal.</summary><returns>true if <paramref name="a" /> is equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Reflection.Emit.PropertyToken" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Reflection.Emit.PropertyToken" /> to compare to <paramref name="a" />.</param>
        public static bool operator ==(PropertyToken a, PropertyToken b)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.PropertyToken" /> structures are not equal.</summary><returns>true if <paramref name="a" /> is not equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Reflection.Emit.PropertyToken" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Reflection.Emit.PropertyToken" /> to compare to <paramref name="a" />.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.PropertyToken" /> structures are not equal.</summary><returns>true if <paramref name="a" /> is not equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Reflection.Emit.PropertyToken" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Reflection.Emit.PropertyToken" /> to compare to <paramref name="a" />.</param>
        public static bool operator !=(PropertyToken a, PropertyToken b)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
