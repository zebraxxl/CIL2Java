using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Class)]
    public sealed class DataObjectAttribute : Attribute
    {
        public static readonly DataObjectAttribute DataObject;
        public static readonly DataObjectAttribute NonDataObject;
        public static readonly DataObjectAttribute Default;
    
        public bool IsDataObject
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DataObjectAttribute()
        {
             throw new NotImplementedException();
        }
        
        
        public DataObjectAttribute(bool isDataObject)
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
        
        
        public override bool IsDefaultAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
