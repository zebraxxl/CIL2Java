using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Property)]
    [ObsoleteAttribute("Use System.ComponentModel.SettingsBindableAttribute instead to work with the new settings model.")]
    public class RecommendedAsConfigurableAttribute : Attribute
    {
        public static readonly RecommendedAsConfigurableAttribute No;
        public static readonly RecommendedAsConfigurableAttribute Yes;
        public static readonly RecommendedAsConfigurableAttribute Default;
    
        public bool RecommendedAsConfigurable
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public RecommendedAsConfigurableAttribute(bool recommendedAsConfigurable)
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
        
        
        public override bool IsDefaultAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
