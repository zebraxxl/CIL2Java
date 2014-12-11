using System;

namespace System.ComponentModel.Design
{
    public abstract class DesignerTransaction : IDisposable
    {
    
        public bool Canceled
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool Committed
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Description
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected DesignerTransaction()
        {
             throw new NotImplementedException();
        }
        
        
        protected DesignerTransaction(string description)
        {
             throw new NotImplementedException();
        }
        
        
        public void Cancel()
        {
             throw new NotImplementedException();
        }
        
        
        public void Commit()
        {
             throw new NotImplementedException();
        }
        
        
        protected abstract void OnCancel();
        
        
        protected abstract void OnCommit();
        
        
        ~DesignerTransaction()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }



        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
