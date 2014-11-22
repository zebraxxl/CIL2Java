
namespace System.Security.Cryptography
{
    /// <summary>Represents the abstract base class from which all implementations of the Advanced Encryption Standard (AES) must inherit. </summary>
    public abstract class Aes : SymmetricAlgorithm
    {
    
        protected Aes()
        {
             throw new NotImplementedException();
        }
        
        
        public static new Aes Create()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a cryptographic object that specifies the implementation of AES to use to perform the symmetric algorithm.</summary><returns>A cryptographic object that is used to perform the symmetric algorithm.</returns><param name="algorithmName">The name of the specific implementation of AES to use.</param><exception cref="T:System.ArgumentNullException">The <paramref name="algorithmName" /> parameter is null.</exception>
        public static new Aes Create(string algorithmName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
