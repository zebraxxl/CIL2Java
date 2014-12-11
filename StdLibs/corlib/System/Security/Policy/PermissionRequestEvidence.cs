using System.Runtime.InteropServices;
using System;
using System.Security;

namespace System.Security.Policy
{
    /// <summary>Defines evidence that represents permission requests. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
    public sealed class PermissionRequestEvidence : EvidenceBase
    {
    
        /// <summary>Gets the minimum permissions the code requires to run.</summary><returns>The minimum permissions the code requires to run.</returns>
        public PermissionSet RequestedPermissions
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the permissions the code can use if they are granted, but are not required.</summary><returns>The permissions the code can use if they are granted, but are not required.</returns>
        public PermissionSet OptionalPermissions
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the permissions the code explicitly asks not to be granted.</summary><returns>The permissions the code explicitly asks not to be granted.</returns>
        public PermissionSet DeniedPermissions
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.PermissionRequestEvidence" /> class with the permission request of a code assembly.</summary><param name="request">The minimum permissions the code requires to run. </param><param name="optional">The permissions the code can use if they are granted, but that are not required. </param><param name="denied">The permissions the code explicitly asks not to be granted. </param>
        public PermissionRequestEvidence(PermissionSet request, PermissionSet optional, PermissionSet denied)
        {
             throw new NotImplementedException();
        }
        
        
        public override EvidenceBase Clone()
        {
             throw new NotImplementedException();
        }
        
        
        public PermissionRequestEvidence Copy()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
