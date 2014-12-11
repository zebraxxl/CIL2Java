using System.Runtime.InteropServices;
using System.Security.Policy;

namespace System.Security
{
    /// <summary>Gets an object's <see cref="T:System.Security.Policy.Evidence" />.</summary>
    [ComVisibleAttribute(true)]
    public interface IEvidenceFactory
    {
        /// <summary>Gets <see cref="T:System.Security.Policy.Evidence" /> that verifies the current object's identity.</summary><returns><see cref="T:System.Security.Policy.Evidence" /> of the current object's identity.</returns>
        Evidence Evidence
        {
            get;
        }
    
    
    }
}
