using System;

namespace System.Diagnostics.Eventing.Reader
{
    public sealed class EventRecordWrittenEventArgs : EventArgs
    {
    
        public EventRecord EventRecord
        {
            get { throw new NotImplementedException(); }
        }
    
        public Exception EventException
        {
            get { throw new NotImplementedException(); }
        }
    
    
    }
}
