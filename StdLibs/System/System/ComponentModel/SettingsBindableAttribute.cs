using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Property)]
    public sealed class SettingsBindableAttribute : Attribute
    {
        public static readonly SettingsBindableAttribute Yes;
        public static readonly SettingsBindableAttribute No;
    
        public bool Bindable
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SettingsBindableAttribute(bool bindable)
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
        
        
    }
}
