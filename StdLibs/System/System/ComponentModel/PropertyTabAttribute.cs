using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.All)]
    public class PropertyTabAttribute : Attribute
    {
    
        public Type[] TabClasses
        {
            get { throw new NotImplementedException(); }
        }
    
        protected string[] TabClassNames
        {
            get { throw new NotImplementedException(); }
        }
    
        public PropertyTabScope[] TabScopes
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public PropertyTabAttribute()
        {
             throw new NotImplementedException();
        }
        
        
        public PropertyTabAttribute(Type tabClass)
        {
             throw new NotImplementedException();
        }
        
        
        public PropertyTabAttribute(string tabClassName)
        {
             throw new NotImplementedException();
        }
        
        
        public PropertyTabAttribute(Type tabClass, PropertyTabScope tabScope)
        {
             throw new NotImplementedException();
        }
        
        
        public PropertyTabAttribute(string tabClassName, PropertyTabScope tabScope)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object other)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Equals(PropertyTabAttribute other)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        protected void InitializeArrays(string[] tabClassNames, PropertyTabScope[] tabScopes)
        {
             throw new NotImplementedException();
        }
        
        
        protected void InitializeArrays(Type[] tabClasses, PropertyTabScope[] tabScopes)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
