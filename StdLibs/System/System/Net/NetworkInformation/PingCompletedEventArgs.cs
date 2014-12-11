using System.ComponentModel;

namespace System.Net.NetworkInformation
{
    public class PingCompletedEventArgs : AsyncCompletedEventArgs
    {
    
        public PingReply Reply
        {
            get { throw new NotImplementedException(); }
        }
    
    
    }
}
