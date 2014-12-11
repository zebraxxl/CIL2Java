
namespace System
{
    public abstract class UriParser
    {
    
    
        protected UriParser()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual UriParser OnNewUri()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnRegister(string schemeName, int defaultPort)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void InitializeAndValidate(Uri uri, ref UriFormatException parsingError)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual string Resolve(Uri baseUri, Uri relativeUri, ref UriFormatException parsingError)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual bool IsBaseOf(Uri baseUri, Uri relativeUri)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual string GetComponents(Uri uri, UriComponents components, UriFormat format)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual bool IsWellFormedOriginalString(Uri uri)
        {
             throw new NotImplementedException();
        }
        
        
        public static void Register(UriParser uriParser, string schemeName, int defaultPort)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool IsKnownScheme(string schemeName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
