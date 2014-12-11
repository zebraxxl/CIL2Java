using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Computes the <see cref="T:System.Security.Cryptography.SHA1" /> hash for the input data.</summary>
    [ComVisibleAttribute(true)]
    public abstract class SHA1 : HashAlgorithm
    {
        protected SHA1()
        {
             throw new NotImplementedException();
        }


        public static new SHA1 Create()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an instance of the specified implementation of <see cref="T:System.Security.Cryptography.SHA1" />.</summary><returns>A new instance of <see cref="T:System.Security.Cryptography.SHA1" /> using the specified implementation.</returns><param name="hashName">The name of the specific implementation of <see cref="T:System.Security.Cryptography.SHA1" /> to be used. </param>
        public static new SHA1 Create(string hashName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
