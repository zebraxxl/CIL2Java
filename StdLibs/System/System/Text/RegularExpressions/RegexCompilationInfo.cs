using System.Runtime.Serialization;
using System;

namespace System.Text.RegularExpressions
{
    [Serializable]
    public class RegexCompilationInfo
    {
    
        public string Pattern
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public RegexOptions Options
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string Namespace
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool IsPublic
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public TimeSpan MatchTimeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public RegexCompilationInfo(string pattern, RegexOptions options, string name, string fullnamespace, bool ispublic)
        {
             throw new NotImplementedException();
        }
        
        
        public RegexCompilationInfo(string pattern, RegexOptions options, string name, string fullnamespace, bool ispublic, TimeSpan matchTimeout)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
