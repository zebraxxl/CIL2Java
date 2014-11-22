using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Security
{
    /// <summary>Defines a permission set that has a name and description associated with it. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class NamedPermissionSet : PermissionSet
    {
    
        /// <summary>Gets or sets the name of the current named permission set.</summary><returns>The name of the named permission set.</returns><exception cref="T:System.ArgumentException">The name is null or is an empty string (""). </exception>
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the text description of the current named permission set.</summary><returns>A text description of the named permission set.</returns>
        public string Description
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new, empty instance of the <see cref="T:System.Security.NamedPermissionSet" /> class with the specified name.</summary><param name="name">The name for the new named permission set. </param><exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is null or is an empty string (""). </exception>
        public NamedPermissionSet(string name)
            : base(null)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.NamedPermissionSet" /> class with the specified name in either an unrestricted or a fully restricted state.</summary><param name="name">The name for the new named permission set. </param><param name="state">One of the <see cref="T:System.Security.Permissions.PermissionState" /> values. </param><exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is null or is an empty string (""). </exception>
        public NamedPermissionSet(string name, PermissionState state)
            : base(null)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.NamedPermissionSet" /> class with the specified name from a permission set.</summary><param name="name">The name for the named permission set. </param><param name="permSet">The permission set from which to take the value of the new named permission set. </param><exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is null or is an empty string (""). </exception>
        public NamedPermissionSet(string name, PermissionSet permSet)
            : base(null)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.NamedPermissionSet" /> class from another named permission set.</summary><param name="permSet">The named permission set from which to create the new instance. </param>
        public NamedPermissionSet(NamedPermissionSet permSet)
            : base(null)
        {
             throw new NotImplementedException();
        }
        
        
        public override PermissionSet Copy()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a copy of the named permission set with a different name but the same permissions.</summary><returns>A copy of the named permission set with the new name.</returns><param name="name">The name for the new named permission set. </param><exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is null or is an empty string (""). </exception>
        public NamedPermissionSet Copy(string name)
        {
             throw new NotImplementedException();
        }
        
        
        public override SecurityElement ToXml()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs a named permission set with a specified state from an XML encoding.</summary><param name="et">A security element containing the XML representation of the named permission set. </param><exception cref="T:System.ArgumentException">The <paramref name="et" /> parameter is not a valid representation of a named permission set. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="et" /> parameter is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public override void FromXml(SecurityElement et)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified <see cref="T:System.Security.NamedPermissionSet" /> object is equal to the current <see cref="T:System.Security.NamedPermissionSet" />.</summary><returns>true if the specified <see cref="T:System.Security.NamedPermissionSet" /> is equal to the current <see cref="T:System.Security.NamedPermissionSet" /> object; otherwise, false.</returns><param name="obj">The <see cref="T:System.Security.NamedPermissionSet" /> object to compare with the current <see cref="T:System.Security.NamedPermissionSet" />. </param>
        [ComVisibleAttribute(false)]
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
