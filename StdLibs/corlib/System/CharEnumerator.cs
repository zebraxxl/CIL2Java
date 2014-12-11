using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace System
{
    /// <summary>Supports iterating over a <see cref="T:System.String" /> object and reading its individual characters. This class cannot be inherited.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class CharEnumerator : ICloneable, IEnumerator<Char>
    {
    
        /// <summary>Gets the currently referenced character in the string enumerated by this <see cref="T:System.CharEnumerator" /> object.</summary><returns>The Unicode character currently referenced by this <see cref="T:System.CharEnumerator" /> object.</returns><exception cref="T:System.InvalidOperationException">The index is invalid; that is, it is before the first or after the last character of the enumerated string. </exception><filterpriority>2</filterpriority>
        public char Current
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public object Clone()
        {
             throw new NotImplementedException();
        }
        
        
        public bool MoveNext()
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        public void Reset()
        {
             throw new NotImplementedException();
        }



        char IEnumerator<char>.Current
        {
            get { throw new NotImplementedException(); }
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        object Collections.IEnumerator.Current
        {
            get { throw new NotImplementedException(); }
        }

        bool Collections.IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }

        void Collections.IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }
    }
}
