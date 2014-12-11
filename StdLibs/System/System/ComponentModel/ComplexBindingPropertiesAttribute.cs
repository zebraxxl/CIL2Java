using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Class)]
    public sealed class ComplexBindingPropertiesAttribute : Attribute
    {
        public static readonly ComplexBindingPropertiesAttribute Default;
    
        public string DataSource
        {
            get { throw new NotImplementedException(); }
        }
    
        public string DataMember
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ComplexBindingPropertiesAttribute()
        {
             throw new NotImplementedException();
        }
        
        
        public ComplexBindingPropertiesAttribute(string dataSource)
        {
             throw new NotImplementedException();
        }
        
        
        public ComplexBindingPropertiesAttribute(string dataSource, string dataMember)
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
        
        
    }
}
