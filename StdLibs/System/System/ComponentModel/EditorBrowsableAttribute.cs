using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Enum|AttributeTargets.Constructor|AttributeTargets.Method|AttributeTargets.Property|AttributeTargets.Field|AttributeTargets.Event|AttributeTargets.Interface|AttributeTargets.Delegate)]
    public sealed class EditorBrowsableAttribute : Attribute
    {
    
        public EditorBrowsableState State
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public EditorBrowsableAttribute(EditorBrowsableState state)
        {
             throw new NotImplementedException();
        }
        
        
        public EditorBrowsableAttribute()
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
