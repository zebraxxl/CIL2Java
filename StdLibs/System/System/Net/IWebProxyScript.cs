using System;

namespace System.Net
{
    public interface IWebProxyScript
    {
        bool Load(Uri scriptLocation, string script, Type helperType);
        
        
        string Run(string url, string host);
        
        
        void Close();
        
        
    }
}
