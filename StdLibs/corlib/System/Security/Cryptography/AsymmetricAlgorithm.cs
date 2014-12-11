using System.Runtime.InteropServices;
using System;

namespace System.Security.Cryptography
{
    /// <summary>Represents the abstract base class from which all implementations of asymmetric algorithms must inherit.</summary>
    [ComVisibleAttribute(true)]
    public abstract class AsymmetricAlgorithm : IDisposable
    {
        /// <summary>Represents the size, in bits, of the key modulus used by the asymmetric algorithm.</summary>
        protected int KeySizeValue;
        /// <summary>Specifies the key sizes that are supported by the asymmetric algorithm.</summary>
        protected KeySizes[] LegalKeySizesValue;
    
        /// <summary>Gets or sets the size, in bits, of the key modulus used by the asymmetric algorithm.</summary><returns>The size, in bits, of the key modulus used by the asymmetric algorithm.</returns><exception cref="T:System.Security.Cryptography.CryptographicException">The key modulus size is invalid. </exception>
        public virtual int KeySize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the key sizes that are supported by the asymmetric algorithm.</summary><returns>An array that contains the key sizes supported by the asymmetric algorithm.</returns>
        public virtual KeySizes[] LegalKeySizes
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the signature algorithm.</summary><returns>The name of the signature algorithm.</returns>
        public abstract string SignatureAlgorithm
        {
            get;
        }
    
        /// <summary>When overridden in a derived class, gets the name of the key exchange algorithm.</summary><returns>The name of the key exchange algorithm.</returns>
        public abstract string KeyExchangeAlgorithm
        {
            get;
        }
    
    
        protected AsymmetricAlgorithm()
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> class and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public static AsymmetricAlgorithm Create()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an instance of the specified implementation of an asymmetric algorithm.</summary><returns>A new instance of the specified asymmetric algorithm implementation.</returns><param name="algName">The asymmetric algorithm implementation to use. The following table shows the valid values for the <paramref name="algName" /> parameter and the algorithms they map to.Parameter valueImplements System.Security.Cryptography.AsymmetricAlgorithm<see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" />RSA<see cref="T:System.Security.Cryptography.RSA" />System.Security.Cryptography.RSA<see cref="T:System.Security.Cryptography.RSA" />DSA<see cref="T:System.Security.Cryptography.DSA" />System.Security.Cryptography.DSA<see cref="T:System.Security.Cryptography.DSA" />ECDsa<see cref="T:System.Security.Cryptography.ECDsa" />ECDsaCng<see cref="T:System.Security.Cryptography.ECDsaCng" />System.Security.Cryptography.ECDsaCng<see cref="T:System.Security.Cryptography.ECDsaCng" />ECDH<see cref="T:System.Security.Cryptography.ECDiffieHellman" />ECDiffieHellman<see cref="T:System.Security.Cryptography.ECDiffieHellman" />ECDiffieHellmanCng<see cref="T:System.Security.Cryptography.ECDiffieHellmanCng" />System.Security.Cryptography.ECDiffieHellmanCng<see cref="T:System.Security.Cryptography.ECDiffieHellmanCng" /></param>
        public static AsymmetricAlgorithm Create(string algName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, reconstructs an <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> object from an XML string.</summary><param name="xmlString">The XML string to use to reconstruct the <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> object. </param>
        public abstract void FromXmlString(string xmlString);
        
        
        /// <summary>When overridden in a derived class, creates and returns an XML string representation of the current <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> object.</summary><returns>An XML string encoding of the current <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> object.</returns><param name="includePrivateParameters">true to include private parameters; otherwise, false. </param>
        public abstract string ToXmlString(bool includePrivateParameters);
        
        
    }
}
