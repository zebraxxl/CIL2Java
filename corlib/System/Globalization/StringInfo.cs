using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Globalization
{
    /// <summary>Provides functionality to split a string into text elements and to iterate through those text elements.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class StringInfo
    {
    
        /// <summary>Gets or sets the value of the current <see cref="T:System.Globalization.StringInfo" /> object.</summary><returns>The string that is the value of the current <see cref="T:System.Globalization.StringInfo" /> object.</returns><exception cref="T:System.ArgumentNullException">The value in a set operation is null.</exception>
        public string String
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of text elements in the current <see cref="T:System.Globalization.StringInfo" /> object.</summary><returns>The number of base characters, surrogate pairs, and combining character sequences in this <see cref="T:System.Globalization.StringInfo" /> object.</returns>
        public int LengthInTextElements
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public StringInfo()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Globalization.StringInfo" /> class to a specified string.</summary><param name="value">A string to initialize this <see cref="T:System.Globalization.StringInfo" /> object.</param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null.</exception>
        public StringInfo(string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the current <see cref="T:System.Globalization.StringInfo" /> object is equal to a specified object.</summary><returns>true if the <paramref name="value" /> parameter is a <see cref="T:System.Globalization.StringInfo" /> object and its <see cref="P:System.Globalization.StringInfo.String" /> property equals the <see cref="P:System.Globalization.StringInfo.String" /> property of this <see cref="T:System.Globalization.StringInfo" /> object; otherwise, false.</returns><param name="value">An object.</param>
        [ComVisibleAttribute(false)]
        public override bool Equals(object value)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a substring of text elements from the current <see cref="T:System.Globalization.StringInfo" /> object starting from a specified text element and continuing through the last text element.</summary><returns>A substring of text elements in this <see cref="T:System.Globalization.StringInfo" /> object, starting from the text element index specified by the <paramref name="startingTextElement" /> parameter and continuing through the last text element in this object.</returns><param name="startingTextElement">The zero-based index of a text element in this <see cref="T:System.Globalization.StringInfo" /> object.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startingTextElement" /> is less than zero.-or-The string that is the value of the current <see cref="T:System.Globalization.StringInfo" /> object is the empty string ("").</exception>
        public string SubstringByTextElements(int startingTextElement)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a substring of text elements from the current <see cref="T:System.Globalization.StringInfo" /> object starting from a specified text element and continuing through the specified number of text elements.</summary><returns>A substring of text elements in this <see cref="T:System.Globalization.StringInfo" /> object. The substring consists of the number of text elements specified by the <paramref name="lengthInTextElements" /> parameter and starts from the text element index specified by the <paramref name="startingTextElement" /> parameter.</returns><param name="startingTextElement">The zero-based index of a text element in this <see cref="T:System.Globalization.StringInfo" /> object.</param><param name="lengthInTextElements">The number of text elements to retrieve.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startingTextElement" /> is less than zero.-or-<paramref name="startingTextElement" /> is greater than or equal to the length of the string that is the value of the current <see cref="T:System.Globalization.StringInfo" /> object.-or-<paramref name="lengthInTextElements" /> is less than zero.-or-The string that is the value of the current <see cref="T:System.Globalization.StringInfo" /> object is the empty string ("").-or-<paramref name="startingTextElement" /> + <paramref name="lengthInTextElements" /> specify an index that is greater than the number of text elements in this <see cref="T:System.Globalization.StringInfo" /> object.</exception>
        public string SubstringByTextElements(int startingTextElement, int lengthInTextElements)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the first text element in a specified string.</summary><returns>A string containing the first text element in the specified string.</returns><param name="str">The string from which to get the text element. </param><exception cref="T:System.ArgumentNullException"><paramref name="str" /> is null. </exception>
        public static string GetNextTextElement(string str)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the text element at the specified index of the specified string.</summary><returns>A string containing the text element at the specified index of the specified string.</returns><param name="str">The string from which to get the text element. </param><param name="index">The zero-based index at which the text element starts. </param><exception cref="T:System.ArgumentNullException"><paramref name="str" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is outside the range of valid indexes for <paramref name="str" />. </exception>
        public static string GetNextTextElement(string str, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an enumerator that iterates through the text elements of the entire string.</summary><returns>A <see cref="T:System.Globalization.TextElementEnumerator" /> for the entire string.</returns><param name="str">The string to iterate through. </param><exception cref="T:System.ArgumentNullException"><paramref name="str" /> is null. </exception>
        public static TextElementEnumerator GetTextElementEnumerator(string str)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an enumerator that iterates through the text elements of the string, starting at the specified index.</summary><returns>A <see cref="T:System.Globalization.TextElementEnumerator" /> for the string starting at <paramref name="index" />.</returns><param name="str">The string to iterate through. </param><param name="index">The zero-based index at which to start iterating. </param><exception cref="T:System.ArgumentNullException"><paramref name="str" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is outside the range of valid indexes for <paramref name="str" />. </exception>
        public static TextElementEnumerator GetTextElementEnumerator(string str, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the indexes of each base character, high surrogate, or control character within the specified string.</summary><returns>An array of integers that contains the zero-based indexes of each base character, high surrogate, or control character within the specified string.</returns><param name="str">The string to search. </param><exception cref="T:System.ArgumentNullException"><paramref name="str" /> is null. </exception>
        public static int[] ParseCombiningCharacters(string str)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
