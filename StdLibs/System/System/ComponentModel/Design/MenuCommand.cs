using System.Runtime.InteropServices;
using System;
using System.Collections;

namespace System.ComponentModel.Design
{
    [ComVisibleAttribute(true)]
    public class MenuCommand
    {
    
        public event EventHandler CommandChanged;
    
        internal MenuCommand()
        {
            //TODO: Remove this
        }
    
        public virtual bool Checked
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual bool Enabled
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual IDictionary Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual bool Supported
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual bool Visible
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual CommandID CommandID
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual int OleStatus
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public MenuCommand(EventHandler handler, CommandID command)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Invoke()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Invoke(object arg)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnCommandChanged(EventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
