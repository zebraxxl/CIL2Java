using System.Collections;
using System;

namespace System.Security
{
    /// <summary>Represents a read-only collection that can contain many different types of permissions.</summary>
    [Serializable]
    public sealed class ReadOnlyPermissionSet : PermissionSet
    {
    
        /// <summary>Gets a value that indicates whether the collection is read-only.</summary><returns>Always true.</returns>
        public override bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.ReadOnlyPermissionSet" /> class. </summary><param name="permissionSetXml">The XML element from which to take the value of the new <see cref="T:System.Security.ReadOnlyPermissionSet" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="permissionSetXml" /> is null.</exception>
        public ReadOnlyPermissionSet(SecurityElement permissionSetXml)
            : base(null)
        {
             throw new NotImplementedException();
        }
        
        
        public override PermissionSet Copy()
        {
             throw new NotImplementedException();
        }
        
        
        public override SecurityElement ToXml()
        {
             throw new NotImplementedException();
        }
        
        
        protected override IEnumerator GetEnumeratorImpl()
        {
             throw new NotImplementedException();
        }
        
        
        protected override IPermission GetPermissionImpl(Type permClass)
        {
             throw new NotImplementedException();
        }
        
        
        protected override IPermission AddPermissionImpl(IPermission perm)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs a security object with a specified state from an XML encoding.</summary><param name="et">The XML encoding to use to reconstruct the security object.</param><exception cref="T:System.ArgumentNullException">The <paramref name="et" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="et" /> parameter is not a valid permission element.-or- The <paramref name="et" /> parameter's version number is not supported. </exception><exception cref="T:System.InvalidOperationException">The object is not being deserialized; that is, <see cref="T:System.Security.PermissionSet" /> did not call back into <see cref="M:System.Security.ReadOnlyPermissionSet.FromXml(System.Security.SecurityElement)" /> during deserialization.</exception>
        public override void FromXml(SecurityElement et)
        {
             throw new NotImplementedException();
        }
        
        
        protected override IPermission RemovePermissionImpl(Type permClass)
        {
             throw new NotImplementedException();
        }
        
        
        protected override IPermission SetPermissionImpl(IPermission perm)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
