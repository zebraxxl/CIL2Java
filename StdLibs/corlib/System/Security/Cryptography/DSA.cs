using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Represents the abstract base class from which all implementations of the Digital Signature Algorithm (<see cref="T:System.Security.Cryptography.DSA" />) must inherit.</summary>
    [ComVisibleAttribute(true)]
    public abstract class DSA : AsymmetricAlgorithm
    {
        protected DSA()
        {
             throw new NotImplementedException();
        }
        
        
        public static new DSA Create()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates the specified cryptographic object used to perform the asymmetric algorithm.</summary><returns>A cryptographic object used to perform the asymmetric algorithm.</returns><param name="algName">The name of the specific implementation of <see cref="T:System.Security.Cryptography.DSA" /> to use. </param>
        public static new DSA Create(string algName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, creates the <see cref="T:System.Security.Cryptography.DSA" /> signature for the specified data.</summary><returns>The digital signature for the specified data.</returns><param name="rgbHash">The data to be signed. </param>
        public abstract byte[] CreateSignature(byte[] rgbHash);
        
        
        /// <summary>When overridden in a derived class, verifies the <see cref="T:System.Security.Cryptography.DSA" /> signature for the specified data.</summary><returns>true if <paramref name="rgbSignature" /> matches the signature computed using the specified hash algorithm and key on <paramref name="rgbHash" />; otherwise, false.</returns><param name="rgbHash">The hash of the data signed with <paramref name="rgbSignature" />. </param><param name="rgbSignature">The signature to be verified for <paramref name="rgbData" />. </param>
        public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);
        
        
        /// <summary>Reconstructs a <see cref="T:System.Security.Cryptography.DSA" /> object from an XML string.</summary><param name="xmlString">The XML string to use to reconstruct the <see cref="T:System.Security.Cryptography.DSA" /> object. </param><exception cref="T:System.ArgumentNullException">The <paramref name="xmlString" /> parameter is null. </exception><exception cref="T:System.Security.Cryptography.CryptographicException">The format of the <paramref name="xmlString" /> parameter is not valid. </exception>
        public override void FromXmlString(string xmlString)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates and returns an XML string representation of the current <see cref="T:System.Security.Cryptography.DSA" /> object.</summary><returns>An XML string encoding of the current <see cref="T:System.Security.Cryptography.DSA" /> object.</returns><param name="includePrivateParameters">true to include private parameters; otherwise, false. </param>
        public override string ToXmlString(bool includePrivateParameters)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, exports the <see cref="T:System.Security.Cryptography.DSAParameters" />.</summary><returns>The parameters for <see cref="T:System.Security.Cryptography.DSA" />.</returns><param name="includePrivateParameters">true to include private parameters; otherwise, false. </param>
        public abstract DSAParameters ExportParameters(bool includePrivateParameters);
        
        
        /// <summary>When overridden in a derived class, imports the specified <see cref="T:System.Security.Cryptography.DSAParameters" />.</summary><param name="parameters">The parameters for <see cref="T:System.Security.Cryptography.DSA" />. </param>
        public abstract void ImportParameters(DSAParameters parameters);
        
        
    }
}
