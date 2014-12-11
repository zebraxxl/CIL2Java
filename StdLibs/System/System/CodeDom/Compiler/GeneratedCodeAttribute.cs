using System;

namespace System.CodeDom.Compiler
{
    [AttributeUsageAttribute(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
    public sealed class GeneratedCodeAttribute : Attribute
    {
    
        public string Tool
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Version
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public GeneratedCodeAttribute(string tool, string version)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
