using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Represents the base class for the Data Encryption Standard (DES) algorithm from which all <see cref="T:System.Security.Cryptography.DES" /> implementations must derive.</summary>
    [ComVisibleAttribute(true)]
    public abstract class DES : SymmetricAlgorithm
    {
    
        /// <summary>Gets or sets the secret key for the Data Encryption Standard (<see cref="T:System.Security.Cryptography.DES" />) algorithm.</summary><returns>The secret key for the <see cref="T:System.Security.Cryptography.DES" /> algorithm.</returns><exception cref="T:System.ArgumentNullException">An attempt was made to set the key to null. </exception><exception cref="T:System.ArgumentException">An attempt was made to set a key whose length is not equal to <see cref="F:System.Security.Cryptography.SymmetricAlgorithm.BlockSizeValue" />. </exception><exception cref="T:System.Security.Cryptography.CryptographicException">An attempt was made to set a weak key (see <see cref="M:System.Security.Cryptography.DES.IsWeakKey(System.Byte[])" />) or a semi-weak key (see <see cref="M:System.Security.Cryptography.DES.IsSemiWeakKey(System.Byte[])" />). </exception>
        public override byte[] Key
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        protected DES()
        {
             throw new NotImplementedException();
        }
        
        
        public static new DES Create()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an instance of a cryptographic object to perform the specified implementation of the Data Encryption Standard (<see cref="T:System.Security.Cryptography.DES" />) algorithm.</summary><returns>A cryptographic object.</returns><param name="algName">The name of the specific implementation of <see cref="T:System.Security.Cryptography.DES" /> to use. </param>
        public static new DES Create(string algName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified key is weak.</summary><returns>true if the key is weak; otherwise, false.</returns><param name="rgbKey">The secret key to test for weakness. </param><exception cref="T:System.Security.Cryptography.CryptographicException">The size of the <paramref name="rgbKey" /> parameter is not valid. </exception>
        public static bool IsWeakKey(byte[] rgbKey)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified key is semi-weak.</summary><returns>true if the key is semi-weak; otherwise, false.</returns><param name="rgbKey">The secret key to test for semi-weakness. </param><exception cref="T:System.Security.Cryptography.CryptographicException">The size of the <paramref name="rgbKey" /> parameter is not valid. </exception>
        public static bool IsSemiWeakKey(byte[] rgbKey)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
