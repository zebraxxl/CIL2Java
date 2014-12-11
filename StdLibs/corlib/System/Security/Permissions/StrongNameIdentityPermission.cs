using System.Runtime.InteropServices;
using System.Security;
using System;

namespace System.Security.Permissions
{
    /// <summary>Defines the identity permission for strong names. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class StrongNameIdentityPermission : CodeAccessPermission
    {
    
        /// <summary>Gets or sets the public key blob that defines the strong name identity namespace.</summary><returns>A <see cref="T:System.Security.Permissions.StrongNamePublicKeyBlob" /> that contains the public key of the identity, or null if there is no key.</returns><exception cref="T:System.ArgumentNullException">The property value is set to null. </exception><exception cref="T:System.NotSupportedException">The property value cannot be retrieved because it contains an ambiguous identity. </exception>
        public StrongNamePublicKeyBlob PublicKey
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the simple name portion of the strong name identity.</summary><returns>The simple name of the identity.</returns><exception cref="T:System.ArgumentException">The value is an empty string ("").</exception><exception cref="T:System.NotSupportedException">The property value cannot be retrieved because it contains an ambiguous identity. </exception>
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the version number of the identity.</summary><returns>The version of the identity.</returns><exception cref="T:System.NotSupportedException">The property value cannot be retrieved because it contains an ambiguous identity. </exception>
        public Version Version
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.StrongNameIdentityPermission" /> class with the specified <see cref="T:System.Security.Permissions.PermissionState" />.</summary><param name="state">One of the <see cref="T:System.Security.Permissions.PermissionState" /> values. </param><exception cref="T:System.ArgumentException">The <paramref name="state" /> parameter is not a valid value of <see cref="T:System.Security.Permissions.PermissionState" />. </exception>
        public StrongNameIdentityPermission(PermissionState state)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.StrongNameIdentityPermission" /> class for the specified strong name identity.</summary><param name="blob">The public key defining the strong name identity namespace. </param><param name="name">The simple name part of the strong name identity. This corresponds to the name of the assembly. </param><param name="version">The version number of the identity. </param><exception cref="T:System.ArgumentNullException">The <paramref name="blob" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is an empty string ("").</exception>
        public StrongNameIdentityPermission(StrongNamePublicKeyBlob blob, string name, Version version)
        {
             throw new NotImplementedException();
        }
        
        
        public override IPermission Copy()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current permission is a subset of the specified permission.</summary><returns>true if the current permission is a subset of the specified permission; otherwise, false.</returns><param name="target">A permission that is to be tested for the subset relationship. This permission must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not of the same type as the current permission. </exception>
        public override bool IsSubsetOf(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates and returns a permission that is the intersection of the current permission and the specified permission.</summary><returns>A new permission that represents the intersection of the current permission and the specified permission, or null if the intersection is empty.</returns><param name="target">A permission to intersect with the current permission. It must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not of the same type as the current permission. </exception>
        public override IPermission Intersect(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a permission that is the union of the current permission and the specified permission.</summary><returns>A new permission that represents the union of the current permission and the specified permission.</returns><param name="target">A permission to combine with the current permission. It must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not of the same type as the current permission. -or-The two permissions are not equal and one is a subset of the other.</exception>
        public override IPermission Union(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs a permission with a specified state from an XML encoding.</summary><param name="e">The XML encoding to use to reconstruct the permission. </param><exception cref="T:System.ArgumentNullException">The <paramref name="e" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="e" /> parameter is not a valid permission element.-or- The <paramref name="e" /> parameter's version number is not valid. </exception>
        public override void FromXml(SecurityElement e)
        {
             throw new NotImplementedException();
        }
        
        
        public override SecurityElement ToXml()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
