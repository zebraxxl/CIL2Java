using System.Security.Principal;

namespace System.Security.AccessControl
{
    /// <summary>Represents an access control entry (ACE).</summary>
    public sealed class CommonAce : QualifiedAce
    {
        /// <summary>Gets the length, in bytes, of the binary representation of the current <see cref="T:System.Security.AccessControl.CommonAce" /> object. Use this length with the <see cref="M:System.Security.AccessControl.CommonAce.GetBinaryForm(System.Byte[],System.Int32)" /> method before marshaling the ACL into a binary array.</summary><returns>The length, in bytes, of the binary representation of the current <see cref="T:System.Security.AccessControl.CommonAce" /> object.</returns>
        public override int BinaryLength
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.CommonAce" /> class.</summary><param name="flags">Flags that specify information about the inheritance, inheritance propagation, and auditing conditions for the new access control entry (ACE).</param><param name="qualifier">The use of the new ACE.</param><param name="accessMask">The access mask for the ACE.</param><param name="sid">The <see cref="T:System.Security.Principal.SecurityIdentifier" /> associated with the new ACE.</param><param name="isCallback">true to specify that the new ACE is a callback type ACE.</param><param name="opaque">Opaque data associated with the new ACE. Opaque data is allowed only for callback ACE types. The length of this array must not be greater than the return value of the <see cref="M:System.Security.AccessControl.CommonAce.MaxOpaqueLength(System.Boolean)" /> method.</param>
        public CommonAce(AceFlags flags, AceQualifier qualifier, int accessMask, SecurityIdentifier sid, bool isCallback, byte[] opaque)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the maximum allowed length of an opaque data BLOB for callback access control entries (ACEs).</summary><returns>The allowed length of an opaque data BLOB.</returns><param name="isCallback">true to specify that the <see cref="T:System.Security.AccessControl.CommonAce" /> object is a callback ACE type.</param>
        public static int MaxOpaqueLength(bool isCallback)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Marshals the contents of the <see cref="T:System.Security.AccessControl.CommonAce" /> object into the specified byte array beginning at the specified offset.</summary><param name="binaryForm">The byte array into which the contents of the <see cref="T:System.Security.AccessControl.CommonAce" /> object is marshaled.</param><param name="offset">The offset at which to start marshaling.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> is negative or too high to allow the entire <see cref="T:System.Security.AccessControl.CommonAce" /> to be copied into the <paramref name="binaryForm" /> array.</exception>
        public override void GetBinaryForm(byte[] binaryForm, int offset)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
