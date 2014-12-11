using System;

namespace System.Diagnostics
{
    [AttributeUsageAttribute(AttributeTargets.Class)]
    public sealed class SwitchLevelAttribute : Attribute
    {
    
        public Type SwitchLevelType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SwitchLevelAttribute(Type switchLevelType)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
