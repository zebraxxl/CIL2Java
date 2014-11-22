using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Represents the base class from which all implementations of asymmetric signature formatters derive.</summary>
    [ComVisibleAttribute(true)]
    public abstract class AsymmetricSignatureFormatter
    {
        protected AsymmetricSignatureFormatter()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, sets the asymmetric algorithm to use to create the signature.</summary><param name="key">The instance of the implementation of <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> to use to create the signature. </param>
        public abstract void SetKey(AsymmetricAlgorithm key);
        
        
        /// <summary>When overridden in a derived class, sets the hash algorithm to use for creating the signature.</summary><param name="strName">The name of the hash algorithm to use for creating the signature. </param>
        public abstract void SetHashAlgorithm(string strName);
        
        
        /// <summary>Creates the signature from the specified hash value.</summary><returns>The signature for the specified hash value.</returns><param name="hash">The hash algorithm to use to create the signature. </param><exception cref="T:System.ArgumentNullException">The <paramref name="hash" /> parameter is null. </exception>
        public virtual byte[] CreateSignature(HashAlgorithm hash)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, creates the signature for the specified data.</summary><returns>The digital signature for the <paramref name="rgbHash" /> parameter.</returns><param name="rgbHash">The data to be signed. </param>
        public abstract byte[] CreateSignature(byte[] rgbHash);
        
        
    }
}
