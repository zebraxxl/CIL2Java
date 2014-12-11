using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Method|AttributeTargets.Property|AttributeTargets.Field|AttributeTargets.Event)]
    public sealed class DesignerSerializationVisibilityAttribute : Attribute
    {
        public static readonly DesignerSerializationVisibilityAttribute Content;
        public static readonly DesignerSerializationVisibilityAttribute Hidden;
        public static readonly DesignerSerializationVisibilityAttribute Visible;
        public static readonly DesignerSerializationVisibilityAttribute Default;
    
        public DesignerSerializationVisibility Visibility
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility visibility)
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
