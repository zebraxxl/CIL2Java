using System.Runtime.InteropServices;
using System;

namespace System.Security.Principal
{
    /// <summary>Represents an identity and is the base class for the <see cref="T:System.Security.Principal.NTAccount" /> and <see cref="T:System.Security.Principal.SecurityIdentifier" /> classes. This class does not provide a public constructor, and therefore cannot be inherited.</summary>
    [ComVisibleAttribute(false)]
    public abstract class IdentityReference
    {
        /// <summary>Gets the string value of the identity represented by the <see cref="T:System.Security.Principal.IdentityReference" /> object.</summary><returns>The string value of the identity represented by the <see cref="T:System.Security.Principal.IdentityReference" /> object.</returns>
        public abstract string Value
        {
            get;
        }
    
    
        /// <summary>Returns a value that indicates whether the specified type is a valid translation type for the <see cref="T:System.Security.Principal.IdentityReference" /> class.</summary><returns>true if <paramref name="targetType" /> is a valid translation type for the <see cref="T:System.Security.Principal.IdentityReference" /> class; otherwise, false.</returns><param name="targetType">The type being queried for validity to serve as a conversion from <see cref="T:System.Security.Principal.IdentityReference" />. The following target types are valid:<see cref="T:System.Security.Principal.NTAccount" /><see cref="T:System.Security.Principal.SecurityIdentifier" /></param>
        public abstract bool IsValidTargetType(Type targetType);
        
        
        /// <summary>Translates the account name represented by the <see cref="T:System.Security.Principal.IdentityReference" /> object into another <see cref="T:System.Security.Principal.IdentityReference" />-derived type.</summary><returns>The converted identity.</returns><param name="targetType">The target type for the conversion from <see cref="T:System.Security.Principal.IdentityReference" />. </param>
        public abstract IdentityReference Translate(Type targetType);
        
        
        /// <summary>Returns a value that indicates whether the specified object equals this instance of the <see cref="T:System.Security.Principal.IdentityReference" /> class.</summary><returns>true if <paramref name="o" /> is an object with the same underlying type and value as this <see cref="T:System.Security.Principal.IdentityReference" /> instance; otherwise, false.</returns><param name="o">An object to compare with this <see cref="T:System.Security.Principal.IdentityReference" /> instance, or a null reference.</param>
        public abstract override bool Equals(object o);


        public abstract override int GetHashCode();


        public abstract override string ToString();
        
        
        /// <summary>Compares two <see cref="T:System.Security.Principal.IdentityReference" /> objects to determine whether they are equal. They are considered equal if they have the same canonical name representation as the one returned by the <see cref="P:System.Security.Principal.IdentityReference.Value" /> property or if they are both null.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, false.</returns><param name="left">The left <see cref="T:System.Security.Principal.IdentityReference" /> operand to use for the equality comparison. This parameter can be null.</param><param name="right">The right <see cref="T:System.Security.Principal.IdentityReference" /> operand to use for the equality comparison. This parameter can be null.</param>
        /// <summary>Compares two <see cref="T:System.Security.Principal.IdentityReference" /> objects to determine whether they are equal. They are considered equal if they have the same canonical name representation as the one returned by the <see cref="P:System.Security.Principal.IdentityReference.Value" /> property or if they are both null.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, false.</returns><param name="left">The left <see cref="T:System.Security.Principal.IdentityReference" /> operand to use for the equality comparison. This parameter can be null.</param><param name="right">The right <see cref="T:System.Security.Principal.IdentityReference" /> operand to use for the equality comparison. This parameter can be null.</param>
        public static bool operator ==(IdentityReference left, IdentityReference right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares two <see cref="T:System.Security.Principal.IdentityReference" /> objects to determine whether they are not equal. They are considered not equal if they have different canonical name representations than the one returned by the <see cref="P:System.Security.Principal.IdentityReference.Value" /> property or if one of the objects is null and the other is not.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns><param name="left">The left <see cref="T:System.Security.Principal.IdentityReference" /> operand to use for the inequality comparison. This parameter can be null.</param><param name="right">The right <see cref="T:System.Security.Principal.IdentityReference" /> operand to use for the inequality comparison. This parameter can be null.</param>
        /// <summary>Compares two <see cref="T:System.Security.Principal.IdentityReference" /> objects to determine whether they are not equal. They are considered not equal if they have different canonical name representations than the one returned by the <see cref="P:System.Security.Principal.IdentityReference.Value" /> property or if one of the objects is null and the other is not.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns><param name="left">The left <see cref="T:System.Security.Principal.IdentityReference" /> operand to use for the inequality comparison. This parameter can be null.</param><param name="right">The right <see cref="T:System.Security.Principal.IdentityReference" /> operand to use for the inequality comparison. This parameter can be null.</param>
        public static bool operator !=(IdentityReference left, IdentityReference right)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
