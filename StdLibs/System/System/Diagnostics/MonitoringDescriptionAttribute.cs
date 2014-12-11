using System;
using System.ComponentModel;

namespace System.Diagnostics
{
    [AttributeUsageAttribute(AttributeTargets.All)]
    public class MonitoringDescriptionAttribute : DescriptionAttribute
    {
    
        public override string Description
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public MonitoringDescriptionAttribute(string description)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
