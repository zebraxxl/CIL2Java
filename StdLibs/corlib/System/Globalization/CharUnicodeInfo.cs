using System.Security;

namespace System.Globalization
{
    /// <summary>Retrieves information about a Unicode character. This class cannot be inherited.</summary>
    public static class CharUnicodeInfo
    {
        internal const char HIGH_SURROGATE_START = '\ud800';
        internal const char HIGH_SURROGATE_END = '\udbff';
        internal const char LOW_SURROGATE_START = '\udc00';
        internal const char LOW_SURROGATE_END = '\udfff';
    
        /// <summary>Gets the numeric value associated with the specified character.</summary><returns>The numeric value associated with the specified character.-or- -1, if the specified character is not a numeric character.</returns><param name="ch">The Unicode character for which to get the numeric value. </param>
        public static double GetNumericValue(char ch)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the numeric value associated with the character at the specified index of the specified string.</summary><returns>The numeric value associated with the character at the specified index of the specified string.-or- -1, if the character at the specified index of the specified string is not a numeric character.</returns><param name="s">The <see cref="T:System.String" /> containing the Unicode character for which to get the numeric value. </param><param name="index">The index of the Unicode character for which to get the numeric value. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is outside the range of valid indexes in <paramref name="s" />. </exception>
        public static double GetNumericValue(string s, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the decimal digit value of the specified numeric character.</summary><returns>The decimal digit value of the specified numeric character.-or- -1, if the specified character is not a decimal digit.</returns><param name="ch">The Unicode character for which to get the decimal digit value. </param>
        public static int GetDecimalDigitValue(char ch)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the decimal digit value of the numeric character at the specified index of the specified string.</summary><returns>The decimal digit value of the numeric character at the specified index of the specified string.-or- -1, if the character at the specified index of the specified string is not a decimal digit.</returns><param name="s">The <see cref="T:System.String" /> containing the Unicode character for which to get the decimal digit value. </param><param name="index">The index of the Unicode character for which to get the decimal digit value. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is outside the range of valid indexes in <paramref name="s" />. </exception>
        public static int GetDecimalDigitValue(string s, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the digit value of the specified numeric character.</summary><returns>The digit value of the specified numeric character.-or- -1, if the specified character is not a digit.</returns><param name="ch">The Unicode character for which to get the digit value. </param>
        public static int GetDigitValue(char ch)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the digit value of the numeric character at the specified index of the specified string.</summary><returns>The digit value of the numeric character at the specified index of the specified string.-or- -1, if the character at the specified index of the specified string is not a digit.</returns><param name="s">The <see cref="T:System.String" /> containing the Unicode character for which to get the digit value. </param><param name="index">The index of the Unicode character for which to get the digit value. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is outside the range of valid indexes in <paramref name="s" />. </exception>
        public static int GetDigitValue(string s, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the Unicode category of the specified character.</summary><returns>A <see cref="T:System.Globalization.UnicodeCategory" /> value indicating the category of the specified character.</returns><param name="ch">The Unicode character for which to get the Unicode category. </param>
        public static UnicodeCategory GetUnicodeCategory(char ch)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the Unicode category of the character at the specified index of the specified string.</summary><returns>A <see cref="T:System.Globalization.UnicodeCategory" /> value indicating the category of the character at the specified index of the specified string.</returns><param name="s">The <see cref="T:System.String" /> containing the Unicode character for which to get the Unicode category. </param><param name="index">The index of the Unicode character for which to get the Unicode category. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is outside the range of valid indexes in <paramref name="s" />. </exception>
        public static UnicodeCategory GetUnicodeCategory(string s, int index)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
