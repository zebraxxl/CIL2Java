using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
    public sealed class EditorAttribute : Attribute
    {
    
        public string EditorBaseTypeName
        {
            get { throw new NotImplementedException(); }
        }
    
        public string EditorTypeName
        {
            get { throw new NotImplementedException(); }
        }
    
        public override object TypeId
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public EditorAttribute()
        {
             throw new NotImplementedException();
        }
        
        
        public EditorAttribute(string typeName, string baseTypeName)
        {
             throw new NotImplementedException();
        }
        
        
        public EditorAttribute(string typeName, Type baseType)
        {
             throw new NotImplementedException();
        }
        
        
        public EditorAttribute(Type type, Type baseType)
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
