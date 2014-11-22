using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Represents the abstract class from which all implementations of the MD160 hash algorithm inherit.</summary>
    [ComVisibleAttribute(true)]
    public abstract class RIPEMD160 : HashAlgorithm
    {
        protected RIPEMD160()
        {
             throw new NotImplementedException();
        }


        public static new RIPEMD160 Create()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an instance of the specified implementation of the <see cref="T:System.Security.Cryptography.RIPEMD160" /> hash algorithm.</summary><returns>A new instance of the specified implementation of <see cref="T:System.Security.Cryptography.RIPEMD160" />.</returns><param name="hashName">The name of the specific implementation of <see cref="T:System.Security.Cryptography.RIPEMD160" /> to use. </param><exception cref="T:System.Reflection.TargetInvocationException">The algorithm described by the <paramref name="hashName" /> parameter was used with Federal Information Processing Standards (FIPS) mode enabled, but it is not FIPS-compatible.</exception>
        public static new RIPEMD160 Create(string hashName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
