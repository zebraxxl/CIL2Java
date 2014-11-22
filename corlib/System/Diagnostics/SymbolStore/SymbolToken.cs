using System.Runtime.InteropServices;
using System;

namespace System.Diagnostics.SymbolStore
{
    /// <summary>The <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> structure is an object representation of a token that represents symbolic information.</summary>
    [ComVisibleAttribute(true)]
    public struct SymbolToken
    {
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> structure when given a value.</summary><param name="val">The value to be used for the token. </param>
        public SymbolToken(int val)
        {
             throw new NotImplementedException();
        }
        
        
        public int GetToken()
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether <paramref name="obj" /> is an instance of <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> and is equal to this instance.</summary><returns>true if <paramref name="obj" /> is an instance of <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> and is equal to this instance; otherwise, false.</returns><param name="obj">The object to check. </param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether <paramref name="obj" /> is equal to this instance.</summary><returns>true if <paramref name="obj" /> is equal to this instance; otherwise, false.</returns><param name="obj">The <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> to check.</param>
        public bool Equals(SymbolToken obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether two <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> objects are equal.</summary><returns>true if <paramref name="a" /> and <paramref name="b" /> are equal; otherwise, false.</returns><param name="a">A <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> structure.</param><param name="b">A <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> structure.</param>
        /// <summary>Returns a value indicating whether two <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> objects are equal.</summary><returns>true if <paramref name="a" /> and <paramref name="b" /> are equal; otherwise, false.</returns><param name="a">A <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> structure.</param><param name="b">A <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> structure.</param>
        public static bool operator ==(SymbolToken a, SymbolToken b)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether two <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> objects are not equal.</summary><returns>true if <paramref name="a" /> and <paramref name="b" /> are not equal; otherwise, false.</returns><param name="a">A <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> structure.</param><param name="b">A <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> structure.</param>
        /// <summary>Returns a value indicating whether two <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> objects are not equal.</summary><returns>true if <paramref name="a" /> and <paramref name="b" /> are not equal; otherwise, false.</returns><param name="a">A <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> structure.</param><param name="b">A <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> structure.</param>
        public static bool operator !=(SymbolToken a, SymbolToken b)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
