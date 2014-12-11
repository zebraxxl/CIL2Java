using System;

namespace System.IO
{
    public class FileSystemEventArgs : EventArgs
    {
        internal FileSystemEventArgs()
        {
            //TODO: REMOVE THIS
        }
    
        public WatcherChangeTypes ChangeType
        {
            get { throw new NotImplementedException(); }
        }
    
        public string FullPath
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public FileSystemEventArgs(WatcherChangeTypes changeType, string directory, string name)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
