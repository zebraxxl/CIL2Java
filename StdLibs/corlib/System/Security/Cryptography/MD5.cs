using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Represents the abstract class from which all implementations of the <see cref="T:System.Security.Cryptography.MD5" /> hash algorithm inherit. </summary>
    [ComVisibleAttribute(true)]
    public abstract class MD5 : HashAlgorithm
    {
        protected MD5()
        {
             throw new NotImplementedException();
        }


        public static new MD5 Create()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an instance of the specified implementation of the <see cref="T:System.Security.Cryptography.MD5" /> hash algorithm.</summary><returns>A new instance of the specified implementation of <see cref="T:System.Security.Cryptography.MD5" />.</returns><param name="algName">The name of the specific implementation of <see cref="T:System.Security.Cryptography.MD5" /> to use. </param><exception cref="T:System.Reflection.TargetInvocationException">The algorithm described by the <paramref name="algName" /> parameter was used with Federal Information Processing Standards (FIPS) mode enabled, but is not FIPS compatible.</exception>
        public static new MD5 Create(string algName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
