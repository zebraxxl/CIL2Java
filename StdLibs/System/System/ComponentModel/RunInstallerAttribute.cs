using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Class)]
    public class RunInstallerAttribute : Attribute
    {
        public static readonly RunInstallerAttribute Yes;
        public static readonly RunInstallerAttribute No;
        public static readonly RunInstallerAttribute Default;
    
        public bool RunInstaller
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public RunInstallerAttribute(bool runInstaller)
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
