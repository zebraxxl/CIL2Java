using System.Runtime.InteropServices;
using System;

namespace System.Threading
{
    /// <summary>Defines the lock that implements single-writer/multiple-reader semantics. This is a value type.</summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public struct LockCookie
    {
    
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether a specified object is a <see cref="T:System.Threading.LockCookie" /> and is equal to the current instance.</summary><returns>true if the value of <paramref name="obj" /> is equal to the value of the current instance; otherwise, false.</returns><param name="obj">The object to compare to the current instance.</param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the current instance is equal to the specified <see cref="T:System.Threading.LockCookie" />.</summary><returns>true if <paramref name="obj" /> is equal to the value of the current instance; otherwise, false.</returns><param name="obj">The <see cref="T:System.Threading.LockCookie" /> to compare to the current instance.</param>
        public bool Equals(LockCookie obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Threading.LockCookie" /> structures are equal.</summary><returns>true if <paramref name="a" /> is equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Threading.LockCookie" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Threading.LockCookie" /> to compare to <paramref name="a" />.</param>
        /// <summary>Indicates whether two <see cref="T:System.Threading.LockCookie" /> structures are equal.</summary><returns>true if <paramref name="a" /> is equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Threading.LockCookie" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Threading.LockCookie" /> to compare to <paramref name="a" />.</param>
        public static bool operator ==(LockCookie a, LockCookie b)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Threading.LockCookie" /> structures are not equal.</summary><returns>true if <paramref name="a" /> is not equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Threading.LockCookie" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Threading.LockCookie" /> to compare to <paramref name="a" />.</param>
        /// <summary>Indicates whether two <see cref="T:System.Threading.LockCookie" /> structures are not equal.</summary><returns>true if <paramref name="a" /> is not equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Threading.LockCookie" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Threading.LockCookie" /> to compare to <paramref name="a" />.</param>
        public static bool operator !=(LockCookie a, LockCookie b)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
