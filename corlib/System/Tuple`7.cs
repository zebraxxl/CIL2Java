using System.Collections;

namespace System
{
    /// <summary>Represents a 7-tuple, or septuple. </summary><typeparam name="T1">The type of the tuple's first component.</typeparam><typeparam name="T2">The type of the tuple's second component.</typeparam><typeparam name="T3">The type of the tuple's third component.</typeparam><typeparam name="T4">The type of the tuple's fourth component.</typeparam><typeparam name="T5">The type of the tuple's fifth component.</typeparam><typeparam name="T6">The type of the tuple's sixth component.</typeparam><typeparam name="T7">The type of the tuple's seventh component.</typeparam><filterpriority>2</filterpriority>
    [Serializable]
    public class Tuple<T1, T2, T3, T4, T5, T6, T7> : IStructuralEquatable, IStructuralComparable, IComparable
    {
    
        /// <summary>Gets the value of the current <see cref="T:System.Tuple`7" /> object's first component.</summary><returns>The value of the current <see cref="T:System.Tuple`7" /> object's first component.</returns>
        public T1 Item1
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value of the current <see cref="T:System.Tuple`7" /> object's second component.</summary><returns>The value of the current <see cref="T:System.Tuple`7" /> object's second component.</returns>
        public T2 Item2
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value of the current <see cref="T:System.Tuple`7" /> object's third component.</summary><returns>The value of the current <see cref="T:System.Tuple`7" /> object's third component.</returns>
        public T3 Item3
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value of the current <see cref="T:System.Tuple`7" /> object's fourth component.</summary><returns>The value of the current <see cref="T:System.Tuple`7" /> object's fourth component.</returns>
        public T4 Item4
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value of the current <see cref="T:System.Tuple`7" /> object's fifth component.</summary><returns>The value of the current <see cref="T:System.Tuple`7" /> object's fifth component.</returns>
        public T5 Item5
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value of the current <see cref="T:System.Tuple`7" /> object's sixth component.</summary><returns>The value of the current <see cref="T:System.Tuple`7" /> object's sixth component.</returns>
        public T6 Item6
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value of the current <see cref="T:System.Tuple`7" /> object's seventh component.</summary><returns>The value of the current <see cref="T:System.Tuple`7" /> object's seventh component.</returns>
        public T7 Item7
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether the current <see cref="T:System.Tuple`7" /> object is equal to a specified object.</summary><returns>true if the current instance is equal to the specified object; otherwise, false.</returns><param name="obj">The object to compare with this instance.</param>
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
