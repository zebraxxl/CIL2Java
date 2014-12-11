using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.Serialization;

namespace System.Security.Permissions
{
    /// <summary>Defines the identity permission for the URL from which the code originates. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class UrlIdentityPermission : CodeAccessPermission
    {
    
        /// <summary>Gets or sets a URL representing the identity of Internet code.</summary><returns>A URL representing the identity of Internet code.</returns><exception cref="T:System.NotSupportedException">The URL cannot be retrieved because it has an ambiguous identity.</exception>
        public string Url
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.UrlIdentityPermission" /> class with the specified <see cref="T:System.Security.Permissions.PermissionState" />.</summary><param name="state">One of the <see cref="T:System.Security.Permissions.PermissionState" />  values. </param><exception cref="T:System.ArgumentException">The <paramref name="state" /> parameter is not a valid value of <see cref="T:System.Security.Permissions.PermissionState" />. </exception>
        public UrlIdentityPermission(PermissionState state)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.UrlIdentityPermission" /> class to represent the URL identity described by <paramref name="site" />.</summary><param name="site">A URL or wildcard expression. </param><exception cref="T:System.ArgumentNullException">The <paramref name="site" /> parameter is null. </exception><exception cref="T:System.FormatException">The length of the <paramref name="site" /> parameter is zero. </exception><exception cref="T:System.ArgumentException">The URL, directory, or site portion of the <paramref name="site" /> parameter is not valid. </exception>
        public UrlIdentityPermission(string site)
        {
             throw new NotImplementedException();
        }
        
        
        public override IPermission Copy()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current permission is a subset of the specified permission.</summary><returns>true if the current permission is a subset of the specified permission; otherwise, false.</returns><param name="target">A permission that is to be tested for the subset relationship. This permission must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not of the same type as the current permission. -or-The Url property is not a valid URL.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public override bool IsSubsetOf(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates and returns a permission that is the intersection of the current permission and the specified permission.</summary><returns>A new permission that represents the intersection of the current permission and the specified permission. This new permission is null if the intersection is empty.</returns><param name="target">A permission to intersect with the current permission. It must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not of the same type as the current permission. -or-The Url property is not a valid URL.</exception>
        public override IPermission Intersect(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a permission that is the union of the current permission and the specified permission.</summary><returns>A new permission that represents the union of the current permission and the specified permission.</returns><param name="target">A permission to combine with the current permission. It must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not of the same type as the current permission. -or-The <see cref="P:System.Security.Permissions.UrlIdentityPermission.Url" /> property is not a valid URL.-or-The two permissions are not equal and one is not a subset of the other.</exception>
        public override IPermission Union(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs a permission with a specified state from an XML encoding.</summary><param name="esd">The XML encoding to use to reconstruct the permission. </param><exception cref="T:System.ArgumentNullException">The <paramref name="esd" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="esd" /> parameter is not a valid permission element.-or- The <paramref name="esd" /> parameter's version number is not valid.  </exception>
        public override void FromXml(SecurityElement esd)
        {
             throw new NotImplementedException();
        }
        
        
        public override SecurityElement ToXml()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
