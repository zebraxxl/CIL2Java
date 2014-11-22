using System.Runtime.InteropServices;
using System.Collections;
using System.Security;

namespace System.Security.Policy
{
    /// <summary>Represents the enumerator for <see cref="T:System.Security.Policy.ApplicationTrust" /> objects in the <see cref="T:System.Security.Policy.ApplicationTrustCollection" /> collection.</summary>
    [ComVisibleAttribute(true)]
    public sealed class ApplicationTrustEnumerator : IEnumerator
    {
    
        /// <summary>Gets the current <see cref="T:System.Security.Policy.ApplicationTrust" /> object in the <see cref="T:System.Security.Policy.ApplicationTrustCollection" /> collection.</summary><returns>The current <see cref="T:System.Security.Policy.ApplicationTrust" /> in the <see cref="T:System.Security.Policy.ApplicationTrustCollection" />.</returns>
        public ApplicationTrust Current
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [SecuritySafeCriticalAttribute()]
        public bool MoveNext()
        {
             throw new NotImplementedException();
        }
        
        
        public void Reset()
        {
             throw new NotImplementedException();
        }



        object IEnumerator.Current
        {
            get { throw new NotImplementedException(); }
        }

        bool IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }
    }
}
