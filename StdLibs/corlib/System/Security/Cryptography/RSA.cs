using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Represents the base class from which all implementations of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm inherit.</summary>
    [ComVisibleAttribute(true)]
    public abstract class RSA : AsymmetricAlgorithm
    {
        protected RSA()
        {
             throw new NotImplementedException();
        }


        public static new RSA Create()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an instance of the specified implementation of <see cref="T:System.Security.Cryptography.RSA" />.</summary><returns>A new instance of the specified implementation of <see cref="T:System.Security.Cryptography.RSA" />.</returns><param name="algName">The name of the implementation of <see cref="T:System.Security.Cryptography.RSA" /> to use. </param>
        public static new RSA Create(string algName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, decrypts the input data using the private key.</summary><returns>The resulting decryption of the <paramref name="rgb" /> parameter in plain text.</returns><param name="rgb">The cipher text to be decrypted. </param>
        public abstract byte[] DecryptValue(byte[] rgb);
        
        
        /// <summary>When overridden in a derived class, encrypts the input data using the public key.</summary><returns>The resulting encryption of the <paramref name="rgb" /> parameter as cipher text.</returns><param name="rgb">The plain text to be encrypted. </param>
        public abstract byte[] EncryptValue(byte[] rgb);
        
        
        /// <summary>Initializes an <see cref="T:System.Security.Cryptography.RSA" /> object from the key information from an XML string.</summary><param name="xmlString">The XML string containing <see cref="T:System.Security.Cryptography.RSA" /> key information. </param><exception cref="T:System.ArgumentNullException">The <paramref name="xmlString" /> parameter is null. </exception><exception cref="T:System.Security.Cryptography.CryptographicException">The format of the <paramref name="xmlString" /> parameter is not valid. </exception>
        public override void FromXmlString(string xmlString)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates and returns an XML string containing the key of the current <see cref="T:System.Security.Cryptography.RSA" /> object.</summary><returns>An XML string containing the key of the current <see cref="T:System.Security.Cryptography.RSA" /> object.</returns><param name="includePrivateParameters">true to include a public and private RSA key; false to include only the public key. </param>
        public override string ToXmlString(bool includePrivateParameters)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, exports the <see cref="T:System.Security.Cryptography.RSAParameters" />.</summary><returns>The parameters for <see cref="T:System.Security.Cryptography.DSA" />.</returns><param name="includePrivateParameters">true to include private parameters; otherwise, false. </param>
        public abstract RSAParameters ExportParameters(bool includePrivateParameters);
        
        
        /// <summary>When overridden in a derived class, imports the specified <see cref="T:System.Security.Cryptography.RSAParameters" />.</summary><param name="parameters">The parameters for <see cref="T:System.Security.Cryptography.RSA" />. </param>
        public abstract void ImportParameters(RSAParameters parameters);
        
        
    }
}
