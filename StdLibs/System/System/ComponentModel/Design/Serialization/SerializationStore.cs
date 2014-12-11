using System;
using System.Collections;
using System.IO;

namespace System.ComponentModel.Design.Serialization
{
    public abstract class SerializationStore : IDisposable
    {
        public abstract ICollection Errors
        {
            get;
        }
    
    
        public abstract void Close();
        
        
        public abstract void Save(Stream stream);
        
        
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        protected SerializationStore()
        {
             throw new NotImplementedException();
        }



        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
