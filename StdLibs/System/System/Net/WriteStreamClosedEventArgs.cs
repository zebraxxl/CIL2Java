using System.ComponentModel;
using System;

namespace System.Net
{
    [EditorBrowsableAttribute(EditorBrowsableState.Never)]
    public class WriteStreamClosedEventArgs : EventArgs
    {
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public Exception Error
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public WriteStreamClosedEventArgs()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
