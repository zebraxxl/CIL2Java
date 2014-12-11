using System.Runtime.InteropServices;
using System.Collections;
using System.Runtime.Serialization;

namespace System.Globalization
{
    /// <summary>Enumerates the text elements of a string. </summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class TextElementEnumerator : IEnumerator
    {
    
        /// <summary>Gets the current text element in the string.</summary><returns>An object containing the current text element in the string.</returns><exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first text element of the string or after the last text element. </exception>
        public object Current
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the index of the text element that the enumerator is currently positioned over.</summary><returns>The index of the text element that the enumerator is currently positioned over.</returns><exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first text element of the string or after the last text element. </exception>
        public int ElementIndex
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public bool MoveNext()
        {
             throw new NotImplementedException();
        }
        
        
        public string GetTextElement()
        {
             throw new NotImplementedException();
        }
        
        
        public void Reset()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
