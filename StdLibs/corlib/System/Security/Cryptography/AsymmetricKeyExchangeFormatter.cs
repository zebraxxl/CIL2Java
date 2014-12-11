using System.Runtime.InteropServices;
using System;

namespace System.Security.Cryptography
{
    /// <summary>Represents the base class from which all asymmetric key exchange formatters derive.</summary>
    [ComVisibleAttribute(true)]
    public abstract class AsymmetricKeyExchangeFormatter
    {
        /// <summary>When overridden in a derived class, gets the parameters for the asymmetric key exchange.</summary><returns>A string in XML format containing the parameters of the asymmetric key exchange operation.</returns>
        public abstract string Parameters
        {
            get;
        }
    
    
        protected AsymmetricKeyExchangeFormatter()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, sets the public key to use for encrypting the secret information.</summary><param name="key">The instance of the implementation of <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> that holds the public key. </param>
        public abstract void SetKey(AsymmetricAlgorithm key);
        
        
        /// <summary>When overridden in a derived class, creates the encrypted key exchange data from the specified input data.</summary><returns>The encrypted key exchange data to be sent to the intended recipient.</returns><param name="data">The secret information to be passed in the key exchange. </param>
        public abstract byte[] CreateKeyExchange(byte[] data);
        
        
        /// <summary>When overridden in a derived class, creates the encrypted key exchange data from the specified input data.</summary><returns>The encrypted key exchange data to be sent to the intended recipient.</returns><param name="data">The secret information to be passed in the key exchange. </param><param name="symAlgType">This parameter is not used in the current version. </param>
        public abstract byte[] CreateKeyExchange(byte[] data, Type symAlgType);
        
        
    }
}
