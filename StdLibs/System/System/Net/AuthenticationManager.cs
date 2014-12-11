using System.Collections.Specialized;
using System.Collections;

namespace System.Net
{
    public class AuthenticationManager
    {
    
        public static ICredentialPolicy CredentialPolicy
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public static StringDictionary CustomTargetNameDictionary
        {
            get { throw new NotImplementedException(); }
        }
    
        public static IEnumerator RegisteredModules
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials)
        {
             throw new NotImplementedException();
        }
        
        
        public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials)
        {
             throw new NotImplementedException();
        }
        
        
        public static void Register(IAuthenticationModule authenticationModule)
        {
             throw new NotImplementedException();
        }
        
        
        public static void Unregister(IAuthenticationModule authenticationModule)
        {
             throw new NotImplementedException();
        }
        
        
        public static void Unregister(string authenticationScheme)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
