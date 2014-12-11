using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Method)]
    public sealed class DataObjectMethodAttribute : Attribute
    {
    
        public bool IsDefault
        {
            get { throw new NotImplementedException(); }
        }
    
        public DataObjectMethodType MethodType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DataObjectMethodAttribute(DataObjectMethodType methodType)
        {
             throw new NotImplementedException();
        }
        
        
        public DataObjectMethodAttribute(DataObjectMethodType methodType, bool isDefault)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Match(object obj)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
