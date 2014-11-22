using System.Runtime.InteropServices;
using System;

namespace System.Security.Cryptography
{
    /// <summary>Represents the abstract base class from which all classes that derive byte sequences of a specified length inherit.</summary>
    [ComVisibleAttribute(true)]
    public abstract class DeriveBytes : IDisposable
    {
        /// <summary>When overridden in a derived class, returns pseudo-random key bytes.</summary><returns>A byte array filled with pseudo-random key bytes.</returns><param name="cb">The number of pseudo-random key bytes to generate. </param>
        public abstract byte[] GetBytes(int cb);
        
        
        public abstract void Reset();
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.DeriveBytes" /> class and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        protected DeriveBytes()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
