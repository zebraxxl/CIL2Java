using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Class)]
    public sealed class InitializationEventAttribute : Attribute
    {
    
        public string EventName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public InitializationEventAttribute(string eventName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
