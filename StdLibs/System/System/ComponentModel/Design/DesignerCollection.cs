using System.Collections;

namespace System.ComponentModel.Design
{
    public class DesignerCollection : ICollection
    {
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual IDesignerHost this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DesignerCollection(IDesignerHost[] designers)
        {
             throw new NotImplementedException();
        }
        
        
        public DesignerCollection(IList designers)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator GetEnumerator()
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
    }
}
