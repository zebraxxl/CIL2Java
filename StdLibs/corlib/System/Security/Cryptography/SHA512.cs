using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Computes the <see cref="T:System.Security.Cryptography.SHA512" /> hash for the input data.  </summary>
    [ComVisibleAttribute(true)]
    public abstract class SHA512 : HashAlgorithm
    {
        protected SHA512()
        {
             throw new NotImplementedException();
        }


        public static new SHA512 Create()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an instance of a specified implementation of <see cref="T:System.Security.Cryptography.SHA512" />.</summary><returns>A new instance of <see cref="T:System.Security.Cryptography.SHA512" /> using the specified implementation.</returns><param name="hashName">The name of the specific implementation of <see cref="T:System.Security.Cryptography.SHA512" /> to be used. </param><exception cref="T:System.Reflection.TargetInvocationException">The algorithm described by the <paramref name="hashName" /> parameter was used with Federal Information Processing Standards (FIPS) mode enabled, but is not FIPS compatible.</exception>
        public static new SHA512 Create(string hashName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
