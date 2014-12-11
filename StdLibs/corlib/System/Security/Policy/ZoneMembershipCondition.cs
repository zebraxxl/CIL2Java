using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Policy
{
    /// <summary>Determines whether an assembly belongs to a code group by testing its zone of origin. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class ZoneMembershipCondition
    {
    
        /// <summary>Gets or sets the zone for which the membership condition tests.</summary><returns>The zone for which the membership condition tests.</returns><exception cref="T:System.ArgumentNullException">The value is null. </exception><exception cref="T:System.ArgumentException">An attempt is made to set <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> to an invalid <see cref="T:System.Security.SecurityZone" />. </exception>
        public SecurityZone SecurityZone
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.ZoneMembershipCondition" /> class with the zone that determines membership.</summary><param name="zone">The <see cref="T:System.Security.SecurityZone" /> for which to test. </param><exception cref="T:System.ArgumentException">The <paramref name="zone" /> parameter is not a valid <see cref="T:System.Security.SecurityZone" />. </exception>
        public ZoneMembershipCondition(SecurityZone zone)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified evidence satisfies the membership condition.</summary><returns>true if the specified evidence satisfies the membership condition; otherwise, false.</returns><param name="evidence">The evidence set against which to make the test. </param><exception cref="T:System.ArgumentNullException">The <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> property is null. </exception><exception cref="T:System.ArgumentException">The <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> property is not a valid <see cref="T:System.Security.SecurityZone" />. </exception>
        public bool Check(Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        public IMembershipCondition Copy()
        {
             throw new NotImplementedException();
        }
        
        
        public SecurityElement ToXml()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs a security object with a specified state from an XML encoding.</summary><param name="e">The XML encoding to use to reconstruct the security object. </param><exception cref="T:System.ArgumentNullException">The <paramref name="e" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="e" /> parameter is not a valid membership condition element.</exception>
        public void FromXml(SecurityElement e)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an XML encoding of the security object and its current state with the specified <see cref="T:System.Security.Policy.PolicyLevel" />.</summary><returns>An XML encoding of the security object, including any state information.</returns><param name="level">The policy level context for resolving named permission set references. </param><exception cref="T:System.ArgumentNullException">The <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> property is null. </exception><exception cref="T:System.ArgumentException">The <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> property is not a valid <see cref="T:System.Security.SecurityZone" />. </exception>
        public SecurityElement ToXml(PolicyLevel level)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs a security object with a specified state from an XML encoding.</summary><param name="e">The XML encoding to use to reconstruct the security object. </param><param name="level">The policy level context used to resolve named permission set references. </param><exception cref="T:System.ArgumentNullException">The <paramref name="e" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="e" /> parameter is not a valid membership condition element. </exception>
        public void FromXml(SecurityElement e, PolicyLevel level)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the zone from the specified object is equivalent to the zone contained in the current <see cref="T:System.Security.Policy.ZoneMembershipCondition" />.</summary><returns>true if the zone from the specified object is equivalent to the zone contained in the current <see cref="T:System.Security.Policy.ZoneMembershipCondition" />; otherwise, false.</returns><param name="o">The object to compare to the current <see cref="T:System.Security.Policy.ZoneMembershipCondition" />. </param><exception cref="T:System.ArgumentNullException">The <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> property for the current object or the specified object is null. </exception><exception cref="T:System.ArgumentException">The <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> property for the current object or the specified object is not a valid <see cref="T:System.Security.SecurityZone" />. </exception>
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
        
        
    }
}
