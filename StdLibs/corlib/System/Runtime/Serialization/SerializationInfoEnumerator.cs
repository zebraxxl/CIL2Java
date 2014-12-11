using System.Runtime.InteropServices;
using System.Collections;
using System;

namespace System.Runtime.Serialization
{
    /// <summary>Provides a formatter-friendly mechanism for parsing the data in <see cref="T:System.Runtime.Serialization.SerializationInfo" />. This class cannot be inherited.</summary>
    [ComVisibleAttribute(true)]
    public sealed class SerializationInfoEnumerator : IEnumerator
    {
    
        /// <summary>Gets the item currently being examined.</summary><returns>The item currently being examined.</returns><exception cref="T:System.InvalidOperationException">The enumerator has not started enumerating items or has reached the end of the enumeration. </exception>
        public SerializationEntry Current
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name for the item currently being examined.</summary><returns>The item name.</returns><exception cref="T:System.InvalidOperationException">The enumerator has not started enumerating items or has reached the end of the enumeration. </exception>
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value of the item currently being examined.</summary><returns>The value of the item currently being examined.</returns><exception cref="T:System.InvalidOperationException">The enumerator has not started enumerating items or has reached the end of the enumeration. </exception>
        public object Value
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the type of the item currently being examined.</summary><returns>The type of the item currently being examined.</returns><exception cref="T:System.InvalidOperationException">The enumerator has not started enumerating items or has reached the end of the enumeration. </exception>
        public Type ObjectType
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
