using System.Collections;
using System;

namespace System.Collections.Generic
{
    /// <summary>Provides a base class for implementations of the <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface.</summary><typeparam name="T">The type of objects to compare.</typeparam><filterpriority>1</filterpriority>
    [Serializable]
    public abstract class Comparer<T> : IComparer, IComparer<T>
    {
    
        /// <summary>Returns a default sort order comparer for the type specified by the generic argument.</summary><returns>An object that inherits <see cref="T:System.Collections.Generic.Comparer`1" /> and serves as a sort order comparer for type <paramref name="T" />.</returns>
        public static Comparer<T> Default
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public static Comparer<T> Create(Comparison<T> comparison)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract int Compare(T x, T y);
        
        
        protected Comparer()
        {
             throw new NotImplementedException();
        }



        int IComparer.Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
}
