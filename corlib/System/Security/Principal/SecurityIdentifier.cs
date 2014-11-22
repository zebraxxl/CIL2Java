using System.Runtime.InteropServices;
using System;
using System.Security;

namespace System.Security.Principal
{
    /// <summary>Represents a security identifier (SID) and provides marshaling and comparison operations for SIDs.</summary>
    [ComVisibleAttribute(false)]
    public sealed class SecurityIdentifier : IdentityReference, IComparable<SecurityIdentifier>
    {
        /// <summary>Returns the minimum size, in bytes, of the binary representation of the security identifier.</summary>
        public static readonly int MinBinaryLength;
        /// <summary>Returns the maximum size, in bytes, of the binary representation of the security identifier.</summary>
        public static readonly int MaxBinaryLength;
    
        /// <summary>Returns the length, in bytes, of the security identifier (SID) represented by the <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</summary><returns>The length, in bytes, of the SID represented by the <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</returns>
        public int BinaryLength
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the account domain security identifier (SID) portion from the SID represented by the <see cref="T:System.Security.Principal.SecurityIdentifier" /> object if the SID represents a Windows account SID. If the SID does not represent a Windows account SID, this property returns <see cref="T:System.ArgumentNullException" />.</summary><returns>The account domain SID portion from the SID represented by the <see cref="T:System.Security.Principal.SecurityIdentifier" /> object if the SID represents a Windows account SID; otherwise, it returns <see cref="T:System.ArgumentNullException" />.</returns>
        public SecurityIdentifier AccountDomainSid
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns an uppercase Security Descriptor Definition Language (SDDL) string for the security identifier (SID) represented by this <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</summary><returns>An uppercase SDDL string for the SID represented by the <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public override string Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.SecurityIdentifier" /> class by using the specified security identifier (SID) in Security Descriptor Definition Language (SDDL) format.</summary><param name="sddlForm">SDDL string for the SID used to create the <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</param>
        [SecuritySafeCriticalAttribute()]
        public SecurityIdentifier(string sddlForm)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.SecurityIdentifier" /> class by using a specified binary representation of a security identifier (SID).</summary><param name="binaryForm">The byte array that represents the SID.</param><param name="offset">The byte offset to use as the starting index in <paramref name="binaryForm" />. </param>
        public SecurityIdentifier(byte[] binaryForm, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.SecurityIdentifier" /> class by using an integer that represents the binary form of a security identifier (SID).</summary><param name="binaryForm">An integer that represents the binary form of a SID.</param>
        [SecuritySafeCriticalAttribute()]
        public SecurityIdentifier(IntPtr binaryForm)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.SecurityIdentifier" /> class by using the specified well known security identifier (SID) type and domain SID.</summary><param name="sidType">One of the enumeration values. This value must not be <see cref="F:System.Security.Principal.WellKnownSidType.LogonIdsSid" />.</param><param name="domainSid">The domain SID. This value is required for the following <see cref="T:System.Security.Principal.WellKnownSidType" /> values. This parameter is ignored for any other <see cref="T:System.Security.Principal.WellKnownSidType" /> values.- <see cref="F:System.Security.Principal.WellKnownSidType.AccountAdministratorSid" />- <see cref="F:System.Security.Principal.WellKnownSidType.AccountGuestSid" />- <see cref="F:System.Security.Principal.WellKnownSidType.AccountKrbtgtSid" />- <see cref="F:System.Security.Principal.WellKnownSidType.AccountDomainAdminsSid" />- <see cref="F:System.Security.Principal.WellKnownSidType.AccountDomainUsersSid" />- <see cref="F:System.Security.Principal.WellKnownSidType.AccountDomainGuestsSid" />- <see cref="F:System.Security.Principal.WellKnownSidType.AccountComputersSid" />- <see cref="F:System.Security.Principal.WellKnownSidType.AccountControllersSid" />- <see cref="F:System.Security.Principal.WellKnownSidType.AccountCertAdminsSid" />- <see cref="F:System.Security.Principal.WellKnownSidType.AccountSchemaAdminsSid" />- <see cref="F:System.Security.Principal.WellKnownSidType.AccountEnterpriseAdminsSid" />- <see cref="F:System.Security.Principal.WellKnownSidType.AccountPolicyAdminsSid" />- <see cref="F:System.Security.Principal.WellKnownSidType.AccountRasAndIasServersSid" /></param>
        [SecuritySafeCriticalAttribute()]
        public SecurityIdentifier(WellKnownSidType sidType, SecurityIdentifier domainSid)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether this <see cref="T:System.Security.Principal.SecurityIdentifier" /> object is equal to a specified object.</summary><returns>true if <paramref name="o" /> is an object with the same underlying type and value as this <see cref="T:System.Security.Principal.SecurityIdentifier" /> object; otherwise, false.</returns><param name="o">An object to compare with this <see cref="T:System.Security.Principal.SecurityIdentifier" /> object, or null.</param>
        public override bool Equals(object o)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified <see cref="T:System.Security.Principal.SecurityIdentifier" /> object is equal to the current <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</summary><returns>true if the value of <paramref name="sid" /> is equal to the value of the current <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</returns><param name="sid">The object to compare with the current object.</param>
        public bool Equals(SecurityIdentifier sid)
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
        
        
        /// <summary>Returns a value that indicates whether the specified type is a valid translation type for the <see cref="T:System.Security.Principal.SecurityIdentifier" /> class.</summary><returns>true if <paramref name="targetType" /> is a valid translation type for the <see cref="T:System.Security.Principal.SecurityIdentifier" /> class; otherwise, false.</returns><param name="targetType">The type being queried for validity to serve as a conversion from <see cref="T:System.Security.Principal.SecurityIdentifier" />. The following target types are valid:- <see cref="T:System.Security.Principal.NTAccount" />- <see cref="T:System.Security.Principal.SecurityIdentifier" /></param>
        public override bool IsValidTargetType(Type targetType)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public bool IsAccountSid()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Translates the account name represented by the <see cref="T:System.Security.Principal.SecurityIdentifier" /> object into another <see cref="T:System.Security.Principal.IdentityReference" />-derived type.</summary><returns>The converted identity.</returns><param name="targetType">The target type for the conversion from <see cref="T:System.Security.Principal.SecurityIdentifier" />. The target type must be a type that is considered valid by the <see cref="M:System.Security.Principal.SecurityIdentifier.IsValidTargetType(System.Type)" /> method.</param><exception cref="T:System.ArgumentNullException"><paramref name="targetType " />is null.</exception><exception cref="T:System.ArgumentException"><paramref name="targetType " />is not an <see cref="T:System.Security.Principal.IdentityReference" /> type.</exception><exception cref="T:System.Security.Principal.IdentityNotMappedException">Some or all identity references could not be translated.</exception><exception cref="T:System.SystemException">A Win32 error code was returned.</exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public override IdentityReference Translate(Type targetType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares two <see cref="T:System.Security.Principal.SecurityIdentifier" /> objects to determine whether they are equal. They are considered equal if they have the same canonical representation as the one returned by the <see cref="P:System.Security.Principal.SecurityIdentifier.Value" /> property or if they are both null. </summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, false.</returns><param name="left">The left operand to use for the equality comparison. This parameter can be null.</param><param name="right">The right operand to use for the equality comparison. This parameter can be null.</param>
        /// <summary>Compares two <see cref="T:System.Security.Principal.SecurityIdentifier" /> objects to determine whether they are equal. They are considered equal if they have the same canonical representation as the one returned by the <see cref="P:System.Security.Principal.SecurityIdentifier.Value" /> property or if they are both null. </summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, false.</returns><param name="left">The left operand to use for the equality comparison. This parameter can be null.</param><param name="right">The right operand to use for the equality comparison. This parameter can be null.</param>
        public static bool operator ==(SecurityIdentifier left, SecurityIdentifier right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares two <see cref="T:System.Security.Principal.SecurityIdentifier" /> objects to determine whether they are not equal. They are considered not equal if they have different canonical name representations than the one returned by the <see cref="P:System.Security.Principal.SecurityIdentifier.Value" /> property or if one of the objects is null and the other is not.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns><param name="left">The left operand to use for the inequality comparison. This parameter can be null.</param><param name="right">The right operand to use for the inequality comparison. This parameter can be null.</param>
        /// <summary>Compares two <see cref="T:System.Security.Principal.SecurityIdentifier" /> objects to determine whether they are not equal. They are considered not equal if they have different canonical name representations than the one returned by the <see cref="P:System.Security.Principal.SecurityIdentifier.Value" /> property or if one of the objects is null and the other is not.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns><param name="left">The left operand to use for the inequality comparison. This parameter can be null.</param><param name="right">The right operand to use for the inequality comparison. This parameter can be null.</param>
        public static bool operator !=(SecurityIdentifier left, SecurityIdentifier right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares the current <see cref="T:System.Security.Principal.SecurityIdentifier" /> object with the specified <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</summary><returns>A signed number indicating the relative values of this instance and <paramref name="sid" />.Return Value Description Less than zero This instance is less than <paramref name="sid" />. Zero This instance is equal to <paramref name="sid" />. Greater than zero This instance is greater than <paramref name="sid" />. </returns><param name="sid">The object to compare with the current object.</param>
        public int CompareTo(SecurityIdentifier sid)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether the <see cref="T:System.Security.Principal.SecurityIdentifier" /> object matches the specified well known security identifier (SID) type. </summary><returns>true if <paramref name="type" /> is the SID type for the <see cref="T:System.Security.Principal.SecurityIdentifier" /> object; otherwise, false.</returns><param name="type">A value to compare with the <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</param>
        [SecuritySafeCriticalAttribute()]
        public bool IsWellKnown(WellKnownSidType type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the binary representation of the specified security identifier (SID) represented by the <see cref="T:System.Security.Principal.SecurityIdentifier" /> class to a byte array.</summary><param name="binaryForm">The byte array to receive the copied SID.</param><param name="offset">The byte offset to use as the starting index in <paramref name="binaryForm" />. </param>
        public void GetBinaryForm(byte[] binaryForm, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether the security identifier (SID) represented by this <see cref="T:System.Security.Principal.SecurityIdentifier" /> object is from the same domain as the specified SID.</summary><returns>true if the SID represented by this <see cref="T:System.Security.Principal.SecurityIdentifier" /> object is in the same domain as the <paramref name="sid" /> SID; otherwise, false.</returns><param name="sid">The SID to compare with this <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</param>
        [SecuritySafeCriticalAttribute()]
        public bool IsEqualDomainSid(SecurityIdentifier sid)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
