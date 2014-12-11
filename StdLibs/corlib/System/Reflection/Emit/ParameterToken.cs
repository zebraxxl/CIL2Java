using System.Runtime.InteropServices;
using System;

namespace System.Reflection.Emit
{
    /// <summary>The ParameterToken struct is an opaque representation of the token returned by the metadata to represent a parameter.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public struct ParameterToken
    {
        /// <summary>The default ParameterToken with <see cref="P:System.Reflection.Emit.ParameterToken.Token" /> value 0.</summary>
        public static readonly ParameterToken Empty;
    
        /// <summary>Retrieves the metadata token for this parameter.</summary><returns>Read-only. Retrieves the metadata token for this parameter.</returns>
        public int Token
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Checks if the given object is an instance of ParameterToken and is equal to this instance.</summary><returns>true if <paramref name="obj" /> is an instance of ParameterToken and equals the current instance; otherwise, false.</returns><param name="obj">The object to compare to this object. </param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the current instance is equal to the specified <see cref="T:System.Reflection.Emit.ParameterToken" />.</summary><returns>true if the value of <paramref name="obj" /> is equal to the value of the current instance; otherwise, false.</returns><param name="obj">The <see cref="T:System.Reflection.Emit.ParameterToken" /> to compare to the current instance.</param>
        public bool Equals(ParameterToken obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.ParameterToken" /> structures are equal.</summary><returns>true if <paramref name="a" /> is equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Reflection.Emit.ParameterToken" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Reflection.Emit.ParameterToken" /> to compare to <paramref name="a" />.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.ParameterToken" /> structures are equal.</summary><returns>true if <paramref name="a" /> is equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Reflection.Emit.ParameterToken" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Reflection.Emit.ParameterToken" /> to compare to <paramref name="a" />.</param>
        public static bool operator ==(ParameterToken a, ParameterToken b)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.ParameterToken" /> structures are not equal.</summary><returns>true if <paramref name="a" /> is not equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Reflection.Emit.ParameterToken" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Reflection.Emit.ParameterToken" /> to compare to <paramref name="a" />.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.ParameterToken" /> structures are not equal.</summary><returns>true if <paramref name="a" /> is not equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Reflection.Emit.ParameterToken" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Reflection.Emit.ParameterToken" /> to compare to <paramref name="a" />.</param>
        public static bool operator !=(ParameterToken a, ParameterToken b)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
