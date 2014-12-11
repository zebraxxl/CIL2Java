using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Property)]
    public sealed class DataObjectFieldAttribute : Attribute
    {
    
        public bool IsIdentity
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsNullable
        {
            get { throw new NotImplementedException(); }
        }
    
        public int Length
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool PrimaryKey
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DataObjectFieldAttribute(bool primaryKey)
        {
             throw new NotImplementedException();
        }
        
        
        public DataObjectFieldAttribute(bool primaryKey, bool isIdentity)
        {
             throw new NotImplementedException();
        }
        
        
        public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable)
        {
             throw new NotImplementedException();
        }
        
        
        public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable, int length)
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
