using System;

namespace System.Runtime.InteropServices
{
    [AttributeUsageAttribute(AttributeTargets.Parameter)]
    public sealed class DefaultParameterValueAttribute : Attribute
    {
    
        public object Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DefaultParameterValueAttribute(object value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
