using System.Collections;

namespace System.Security.AccessControl
{
    /// <summary>Provides the ability to iterate through the access control entries (ACEs) in an access control list (ACL). </summary>
    public sealed class AceEnumerator : IEnumerator
    {
    
        /// <summary>Gets the current element in the <see cref="T:System.Security.AccessControl.GenericAce" /> collection. This property gets the type-friendly version of the object. </summary><returns>The current element in the <see cref="T:System.Security.AccessControl.GenericAce" /> collection.</returns>
        public GenericAce Current
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
