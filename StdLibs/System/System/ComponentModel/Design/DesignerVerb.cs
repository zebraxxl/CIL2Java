using System.Runtime.InteropServices;
using System;

namespace System.ComponentModel.Design
{
    [ComVisibleAttribute(true)]
    public class DesignerVerb : MenuCommand
    {
        public string Description
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string Text
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DesignerVerb(string text, EventHandler handler)
        {
             throw new NotImplementedException();
        }
        
        
        public DesignerVerb(string text, EventHandler handler, CommandID startCommandID)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
