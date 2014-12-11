using System.Net;
using System;

namespace Microsoft.Win32
{
    public class IntranetZoneCredentialPolicy : ICredentialPolicy
    {
    
        public IntranetZoneCredentialPolicy()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool ShouldSendCredential(Uri challengeUri, WebRequest request, NetworkCredential credential, IAuthenticationModule authModule)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
