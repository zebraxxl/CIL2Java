using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Runtime.Serialization;
using System;
using System.Runtime.CompilerServices;
using System.Security;
using Microsoft.Win32.SafeHandles;
using System.Collections.Generic;

namespace System.Security.Principal
{
    /// <summary>Represents a Windows user.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class WindowsIdentity : ClaimsIdentity, ISerializable, IDeserializationCallback, IDisposable
    {
        /// <summary>Identifies the name of the default <see cref="T:System.Security.Claims.ClaimsIdentity" /> issuer.</summary><returns>NT_AUTHORITY.</returns>
        public new const string DefaultIssuer = "AD AUTHORITY";
    
        /// <summary>Gets the type of authentication used to identify the user.</summary><returns>The type of authentication used to identify the user.</returns><exception cref="T:System.UnauthorizedAccessException">Windows returned the Windows NT status code STATUS_ACCESS_DENIED.</exception><exception cref="T:System.OutOfMemoryException">There is insufficient memory available.</exception><exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions. -or-The computer is not attached to a Windows 2003 or later domain.-or-The computer is not running Windows 2003 or later.-or-The user is not a member of the domain the computer is attached to.</exception>
        public override string AuthenticationType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the impersonation level for the user.</summary><returns>One of the enumeration values that specifies the impersonation level. </returns>
        [ComVisibleAttribute(false)]
        public TokenImpersonationLevel ImpersonationLevel
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the user has been authenticated by Windows.</summary><returns>true if the user was authenticated; otherwise, false.</returns>
        public override bool IsAuthenticated
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the user account is identified as a <see cref="F:System.Security.Principal.WindowsAccountType.Guest" /> account by the system.</summary><returns>true if the user account is a <see cref="F:System.Security.Principal.WindowsAccountType.Guest" /> account; otherwise, false.</returns>
        public virtual bool IsGuest
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the user account is identified as a <see cref="F:System.Security.Principal.WindowsAccountType.System" /> account by the system.</summary><returns>true if the user account is a <see cref="F:System.Security.Principal.WindowsAccountType.System" /> account; otherwise, false.</returns>
        public virtual bool IsSystem
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the user account is identified as an anonymous account by the system.</summary><returns>true if the user account is an anonymous account; otherwise, false.</returns>
        public virtual bool IsAnonymous
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the user's Windows logon name.</summary><returns>The Windows logon name of the user on whose behalf the code is being run.</returns>
        public override string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the security identifier (SID) for the token owner.</summary><returns>An object for the token owner.</returns>
        [ComVisibleAttribute(false)]
        public SecurityIdentifier Owner
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the security identifier (SID) for the user.</summary><returns>An object for the user.</returns>
        [ComVisibleAttribute(false)]
        public SecurityIdentifier User
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the groups the current Windows user belongs to.</summary><returns>An object representing the groups the current Windows user belongs to.</returns>
        public IdentityReferenceCollection Groups
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the Windows account token for the user.</summary><returns>The handle of the access token associated with the current execution thread.</returns>
        public virtual IntPtr Token
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets claims that have the <see cref="F:System.Security.Claims.ClaimTypes.WindowsUserClaim" /> property key.</summary><returns>A collection of claims that have the <see cref="F:System.Security.Claims.ClaimTypes.WindowsUserClaim" /> property key.</returns>
        public virtual IEnumerable<Claim> UserClaims
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets claims that have the <see cref="F:System.Security.Claims.ClaimTypes.WindowsDeviceClaim" /> property key.</summary><returns>A collection of claims that have the <see cref="F:System.Security.Claims.ClaimTypes.WindowsDeviceClaim" /> property key.</returns>
        public virtual IEnumerable<Claim> DeviceClaims
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets all claims for the user represented by this Windows identity.</summary><returns>A collection of claims for this <see cref="T:System.Security.Principal.WindowsIdentity" /> object.</returns>
        public override IEnumerable<Claim> Claims
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.WindowsIdentity" /> class for the user represented by the specified Windows account token.</summary><param name="userToken">The account token for the user on whose behalf the code is running. </param><exception cref="T:System.ArgumentException"><paramref name="userToken" /> is 0.-or-<paramref name="userToken" /> is duplicated and invalid for impersonation.</exception><exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions. -or-A Win32 error occurred.</exception>
        [SecuritySafeCriticalAttribute()]
        public WindowsIdentity(IntPtr userToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.WindowsIdentity" /> class for the user represented by the specified Windows account token and the specified authentication type.</summary><param name="userToken">The account token for the user on whose behalf the code is running. </param><param name="type">(Informational use only.) The type of authentication used to identify the user. For more information, see Remarks.</param><exception cref="T:System.ArgumentException"><paramref name="userToken" /> is 0.-or-<paramref name="userToken" /> is duplicated and invalid for impersonation.</exception><exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions. -or-A Win32 error occurred.</exception>
        [SecuritySafeCriticalAttribute()]
        public WindowsIdentity(IntPtr userToken, string type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.WindowsIdentity" /> class for the user represented by the specified Windows account token, the specified authentication type, and the specified Windows account type.</summary><param name="userToken">The account token for the user on whose behalf the code is running. </param><param name="type">(Informational use only.) The type of authentication used to identify the user. For more information, see Remarks.</param><param name="acctType">One of the enumeration values. </param><exception cref="T:System.ArgumentException"><paramref name="userToken" /> is 0.-or-<paramref name="userToken" /> is duplicated and invalid for impersonation.</exception><exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions. -or-A Win32 error occurred.</exception>
        [SecuritySafeCriticalAttribute()]
        public WindowsIdentity(IntPtr userToken, string type, WindowsAccountType acctType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.WindowsIdentity" /> class for the user represented by the specified Windows account token, the specified authentication type, the specified Windows account type, and the specified authentication status.</summary><param name="userToken">The account token for the user on whose behalf the code is running. </param><param name="type">(Informational use only.) The type of authentication used to identify the user. For more information, see Remarks.</param><param name="acctType">One of the enumeration values. </param><param name="isAuthenticated">true to indicate that the user is authenticated; otherwise, false. </param><exception cref="T:System.ArgumentException"><paramref name="userToken" /> is 0.-or-<paramref name="userToken" /> is duplicated and invalid for impersonation.</exception><exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions. -or-A Win32 error occurred.</exception>
        [SecuritySafeCriticalAttribute()]
        public WindowsIdentity(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.WindowsIdentity" /> class for the user represented by the specified User Principal Name (UPN).</summary><param name="sUserPrincipalName">The UPN for the user on whose behalf the code is running. </param><exception cref="T:System.UnauthorizedAccessException">Windows returned the Windows NT status code STATUS_ACCESS_DENIED.</exception><exception cref="T:System.OutOfMemoryException">There is insufficient memory available.</exception><exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions. -or-The computer is not attached to a Windows 2003 or later domain.-or-The computer is not running Windows 2003 or later.-or-The user is not a member of the domain the computer is attached to.</exception>
        [SecuritySafeCriticalAttribute()]
        public WindowsIdentity(string sUserPrincipalName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.WindowsIdentity" /> class for the user represented by the specified User Principal Name (UPN) and the specified authentication type.</summary><param name="sUserPrincipalName">The UPN for the user on whose behalf the code is running. </param><param name="type">(Informational use only.) The type of authentication used to identify the user. For more information, see Remarks.</param><exception cref="T:System.UnauthorizedAccessException">Windows returned the Windows NT status code STATUS_ACCESS_DENIED.</exception><exception cref="T:System.OutOfMemoryException">There is insufficient memory available.</exception><exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions. -or-The computer is not attached to a Windows 2003 or later domain.-or-The computer is not running Windows 2003 or later.-or-The user is not a member of the domain the computer is attached to.</exception>
        [SecuritySafeCriticalAttribute()]
        public WindowsIdentity(string sUserPrincipalName, string type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.WindowsIdentity" /> class for the user represented by information in a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> stream.</summary><param name="info">The object containing the account information for the user. </param><param name="context">An object that indicates the stream characteristics. </param><exception cref="T:System.NotSupportedException">A <see cref="T:System.Security.Principal.WindowsIdentity" /> cannot be serialized across processes. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions. -or-A Win32 error occurred.</exception>
        [SecuritySafeCriticalAttribute()]
        public WindowsIdentity(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static WindowsIdentity GetCurrent()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.Security.Principal.WindowsIdentity" /> object that represents the Windows identity for either the thread or the process, depending on the value of the <paramref name="ifImpersonating" /> parameter.</summary><returns>An object that represents a Windows user.</returns><param name="ifImpersonating">true to return the <see cref="T:System.Security.Principal.WindowsIdentity" /> only if the thread is currently impersonating; false to return the <see cref="T:System.Security.Principal.WindowsIdentity" />   of the thread if it is impersonating or the <see cref="T:System.Security.Principal.WindowsIdentity" /> of the process if the thread is not currently impersonating.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlPrincipal" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static WindowsIdentity GetCurrent(bool ifImpersonating)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.Security.Principal.WindowsIdentity" /> object that represents the current Windows user, using the specified desired token access level.</summary><returns>An object that represents the current user.</returns><param name="desiredAccess">A bitwise combination of the enumeration values. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlPrincipal" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static WindowsIdentity GetCurrent(TokenAccessLevels desiredAccess)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static WindowsIdentity GetAnonymous()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public virtual WindowsImpersonationContext Impersonate()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Impersonates the user represented by the specified user token.</summary><returns>An object that represents the Windows user prior to impersonation; this object can be used to revert to the original user's context.</returns><param name="userToken">The handle of a Windows account token. This token is usually retrieved through a call to unmanaged code, such as a call to the Win32 API LogonUser function. </param><exception cref="T:System.UnauthorizedAccessException">Windows returned the Windows NT status code STATUS_ACCESS_DENIED.</exception><exception cref="T:System.OutOfMemoryException">There is insufficient memory available.</exception><exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlPrincipal" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static WindowsImpersonationContext Impersonate(IntPtr userToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Principal.WindowsIdentity" /> and optionally releases the managed resources. </summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.WindowsIdentity" /> class by using the specified <see cref="T:System.Security.Principal.WindowsIdentity" /> object.</summary><param name="identity">The object from which to construct the new instance of <see cref="T:System.Security.Principal.WindowsIdentity" />.</param>
        [SecuritySafeCriticalAttribute()]
        protected WindowsIdentity(WindowsIdentity identity)
        {
             throw new NotImplementedException();
        }
        
        
        public override ClaimsIdentity Clone()
        {
             throw new NotImplementedException();
        }



        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        void IDeserializationCallback.OnDeserialization(object sender)
        {
            throw new NotImplementedException();
        }
    }
}
