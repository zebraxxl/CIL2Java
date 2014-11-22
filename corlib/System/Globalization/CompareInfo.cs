using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Reflection;
using System.Security;

namespace System.Globalization
{
    /// <summary>Implements a set of methods for culture-sensitive string comparisons.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class CompareInfo : IDeserializationCallback
    {
    
        /// <summary>Gets the name of the culture used for sorting operations by this <see cref="T:System.Globalization.CompareInfo" /> object.</summary><returns>The name of a culture.</returns>
        [ComVisibleAttribute(false)]
        public virtual string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the properly formed culture identifier for the current <see cref="T:System.Globalization.CompareInfo" />.</summary><returns>The properly formed culture identifier for the current <see cref="T:System.Globalization.CompareInfo" />.</returns>
        public int LCID
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets information about the version of Unicode used for comparing and sorting strings.</summary><returns>An object that contains information about the Unicode version used for comparing and sorting strings.</returns>
        public SortVersion Version
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new <see cref="T:System.Globalization.CompareInfo" /> object that is associated with the specified culture and that uses string comparison methods in the specified <see cref="T:System.Reflection.Assembly" />.</summary><returns>A new <see cref="T:System.Globalization.CompareInfo" /> object associated with the culture with the specified identifier and using string comparison methods in the current <see cref="T:System.Reflection.Assembly" />.</returns><param name="culture">An integer representing the culture identifier. </param><param name="assembly">An <see cref="T:System.Reflection.Assembly" /> that contains the string comparison methods to use. </param><exception cref="T:System.ArgumentNullException"><paramref name="assembly" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="assembly" /> is of an invalid type. </exception>
        public static CompareInfo GetCompareInfo(int culture, Assembly assembly)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new <see cref="T:System.Globalization.CompareInfo" /> object that is associated with the specified culture and that uses string comparison methods in the specified <see cref="T:System.Reflection.Assembly" />.</summary><returns>A new <see cref="T:System.Globalization.CompareInfo" /> object associated with the culture with the specified identifier and using string comparison methods in the current <see cref="T:System.Reflection.Assembly" />.</returns><param name="name">A string representing the culture name. </param><param name="assembly">An <see cref="T:System.Reflection.Assembly" /> that contains the string comparison methods to use. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null.-or- <paramref name="assembly" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="name" /> is an invalid culture name.-or- <paramref name="assembly" /> is of an invalid type. </exception>
        public static CompareInfo GetCompareInfo(string name, Assembly assembly)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new <see cref="T:System.Globalization.CompareInfo" /> object that is associated with the culture with the specified identifier.</summary><returns>A new <see cref="T:System.Globalization.CompareInfo" /> object associated with the culture with the specified identifier and using string comparison methods in the current <see cref="T:System.Reflection.Assembly" />.</returns><param name="culture">An integer representing the culture identifier. </param>
        public static CompareInfo GetCompareInfo(int culture)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new <see cref="T:System.Globalization.CompareInfo" /> object that is associated with the culture with the specified name.</summary><returns>A new <see cref="T:System.Globalization.CompareInfo" /> object associated with the culture with the specified identifier and using string comparison methods in the current <see cref="T:System.Reflection.Assembly" />.</returns><param name="name">A string representing the culture name. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="name" /> is an invalid culture name. </exception>
        public static CompareInfo GetCompareInfo(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether a specified Unicode character is sortable.</summary><returns>true if the <paramref name="ch" /> parameter is sortable; otherwise, false.</returns><param name="ch">A Unicode character.</param>
        [ComVisibleAttribute(false)]
        public static bool IsSortable(char ch)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether a specified Unicode string is sortable.</summary><returns>true if the <paramref name="str" /> parameter is not an empty string ("") and all the Unicode characters in <paramref name="str" /> are sortable; otherwise, false.</returns><param name="text">A string of zero or more Unicode characters.</param><exception cref="T:System.ArgumentNullException"><paramref name="str" /> is null.</exception>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public static bool IsSortable(string text)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares two strings. </summary><returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.Value Condition zero The two strings are equal. less than zero <paramref name="string1" /> is less than <paramref name="string2" />. greater than zero <paramref name="string1" /> is greater than <paramref name="string2" />. </returns><param name="string1">The first string to compare. </param><param name="string2">The second string to compare. </param>
        public virtual int Compare(string string1, string string2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares two strings using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary><returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.Value Condition zero The two strings are equal. less than zero <paramref name="string1" /> is less than <paramref name="string2" />. greater than zero <paramref name="string1" /> is greater than <paramref name="string2" />. </returns><param name="string1">The first string to compare. </param><param name="string2">The second string to compare. </param><param name="options">A value that defines how <paramref name="string1" /> and <paramref name="string2" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />, and <see cref="F:System.Globalization.CompareOptions.StringSort" />.</param><exception cref="T:System.ArgumentException"><paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
        [SecuritySafeCriticalAttribute()]
        public virtual int Compare(string string1, string string2, CompareOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares a section of one string with a section of another string.</summary><returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.Value Condition zero The two strings are equal. less than zero The specified section of <paramref name="string1" /> is less than the specified section of <paramref name="string2" />. greater than zero The specified section of <paramref name="string1" /> is greater than the specified section of <paramref name="string2" />. </returns><param name="string1">The first string to compare. </param><param name="offset1">The zero-based index of the character in <paramref name="string1" /> at which to start comparing. </param><param name="length1">The number of consecutive characters in <paramref name="string1" /> to compare. </param><param name="string2">The second string to compare. </param><param name="offset2">The zero-based index of the character in <paramref name="string2" /> at which to start comparing. </param><param name="length2">The number of consecutive characters in <paramref name="string2" /> to compare. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset1" /> or <paramref name="length1" /> or <paramref name="offset2" /> or <paramref name="length2" /> is less than zero.-or- <paramref name="offset1" /> is greater than or equal to the number of characters in <paramref name="string1" />.-or- <paramref name="offset2" /> is greater than or equal to the number of characters in <paramref name="string2" />.-or- <paramref name="length1" /> is greater than the number of characters from <paramref name="offset1" /> to the end of <paramref name="string1" />.-or- <paramref name="length2" /> is greater than the number of characters from <paramref name="offset2" /> to the end of <paramref name="string2" />. </exception>
        public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares the end section of a string with the end section of another string using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary><returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.Value Condition zero The two strings are equal. less than zero The specified section of <paramref name="string1" /> is less than the specified section of <paramref name="string2" />. greater than zero The specified section of <paramref name="string1" /> is greater than the specified section of <paramref name="string2" />. </returns><param name="string1">The first string to compare. </param><param name="offset1">The zero-based index of the character in <paramref name="string1" /> at which to start comparing. </param><param name="string2">The second string to compare. </param><param name="offset2">The zero-based index of the character in <paramref name="string2" /> at which to start comparing. </param><param name="options">A value that defines how <paramref name="string1" /> and <paramref name="string2" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />, and <see cref="F:System.Globalization.CompareOptions.StringSort" />.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset1" /> or <paramref name="offset2" /> is less than zero.-or- <paramref name="offset1" /> is greater than or equal to the number of characters in <paramref name="string1" />.-or- <paramref name="offset2" /> is greater than or equal to the number of characters in <paramref name="string2" />. </exception><exception cref="T:System.ArgumentException"><paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
        public virtual int Compare(string string1, int offset1, string string2, int offset2, CompareOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares the end section of a string with the end section of another string.</summary><returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.Value Condition zero The two strings are equal. less than zero The specified section of <paramref name="string1" /> is less than the specified section of <paramref name="string2" />. greater than zero The specified section of <paramref name="string1" /> is greater than the specified section of <paramref name="string2" />. </returns><param name="string1">The first string to compare. </param><param name="offset1">The zero-based index of the character in <paramref name="string1" /> at which to start comparing. </param><param name="string2">The second string to compare. </param><param name="offset2">The zero-based index of the character in <paramref name="string2" /> at which to start comparing. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset1" /> or <paramref name="offset2" /> is less than zero.-or- <paramref name="offset1" /> is greater than or equal to the number of characters in <paramref name="string1" />.-or- <paramref name="offset2" /> is greater than or equal to the number of characters in <paramref name="string2" />. </exception>
        public virtual int Compare(string string1, int offset1, string string2, int offset2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares a section of one string with a section of another string using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary><returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.Value Condition zero The two strings are equal. less than zero The specified section of <paramref name="string1" /> is less than the specified section of <paramref name="string2" />. greater than zero The specified section of <paramref name="string1" /> is greater than the specified section of <paramref name="string2" />. </returns><param name="string1">The first string to compare. </param><param name="offset1">The zero-based index of the character in <paramref name="string1" /> at which to start comparing. </param><param name="length1">The number of consecutive characters in <paramref name="string1" /> to compare. </param><param name="string2">The second string to compare. </param><param name="offset2">The zero-based index of the character in <paramref name="string2" /> at which to start comparing. </param><param name="length2">The number of consecutive characters in <paramref name="string2" /> to compare. </param><param name="options">A value that defines how <paramref name="string1" /> and <paramref name="string2" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />, and <see cref="F:System.Globalization.CompareOptions.StringSort" />.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset1" /> or <paramref name="length1" /> or <paramref name="offset2" /> or <paramref name="length2" /> is less than zero.-or- <paramref name="offset1" /> is greater than or equal to the number of characters in <paramref name="string1" />.-or- <paramref name="offset2" /> is greater than or equal to the number of characters in <paramref name="string2" />.-or- <paramref name="length1" /> is greater than the number of characters from <paramref name="offset1" /> to the end of <paramref name="string1" />.-or- <paramref name="length2" /> is greater than the number of characters from <paramref name="offset2" /> to the end of <paramref name="string2" />. </exception><exception cref="T:System.ArgumentException"><paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
        [SecuritySafeCriticalAttribute()]
        public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified source string starts with the specified prefix using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary><returns>true if the length of <paramref name="prefix" /> is less than or equal to the length of <paramref name="source" /> and <paramref name="source" /> starts with <paramref name="prefix" />; otherwise, false.</returns><param name="source">The string to search in. </param><param name="prefix">The string to compare with the beginning of <paramref name="source" />. </param><param name="options">A value that defines how <paramref name="source" /> and <paramref name="prefix" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null.-or- <paramref name="prefix" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
        [SecuritySafeCriticalAttribute()]
        public virtual bool IsPrefix(string source, string prefix, CompareOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified source string starts with the specified prefix.</summary><returns>true if the length of <paramref name="prefix" /> is less than or equal to the length of <paramref name="source" /> and <paramref name="source" /> starts with <paramref name="prefix" />; otherwise, false.</returns><param name="source">The string to search in. </param><param name="prefix">The string to compare with the beginning of <paramref name="source" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null.-or- <paramref name="prefix" /> is null. </exception>
        public virtual bool IsPrefix(string source, string prefix)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified source string ends with the specified suffix using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary><returns>true if the length of <paramref name="suffix" /> is less than or equal to the length of <paramref name="source" /> and <paramref name="source" /> ends with <paramref name="suffix" />; otherwise, false.</returns><param name="source">The string to search in. </param><param name="suffix">The string to compare with the end of <paramref name="source" />. </param><param name="options">A value that defines how <paramref name="source" /> and <paramref name="suffix" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" /> used by itself, or the bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null.-or- <paramref name="suffix" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
        [SecuritySafeCriticalAttribute()]
        public virtual bool IsSuffix(string source, string suffix, CompareOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified source string ends with the specified suffix.</summary><returns>true if the length of <paramref name="suffix" /> is less than or equal to the length of <paramref name="source" /> and <paramref name="source" /> ends with <paramref name="suffix" />; otherwise, false.</returns><param name="source">The string to search in. </param><param name="suffix">The string to compare with the end of <paramref name="source" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null.-or- <paramref name="suffix" /> is null. </exception>
        public virtual bool IsSuffix(string source, string suffix)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified character and returns the zero-based index of the first occurrence within the entire source string.</summary><returns>The zero-based index of the first occurrence of <paramref name="value" />, if found, within <paramref name="source" />; otherwise, -1. Returns 0 (zero) if <paramref name="value" /> is an ignorable character.</returns><param name="source">The string to search. </param><param name="value">The character to locate within <paramref name="source" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null. </exception>
        public virtual int IndexOf(string source, char value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified substring and returns the zero-based index of the first occurrence within the entire source string.</summary><returns>The zero-based index of the first occurrence of <paramref name="value" />, if found, within <paramref name="source" />; otherwise, -1. Returns 0 (zero) if <paramref name="value" /> is an ignorable character.</returns><param name="source">The string to search. </param><param name="value">The string to locate within <paramref name="source" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null.-or- <paramref name="value" /> is null. </exception>
        public virtual int IndexOf(string source, string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified character and returns the zero-based index of the first occurrence within the entire source string using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary><returns>The zero-based index of the first occurrence of <paramref name="value" />, if found, within <paramref name="source" />, using the specified comparison options; otherwise, -1. Returns 0 (zero) if <paramref name="value" /> is an ignorable character.</returns><param name="source">The string to search. </param><param name="value">The character to locate within <paramref name="source" />. </param><param name="options">A value that defines how the strings should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
        public virtual int IndexOf(string source, char value, CompareOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified substring and returns the zero-based index of the first occurrence within the entire source string using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary><returns>The zero-based index of the first occurrence of <paramref name="value" />, if found, within <paramref name="source" />, using the specified comparison options; otherwise, -1. Returns 0 (zero) if <paramref name="value" /> is an ignorable character.</returns><param name="source">The string to search. </param><param name="value">The string to locate within <paramref name="source" />. </param><param name="options">A value that defines how <paramref name="source" /> and <paramref name="value" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null.-or- <paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
        public virtual int IndexOf(string source, string value, CompareOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified character and returns the zero-based index of the first occurrence within the section of the source string that extends from the specified index to the end of the string.</summary><returns>The zero-based index of the first occurrence of <paramref name="value" />, if found, within the section of <paramref name="source" /> that extends from <paramref name="startIndex" /> to the end of <paramref name="source" />; otherwise, -1. Returns <paramref name="startIndex" /> if <paramref name="value" /> is an ignorable character.</returns><param name="source">The string to search. </param><param name="value">The character to locate within <paramref name="source" />. </param><param name="startIndex">The zero-based starting index of the search. </param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />. </exception>
        public virtual int IndexOf(string source, char value, int startIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified substring and returns the zero-based index of the first occurrence within the section of the source string that extends from the specified index to the end of the string.</summary><returns>The zero-based index of the first occurrence of <paramref name="value" />, if found, within the section of <paramref name="source" /> that extends from <paramref name="startIndex" /> to the end of <paramref name="source" />; otherwise, -1. Returns <paramref name="startIndex" /> if <paramref name="value" /> is an ignorable character.</returns><param name="source">The string to search. </param><param name="value">The string to locate within <paramref name="source" />. </param><param name="startIndex">The zero-based starting index of the search. </param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null.-or- <paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />. </exception>
        public virtual int IndexOf(string source, string value, int startIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified character and returns the zero-based index of the first occurrence within the section of the source string that extends from the specified index to the end of the string using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary><returns>The zero-based index of the first occurrence of <paramref name="value" />, if found, within the section of <paramref name="source" /> that extends from <paramref name="startIndex" /> to the end of <paramref name="source" />, using the specified comparison options; otherwise, -1. Returns <paramref name="startIndex" /> if <paramref name="value" /> is an ignorable character.</returns><param name="source">The string to search. </param><param name="value">The character to locate within <paramref name="source" />. </param><param name="startIndex">The zero-based starting index of the search. </param><param name="options">A value that defines how <paramref name="source" /> and <paramref name="value" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />. </exception><exception cref="T:System.ArgumentException"><paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
        public virtual int IndexOf(string source, char value, int startIndex, CompareOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified substring and returns the zero-based index of the first occurrence within the section of the source string that extends from the specified index to the end of the string using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary><returns>The zero-based index of the first occurrence of <paramref name="value" />, if found, within the section of <paramref name="source" /> that extends from <paramref name="startIndex" /> to the end of <paramref name="source" />, using the specified comparison options; otherwise, -1. Returns <paramref name="startIndex" /> if <paramref name="value" /> is an ignorable character.</returns><param name="source">The string to search. </param><param name="value">The string to locate within <paramref name="source" />. </param><param name="startIndex">The zero-based starting index of the search. </param><param name="options">A value that defines how <paramref name="source" /> and <paramref name="value" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null.-or- <paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />. </exception><exception cref="T:System.ArgumentException"><paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
        public virtual int IndexOf(string source, string value, int startIndex, CompareOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified character and returns the zero-based index of the first occurrence within the section of the source string that starts at the specified index and contains the specified number of elements.</summary><returns>The zero-based index of the first occurrence of <paramref name="value" />, if found, within the section of <paramref name="source" /> that starts at <paramref name="startIndex" /> and contains the number of elements specified by <paramref name="count" />; otherwise, -1. Returns <paramref name="startIndex" /> if <paramref name="value" /> is an ignorable character.</returns><param name="source">The string to search. </param><param name="value">The character to locate within <paramref name="source" />. </param><param name="startIndex">The zero-based starting index of the search. </param><param name="count">The number of elements in the section to search. </param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />.-or- <paramref name="count" /> is less than zero.-or- <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="source" />. </exception>
        public virtual int IndexOf(string source, char value, int startIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified substring and returns the zero-based index of the first occurrence within the section of the source string that starts at the specified index and contains the specified number of elements.</summary><returns>The zero-based index of the first occurrence of <paramref name="value" />, if found, within the section of <paramref name="source" /> that starts at <paramref name="startIndex" /> and contains the number of elements specified by <paramref name="count" />; otherwise, -1. Returns <paramref name="startIndex" /> if <paramref name="value" /> is an ignorable character.</returns><param name="source">The string to search. </param><param name="value">The string to locate within <paramref name="source" />. </param><param name="startIndex">The zero-based starting index of the search. </param><param name="count">The number of elements in the section to search. </param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null.-or- <paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />.-or- <paramref name="count" /> is less than zero.-or- <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="source" />. </exception>
        public virtual int IndexOf(string source, string value, int startIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified character and returns the zero-based index of the first occurrence within the section of the source string that starts at the specified index and contains the specified number of elements using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary><returns>The zero-based index of the first occurrence of <paramref name="value" />, if found, within the section of <paramref name="source" /> that starts at <paramref name="startIndex" /> and contains the number of elements specified by <paramref name="count" />, using the specified comparison options; otherwise, -1. Returns <paramref name="startIndex" /> if <paramref name="value" /> is an ignorable character.</returns><param name="source">The string to search. </param><param name="value">The character to locate within <paramref name="source" />. </param><param name="startIndex">The zero-based starting index of the search. </param><param name="count">The number of elements in the section to search. </param><param name="options">A value that defines how <paramref name="source" /> and <paramref name="value" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />.-or- <paramref name="count" /> is less than zero.-or- <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="source" />. </exception><exception cref="T:System.ArgumentException"><paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
        [SecuritySafeCriticalAttribute()]
        public virtual int IndexOf(string source, char value, int startIndex, int count, CompareOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified substring and returns the zero-based index of the first occurrence within the section of the source string that starts at the specified index and contains the specified number of elements using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary><returns>The zero-based index of the first occurrence of <paramref name="value" />, if found, within the section of <paramref name="source" /> that starts at <paramref name="startIndex" /> and contains the number of elements specified by <paramref name="count" />, using the specified comparison options; otherwise, -1. Returns <paramref name="startIndex" /> if <paramref name="value" /> is an ignorable character.</returns><param name="source">The string to search. </param><param name="value">The string to locate within <paramref name="source" />. </param><param name="startIndex">The zero-based starting index of the search. </param><param name="count">The number of elements in the section to search. </param><param name="options">A value that defines how <paramref name="source" /> and <paramref name="value" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null.-or- <paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />.-or- <paramref name="count" /> is less than zero.-or- <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="source" />. </exception><exception cref="T:System.ArgumentException"><paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
        [SecuritySafeCriticalAttribute()]
        public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified character and returns the zero-based index of the last occurrence within the entire source string.</summary><returns>The zero-based index of the last occurrence of <paramref name="value" />, if found, within <paramref name="source" />; otherwise, -1.</returns><param name="source">The string to search. </param><param name="value">The character to locate within <paramref name="source" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null. </exception>
        public virtual int LastIndexOf(string source, char value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified substring and returns the zero-based index of the last occurrence within the entire source string.</summary><returns>The zero-based index of the last occurrence of <paramref name="value" />, if found, within <paramref name="source" />; otherwise, -1.</returns><param name="source">The string to search. </param><param name="value">The string to locate within <paramref name="source" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null.-or- <paramref name="value" /> is null. </exception>
        public virtual int LastIndexOf(string source, string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified character and returns the zero-based index of the last occurrence within the entire source string using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary><returns>The zero-based index of the last occurrence of <paramref name="value" />, if found, within <paramref name="source" />, using the specified comparison options; otherwise, -1.</returns><param name="source">The string to search. </param><param name="value">The character to locate within <paramref name="source" />. </param><param name="options">A value that defines how <paramref name="source" /> and <paramref name="value" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
        public virtual int LastIndexOf(string source, char value, CompareOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified substring and returns the zero-based index of the last occurrence within the entire source string using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary><returns>The zero-based index of the last occurrence of <paramref name="value" />, if found, within <paramref name="source" />, using the specified comparison options; otherwise, -1.</returns><param name="source">The string to search. </param><param name="value">The string to locate within <paramref name="source" />. </param><param name="options">A value that defines how <paramref name="source" /> and <paramref name="value" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null.-or- <paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
        public virtual int LastIndexOf(string source, string value, CompareOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified character and returns the zero-based index of the last occurrence within the section of the source string that extends from the beginning of the string to the specified index.</summary><returns>The zero-based index of the last occurrence of <paramref name="value" />, if found, within the section of <paramref name="source" /> that extends from the beginning of <paramref name="source" /> to <paramref name="startIndex" />; otherwise, -1. Returns <paramref name="startIndex" /> if <paramref name="value" /> is an ignorable character.</returns><param name="source">The string to search. </param><param name="value">The character to locate within <paramref name="source" />. </param><param name="startIndex">The zero-based starting index of the backward search. </param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />. </exception>
        public virtual int LastIndexOf(string source, char value, int startIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified substring and returns the zero-based index of the last occurrence within the section of the source string that extends from the beginning of the string to the specified index.</summary><returns>The zero-based index of the last occurrence of <paramref name="value" />, if found, within the section of <paramref name="source" /> that extends from the beginning of <paramref name="source" /> to <paramref name="startIndex" />; otherwise, -1. Returns <paramref name="startIndex" /> if <paramref name="value" /> is an ignorable character.</returns><param name="source">The string to search. </param><param name="value">The string to locate within <paramref name="source" />. </param><param name="startIndex">The zero-based starting index of the backward search. </param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null.-or- <paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />. </exception>
        public virtual int LastIndexOf(string source, string value, int startIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified character and returns the zero-based index of the last occurrence within the section of the source string that extends from the beginning of the string to the specified index using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary><returns>The zero-based index of the last occurrence of <paramref name="value" />, if found, within the section of <paramref name="source" /> that extends from the beginning of <paramref name="source" /> to <paramref name="startIndex" />, using the specified comparison options; otherwise, -1. Returns <paramref name="startIndex" /> if <paramref name="value" /> is an ignorable character.</returns><param name="source">The string to search. </param><param name="value">The character to locate within <paramref name="source" />. </param><param name="startIndex">The zero-based starting index of the backward search. </param><param name="options">A value that defines how <paramref name="source" /> and <paramref name="value" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />. </exception><exception cref="T:System.ArgumentException"><paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
        public virtual int LastIndexOf(string source, char value, int startIndex, CompareOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified substring and returns the zero-based index of the last occurrence within the section of the source string that extends from the beginning of the string to the specified index using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary><returns>The zero-based index of the last occurrence of <paramref name="value" />, if found, within the section of <paramref name="source" /> that extends from the beginning of <paramref name="source" /> to <paramref name="startIndex" />, using the specified comparison options; otherwise, -1. Returns <paramref name="startIndex" /> if <paramref name="value" /> is an ignorable character.</returns><param name="source">The string to search. </param><param name="value">The string to locate within <paramref name="source" />. </param><param name="startIndex">The zero-based starting index of the backward search. </param><param name="options">A value that defines how <paramref name="source" /> and <paramref name="value" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null.-or- <paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />. </exception><exception cref="T:System.ArgumentException"><paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
        public virtual int LastIndexOf(string source, string value, int startIndex, CompareOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified character and returns the zero-based index of the last occurrence within the section of the source string that contains the specified number of elements and ends at the specified index.</summary><returns>The zero-based index of the last occurrence of <paramref name="value" />, if found, within the section of <paramref name="source" /> that contains the number of elements specified by <paramref name="count" /> and that ends at <paramref name="startIndex" />; otherwise, -1. Returns <paramref name="startIndex" /> if <paramref name="value" /> is an ignorable character.</returns><param name="source">The string to search. </param><param name="value">The character to locate within <paramref name="source" />. </param><param name="startIndex">The zero-based starting index of the backward search. </param><param name="count">The number of elements in the section to search. </param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />.-or- <paramref name="count" /> is less than zero.-or- <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="source" />. </exception>
        public virtual int LastIndexOf(string source, char value, int startIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified substring and returns the zero-based index of the last occurrence within the section of the source string that contains the specified number of elements and ends at the specified index.</summary><returns>The zero-based index of the last occurrence of <paramref name="value" />, if found, within the section of <paramref name="source" /> that contains the number of elements specified by <paramref name="count" /> and that ends at <paramref name="startIndex" />; otherwise, -1. Returns <paramref name="startIndex" /> if <paramref name="value" /> is an ignorable character.</returns><param name="source">The string to search. </param><param name="value">The string to locate within <paramref name="source" />. </param><param name="startIndex">The zero-based starting index of the backward search. </param><param name="count">The number of elements in the section to search. </param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null.-or- <paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />.-or- <paramref name="count" /> is less than zero.-or- <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="source" />. </exception>
        public virtual int LastIndexOf(string source, string value, int startIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified character and returns the zero-based index of the last occurrence within the section of the source string that contains the specified number of elements and ends at the specified index using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary><returns>The zero-based index of the last occurrence of <paramref name="value" />, if found, within the section of <paramref name="source" /> that contains the number of elements specified by <paramref name="count" /> and that ends at <paramref name="startIndex" />, using the specified comparison options; otherwise, -1. Returns <paramref name="startIndex" /> if <paramref name="value" /> is an ignorable character.</returns><param name="source">The string to search. </param><param name="value">The character to locate within <paramref name="source" />. </param><param name="startIndex">The zero-based starting index of the backward search. </param><param name="count">The number of elements in the section to search. </param><param name="options">A value that defines how <paramref name="source" /> and <paramref name="value" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />.-or- <paramref name="count" /> is less than zero.-or- <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="source" />. </exception><exception cref="T:System.ArgumentException"><paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
        [SecuritySafeCriticalAttribute()]
        public virtual int LastIndexOf(string source, char value, int startIndex, int count, CompareOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified substring and returns the zero-based index of the last occurrence within the section of the source string that contains the specified number of elements and ends at the specified index using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary><returns>The zero-based index of the last occurrence of <paramref name="value" />, if found, within the section of <paramref name="source" /> that contains the number of elements specified by <paramref name="count" /> and that ends at <paramref name="startIndex" />, using the specified comparison options; otherwise, -1. Returns <paramref name="startIndex" /> if <paramref name="value" /> is an ignorable character. </returns><param name="source">The string to search. </param><param name="value">The string to locate within <paramref name="source" />. </param><param name="startIndex">The zero-based starting index of the backward search. </param><param name="count">The number of elements in the section to search. </param><param name="options">A value that defines how <paramref name="source" /> and <paramref name="value" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" /> is null.-or- <paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />.-or- <paramref name="count" /> is less than zero.-or- <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="source" />. </exception><exception cref="T:System.ArgumentException"><paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
        [SecuritySafeCriticalAttribute()]
        public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a <see cref="T:System.Globalization.SortKey" /> object for the specified string using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary><returns>The <see cref="T:System.Globalization.SortKey" /> object that contains the sort key for the specified string.</returns><param name="source">The string for which a <see cref="T:System.Globalization.SortKey" /> object is obtained. </param><param name="options">A bitwise combination of one or more of the following enumeration values that define how the sort key is calculated: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />, and <see cref="F:System.Globalization.CompareOptions.StringSort" />.</param><exception cref="T:System.ArgumentException"><paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public virtual SortKey GetSortKey(string source, CompareOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the sort key for the specified string.</summary><returns>The <see cref="T:System.Globalization.SortKey" /> object that contains the sort key for the specified string.</returns><param name="source">The string for which a <see cref="T:System.Globalization.SortKey" /> object is obtained. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public virtual SortKey GetSortKey(string source)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified object is equal to the current <see cref="T:System.Globalization.CompareInfo" /> object.</summary><returns>true if the specified object is equal to the current <see cref="T:System.Globalization.CompareInfo" />; otherwise, false.</returns><param name="value">The object to compare with the current <see cref="T:System.Globalization.CompareInfo" />. </param>
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



        void IDeserializationCallback.OnDeserialization(object sender)
        {
            throw new NotImplementedException();
        }
    }
}
