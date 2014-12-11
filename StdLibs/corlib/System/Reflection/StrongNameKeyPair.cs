using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.IO;

namespace System.Reflection
{
    /// <summary>Encapsulates access to a public or private key pair used to sign strong name assemblies.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class StrongNameKeyPair : IDeserializationCallback, ISerializable
    {
    
        /// <summary>Gets the public part of the public key or public key token of the key pair.</summary><returns>An array of type byte containing the public key or public key token of the key pair.</returns>
        public byte[] PublicKey
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.StrongNameKeyPair" /> class, building the key pair from a FileStream.</summary><param name="keyPairFile">A FileStream containing the key pair. </param><exception cref="T:System.ArgumentNullException"><paramref name="keyPairFile" /> is null. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        [SecuritySafeCriticalAttribute()]
        public StrongNameKeyPair(FileStream keyPairFile)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.StrongNameKeyPair" /> class, building the key pair from a byte array.</summary><param name="keyPairArray">An array of type byte containing the key pair. </param><exception cref="T:System.ArgumentNullException"><paramref name="keyPairArray" /> is null. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        [SecuritySafeCriticalAttribute()]
        public StrongNameKeyPair(byte[] keyPairArray)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.StrongNameKeyPair" /> class, building the key pair from a String.</summary><param name="keyPairContainer">A string containing the key pair. </param><exception cref="T:System.ArgumentNullException"><paramref name="keyPairContainer" /> is null. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        [SecuritySafeCriticalAttribute()]
        public StrongNameKeyPair(string keyPairContainer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.StrongNameKeyPair" /> class, building the key pair from serialized data.</summary><param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that holds the serialized object data.</param><param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains contextual information about the source or destination.</param>
        [SecuritySafeCriticalAttribute()]
        protected StrongNameKeyPair(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }



        void IDeserializationCallback.OnDeserialization(object sender)
        {
            throw new NotImplementedException();
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
