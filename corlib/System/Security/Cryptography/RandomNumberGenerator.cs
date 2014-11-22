using System.Runtime.InteropServices;
using System;

namespace System.Security.Cryptography
{
    /// <summary>Represents the abstract class from which all implementations of cryptographic random number generators derive.</summary>
    [ComVisibleAttribute(true)]
    public abstract class RandomNumberGenerator : IDisposable
    {
        protected RandomNumberGenerator()
        {
             throw new NotImplementedException();
        }
        
        
        public static RandomNumberGenerator Create()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, creates an instance of the specified implementation of a cryptographic random number generator.</summary><returns>A new instance of a cryptographic random number generator.</returns><param name="rngName">The name of the random number generator implementation to use. </param>
        public static RandomNumberGenerator Create(string rngName)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.RandomNumberGenerator" /> and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, fills an array of bytes with a cryptographically strong random sequence of values.</summary><param name="data">The array to fill with cryptographically strong random bytes. </param>
        public abstract void GetBytes(byte[] data);
        
        
        /// <summary>When overridden in a derived class, fills an array of bytes with a cryptographically strong random sequence of nonzero values.</summary><param name="data">The array to fill with cryptographically strong random nonzero bytes. </param>
        public virtual void GetNonZeroBytes(byte[] data)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
