using System.Runtime.InteropServices;

namespace System.Security
{
    /// <summary>Defines the methods that convert permission object state to and from XML element representation.</summary>
    [ComVisibleAttribute(true)]
    public interface ISecurityEncodable
    {
        SecurityElement ToXml();
        
        
        /// <summary>Reconstructs a security object with a specified state from an XML encoding.</summary><param name="e">The XML encoding to use to reconstruct the security object. </param>
        void FromXml(SecurityElement e);
        
        
    }
}
