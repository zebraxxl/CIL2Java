using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.All)]
    public sealed class TypeConverterAttribute : Attribute
    {
        public static readonly TypeConverterAttribute Default;
    
        public string ConverterTypeName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public TypeConverterAttribute()
        {
             throw new NotImplementedException();
        }
        
        
        public TypeConverterAttribute(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public TypeConverterAttribute(string typeName)
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
