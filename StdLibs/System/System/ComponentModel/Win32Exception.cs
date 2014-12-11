using System.Security;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System;

namespace System.ComponentModel
{
    [Serializable]
    [SuppressUnmanagedCodeSecurityAttribute()]
    public class Win32Exception : ExternalException, ISerializable
    {
    
        public int NativeErrorCode
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public Win32Exception()
        {
             throw new NotImplementedException();
        }
        
        
        public Win32Exception(int error)
        {
             throw new NotImplementedException();
        }
        
        
        public Win32Exception(int error, string message)
        {
             throw new NotImplementedException();
        }
        
        
        public Win32Exception(string message)
        {
             throw new NotImplementedException();
        }
        
        
        public Win32Exception(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        protected Win32Exception(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
