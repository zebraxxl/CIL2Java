using System.Runtime.InteropServices;
using System.Globalization;

namespace System
{
    /// <summary>Represents a character as a UTF-16 code unit.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public struct Char : IComparable, IConvertible, IComparable<Char>, IEquatable<Char>
    {
        /// <summary>Represents the largest possible value of a <see cref="T:System.Char" />. This field is constant.</summary><filterpriority>1</filterpriority>
        public const char MaxValue = (char)0xffff;
        /// <summary>Represents the smallest possible value of a <see cref="T:System.Char" />. This field is constant.</summary><filterpriority>1</filterpriority>
        public const char MinValue = (char)0x0000;
    
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> is an instance of <see cref="T:System.Char" /> and equals the value of this instance; otherwise, false.</returns><param name="obj">An object to compare with this instance or null. </param><filterpriority>2</filterpriority>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether this instance is equal to the specified <see cref="T:System.Char" /> object.</summary><returns>true if the <paramref name="obj" /> parameter equals the value of this instance; otherwise, false.</returns><param name="obj">An object to compare to this instance. </param><filterpriority>2</filterpriority>
        public bool Equals(char obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares this instance to a specified object and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified <see cref="T:System.Object" />.</summary><returns>A signed number indicating the position of this instance in the sort order in relation to the <paramref name="value" /> parameter.Return Value Description Less than zero This instance precedes <paramref name="value" />. Zero This instance has the same position in the sort order as <paramref name="value" />. Greater than zero This instance follows <paramref name="value" />.-or- <paramref name="value" /> is null. </returns><param name="value">An object to compare this instance to, or null. </param><exception cref="T:System.ArgumentException"><paramref name="value" /> is not a <see cref="T:System.Char" /> object. </exception><filterpriority>2</filterpriority>
        public int CompareTo(object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares this instance to a specified <see cref="T:System.Char" /> object and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified <see cref="T:System.Char" /> object.</summary><returns>A signed number indicating the position of this instance in the sort order in relation to the <paramref name="value" /> parameter.Return Value Description Less than zero This instance precedes <paramref name="value" />. Zero This instance has the same position in the sort order as <paramref name="value" />. Greater than zero This instance follows <paramref name="value" />. </returns><param name="value">A <see cref="T:System.Char" /> object to compare. </param><filterpriority>2</filterpriority>
        public int CompareTo(char value)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of this instance to its equivalent string representation using the specified culture-specific format information.</summary><returns>The string representation of the value of this instance as specified by <paramref name="provider" />.</returns><param name="provider">(Reserved) An object that supplies culture-specific formatting information. </param><filterpriority>1</filterpriority>
        public string ToString(IFormatProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified Unicode character to its equivalent string representation.</summary><returns>The string representation of the value of <paramref name="c" />.</returns><param name="c">The Unicode character to convert. </param><filterpriority>1</filterpriority>
        public static string ToString(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of the specified string to its equivalent Unicode character.</summary><returns>A Unicode character equivalent to the sole character in <paramref name="s" />.</returns><param name="s">A string that contains a single character, or null. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException">The length of <paramref name="s" /> is not 1. </exception><filterpriority>1</filterpriority>
        public static char Parse(string s)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParse(string s, ref char result)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified Unicode character is categorized as a decimal digit.</summary><returns>true if <paramref name="c" /> is a decimal digit; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        public static bool IsDigit(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified Unicode character is categorized as a Unicode letter. </summary><returns>true if <paramref name="c" /> is a letter; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        public static bool IsLetter(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified Unicode character is categorized as white space.</summary><returns>true if <paramref name="c" /> is white space; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        public static bool IsWhiteSpace(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified Unicode character is categorized as an uppercase letter.</summary><returns>true if <paramref name="c" /> is an uppercase letter; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        public static bool IsUpper(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified Unicode character is categorized as a lowercase letter.</summary><returns>true if <paramref name="c" /> is a lowercase letter; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        public static bool IsLower(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified Unicode character is categorized as a punctuation mark.</summary><returns>true if <paramref name="c" /> is a punctuation mark; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        public static bool IsPunctuation(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified Unicode character is categorized as a letter or a decimal digit.</summary><returns>true if <paramref name="c" /> is a letter or a decimal digit; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        public static bool IsLetterOrDigit(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of a specified Unicode character to its uppercase equivalent using specified culture-specific formatting information.</summary><returns>The uppercase equivalent of <paramref name="c" />, modified according to <paramref name="culture" />, or the unchanged value of <paramref name="c" /> if <paramref name="c" /> is already uppercase, has no uppercase equivalent, or is not alphabetic.</returns><param name="c">The Unicode character to convert. </param><param name="culture">An object that supplies culture-specific casing rules. </param><exception cref="T:System.ArgumentNullException"><paramref name="culture" /> is null. </exception><filterpriority>1</filterpriority>
        public static char ToUpper(char c, CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of a Unicode character to its uppercase equivalent.</summary><returns>The uppercase equivalent of <paramref name="c" />, or the unchanged value of <paramref name="c" /> if <paramref name="c" /> is already uppercase, has no uppercase equivalent, or is not alphabetic.</returns><param name="c">The Unicode character to convert. </param><filterpriority>1</filterpriority>
        public static char ToUpper(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of a Unicode character to its uppercase equivalent using the casing rules of the invariant culture.</summary><returns>The uppercase equivalent of the <paramref name="c" /> parameter, or the unchanged value of <paramref name="c" />, if <paramref name="c" /> is already uppercase or not alphabetic.</returns><param name="c">The Unicode character to convert. </param><filterpriority>1</filterpriority>
        public static char ToUpperInvariant(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of a specified Unicode character to its lowercase equivalent using specified culture-specific formatting information.</summary><returns>The lowercase equivalent of <paramref name="c" />, modified according to <paramref name="culture" />, or the unchanged value of <paramref name="c" />, if <paramref name="c" /> is already lowercase or not alphabetic.</returns><param name="c">The Unicode character to convert. </param><param name="culture">An object that supplies culture-specific casing rules. </param><exception cref="T:System.ArgumentNullException"><paramref name="culture" /> is null. </exception><filterpriority>1</filterpriority>
        public static char ToLower(char c, CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of a Unicode character to its lowercase equivalent.</summary><returns>The lowercase equivalent of <paramref name="c" />, or the unchanged value of <paramref name="c" />, if <paramref name="c" /> is already lowercase or not alphabetic.</returns><param name="c">The Unicode character to convert. </param><filterpriority>1</filterpriority>
        public static char ToLower(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of a Unicode character to its lowercase equivalent using the casing rules of the invariant culture.</summary><returns>The lowercase equivalent of the <paramref name="c" /> parameter, or the unchanged value of <paramref name="c" />, if <paramref name="c" /> is already lowercase or not alphabetic.</returns><param name="c">The Unicode character to convert. </param><filterpriority>1</filterpriority>
        public static char ToLowerInvariant(char c)
        {
             throw new NotImplementedException();
        }
        
        
        public TypeCode GetTypeCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified Unicode character is categorized as a control character.</summary><returns>true if <paramref name="c" /> is a control character; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        public static bool IsControl(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as a control character.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is a control character; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        public static bool IsControl(string s, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as a decimal digit.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is a decimal digit; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        public static bool IsDigit(string s, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as a Unicode letter.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is a letter; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        public static bool IsLetter(string s, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as a letter or a decimal digit.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is a letter or a decimal digit; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        public static bool IsLetterOrDigit(string s, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as a lowercase letter.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is a lowercase letter; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        public static bool IsLower(string s, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified Unicode character is categorized as a number.</summary><returns>true if <paramref name="c" /> is a number; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        public static bool IsNumber(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as a number.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is a number; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        public static bool IsNumber(string s, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as a punctuation mark.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is a punctuation mark; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        public static bool IsPunctuation(string s, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified Unicode character is categorized as a separator character.</summary><returns>true if <paramref name="c" /> is a separator character; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        public static bool IsSeparator(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as a separator character.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is a separator character; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        public static bool IsSeparator(string s, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified character has a surrogate code unit.</summary><returns>true if <paramref name="c" /> is either a high surrogate or a low surrogate; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        public static bool IsSurrogate(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the character at the specified position in a specified string has a surrogate code unit.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is a either a high surrogate or a low surrogate; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        public static bool IsSurrogate(string s, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified Unicode character is categorized as a symbol character.</summary><returns>true if <paramref name="c" /> is a symbol character; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        public static bool IsSymbol(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as a symbol character.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is a symbol character; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        public static bool IsSymbol(string s, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as an uppercase letter.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is an uppercase letter; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        public static bool IsUpper(string s, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as white space.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is white space; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        public static bool IsWhiteSpace(string s, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Categorizes a specified Unicode character into a group identified by one of the <see cref="T:System.Globalization.UnicodeCategory" /> values.</summary><returns>A <see cref="T:System.Globalization.UnicodeCategory" /> value that identifies the group that contains <paramref name="c" />.</returns><param name="c">The Unicode character to categorize. </param><filterpriority>1</filterpriority>
        public static UnicodeCategory GetUnicodeCategory(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Categorizes the character at the specified position in a specified string into a group identified by one of the <see cref="T:System.Globalization.UnicodeCategory" /> values.</summary><returns>A <see cref="T:System.Globalization.UnicodeCategory" /> enumerated constant that identifies the group that contains the character at position <paramref name="index" /> in <paramref name="s" />.</returns><param name="s">A <see cref="T:System.String" />. </param><param name="index">The character position in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        public static UnicodeCategory GetUnicodeCategory(string s, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified numeric Unicode character to a double-precision floating point number.</summary><returns>The numeric value of <paramref name="c" /> if that character represents a number; otherwise, -1.0.</returns><param name="c">The Unicode character to convert. </param><filterpriority>1</filterpriority>
        public static double GetNumericValue(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the numeric Unicode character at the specified position in a specified string to a double-precision floating point number.</summary><returns>The numeric value of the character at position <paramref name="index" /> in <paramref name="s" /> if that character represents a number; otherwise, -1.</returns><param name="s">A <see cref="T:System.String" />. </param><param name="index">The character position in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        public static double GetNumericValue(string s, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified <see cref="T:System.Char" /> object is a high surrogate.</summary><returns>true if the numeric value of the <paramref name="c" /> parameter ranges from U+D800 through U+DBFF; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        public static bool IsHighSurrogate(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the <see cref="T:System.Char" /> object at the specified position in a string is a high surrogate.</summary><returns>true if the numeric value of the specified character in the <paramref name="s" /> parameter ranges from U+D800 through U+DBFF; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is not a position within <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        public static bool IsHighSurrogate(string s, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified <see cref="T:System.Char" /> object is a low surrogate.</summary><returns>true if the numeric value of the <paramref name="c" /> parameter ranges from U+DC00 through U+DFFF; otherwise, false.</returns><param name="c">The character to evaluate. </param><filterpriority>1</filterpriority>
        public static bool IsLowSurrogate(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the <see cref="T:System.Char" /> object at the specified position in a string is a low surrogate.</summary><returns>true if the numeric value of the specified character in the <paramref name="s" /> parameter ranges from U+DC00 through U+DFFF; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is not a position within <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        public static bool IsLowSurrogate(string s, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two adjacent <see cref="T:System.Char" /> objects at a specified position in a string form a surrogate pair.</summary><returns>true if the <paramref name="s" /> parameter includes adjacent characters at positions <paramref name="index" /> and <paramref name="index" /> + 1, and the numeric value of the character at position <paramref name="index" /> ranges from U+D800 through U+DBFF, and the numeric value of the character at position <paramref name="index" />+1 ranges from U+DC00 through U+DFFF; otherwise, false.</returns><param name="s">A string. </param><param name="index">The starting position of the pair of characters to evaluate within <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is not a position within <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        public static bool IsSurrogatePair(string s, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the two specified <see cref="T:System.Char" /> objects form a surrogate pair.</summary><returns>true if the numeric value of the <paramref name="highSurrogate" /> parameter ranges from U+D800 through U+DBFF, and the numeric value of the <paramref name="lowSurrogate" /> parameter ranges from U+DC00 through U+DFFF; otherwise, false.</returns><param name="highSurrogate">The character to evaluate as the high surrogate of a surrogate pair. </param><param name="lowSurrogate">The character to evaluate as the low surrogate of a surrogate pair. </param><filterpriority>1</filterpriority>
        public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified Unicode code point into a UTF-16 encoded string.</summary><returns>A string consisting of one <see cref="T:System.Char" /> object or a surrogate pair of <see cref="T:System.Char" /> objects equivalent to the code point specified by the <paramref name="utf32" /> parameter.</returns><param name="utf32">A 21-bit Unicode code point. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="utf32" /> is not a valid 21-bit Unicode code point ranging from U+0 through U+10FFFF, excluding the surrogate pair range from U+D800 through U+DFFF. </exception><filterpriority>1</filterpriority>
        public static string ConvertFromUtf32(int utf32)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of a UTF-16 encoded surrogate pair into a Unicode code point.</summary><returns>The 21-bit Unicode code point represented by the <paramref name="highSurrogate" /> and <paramref name="lowSurrogate" /> parameters.</returns><param name="highSurrogate">A high surrogate code unit (that is, a code unit ranging from U+D800 through U+DBFF). </param><param name="lowSurrogate">A low surrogate code unit (that is, a code unit ranging from U+DC00 through U+DFFF). </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="highSurrogate" /> is not in the range U+D800 through U+DBFF, or <paramref name="lowSurrogate" /> is not in the range U+DC00 through U+DFFF. </exception><filterpriority>1</filterpriority>
        public static int ConvertToUtf32(char highSurrogate, char lowSurrogate)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of a UTF-16 encoded character or surrogate pair at a specified position in a string into a Unicode code point.</summary><returns>The 21-bit Unicode code point represented by the character or surrogate pair at the position in the <paramref name="s" /> parameter specified by the <paramref name="index" /> parameter.</returns><param name="s">A string that contains a character or surrogate pair. </param><param name="index">The index position of the character or surrogate pair in <paramref name="s" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is not a position within <paramref name="s" />. </exception><exception cref="T:System.ArgumentException">The specified index position contains a surrogate pair, and either the first character in the pair is not a valid high surrogate or the second character in the pair is not a valid low surrogate. </exception><filterpriority>1</filterpriority>
        public static int ConvertToUtf32(string s, int index)
        {
             throw new NotImplementedException();
        }



        TypeCode IConvertible.GetTypeCode()
        {
            throw new NotImplementedException();
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        short IConvertible.ToInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        int IConvertible.ToInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        float IConvertible.ToSingle(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        double IConvertible.ToDouble(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        string IConvertible.ToString(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }
    }
}
