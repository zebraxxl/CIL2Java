
namespace System.Security.AccessControl
{
    /// <summary>Represents an Access Control Entry (ACE) that is not defined by one of the members of the <see cref="T:System.Security.AccessControl.AceType" /> enumeration.</summary>
    public sealed class CustomAce : GenericAce
    {
        /// <summary>Returns the maximum allowed length of an opaque data blob for this <see cref="T:System.Security.AccessControl.CustomAce" /> object.</summary>
        public static readonly int MaxOpaqueLength;
    
        /// <summary>Gets the length of the opaque data associated with this <see cref="T:System.Security.AccessControl.CustomAce" /> object.</summary><returns>The length of the opaque callback data.</returns>
        public int OpaqueLength
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the length, in bytes, of the binary representation of the current <see cref="T:System.Security.AccessControl.CustomAce" /> object. This length should be used before marshaling the ACL into a binary array with the <see cref="M:System.Security.AccessControl.CustomAce.GetBinaryForm" /> method.</summary><returns>The length, in bytes, of the binary representation of the current <see cref="T:System.Security.AccessControl.CustomAce" /> object.</returns>
        public override int BinaryLength
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.CustomAce" /> class.</summary><param name="type">Type of the new Access Control Entry (ACE). This value must be greater than <see cref="F:System.Security.AccessControl.AceType.MaxDefinedAceType" />.</param><param name="flags">Flags that specify information about the inheritance, inheritance propagation, and auditing conditions for the new ACE.</param><param name="opaque">An array of byte values that contains the data for the new ACE. This value can be null. The length of this array must not be greater than the value of the <see cref="F:System.Security.AccessControl.CustomAce.MaxOpaqueLength" /> field, and must be a multiple of four.</param><exception cref="T:System.ArgumentOutOfRangeException">The value of the <paramref name="type" /> parameter is not greater than <see cref="F:System.Security.AccessControl.AceType.MaxDefinedAceType" /> or the length of the <paramref name="opaque" /> array is either greater than the value of the <see cref="F:System.Security.AccessControl.CustomAce.MaxOpaqueLength" /> field or not a multiple of four.</exception>
        public CustomAce(AceType type, AceFlags flags, byte[] opaque)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] GetOpaque()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the opaque callback data associated with this <see cref="T:System.Security.AccessControl.CustomAce" /> object.</summary><param name="opaque">An array of byte values that represents the opaque callback data for this <see cref="T:System.Security.AccessControl.CustomAce" /> object.</param>
        public void SetOpaque(byte[] opaque)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Marshals the contents of the <see cref="T:System.Security.AccessControl.CustomAce" /> object into the specified byte array beginning at the specified offset.</summary><param name="binaryForm">The byte array into which the contents of the <see cref="T:System.Security.AccessControl.CustomAce" /> is marshaled.</param><param name="offset">The offset at which to start marshaling.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> is negative or too high to allow the entire <see cref="T:System.Security.AccessControl.CustomAce" /> to be copied into <paramref name="array" />.</exception>
        public override void GetBinaryForm(byte[] binaryForm, int offset)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
