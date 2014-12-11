
namespace System.Security.AccessControl
{
    /// <summary>Represents an Access Control List (ACL).</summary>
    public sealed class RawAcl : GenericAcl
    {
    
        /// <summary>Gets the revision level of the <see cref="T:System.Security.AccessControl.RawAcl" />.</summary><returns>A byte value that specifies the revision level of the <see cref="T:System.Security.AccessControl.RawAcl" />.</returns>
        public override byte Revision
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of access control entries (ACEs) in the current <see cref="T:System.Security.AccessControl.RawAcl" /> object.</summary><returns>The number of ACEs in the current <see cref="T:System.Security.AccessControl.RawAcl" /> object.</returns>
        public override int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the length, in bytes, of the binary representation of the current <see cref="T:System.Security.AccessControl.RawAcl" /> object. This length should be used before marshaling the ACL into a binary array with the <see cref="M:System.Security.AccessControl.RawAcl.GetBinaryForm" /> method.</summary><returns>The length, in bytes, of the binary representation of the current <see cref="T:System.Security.AccessControl.RawAcl" /> object.</returns>
        public override int BinaryLength
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the Access Control Entry (ACE) at the specified index.</summary><returns>The ACE at the specified index.</returns><param name="index">The zero-based index of the ACE to get or set.</param>
        public override GenericAce this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.RawAcl" /> class with the specified revision level.</summary><param name="revision">The revision level of the new Access Control List (ACL).</param><param name="capacity">The number of Access Control Entries (ACEs) this <see cref="T:System.Security.AccessControl.RawAcl" /> object can contain. This number is to be used only as a hint.</param>
        public RawAcl(byte revision, int capacity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.RawAcl" /> class from the specified binary form.</summary><param name="binaryForm">An array of byte values that represent an Access Control List (ACL).</param><param name="offset">The offset in the <paramref name="binaryForm" /> parameter at which to begin unmarshaling data.</param>
        public RawAcl(byte[] binaryForm, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Marshals the contents of the <see cref="T:System.Security.AccessControl.RawAcl" /> object into the specified byte array beginning at the specified offset.</summary><param name="binaryForm">The byte array into which the contents of the <see cref="T:System.Security.AccessControl.RawAcl" /> is marshaled.</param><param name="offset">The offset at which to start marshaling.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> is negative or too high to allow the entire <see cref="T:System.Security.AccessControl.RawAcl" /> to be copied into <paramref name="array" />.</exception>
        public override void GetBinaryForm(byte[] binaryForm, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Inserts the specified Access Control Entry (ACE) at the specified index.</summary><param name="index">The position at which to add the new ACE. Specify the value of the <see cref="P:System.Security.AccessControl.RawAcl.Count" /> property to insert an ACE at the end of the <see cref="T:System.Security.AccessControl.RawAcl" /> object.</param><param name="ace">The ACE to insert.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> is negative or too high to allow the entire <see cref="T:System.Security.AccessControl.GenericAcl" /> to be copied into <paramref name="array" />.</exception>
        public void InsertAce(int index, GenericAce ace)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the Access Control Entry (ACE) at the specified location.</summary><param name="index">The zero-based index of the ACE to remove.</param><exception cref="T:System.ArgumentOutOfRangeException">The value of the <paramref name="index" /> parameter is higher than the value of the <see cref="P:System.Security.AccessControl.RawAcl.Count" /> property minus one or is negative.</exception>
        public void RemoveAce(int index)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
