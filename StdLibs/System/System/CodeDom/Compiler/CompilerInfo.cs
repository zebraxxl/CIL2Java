using System;
using System.Collections.Generic;

namespace System.CodeDom.Compiler
{
    public sealed class CompilerInfo
    {
    
        public Type CodeDomProviderType
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsCodeDomProviderTypeValid
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public string[] GetLanguages()
        {
             throw new NotImplementedException();
        }
        
        
        public string[] GetExtensions()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeDomProvider CreateProvider()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeDomProvider CreateProvider(IDictionary<string, string> providerOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public CompilerParameters CreateDefaultCompilerParameters()
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object o)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
