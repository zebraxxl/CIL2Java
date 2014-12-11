using System.Runtime.InteropServices;
using System;

namespace System.Security.Cryptography
{
    /// <summary>Represents the abstract base class from which all implementations of symmetric algorithms must inherit.</summary>
    [ComVisibleAttribute(true)]
    public abstract class SymmetricAlgorithm : IDisposable
    {
        /// <summary>Represents the block size, in bits, of the cryptographic operation.</summary>
        protected int BlockSizeValue;
        /// <summary>Represents the feedback size, in bits, of the cryptographic operation.</summary>
        protected int FeedbackSizeValue;
        /// <summary>Represents the initialization vector (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />) for the symmetric algorithm.</summary>
        protected byte[] IVValue;
        /// <summary>Represents the secret key for the symmetric algorithm.</summary>
        protected byte[] KeyValue;
        /// <summary>Specifies the block sizes, in bits, that are supported by the symmetric algorithm.</summary>
        protected KeySizes[] LegalBlockSizesValue;
        /// <summary>Specifies the key sizes, in bits, that are supported by the symmetric algorithm.</summary>
        protected KeySizes[] LegalKeySizesValue;
        /// <summary>Represents the size, in bits, of the secret key used by the symmetric algorithm.</summary>
        protected int KeySizeValue;
        /// <summary>Represents the cipher mode used in the symmetric algorithm.</summary>
        protected CipherMode ModeValue;
        /// <summary>Represents the padding mode used in the symmetric algorithm.</summary>
        protected PaddingMode PaddingValue;
    
        /// <summary>Gets or sets the block size, in bits, of the cryptographic operation.</summary><returns>The block size, in bits.</returns><exception cref="T:System.Security.Cryptography.CryptographicException">The block size is invalid. </exception>
        public virtual int BlockSize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the feedback size, in bits, of the cryptographic operation.</summary><returns>The feedback size in bits.</returns><exception cref="T:System.Security.Cryptography.CryptographicException">The feedback size is larger than the block size. </exception>
        public virtual int FeedbackSize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the initialization vector (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />) for the symmetric algorithm.</summary><returns>The initialization vector.</returns><exception cref="T:System.ArgumentNullException">An attempt was made to set the initialization vector to null. </exception><exception cref="T:System.Security.Cryptography.CryptographicException">An attempt was made to set the initialization vector to an invalid size. </exception>
        public virtual byte[] IV
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the secret key for the symmetric algorithm.</summary><returns>The secret key to use for the symmetric algorithm.</returns><exception cref="T:System.ArgumentNullException">An attempt was made to set the key to null. </exception><exception cref="T:System.Security.Cryptography.CryptographicException">The key size is invalid.</exception>
        public virtual byte[] Key
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the block sizes, in bits, that are supported by the symmetric algorithm.</summary><returns>An array that contains the block sizes supported by the algorithm.</returns>
        public virtual KeySizes[] LegalBlockSizes
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the key sizes, in bits, that are supported by the symmetric algorithm.</summary><returns>An array that contains the key sizes supported by the algorithm.</returns>
        public virtual KeySizes[] LegalKeySizes
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the size, in bits, of the secret key used by the symmetric algorithm.</summary><returns>The size, in bits, of the secret key used by the symmetric algorithm.</returns><exception cref="T:System.Security.Cryptography.CryptographicException">The key size is not valid. </exception>
        public virtual int KeySize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the mode for operation of the symmetric algorithm.</summary><returns>The mode for operation of the symmetric algorithm. The default is <see cref="F:System.Security.Cryptography.CipherMode.CBC" />.</returns><exception cref="T:System.Security.Cryptography.CryptographicException">The cipher mode is not one of the <see cref="T:System.Security.Cryptography.CipherMode" /> values. </exception>
        public virtual CipherMode Mode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the padding mode used in the symmetric algorithm.</summary><returns>The padding mode used in the symmetric algorithm. The default is <see cref="F:System.Security.Cryptography.PaddingMode.PKCS7" />.</returns><exception cref="T:System.Security.Cryptography.CryptographicException">The padding mode is not one of the <see cref="T:System.Security.Cryptography.PaddingMode" /> values. </exception>
        public virtual PaddingMode Padding
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        protected SymmetricAlgorithm()
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
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.SymmetricAlgorithm" /> and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified key size is valid for the current algorithm.</summary><returns>true if the specified key size is valid for the current algorithm; otherwise, false.</returns><param name="bitLength">The length, in bits, to check for a valid key size. </param>
        public bool ValidKeySize(int bitLength)
        {
             throw new NotImplementedException();
        }
        
        
        public static SymmetricAlgorithm Create()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates the specified cryptographic object used to perform the symmetric algorithm.</summary><returns>A cryptographic object used to perform the symmetric algorithm.</returns><param name="algName">The name of the specific implementation of the <see cref="T:System.Security.Cryptography.SymmetricAlgorithm" /> class to use. </param>
        public static SymmetricAlgorithm Create(string algName)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual ICryptoTransform CreateEncryptor()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, creates a symmetric encryptor object with the specified <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" /> property and initialization vector (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary><returns>A symmetric encryptor object.</returns><param name="rgbKey">The secret key to use for the symmetric algorithm. </param><param name="rgbIV">The initialization vector to use for the symmetric algorithm. </param>
        public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);
        
        
        public virtual ICryptoTransform CreateDecryptor()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, creates a symmetric decryptor object with the specified <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" /> property and initialization vector (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary><returns>A symmetric decryptor object.</returns><param name="rgbKey">The secret key to use for the symmetric algorithm. </param><param name="rgbIV">The initialization vector to use for the symmetric algorithm. </param>
        public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);
        
        
        public abstract void GenerateKey();
        
        
        public abstract void GenerateIV();
        
        
    }
}
