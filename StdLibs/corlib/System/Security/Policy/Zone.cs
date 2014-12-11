using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Security.Policy
{
    /// <summary>Provides the security zone of a code assembly as evidence for policy evaluation. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class Zone : EvidenceBase, IIdentityPermissionFactory
    {
    
        /// <summary>Gets the zone from which the code assembly originates.</summary><returns>The zone from which the code assembly originates.</returns>
        public SecurityZone SecurityZone
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.Zone" /> class with the zone from which a code assembly originates.</summary><param name="zone">The zone of origin for the associated code assembly. </param><exception cref="T:System.ArgumentException">The <paramref name="zone" /> parameter is not a valid <see cref="T:System.Security.SecurityZone" />. </exception>
        public Zone(SecurityZone zone)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new zone with the specified URL.</summary><returns>A new zone with the specified URL.</returns><param name="url">The URL from which to create the zone. </param><exception cref="T:System.ArgumentNullException">The <paramref name="url" /> parameter is null. </exception>
        public static Zone CreateFromUrl(string url)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an identity permission that corresponds to the current instance of the <see cref="T:System.Security.Policy.Zone" /> evidence class.</summary><returns>A <see cref="T:System.Security.Permissions.ZoneIdentityPermission" /> for the specified <see cref="T:System.Security.Policy.Zone" /> evidence.</returns><param name="evidence">The evidence set from which to construct the identity permission. </param>
        public IPermission CreateIdentityPermission(Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares the current <see cref="T:System.Security.Policy.Zone" /> evidence object to the specified object for equivalence.</summary><returns>true if the two <see cref="T:System.Security.Policy.Zone" /> objects are equal; otherwise, false.</returns><param name="o">The <see cref="T:System.Security.Policy.Zone" /> evidence object to test for equivalence with the current object. </param><exception cref="T:System.ArgumentException">The <paramref name="o" /> parameter is not a <see cref="T:System.Security.Policy.Zone" /> object. </exception>
        public override bool Equals(object o)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
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
        
        
    }
}
