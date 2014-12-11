using System.Collections;

namespace System
{
    /// <summary>Represents a 2-tuple, or pair. </summary><typeparam name="T1">The type of the tuple's first component.</typeparam><typeparam name="T2">The type of the tuple's second component.</typeparam><filterpriority>2</filterpriority>
    [Serializable]
    public class Tuple<T1, T2> : IStructuralEquatable, IStructuralComparable, IComparable
    {
    
        /// <summary>Gets the value of the current <see cref="T:System.Tuple`2" /> object's first component.</summary><returns>The value of the current <see cref="T:System.Tuple`2" /> object's first component.</returns>
        public T1 Item1
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value of the current <see cref="T:System.Tuple`2" /> object's second component.</summary><returns>The value of the current <see cref="T:System.Tuple`2" /> object's second component.</returns>
        public T2 Item2
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public Tuple(T1 item1, T2 item2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether the current <see cref="T:System.Tuple`2" /> object is equal to a specified object.</summary><returns>true if the current instance is equal to the specified object; otherwise, false.</returns><param name="obj">The object to compare with this instance.</param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }



        bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
        {
            throw new NotImplementedException();
        }

        int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
        {
            throw new NotImplementedException();
        }

        int IStructuralComparable.CompareTo(object other, IComparer comparer)
        {
            throw new NotImplementedException();
        }

        int IComparable.CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
