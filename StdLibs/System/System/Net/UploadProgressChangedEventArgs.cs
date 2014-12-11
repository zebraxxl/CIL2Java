using System.ComponentModel;

namespace System.Net
{
    public class UploadProgressChangedEventArgs : ProgressChangedEventArgs
    {
    
        public long BytesReceived
        {
            get { throw new NotImplementedException(); }
        }
    
        public long TotalBytesToReceive
        {
            get { throw new NotImplementedException(); }
        }
    
        public long BytesSent
        {
            get { throw new NotImplementedException(); }
        }
    
        public long TotalBytesToSend
        {
            get { throw new NotImplementedException(); }
        }
    
    
    }
}
