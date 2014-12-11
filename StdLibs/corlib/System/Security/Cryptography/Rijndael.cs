using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Represents the base class from which all implementations of the <see cref="T:System.Security.Cryptography.Rijndael" /> symmetric encryption algorithm must inherit.</summary>
    [ComVisibleAttribute(true)]
    public abstract class Rijndael : SymmetricAlgorithm
    {
    
        protected Rijndael()
        {
             throw new NotImplementedException();
        }


        public static new Rijndael Create()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a cryptographic object to perform the specified implementation of the <see cref="T:System.Security.Cryptography.Rijndael" /> algorithm.</summary><returns>A cryptographic object.</returns><param name="algName">The name of the specific implementation of <see cref="T:System.Security.Cryptography.Rijndael" /> to create. </param><exception cref="T:System.Reflection.TargetInvocationException">The algorithm described by the <paramref name="algName" /> parameter was used with Federal Information Processing Standards (FIPS) mode enabled, but is not FIPS compatible.</exception>
        public static new Rijndael Create(string algName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
