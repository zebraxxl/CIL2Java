using System.Runtime.InteropServices;
using System;

namespace System.ComponentModel.Design
{
    [ComVisibleAttribute(true)]
    public class CommandID
    {
    
        public virtual int ID
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual Guid Guid
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CommandID(Guid menuGroup, int commandID)
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
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
