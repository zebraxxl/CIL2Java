using System;
using System.Reflection;

namespace System.Diagnostics
{
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Constructor|AttributeTargets.Method|AttributeTargets.Property|AttributeTargets.Event)]
    public sealed class SwitchAttribute : Attribute
    {
    
        public string SwitchName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public Type SwitchType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string SwitchDescription
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SwitchAttribute(string switchName, Type switchType)
        {
             throw new NotImplementedException();
        }
        
        
        public static SwitchAttribute[] GetAll(Assembly assembly)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
