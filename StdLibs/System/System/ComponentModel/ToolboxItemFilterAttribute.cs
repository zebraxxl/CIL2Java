using System;

namespace System.ComponentModel
{
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public sealed class ToolboxItemFilterAttribute : Attribute
    {
    
        public string FilterString
        {
            get { throw new NotImplementedException(); }
        }
    
        public ToolboxItemFilterType FilterType
        {
            get { throw new NotImplementedException(); }
        }
    
        public override object TypeId
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ToolboxItemFilterAttribute(string filterString)
        {
             throw new NotImplementedException();
        }
        
        
        public ToolboxItemFilterAttribute(string filterString, ToolboxItemFilterType filterType)
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
        
        
        public override bool Match(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
