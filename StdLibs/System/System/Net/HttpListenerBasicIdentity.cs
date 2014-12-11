using System.Security.Principal;

namespace System.Net
{
    public class HttpListenerBasicIdentity : GenericIdentity
    {
    
        public virtual string Password
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public HttpListenerBasicIdentity(string username, string password)
            : base(username)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
