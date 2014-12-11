using System;

namespace System.Diagnostics.Eventing
{
    public struct EventDescriptor
    {
    
        public int EventId
        {
            get { throw new NotImplementedException(); }
        }
    
        public byte Version
        {
            get { throw new NotImplementedException(); }
        }
    
        public byte Channel
        {
            get { throw new NotImplementedException(); }
        }
    
        public byte Level
        {
            get { throw new NotImplementedException(); }
        }
    
        public byte Opcode
        {
            get { throw new NotImplementedException(); }
        }
    
        public int Task
        {
            get { throw new NotImplementedException(); }
        }
    
        public long Keywords
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public EventDescriptor(int id, byte version, byte channel, byte level, byte opcode, int task, long keywords)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
