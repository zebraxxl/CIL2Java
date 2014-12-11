using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Class)]
    public class InstallerTypeAttribute : Attribute
    {
    
        public virtual Type InstallerType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public InstallerTypeAttribute(Type installerType)
        {
             throw new NotImplementedException();
        }
        
        
        public InstallerTypeAttribute(string typeName)
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
