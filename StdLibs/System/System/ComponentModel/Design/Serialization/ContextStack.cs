using System;

namespace System.ComponentModel.Design.Serialization
{
    public sealed class ContextStack
    {
    
        public object Current
        {
            get { throw new NotImplementedException(); }
        }
    
        public object this[int level]
        {
            get { throw new NotImplementedException(); }
        }
    
        public object this[Type type]
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public void Append(object context)
        {
             throw new NotImplementedException();
        }
        
        
        public object Pop()
        {
             throw new NotImplementedException();
        }
        
        
        public void Push(object context)
        {
             throw new NotImplementedException();
        }
        
        
        public ContextStack()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
