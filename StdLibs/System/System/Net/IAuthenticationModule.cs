
namespace System.Net
{
    public interface IAuthenticationModule
    {
        bool CanPreAuthenticate
        {
            get;
        }
    
        string AuthenticationType
        {
            get;
        }
    
    
        Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials);
        
        
        Authorization PreAuthenticate(WebRequest request, ICredentials credentials);
        
        
    }
}
