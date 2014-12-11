using System.Collections;

namespace System.Security.Cryptography
{
    public sealed class OidEnumerator : IEnumerator
    {
    
        public Oid Current
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public bool MoveNext()
        {
             throw new NotImplementedException();
        }
        
        
        public void Reset()
        {
             throw new NotImplementedException();
        }



        object IEnumerator.Current
        {
            get { throw new NotImplementedException(); }
        }

        bool IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }
    }
}
