using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
    /// <summary>Represents the public key information (called a blob) for a strong name. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class StrongNamePublicKeyBlob
    {
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.StrongNamePublicKeyBlob" /> class with raw bytes of the public key blob.</summary><param name="publicKey">The array of bytes representing the raw public key data. </param><exception cref="T:System.ArgumentNullException">The <paramref name="publicKey" /> parameter is null. </exception>
        public StrongNamePublicKeyBlob(byte[] publicKey)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets or sets a value indicating whether the current public key blob is equal to the specified public key blob.</summary><returns>true if the public key blob of the current object is equal to the public key blob of the <paramref name="obj" /> parameter; otherwise, false.</returns><param name="obj">An object containing a public key blob. </param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
