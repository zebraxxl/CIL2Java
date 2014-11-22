using System.Collections;

namespace System.Collections.Generic
{
    /// <summary>Provides a base class for implementations of the <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> generic interface.</summary><typeparam name="T">The type of objects to compare.</typeparam>
    [Serializable]
    public abstract class EqualityComparer<T> : IEqualityComparer, IEqualityComparer<T>
    {
    
        /// <summary>Returns a default equality comparer for the type specified by the generic argument.</summary><returns>The default instance of the <see cref="T:System.Collections.Generic.EqualityComparer`1" /> class for type <paramref name="T" />.</returns>
        public static EqualityComparer<T> Default
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public abstract bool Equals(T x, T y);
        
        
        public abstract int GetHashCode(T obj);
        
        
        protected EqualityComparer()
        {
             throw new NotImplementedException();
        }



        bool IEqualityComparer.Equals(object x, object y)
        {
            throw new NotImplementedException();
        }

        int IEqualityComparer.GetHashCode(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
