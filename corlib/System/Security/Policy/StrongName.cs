using System.Runtime.InteropServices;
using System.Security.Permissions;
using System;
using System.Security;

namespace System.Security.Policy
{
    /// <summary>Provides the strong name of a code assembly as evidence for policy evaluation. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class StrongName : EvidenceBase, IIdentityPermissionFactory
    {
    
        /// <summary>Gets the <see cref="T:System.Security.Permissions.StrongNamePublicKeyBlob" /> of the current <see cref="T:System.Security.Policy.StrongName" />.</summary><returns>The <see cref="T:System.Security.Permissions.StrongNamePublicKeyBlob" /> of the current <see cref="T:System.Security.Policy.StrongName" />.</returns>
        public StrongNamePublicKeyBlob PublicKey
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the simple name of the current <see cref="T:System.Security.Policy.StrongName" />.</summary><returns>The simple name part of the <see cref="T:System.Security.Policy.StrongName" />.</returns>
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Version" /> of the current <see cref="T:System.Security.Policy.StrongName" />.</summary><returns>The <see cref="T:System.Version" /> of the current <see cref="T:System.Security.Policy.StrongName" />.</returns>
        public Version Version
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.StrongName" /> class with the strong name public key blob, name, and version.</summary><param name="blob">The <see cref="T:System.Security.Permissions.StrongNamePublicKeyBlob" /> of the software publisher. </param><param name="name">The simple name section of the strong name. </param><param name="version">The <see cref="T:System.Version" /> of the strong name. </param><exception cref="T:System.ArgumentNullException">The <paramref name="blob" /> parameter is null.-or- The <paramref name="name" /> parameter is null.-or- The <paramref name="version" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is an empty string (""). </exception>
        public StrongName(StrongNamePublicKeyBlob blob, string name, Version version)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a <see cref="T:System.Security.Permissions.StrongNameIdentityPermission" /> that corresponds to the current <see cref="T:System.Security.Policy.StrongName" />.</summary><returns>A <see cref="T:System.Security.Permissions.StrongNameIdentityPermission" /> for the specified <see cref="T:System.Security.Policy.StrongName" />.</returns><param name="evidence">The <see cref="T:System.Security.Policy.Evidence" /> from which to construct the <see cref="T:System.Security.Permissions.StrongNameIdentityPermission" />. </param>
        public IPermission CreateIdentityPermission(Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        public override EvidenceBase Clone()
        {
             throw new NotImplementedException();
        }
        
        
        public object Copy()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified strong name is equal to the current strong name.</summary><returns>true if the specified strong name is equal to the current strong name; otherwise, false.</returns><param name="o">The strong name to compare against the current strong name. </param>
        public override bool Equals(object o)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
