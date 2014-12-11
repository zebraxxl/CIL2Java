using System;
using System.Security;

namespace System.Diagnostics.Eventing
{
    public class EventProvider : IDisposable
    {
        public enum WriteEventErrorCode : int
        {
            NoError = 0,
            NoFreeBuffers = 1,
            EventTooBig = 2
        }
    
    
        [SecuritySafeCriticalAttribute()]
        public EventProvider(Guid providerGuid)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Close()
        {
             throw new NotImplementedException();
        }
        
        
        ~EventProvider()
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsEnabled()
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsEnabled(byte level, long keywords)
        {
             throw new NotImplementedException();
        }
        
        
        public static WriteEventErrorCode GetLastWriteEventError()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public bool WriteMessageEvent(string eventMessage, byte eventLevel, long eventKeywords)
        {
             throw new NotImplementedException();
        }
        
        
        public bool WriteMessageEvent(string eventMessage)
        {
             throw new NotImplementedException();
        }
        
        
        public bool WriteEvent(ref EventDescriptor eventDescriptor, params  object[] eventPayload)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public bool WriteEvent(ref EventDescriptor eventDescriptor, string data)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        protected bool WriteEvent(ref EventDescriptor eventDescriptor, int dataCount, IntPtr data)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public bool WriteTransferEvent(ref EventDescriptor eventDescriptor, Guid relatedActivityId, params  object[] eventPayload)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        protected bool WriteTransferEvent(ref EventDescriptor eventDescriptor, Guid relatedActivityId, int dataCount, IntPtr data)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static void SetActivityId(ref Guid id)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static Guid CreateActivityId()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
