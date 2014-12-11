using System.Collections;
using System;

namespace System.CodeDom.Compiler
{
    [Serializable]
    public class TempFileCollection : ICollection, IDisposable
    {
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public string TempDir
        {
            get { throw new NotImplementedException(); }
        }
    
        public string BasePath
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool KeepFiles
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public TempFileCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public TempFileCollection(string tempDir)
        {
             throw new NotImplementedException();
        }
        
        
        public TempFileCollection(string tempDir, bool keepFiles)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        ~TempFileCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public string AddExtension(string fileExtension)
        {
             throw new NotImplementedException();
        }
        
        
        public string AddExtension(string fileExtension, bool keepFile)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddFile(string fileName, bool keepFile)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(string[] fileNames, int start)
        {
             throw new NotImplementedException();
        }
        
        
        public void Delete()
        {
             throw new NotImplementedException();
        }



        void ICollection.CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        int ICollection.Count
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection.IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        object ICollection.SyncRoot
        {
            get { throw new NotImplementedException(); }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
