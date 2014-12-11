using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security;

namespace System.Security.Policy
{
    /// <summary>Determines whether an assembly belongs to a code group by testing its hash value. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class HashMembershipCondition : ISerializable, IDeserializationCallback
    {
    
        /// <summary>Gets or sets the hash algorithm to use for the membership condition.</summary><returns>The hash algorithm to use for the membership condition.</returns><exception cref="T:System.ArgumentNullException">An attempt is made to set <see cref="P:System.Security.Policy.HashMembershipCondition.HashAlgorithm" /> to null. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public HashAlgorithm HashAlgorithm
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the hash value for which the membership condition tests.</summary><returns>The hash value for which the membership condition tests.</returns><exception cref="T:System.ArgumentNullException">An attempt is made to set <see cref="P:System.Security.Policy.HashMembershipCondition.HashValue" /> to null. </exception>
        public byte[] HashValue
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.HashMembershipCondition" /> class with the hash algorithm and hash value that determine membership.</summary><param name="hashAlg">The hash algorithm to use to compute the hash value for the assembly. </param><param name="value">The hash value for which to test. </param><exception cref="T:System.ArgumentNullException">The <paramref name="hashAlg" /> parameter is null.-or- The <paramref name="value" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="hashAlg" /> parameter is not a valid hash algorithm. </exception>
        public HashMembershipCondition(HashAlgorithm hashAlg, byte[] value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified evidence satisfies the membership condition.</summary><returns>true if the specified evidence satisfies the membership condition; otherwise, false.</returns><param name="evidence">The evidence set against which to make the test. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public bool Check(Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        public IMembershipCondition Copy()
        {
             throw new NotImplementedException();
        }
        
        
        public SecurityElement ToXml()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs a security object with a specified state from an XML encoding.</summary><param name="e">The XML encoding to use to reconstruct the security object. </param>
        public void FromXml(SecurityElement e)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an XML encoding of the security object and its current state with the specified <see cref="T:System.Security.Policy.PolicyLevel" />.</summary><returns>An XML encoding of the security object, including any state information.</returns><param name="level">The policy level context for resolving named permission set references. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public SecurityElement ToXml(PolicyLevel level)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs a security object with a specified state from an XML encoding.</summary><param name="e">The XML encoding to use to reconstruct the security object. </param><param name="level">The policy level context, used to resolve named permission set references. </param><exception cref="T:System.ArgumentNullException">The <paramref name="e" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="e" /> parameter is not a valid membership condition element. </exception>
        public void FromXml(SecurityElement e, PolicyLevel level)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the <see cref="P:System.Security.Policy.HashMembershipCondition.HashValue" /> and the <see cref="P:System.Security.Policy.HashMembershipCondition.HashAlgorithm" /> from the specified object are equivalent to the <see cref="P:System.Security.Policy.HashMembershipCondition.HashValue" /> and <see cref="P:System.Security.Policy.HashMembershipCondition.HashAlgorithm" /> contained in the current <see cref="T:System.Security.Policy.HashMembershipCondition" />.</summary><returns>true if the <see cref="P:System.Security.Policy.HashMembershipCondition.HashValue" /> and <see cref="P:System.Security.Policy.HashMembershipCondition.HashAlgorithm" /> from the specified object is equivalent to the <see cref="P:System.Security.Policy.HashMembershipCondition.HashValue" /> and <see cref="P:System.Security.Policy.HashMembershipCondition.HashAlgorithm" /> contained in the current <see cref="T:System.Security.Policy.HashMembershipCondition" />; otherwise, false.</returns><param name="o">The object to compare to the current <see cref="T:System.Security.Policy.HashMembershipCondition" />. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public override bool Equals(object o)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }



        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        void IDeserializationCallback.OnDeserialization(object sender)
        {
            throw new NotImplementedException();
        }
    }
}
