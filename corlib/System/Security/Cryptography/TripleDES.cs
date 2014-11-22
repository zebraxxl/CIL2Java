using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Represents the base class for Triple Data Encryption Standard algorithms from which all <see cref="T:System.Security.Cryptography.TripleDES" /> implementations must derive.</summary>
    [ComVisibleAttribute(true)]
    public abstract class TripleDES : SymmetricAlgorithm
    {
    
        /// <summary>Gets or sets the secret key for the <see cref="T:System.Security.Cryptography.TripleDES" /> algorithm.</summary><returns>The secret key for the <see cref="T:System.Security.Cryptography.TripleDES" /> algorithm.</returns><exception cref="T:System.ArgumentNullException">An attempt was made to set the key to null. </exception><exception cref="T:System.Security.Cryptography.CryptographicException">An attempt was made to set a key whose length is invalid.-or- An attempt was made to set a weak key (see <see cref="M:System.Security.Cryptography.TripleDES.IsWeakKey(System.Byte[])" />). </exception>
        public override byte[] Key
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        protected TripleDES()
        {
             throw new NotImplementedException();
        }


        public static new TripleDES Create()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an instance of a cryptographic object to perform the specified implementation of the <see cref="T:System.Security.Cryptography.TripleDES" /> algorithm.</summary><returns>An instance of a cryptographic object.</returns><param name="str">The name of the specific implementation of <see cref="T:System.Security.Cryptography.TripleDES" /> to use. </param>
        public static new TripleDES Create(string str)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified key is weak.</summary><returns>true if the key is weak; otherwise, false.</returns><param name="rgbKey">The secret key to test for weakness. </param><exception cref="T:System.Security.Cryptography.CryptographicException">The size of the <paramref name="rgbKey" /> parameter is not valid. </exception>
        public static bool IsWeakKey(byte[] rgbKey)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
