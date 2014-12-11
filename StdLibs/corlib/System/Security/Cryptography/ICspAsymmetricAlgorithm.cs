using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Defines methods that allow an <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> class to enumerate key container information, and import and export Microsoft Cryptographic API (CAPI)–compatible key blobs.</summary>
    [ComVisibleAttribute(true)]
    public interface ICspAsymmetricAlgorithm
    {
        /// <summary>Gets a <see cref="T:System.Security.Cryptography.CspKeyContainerInfo" /> object that describes additional information about a cryptographic key pair.</summary><returns>A <see cref="T:System.Security.Cryptography.CspKeyContainerInfo" /> object that describes additional information about a cryptographic key pair.</returns>
        CspKeyContainerInfo CspKeyContainerInfo
        {
            get;
        }
    
    
        /// <summary>Exports a blob that contains the key information associated with an <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> object.  </summary><returns>A byte array that contains the key information associated with an <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> object.</returns><param name="includePrivateParameters">true to include the private key; otherwise, false.</param>
        byte[] ExportCspBlob(bool includePrivateParameters);
        
        
        /// <summary>Imports a blob that represents asymmetric key information.  </summary><param name="rawData">A byte array that represents an asymmetric key blob.</param>
        void ImportCspBlob(byte[] rawData);
        
        
    }
}
