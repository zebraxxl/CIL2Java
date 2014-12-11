using System;
using System.Collections.Generic;

namespace System.Runtime.CompilerServices
{
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Property|AttributeTargets.Field|AttributeTargets.Parameter|AttributeTargets.ReturnValue)]
    public sealed class DynamicAttribute : Attribute
    {
    
        public IList<bool> TransformFlags
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DynamicAttribute()
        {
             throw new NotImplementedException();
        }
        
        
        public DynamicAttribute(bool[] transformFlags)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
