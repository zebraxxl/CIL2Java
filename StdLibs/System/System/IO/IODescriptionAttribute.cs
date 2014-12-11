using System;
using System.ComponentModel;

namespace System.IO
{
    [AttributeUsageAttribute(AttributeTargets.All)]
    public class IODescriptionAttribute : DescriptionAttribute
    {
    
        public override string Description
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public IODescriptionAttribute(string description)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
