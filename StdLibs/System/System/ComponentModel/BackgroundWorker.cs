using System;

namespace System.ComponentModel
{
    [DefaultEventAttribute("DoWork")]
    public class BackgroundWorker : Component
    {
    
        public event DoWorkEventHandler DoWork;
    
        public event ProgressChangedEventHandler ProgressChanged;
    
        public event RunWorkerCompletedEventHandler RunWorkerCompleted;
    
    
        [BrowsableAttribute(false)]
        public bool CancellationPending
        {
            get { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        public bool IsBusy
        {
            get { throw new NotImplementedException(); }
        }
    
        [DefaultValueAttribute(false)]
        public bool WorkerReportsProgress
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [DefaultValueAttribute(false)]
        public bool WorkerSupportsCancellation
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public BackgroundWorker()
        {
             throw new NotImplementedException();
        }
        
        
        public void CancelAsync()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnDoWork(DoWorkEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnProgressChanged(ProgressChangedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public void ReportProgress(int percentProgress)
        {
             throw new NotImplementedException();
        }
        
        
        public void ReportProgress(int percentProgress, object userState)
        {
             throw new NotImplementedException();
        }
        
        
        public void RunWorkerAsync()
        {
             throw new NotImplementedException();
        }
        
        
        public void RunWorkerAsync(object argument)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
