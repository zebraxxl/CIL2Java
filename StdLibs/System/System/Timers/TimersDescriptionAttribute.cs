using System;
using System.ComponentModel;

namespace System.Timers
{
    [AttributeUsageAttribute(AttributeTargets.All)]
    public class TimersDescriptionAttribute : DescriptionAttribute
    {
    
        public override string Description
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public TimersDescriptionAttribute(string description)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
