using System;

namespace System.ComponentModel.Design
{
    public class ActiveDesignerEventArgs : EventArgs
    {
    
        public IDesignerHost OldDesigner
        {
            get { throw new NotImplementedException(); }
        }
    
        public IDesignerHost NewDesigner
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ActiveDesignerEventArgs(IDesignerHost oldDesigner, IDesignerHost newDesigner)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
