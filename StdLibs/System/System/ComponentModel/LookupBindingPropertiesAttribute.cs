using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Class)]
    public sealed class LookupBindingPropertiesAttribute : Attribute
    {
        public static readonly LookupBindingPropertiesAttribute Default;
    
        public string DataSource
        {
            get { throw new NotImplementedException(); }
        }
    
        public string DisplayMember
        {
            get { throw new NotImplementedException(); }
        }
    
        public string ValueMember
        {
            get { throw new NotImplementedException(); }
        }
    
        public string LookupMember
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public LookupBindingPropertiesAttribute()
        {
             throw new NotImplementedException();
        }
        
        
        public LookupBindingPropertiesAttribute(string dataSource, string displayMember, string valueMember, string lookupMember)
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
