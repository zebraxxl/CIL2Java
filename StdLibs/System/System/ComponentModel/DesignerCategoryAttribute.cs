using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed class DesignerCategoryAttribute : Attribute
    {
        public static readonly DesignerCategoryAttribute Component;
        public static readonly DesignerCategoryAttribute Default;
        public static readonly DesignerCategoryAttribute Form;
        public static readonly DesignerCategoryAttribute Generic;
    
        public string Category
        {
            get { throw new NotImplementedException(); }
        }
    
        public override object TypeId
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DesignerCategoryAttribute()
        {
             throw new NotImplementedException();
        }
        
        
        public DesignerCategoryAttribute(string category)
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
