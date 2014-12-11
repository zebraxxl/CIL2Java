using System.ComponentModel;

namespace System.Net
{
    public class DownloadDataCompletedEventArgs : AsyncCompletedEventArgs
    {
    
        public byte[] Result
        {
            get { throw new NotImplementedException(); }
        }
    
    
    }
}
