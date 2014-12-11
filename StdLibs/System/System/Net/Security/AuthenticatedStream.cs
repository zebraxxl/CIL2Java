using System.IO;

namespace System.Net.Security
{
    public abstract class AuthenticatedStream : Stream
    {
        internal AuthenticatedStream()
        {
            //TODO: REMOVE THIS
        }
    
        public bool LeaveInnerStreamOpen
        {
            get { throw new NotImplementedException(); }
        }
    
        protected Stream InnerStream
        {
            get { throw new NotImplementedException(); }
        }
    
        public abstract bool IsAuthenticated
        {
            get;
        }
    
        public abstract bool IsMutuallyAuthenticated
        {
            get;
        }
    
        public abstract bool IsEncrypted
        {
            get;
        }
    
        public abstract bool IsSigned
        {
            get;
        }
    
        public abstract bool IsServer
        {
            get;
        }
    
    
        protected AuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
