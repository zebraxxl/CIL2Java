using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Security;

namespace System.Security.Principal
{
    /// <summary>Enables code to check the Windows group membership of a Windows user.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class WindowsPrincipal : ClaimsPrincipal
    {
    
        /// <summary>Gets the identity of the current principal.</summary><returns>The <see cref="T:System.Security.Principal.WindowsIdentity" /> object of the current principal.</returns>
        public override IIdentity Identity
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets all Windows user claims from this principal.</summary><returns>A collection of all Windows user claims from this principal.</returns>
        public virtual IEnumerable<Claim> UserClaims
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets all Windows device claims from this principal.</summary><returns>A collection of all Windows device claims from this principal.</returns>
        public virtual IEnumerable<Claim> DeviceClaims
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.WindowsPrincipal" /> class by using the specified <see cref="T:System.Security.Principal.WindowsIdentity" /> object.</summary><param name="ntIdentity">The object from which to construct the new instance of <see cref="T:System.Security.Principal.WindowsPrincipal" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="ntIdentity" /> is null. </exception>
        public WindowsPrincipal(WindowsIdentity ntIdentity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current principal belongs to the Windows user group with the specified name.</summary><returns>true if the current principal is a member of the specified Windows user group; otherwise, false.</returns><param name="role">The name of the Windows user group for which to check membership. </param><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public override bool IsInRole(string role)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current principal belongs to the Windows user group with the specified <see cref="T:System.Security.Principal.WindowsBuiltInRole" />.</summary><returns>true if the current principal is a member of the specified Windows user group; otherwise, false.</returns><param name="role">One of the <see cref="T:System.Security.Principal.WindowsBuiltInRole" /> values. </param><exception cref="T:System.ArgumentException"><paramref name="role" /> is not a valid <see cref="T:System.Security.Principal.WindowsBuiltInRole" /> value.</exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public virtual bool IsInRole(WindowsBuiltInRole role)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current principal belongs to the Windows user group with the specified relative identifier (RID).</summary><returns>true if the current principal is a member of the specified Windows user group, that is, in a particular role; otherwise, false.</returns><param name="rid">The RID of the Windows user group in which to check for the principal’s membership status. </param><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public virtual bool IsInRole(int rid)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current principal belongs to the Windows user group with the specified security identifier (SID).</summary><returns>true if the current principal is a member of the specified Windows user group; otherwise, false.</returns><param name="sid">A <see cref="T:System.Security.Principal.SecurityIdentifier" />  that uniquely identifies a Windows user group.</param><exception cref="T:System.ArgumentNullException"><paramref name="sid" /> is null.</exception><exception cref="T:System.Security.SecurityException">Windows returned a Win32 error.</exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [ComVisibleAttribute(false)]
        [SecuritySafeCriticalAttribute()]
        public virtual bool IsInRole(SecurityIdentifier sid)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
