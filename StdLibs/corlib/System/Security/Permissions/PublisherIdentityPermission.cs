using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace System.Security.Permissions
{
    /// <summary>Represents the identity of a software publisher. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class PublisherIdentityPermission : CodeAccessPermission
    {
    
        /// <summary>Gets or sets an Authenticode X.509v3 certificate that represents the identity of the software publisher.</summary><returns>An X.509 certificate representing the identity of the software publisher.</returns><exception cref="T:System.ArgumentNullException">The <see cref="P:System.Security.Permissions.PublisherIdentityPermission.Certificate" /> is null. </exception><exception cref="T:System.ArgumentException">The <see cref="P:System.Security.Permissions.PublisherIdentityPermission.Certificate" /> is not a valid certificate. </exception><exception cref="T:System.NotSupportedException">The property cannot be set because the identity is ambiguous.</exception>
        public X509Certificate Certificate
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.PublisherIdentityPermission" /> class with the specified <see cref="T:System.Security.Permissions.PermissionState" />.</summary><param name="state">One of the <see cref="T:System.Security.Permissions.PermissionState" /> values.</param><exception cref="T:System.ArgumentException">The <paramref name="state" /> parameter is not a valid value of <see cref="T:System.Security.Permissions.PermissionState" />. </exception>
        public PublisherIdentityPermission(PermissionState state)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.PublisherIdentityPermission" /> class with the specified Authenticode X.509v3 certificate.</summary><param name="certificate">An X.509 certificate representing the software publisher's identity. </param><exception cref="T:System.ArgumentNullException">The <paramref name="certificate" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="certificate" /> parameter is not a valid certificate. </exception>
        public PublisherIdentityPermission(X509Certificate certificate)
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
        
        
        /// <summary>Creates and returns a permission that is the intersection of the current permission and the specified permission.</summary><returns>A new permission that represents the intersection of the current permission and the specified permission. This new permission is null if the intersection is empty.</returns><param name="target">A permission to intersect with the current permission. It must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not of the same type as the current permission. </exception>
        public override IPermission Intersect(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a permission that is the union of the current permission and the specified permission.</summary><returns>A new permission that represents the union of the current permission and the specified permission.</returns><param name="target">A permission to combine with the current permission. It must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not of the same type as the current permission. -or-The two permissions are not equal.</exception>
        public override IPermission Union(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs a permission with a specified state from an XML encoding.</summary><param name="esd">The XML encoding to use to reconstruct the permission. </param><exception cref="T:System.ArgumentNullException">The <paramref name="esd" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="esd" /> parameter is not a valid permission element.-or- The <paramref name="esd" /> parameter's version number is not valid. </exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Create" /></PermissionSet>
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
