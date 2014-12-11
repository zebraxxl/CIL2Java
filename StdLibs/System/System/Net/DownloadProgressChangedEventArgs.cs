using System.ComponentModel;

namespace System.Net
{
    public class DownloadProgressChangedEventArgs : ProgressChangedEventArgs
    {
    
        public long BytesReceived
        {
            get { throw new NotImplementedException(); }
        }
    
        public long TotalBytesToReceive
        {
            get { throw new NotImplementedException(); }
        }
    
    
    }
}
