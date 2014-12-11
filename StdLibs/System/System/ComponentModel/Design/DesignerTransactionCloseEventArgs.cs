using System.Runtime.InteropServices;
using System;

namespace System.ComponentModel.Design
{
    [ComVisibleAttribute(true)]
    public class DesignerTransactionCloseEventArgs : EventArgs
    {
    
        public bool TransactionCommitted
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool LastTransaction
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [ObsoleteAttribute("This constructor is obsolete. Use DesignerTransactionCloseEventArgs(bool, bool) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public DesignerTransactionCloseEventArgs(bool commit)
        {
             throw new NotImplementedException();
        }
        
        
        public DesignerTransactionCloseEventArgs(bool commit, bool lastTransaction)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
