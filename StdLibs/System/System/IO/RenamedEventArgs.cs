
namespace System.IO
{
    public class RenamedEventArgs : FileSystemEventArgs
    {
    
        public string OldFullPath
        {
            get { throw new NotImplementedException(); }
        }
    
        public string OldName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public RenamedEventArgs(WatcherChangeTypes changeType, string directory, string name, string oldName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
