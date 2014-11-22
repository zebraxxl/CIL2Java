
namespace System.Security.AccessControl
{
    /// <summary>Represents an Access Control Entry (ACE), and is the base class for all other ACE classes.</summary>
    public abstract class GenericAce
    {
    
        /// <summary>Gets the type of this Access Control Entry (ACE).</summary><returns>The type of this ACE.</returns>
        public AceType AceType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the <see cref="T:System.Security.AccessControl.AceFlags" /> associated with this <see cref="T:System.Security.AccessControl.GenericAce" /> object.</summary><returns>The <see cref="T:System.Security.AccessControl.AceFlags" /> associated with this <see cref="T:System.Security.AccessControl.GenericAce" /> object.</returns>
        public AceFlags AceFlags
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a Boolean value that specifies whether this Access Control Entry (ACE) is inherited or is set explicitly.</summary><returns>true if this ACE is inherited; otherwise, false.</returns>
        public bool IsInherited
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets flags that specify the inheritance properties of this Access Control Entry (ACE).</summary><returns>Flags that specify the inheritance properties of this ACE.</returns>
        public InheritanceFlags InheritanceFlags
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets flags that specify the inheritance propagation properties of this Access Control Entry (ACE).</summary><returns>Flags that specify the inheritance propagation properties of this ACE.</returns>
        public PropagationFlags PropagationFlags
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the audit information associated with this Access Control Entry (ACE).</summary><returns>The audit information associated with this Access Control Entry (ACE).</returns>
        public AuditFlags AuditFlags
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the length, in bytes, of the binary representation of the current <see cref="T:System.Security.AccessControl.GenericAce" /> object. This length should be used before marshaling the ACL into a binary array with the <see cref="M:System.Security.AccessControl.GenericAce.GetBinaryForm" /> method.</summary><returns>The length, in bytes, of the binary representation of the current <see cref="T:System.Security.AccessControl.GenericAce" /> object.</returns>
        public abstract int BinaryLength
        {
            get;
        }
    
    
        /// <summary>Creates a <see cref="T:System.Security.AccessControl.GenericAce" /> object from the specified binary data.</summary><returns>The <see cref="T:System.Security.AccessControl.GenericAce" /> object this method creates.</returns><param name="binaryForm">The binary data from which to create the new <see cref="T:System.Security.AccessControl.GenericAce" /> object.</param><param name="offset">The offset at which to begin unmarshaling.</param>
        public static GenericAce CreateFromBinaryForm(byte[] binaryForm, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Marshals the contents of the <see cref="T:System.Security.AccessControl.GenericAce" /> object into the specified byte array beginning at the specified offset.</summary><param name="binaryForm">The byte array into which the contents of the <see cref="T:System.Security.AccessControl.GenericAce" /> is marshaled.</param><param name="offset">The offset at which to start marshaling.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> is negative or too high to allow the entire <see cref="T:System.Security.AccessControl.GenericAcl" /> to be copied into <paramref name="array" />.</exception>
        public abstract void GetBinaryForm(byte[] binaryForm, int offset);
        
        
        public GenericAce Copy()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified <see cref="T:System.Security.AccessControl.GenericAce" /> object is equal to the current <see cref="T:System.Security.AccessControl.GenericAce" /> object.</summary><returns>true if the specified <see cref="T:System.Security.AccessControl.GenericAce" /> object is equal to the current <see cref="T:System.Security.AccessControl.GenericAce" /> object; otherwise, false.</returns><param name="o">The <see cref="T:System.Security.AccessControl.GenericAce" /> object to compare to the current <see cref="T:System.Security.AccessControl.GenericAce" /> object.</param>
        public override bool Equals(object o)
        {
             throw new NotImplementedException();
        }


        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified <see cref="T:System.Security.AccessControl.GenericAce" /> objects are considered equal.</summary><returns>true if the two <see cref="T:System.Security.AccessControl.GenericAce" /> objects are equal; otherwise, false.</returns><param name="left">The first <see cref="T:System.Security.AccessControl.GenericAce" /> object to compare.</param><param name="right">The second <see cref="T:System.Security.AccessControl.GenericAce" /> to compare.</param>
        /// <summary>Determines whether the specified <see cref="T:System.Security.AccessControl.GenericAce" /> objects are considered equal.</summary><returns>true if the two <see cref="T:System.Security.AccessControl.GenericAce" /> objects are equal; otherwise, false.</returns><param name="left">The first <see cref="T:System.Security.AccessControl.GenericAce" /> object to compare.</param><param name="right">The second <see cref="T:System.Security.AccessControl.GenericAce" /> to compare.</param>
        public static bool operator ==(GenericAce left, GenericAce right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified <see cref="T:System.Security.AccessControl.GenericAce" /> objects are considered unequal.</summary><returns>true if the two <see cref="T:System.Security.AccessControl.GenericAce" /> objects are unequal; otherwise, false.</returns><param name="left">The first <see cref="T:System.Security.AccessControl.GenericAce" /> object to compare.</param><param name="right">The second <see cref="T:System.Security.AccessControl.GenericAce" /> to compare.</param>
        /// <summary>Determines whether the specified <see cref="T:System.Security.AccessControl.GenericAce" /> objects are considered unequal.</summary><returns>true if the two <see cref="T:System.Security.AccessControl.GenericAce" /> objects are unequal; otherwise, false.</returns><param name="left">The first <see cref="T:System.Security.AccessControl.GenericAce" /> object to compare.</param><param name="right">The second <see cref="T:System.Security.AccessControl.GenericAce" /> to compare.</param>
        public static bool operator !=(GenericAce left, GenericAce right)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
