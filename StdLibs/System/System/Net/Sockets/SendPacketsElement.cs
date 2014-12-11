
namespace System.Net.Sockets
{
    public class SendPacketsElement
    {
    
        public string FilePath
        {
            get { throw new NotImplementedException(); }
        }
    
        public byte[] Buffer
        {
            get { throw new NotImplementedException(); }
        }
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public int Offset
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool EndOfPacket
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SendPacketsElement(string filepath)
        {
             throw new NotImplementedException();
        }
        
        
        public SendPacketsElement(string filepath, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public SendPacketsElement(string filepath, int offset, int count, bool endOfPacket)
        {
             throw new NotImplementedException();
        }
        
        
        public SendPacketsElement(byte[] buffer)
        {
             throw new NotImplementedException();
        }
        
        
        public SendPacketsElement(byte[] buffer, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public SendPacketsElement(byte[] buffer, int offset, int count, bool endOfPacket)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
