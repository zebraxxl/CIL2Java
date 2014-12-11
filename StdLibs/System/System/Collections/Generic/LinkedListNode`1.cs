using System.Runtime.InteropServices;

namespace System.Collections.Generic
{
    [ComVisibleAttribute(false)]
    public sealed class LinkedListNode<T>
    {
    
        public LinkedList<T> List
        {
            get { throw new NotImplementedException(); }
        }
    
        public LinkedListNode<T> Next
        {
            get { throw new NotImplementedException(); }
        }
    
        public LinkedListNode<T> Previous
        {
            get { throw new NotImplementedException(); }
        }
    
        public T Value
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public LinkedListNode(T value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
