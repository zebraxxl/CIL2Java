using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.All)]
    public class ToolboxItemAttribute : Attribute
    {
        public static readonly ToolboxItemAttribute Default;
        public static readonly ToolboxItemAttribute None;
    
        public Type ToolboxItemType
        {
            get { throw new NotImplementedException(); }
        }
    
        public string ToolboxItemTypeName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public override bool IsDefaultAttribute()
        {
             throw new NotImplementedException();
        }
        
        
        public ToolboxItemAttribute(bool defaultType)
        {
             throw new NotImplementedException();
        }
        
        
        public ToolboxItemAttribute(string toolboxItemTypeName)
        {
             throw new NotImplementedException();
        }
        
        
        public ToolboxItemAttribute(Type toolboxItemType)
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
