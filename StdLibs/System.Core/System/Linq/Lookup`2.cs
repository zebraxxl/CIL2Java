using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System;

namespace System.Linq
{
    public class Lookup<TKey, TElement> : ILookup<TKey, TElement>
    {
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public IEnumerable<TElement> this[TKey key]
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public bool Contains(TKey key)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerable<TResult> ApplyResultSelector<TResult>(Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
        {
             throw new NotImplementedException();
        }



        int ILookup<TKey, TElement>.Count
        {
            get { throw new NotImplementedException(); }
        }

        IEnumerable<TElement> ILookup<TKey, TElement>.this[TKey key]
        {
            get { throw new NotImplementedException(); }
        }

        bool ILookup<TKey, TElement>.Contains(TKey key)
        {
            throw new NotImplementedException();
        }

        IEnumerator<IGrouping<TKey, TElement>> IEnumerable<IGrouping<TKey, TElement>>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        Collections.IEnumerator Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
