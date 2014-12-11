using System.ComponentModel;
using System.IO;

namespace System.Net
{
    public class OpenReadCompletedEventArgs : AsyncCompletedEventArgs
    {
    
        public Stream Result
        {
            get { throw new NotImplementedException(); }
        }
    
    
    }
}
