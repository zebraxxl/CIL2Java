using System;

namespace System.Configuration
{
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Property)]
    public sealed class SpecialSettingAttribute : Attribute
    {
    
        public SpecialSetting SpecialSetting
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SpecialSettingAttribute(SpecialSetting specialSetting)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
