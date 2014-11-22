using System.Runtime.InteropServices;
using System;
using System.Security;

namespace System.Security.Principal
{
    /// <summary>Represents a user or group account.</summary>
    [ComVisibleAttribute(false)]
    public sealed class NTAccount : IdentityReference
    {
    
        /// <summary>Returns an uppercase string representation of this <see cref="T:System.Security.Principal.NTAccount" /> object.</summary><returns>The uppercase string representation of this <see cref="T:System.Security.Principal.NTAccount" /> object.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public override string Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.NTAccount" /> class by using the specified domain name and account name. </summary><param name="domainName">The name of the domain. This parameter can be null or an empty string. Domain names that are null values are treated like an empty string.</param><param name="accountName">The name of the account. This parameter cannot be null or an empty string.</param><exception cref="T:System.ArgumentNullException"><paramref name="accountName" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="accountName" /> is an empty string.-or-<paramref name="accountName" /> is too long.-or-<paramref name="domainName" /> is too long.</exception>
        public NTAccount(string domainName, string accountName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.NTAccount" /> class by using the specified name.</summary><param name="name">The name used to create the <see cref="T:System.Security.Principal.NTAccount" /> object. This parameter cannot be null or an empty string.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="name" /> is an empty string.-or-<paramref name="name" /> is too long.</exception>
        public NTAccount(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether the specified type is a valid translation type for the <see cref="T:System.Security.Principal.NTAccount" /> class.</summary><returns>true if <paramref name="targetType" /> is a valid translation type for the <see cref="T:System.Security.Principal.NTAccount" /> class; otherwise false.</returns><param name="targetType">The type being queried for validity to serve as a conversion from <see cref="T:System.Security.Principal.NTAccount" />. The following target types are valid:- <see cref="T:System.Security.Principal.NTAccount" />- <see cref="T:System.Security.Principal.SecurityIdentifier" /></param>
        public override bool IsValidTargetType(Type targetType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Translates the account name represented by the <see cref="T:System.Security.Principal.NTAccount" /> object into another <see cref="T:System.Security.Principal.IdentityReference" />-derived type.</summary><returns>The converted identity.</returns><param name="targetType">The target type for the conversion from <see cref="T:System.Security.Principal.NTAccount" />. The target type must be a type that is considered valid by the <see cref="M:System.Security.Principal.NTAccount.IsValidTargetType(System.Type)" /> method. </param><exception cref="T:System.ArgumentNullException"><paramref name="targetType " />is null.</exception><exception cref="T:System.ArgumentException"><paramref name="targetType " />is not an <see cref="T:System.Security.Principal.IdentityReference" />  type.</exception><exception cref="T:System.Security.Principal.IdentityNotMappedException">Some or all identity references could not be translated.</exception><exception cref="T:System.SystemException">The source account name is too long.-or-A Win32 error code was returned.</exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public override IdentityReference Translate(Type targetType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether this <see cref="T:System.Security.Principal.NTAccount" /> object is equal to a specified object.</summary><returns>true if <paramref name="o" /> is an object with the same underlying type and value as this <see cref="T:System.Security.Principal.NTAccount" /> object; otherwise, false.</returns><param name="o">An object to compare with this <see cref="T:System.Security.Principal.NTAccount" /> object, or null.</param>
        public override bool Equals(object o)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares two <see cref="T:System.Security.Principal.NTAccount" /> objects to determine whether they are equal. They are considered equal if they have the same canonical name representation as the one returned by the <see cref="P:System.Security.Principal.NTAccount.Value" /> property or if they are both null. </summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise false.</returns><param name="left">The left operand to use for the equality comparison. This parameter can be null.</param><param name="right">The right operand to use for the equality comparison. This parameter can be null.</param>
        /// <summary>Compares two <see cref="T:System.Security.Principal.NTAccount" /> objects to determine whether they are equal. They are considered equal if they have the same canonical name representation as the one returned by the <see cref="P:System.Security.Principal.NTAccount.Value" /> property or if they are both null. </summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise false.</returns><param name="left">The left operand to use for the equality comparison. This parameter can be null.</param><param name="right">The right operand to use for the equality comparison. This parameter can be null.</param>
        public static bool operator ==(NTAccount left, NTAccount right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares two <see cref="T:System.Security.Principal.NTAccount" /> objects to determine whether they are not equal. They are considered not equal if they have different canonical name representations than the one returned by the <see cref="P:System.Security.Principal.NTAccount.Value" /> property or if one of the objects is null and the other is not.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise false.</returns><param name="left">The left operand to use for the inequality comparison. This parameter can be null.</param><param name="right">The right operand to use for the inequality comparison. This parameter can be null.</param>
        /// <summary>Compares two <see cref="T:System.Security.Principal.NTAccount" /> objects to determine whether they are not equal. They are considered not equal if they have different canonical name representations than the one returned by the <see cref="P:System.Security.Principal.NTAccount.Value" /> property or if one of the objects is null and the other is not.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise false.</returns><param name="left">The left operand to use for the inequality comparison. This parameter can be null.</param><param name="right">The right operand to use for the inequality comparison. This parameter can be null.</param>
        public static bool operator !=(NTAccount left, NTAccount right)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
