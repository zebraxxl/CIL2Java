using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
    /// <summary>Represents an access control list (ACL) and is the base class for the <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> and <see cref="T:System.Security.AccessControl.SystemAcl" /> classes.</summary>
    public abstract class CommonAcl : GenericAcl
    {
    
        /// <summary>Gets the revision level of the <see cref="T:System.Security.AccessControl.CommonAcl" />.</summary><returns>A byte value that specifies the revision level of the <see cref="T:System.Security.AccessControl.CommonAcl" />.</returns>
        public override byte Revision
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of access control entries (ACEs) in the current <see cref="T:System.Security.AccessControl.CommonAcl" /> object.</summary><returns>The number of ACEs in the current <see cref="T:System.Security.AccessControl.CommonAcl" /> object.</returns>
        public override int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the length, in bytes, of the binary representation of the current <see cref="T:System.Security.AccessControl.CommonAcl" /> object. This length should be used before marshaling the access control list (ACL) into a binary array by using the <see cref="M:System.Security.AccessControl.CommonAcl.GetBinaryForm" /> method.</summary><returns>The length, in bytes, of the binary representation of the current <see cref="T:System.Security.AccessControl.CommonAcl" /> object.</returns>
        public override int BinaryLength
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a Boolean value that specifies whether the access control entries (ACEs) in the current <see cref="T:System.Security.AccessControl.CommonAcl" /> object are in canonical order.</summary><returns>true if the ACEs in the current <see cref="T:System.Security.AccessControl.CommonAcl" /> object are in canonical order; otherwise, false.</returns>
        public bool IsCanonical
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Sets whether the <see cref="T:System.Security.AccessControl.CommonAcl" /> object is a container. </summary><returns>true if the current <see cref="T:System.Security.AccessControl.CommonAcl" /> object is a container.</returns>
        public bool IsContainer
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Sets whether the current <see cref="T:System.Security.AccessControl.CommonAcl" /> object is a directory object access control list (ACL).</summary><returns>true if the current <see cref="T:System.Security.AccessControl.CommonAcl" /> object is a directory object ACL.</returns>
        public bool IsDS
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the <see cref="T:System.Security.AccessControl.CommonAce" /> at the specified index.</summary><returns>The <see cref="T:System.Security.AccessControl.CommonAce" /> at the specified index.</returns><param name="index">The zero-based index of the <see cref="T:System.Security.AccessControl.CommonAce" /> to get or set.</param>
        public override GenericAce this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Marshals the contents of the <see cref="T:System.Security.AccessControl.CommonAcl" /> object into the specified byte array beginning at the specified offset.</summary><param name="binaryForm">The byte array into which the contents of the <see cref="T:System.Security.AccessControl.CommonAcl" /> is marshaled.</param><param name="offset">The offset at which to start marshaling.</param>
        public override void GetBinaryForm(byte[] binaryForm, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        public void RemoveInheritedAces()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all access control entries (ACEs) contained by this <see cref="T:System.Security.AccessControl.CommonAcl" /> object that are associated with the specified <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</summary><param name="sid">The <see cref="T:System.Security.Principal.SecurityIdentifier" /> object to check for.</param>
        public void Purge(SecurityIdentifier sid)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
