using System.Collections;

namespace System
{
    /// <summary>Represents a 1-tuple, or singleton. </summary><typeparam name="T1">The type of the tuple's only component.</typeparam><filterpriority>1</filterpriority>
    [Serializable]
    public class Tuple<T1> : IStructuralEquatable, IStructuralComparable, IComparable
    {
    
        /// <summary>Gets the value of the <see cref="T:System.Tuple`1" /> object's single component. </summary><returns>The value of the current <see cref="T:System.Tuple`1" /> object's single component.</returns>
        public T1 Item1
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public Tuple(T1 item1)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether the current <see cref="T:System.Tuple`1" /> object is equal to a specified object.</summary><returns>true if the current instance is equal to the specified object; otherwise, false.</returns><param name="obj">The object to compare with this instance.</param>
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
