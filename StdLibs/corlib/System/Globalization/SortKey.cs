using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Globalization
{
    /// <summary>Represents the result of mapping a string to its sort key.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class SortKey
    {
    
        /// <summary>Gets the original string used to create the current <see cref="T:System.Globalization.SortKey" /> object.</summary><returns>The original string used to create the current <see cref="T:System.Globalization.SortKey" /> object.</returns>
        public virtual string OriginalString
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the byte array representing the current <see cref="T:System.Globalization.SortKey" /> object.</summary><returns>A byte array representing the current <see cref="T:System.Globalization.SortKey" /> object.</returns>
        public virtual byte[] KeyData
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Compares two sort keys.</summary><returns>A signed integer that indicates the relationship between <paramref name="sortkey1" /> and <paramref name="sortkey2" />.Value Condition Less than zero <paramref name="sortkey1" /> is less than <paramref name="sortkey2" />. Zero <paramref name="sortkey1" /> is equal to <paramref name="sortkey2" />. Greater than zero <paramref name="sortkey1" /> is greater than <paramref name="sortkey2" />. </returns><param name="sortkey1">The first sort key to compare. </param><param name="sortkey2">The second sort key to compare. </param><exception cref="T:System.ArgumentNullException"><paramref name="sortkey1" /> or <paramref name="sortkey2" /> is null.</exception>
        public static int Compare(SortKey sortkey1, SortKey sortkey2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified object is equal to the current <see cref="T:System.Globalization.SortKey" /> object.</summary><returns>true if the <paramref name="value" /> parameter is equal to the current <see cref="T:System.Globalization.SortKey" /> object; otherwise, false. </returns><param name="value">The object to compare with the current <see cref="T:System.Globalization.SortKey" /> object. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null.</exception>
        public override bool Equals(object value)
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
        
        
    }
}
