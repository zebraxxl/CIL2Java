using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace System.Security.Policy
{
    /// <summary>Provides evidence about the hash value for an assembly. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class Hash : EvidenceBase, ISerializable
    {
    
        /// <summary>Gets the <see cref="T:System.Security.Cryptography.SHA1" /> hash value for the assembly.</summary><returns>A byte array that represents the <see cref="T:System.Security.Cryptography.SHA1" /> hash value for the assembly.</returns>
        public byte[] SHA1
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Security.Cryptography.SHA256" /> hash value for the assembly.</summary><returns>A byte array that represents the <see cref="T:System.Security.Cryptography.SHA256" /> hash value for the assembly.</returns>
        public byte[] SHA256
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Security.Cryptography.MD5" /> hash value for the assembly.</summary><returns>A byte array that represents the <see cref="T:System.Security.Cryptography.MD5" /> hash value for the assembly.</returns>
        public byte[] MD5
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.Hash" /> class.</summary><param name="assembly">The assembly for which to compute the hash value. </param><exception cref="T:System.ArgumentNullException">The <paramref name="assembly" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The hash cannot be generated.</exception><exception cref="T:System.ArgumentException"><paramref name="assembly" /> is not a run-time <see cref="T:System.Reflection.Assembly" /> object.</exception>
        public Hash(Assembly assembly)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a <see cref="T:System.Security.Policy.Hash" /> object that contains a <see cref="T:System.Security.Cryptography.SHA1" /> hash value.</summary><returns>An object that contains the hash value provided by the <paramref name="sha1" /> parameter.</returns><param name="sha1">A byte array that contains a <see cref="T:System.Security.Cryptography.SHA1" /> hash value.</param><exception cref="T:System.ArgumentNullException">The <paramref name="sha1" /> parameter is null. </exception>
        public static Hash CreateSHA1(byte[] sha1)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a <see cref="T:System.Security.Policy.Hash" /> object that contains a <see cref="T:System.Security.Cryptography.SHA256" /> hash value.</summary><returns>A hash object that contains the hash value provided by the <paramref name="sha256" /> parameter.</returns><param name="sha256">A byte array that contains a <see cref="T:System.Security.Cryptography.SHA256" /> hash value.</param><exception cref="T:System.ArgumentNullException">The <paramref name="sha256" /> parameter is null. </exception>
        public static Hash CreateSHA256(byte[] sha256)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a <see cref="T:System.Security.Policy.Hash" /> object that contains an <see cref="T:System.Security.Cryptography.MD5" /> hash value.</summary><returns>An object that contains the hash value provided by the <paramref name="md5" /> parameter.</returns><param name="md5">A byte array that contains an <see cref="T:System.Security.Cryptography.MD5" /> hash value.</param><exception cref="T:System.ArgumentNullException">The <paramref name="md5" /> parameter is null. </exception>
        public static Hash CreateMD5(byte[] md5)
        {
             throw new NotImplementedException();
        }
        
        
        public override EvidenceBase Clone()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the parameter name and additional exception information.</summary><param name="info">The object that holds the serialized object data. </param><param name="context">The contextual information about the source or destination. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Computes the hash value for the assembly using the specified hash algorithm.</summary><returns>A byte array that represents the hash value for the assembly.</returns><param name="hashAlg">The hash algorithm to use to compute the hash value for the assembly. </param><exception cref="T:System.ArgumentNullException">The <paramref name="hashAlg" /> parameter is null. </exception><exception cref="T:System.Security.SecurityException">The hash value for the assembly cannot be generated.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public byte[] GenerateHash(HashAlgorithm hashAlg)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
