using System.Runtime.InteropServices;
using System.Diagnostics;
using System;
using System.Security;

namespace System.Threading
{
    [ComVisibleAttribute(false)]
    [DebuggerDisplayAttribute("Participant Count={ParticipantCount},Participants Remaining={ParticipantsRemaining}")]
    public class Barrier : IDisposable
    {
    
        public int ParticipantsRemaining
        {
            get { throw new NotImplementedException(); }
        }
    
        public int ParticipantCount
        {
            get { throw new NotImplementedException(); }
        }
    
        public long CurrentPhaseNumber
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public Barrier(int participantCount)
        {
             throw new NotImplementedException();
        }
        
        
        public Barrier(int participantCount, Action<Barrier> postPhaseAction)
        {
             throw new NotImplementedException();
        }
        
        
        public long AddParticipant()
        {
             throw new NotImplementedException();
        }
        
        
        public long AddParticipants(int participantCount)
        {
             throw new NotImplementedException();
        }
        
        
        public void RemoveParticipant()
        {
             throw new NotImplementedException();
        }
        
        
        public void RemoveParticipants(int participantCount)
        {
             throw new NotImplementedException();
        }
        
        
        public void SignalAndWait()
        {
             throw new NotImplementedException();
        }
        
        
        public void SignalAndWait(CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public bool SignalAndWait(TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        public bool SignalAndWait(TimeSpan timeout, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public bool SignalAndWait(int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        public bool SignalAndWait(int millisecondsTimeout, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
