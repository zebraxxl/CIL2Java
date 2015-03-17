using System.Runtime.InteropServices;
using System.Globalization;
using CIL2Java.Attributes;
using javaChar = java.lang.Character;
using mapChar = CIL2Java.Maps.CharMap;

namespace System
{
    /// <summary>Represents a character as a UTF-16 code unit.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [JavaBoxTypeMap(typeof(javaChar))]
    [JavaBoxedInterfacesMap(typeof(mapChar))]
    public struct Char : IComparable, IConvertible, IComparable<Char>, IEquatable<Char>
    {
        private char m_value;

        private Char(char value)
        {
            this.m_value = value;
        }

        [return: Boxed]
        public static char valueOf(char value)
        {
            return new Char(value);
        }

        /// <summary>Represents the largest possible value of a <see cref="T:System.Char" />. This field is constant.</summary><filterpriority>1</filterpriority>
        public const char MaxValue = (char)0xffff;
        /// <summary>Represents the smallest possible value of a <see cref="T:System.Char" />. This field is constant.</summary><filterpriority>1</filterpriority>
        public const char MinValue = (char)0x0000;
    
        [JavaBoxMethodMap(typeof(javaChar), "hashCode")]
        public override int GetHashCode()
        {
            return (int)m_value;
        }
        
        /// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> is an instance of <see cref="T:System.Char" /> and equals the value of this instance; otherwise, false.</returns><param name="obj">An object to compare with this instance or null. </param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(javaChar), "equals")]
        public override bool Equals(object obj)
        {
            if (!(obj is Char))
            {
                return false;
            }
            return (m_value == ((Char)obj).m_value);
        }
        
        /// <summary>Returns a value that indicates whether this instance is equal to the specified <see cref="T:System.Char" /> object.</summary><returns>true if the <paramref name="obj" /> parameter equals the value of this instance; otherwise, false.</returns><param name="obj">An object to compare to this instance. </param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "equals", true)]
        public bool Equals(char obj)
        {
            return m_value == obj;
        }
        
        /// <summary>Compares this instance to a specified object and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified <see cref="T:System.Object" />.</summary><returns>A signed number indicating the position of this instance in the sort order in relation to the <paramref name="value" /> parameter.Return Value Description Less than zero This instance precedes <paramref name="value" />. Zero This instance has the same position in the sort order as <paramref name="value" />. Greater than zero This instance follows <paramref name="value" />.-or- <paramref name="value" /> is null. </returns><param name="value">An object to compare this instance to, or null. </param><exception cref="T:System.ArgumentException"><paramref name="value" /> is not a <see cref="T:System.Char" /> object. </exception><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "CompareTo", true)]
        public int CompareTo(object value)
        {
            if (value == null)
            {
                return 1;
            }
            if (!(value is Char))
            {
                throw new ArgumentException(Environment.GetResourceString("Arg_MustBeChar"));
            }

            return (m_value - ((Char)value).m_value);
        }
        
        /// <summary>Compares this instance to a specified <see cref="T:System.Char" /> object and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified <see cref="T:System.Char" /> object.</summary><returns>A signed number indicating the position of this instance in the sort order in relation to the <paramref name="value" /> parameter.Return Value Description Less than zero This instance precedes <paramref name="value" />. Zero This instance has the same position in the sort order as <paramref name="value" />. Greater than zero This instance follows <paramref name="value" />. </returns><param name="value">A <see cref="T:System.Char" /> object to compare. </param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "CompareTo", true)]
        public int CompareTo(char value)
        {
            return (m_value - value);
        }

        [JavaBoxMethodMap(typeof(javaChar), "toString")]
        public override string ToString()
        {
            return new string(m_value, 1);
        }
        
        /// <summary>Converts the value of this instance to its equivalent string representation using the specified culture-specific format information.</summary><returns>The string representation of the value of this instance as specified by <paramref name="provider" />.</returns><param name="provider">(Reserved) An object that supplies culture-specific formatting information. </param><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "toString", true)]
        public string ToString(IFormatProvider provider)
        {
            return new string(m_value, 1);
        }
        
        /// <summary>Converts the specified Unicode character to its equivalent string representation.</summary><returns>The string representation of the value of <paramref name="c" />.</returns><param name="c">The Unicode character to convert. </param><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "toString")]
        public static string ToString(char c)
        {
            return new string(c, 1);
        }
        
        /// <summary>Converts the value of the specified string to its equivalent Unicode character.</summary><returns>A Unicode character equivalent to the sole character in <paramref name="s" />.</returns><param name="s">A string that contains a single character, or null. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException">The length of <paramref name="s" /> is not 1. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "Parse")]
        public static char Parse(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException("s");
            }

            if (s.Length != 1)
            {
                throw new FormatException(Environment.GetResourceString("Format_NeedSingleChar"));
            }
            return s[0];
        }

        [JavaBoxMethodMap(typeof(mapChar), "TryParse")]
        public static bool TryParse(string s, out char result)
        {
            result = '\0';
            if (s == null)
            {
                return false;
            }
            if (s.Length != 1)
            {
                return false;
            }
            result = s[0];
            return true;
        }

        #region Char static methods
        /// <summary>Indicates whether the specified Unicode character is categorized as a decimal digit.</summary><returns>true if <paramref name="c" /> is a decimal digit; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        [MethodMap(typeof(javaChar), "isDigit")]
        public static bool IsDigit(char c)
        {
            return javaChar.isDigit(c);
        }
        
        /// <summary>Indicates whether the specified Unicode character is categorized as a Unicode letter. </summary><returns>true if <paramref name="c" /> is a letter; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        [MethodMap(typeof(javaChar), "isLetter")]
        public static bool IsLetter(char c)
        {
            return javaChar.isLetter(c);
        }
        
        /// <summary>Indicates whether the specified Unicode character is categorized as white space.</summary><returns>true if <paramref name="c" /> is white space; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        [MethodMap(typeof(javaChar), "isWhitespace")]
        public static bool IsWhiteSpace(char c)
        {
            return javaChar.isWhitespace(c);
        }
        
        /// <summary>Indicates whether the specified Unicode character is categorized as an uppercase letter.</summary><returns>true if <paramref name="c" /> is an uppercase letter; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        [MethodMap(typeof(javaChar), "isUpperCase")]
        public static bool IsUpper(char c)
        {
            return javaChar.isUpperCase(c);
        }
        
        /// <summary>Indicates whether the specified Unicode character is categorized as a lowercase letter.</summary><returns>true if <paramref name="c" /> is a lowercase letter; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        [MethodMap(typeof(javaChar), "isLowerCase")]
        public static bool IsLower(char c)
        {
            return javaChar.isLowerCase(c);
        }
        
        /// <summary>Indicates whether the specified Unicode character is categorized as a punctuation mark.</summary><returns>true if <paramref name="c" /> is a punctuation mark; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "IsPunctuation")]
        public static bool IsPunctuation(char c)
        {
            int uc = javaChar.getType(c);

            switch (uc)
            {
                case javaChar.CONNECTOR_PUNCTUATION:
                case javaChar.DASH_PUNCTUATION:
                case javaChar.START_PUNCTUATION:
                case javaChar.END_PUNCTUATION:
                case javaChar.INITIAL_QUOTE_PUNCTUATION:
                case javaChar.FINAL_QUOTE_PUNCTUATION:
                case javaChar.OTHER_PUNCTUATION:
                    return true;

                default:
                    return false;
            }
        }
        
        /// <summary>Indicates whether the specified Unicode character is categorized as a letter or a decimal digit.</summary><returns>true if <paramref name="c" /> is a letter or a decimal digit; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        [MethodMap(typeof(javaChar), "isLetterOrDigit")]
        public static bool IsLetterOrDigit(char c)
        {
            return javaChar.isLetterOrDigit(c);
        }
        
        /// <summary>Converts the value of a specified Unicode character to its uppercase equivalent using specified culture-specific formatting information.</summary><returns>The uppercase equivalent of <paramref name="c" />, modified according to <paramref name="culture" />, or the unchanged value of <paramref name="c" /> if <paramref name="c" /> is already uppercase, has no uppercase equivalent, or is not alphabetic.</returns><param name="c">The Unicode character to convert. </param><param name="culture">An object that supplies culture-specific casing rules. </param><exception cref="T:System.ArgumentNullException"><paramref name="culture" /> is null. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "ToUpper")]
        public static char ToUpper(char c, CultureInfo culture)
        {
            //TODO: char.ToUpper - use CultureInfo
            return javaChar.toUpperCase(c);
        }
        
        /// <summary>Converts the value of a Unicode character to its uppercase equivalent.</summary><returns>The uppercase equivalent of <paramref name="c" />, or the unchanged value of <paramref name="c" /> if <paramref name="c" /> is already uppercase, has no uppercase equivalent, or is not alphabetic.</returns><param name="c">The Unicode character to convert. </param><filterpriority>1</filterpriority>
        [MethodMap(typeof(javaChar), "toUpperCase")]
        public static char ToUpper(char c)
        {
            return javaChar.toUpperCase(c);
        }
        
        /// <summary>Converts the value of a Unicode character to its uppercase equivalent using the casing rules of the invariant culture.</summary><returns>The uppercase equivalent of the <paramref name="c" /> parameter, or the unchanged value of <paramref name="c" />, if <paramref name="c" /> is already uppercase or not alphabetic.</returns><param name="c">The Unicode character to convert. </param><filterpriority>1</filterpriority>
        [MethodMap(typeof(javaChar), "toUpperCase")]
        public static char ToUpperInvariant(char c)
        {
            return javaChar.toUpperCase(c);
        }
        
        /// <summary>Converts the value of a specified Unicode character to its lowercase equivalent using specified culture-specific formatting information.</summary><returns>The lowercase equivalent of <paramref name="c" />, modified according to <paramref name="culture" />, or the unchanged value of <paramref name="c" />, if <paramref name="c" /> is already lowercase or not alphabetic.</returns><param name="c">The Unicode character to convert. </param><param name="culture">An object that supplies culture-specific casing rules. </param><exception cref="T:System.ArgumentNullException"><paramref name="culture" /> is null. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "ToLower")]
        public static char ToLower(char c, CultureInfo culture)
        {
            return javaChar.toLowerCase(c);
        }
        
        /// <summary>Converts the value of a Unicode character to its lowercase equivalent.</summary><returns>The lowercase equivalent of <paramref name="c" />, or the unchanged value of <paramref name="c" />, if <paramref name="c" /> is already lowercase or not alphabetic.</returns><param name="c">The Unicode character to convert. </param><filterpriority>1</filterpriority>
        [MethodMap(typeof(javaChar), "toLowerCase")]
        public static char ToLower(char c)
        {
            return javaChar.toLowerCase(c);
        }
        
        /// <summary>Converts the value of a Unicode character to its lowercase equivalent using the casing rules of the invariant culture.</summary><returns>The lowercase equivalent of the <paramref name="c" /> parameter, or the unchanged value of <paramref name="c" />, if <paramref name="c" /> is already lowercase or not alphabetic.</returns><param name="c">The Unicode character to convert. </param><filterpriority>1</filterpriority>
        [MethodMap(typeof(javaChar), "toLowerCase")]
        public static char ToLowerInvariant(char c)
        {
            return javaChar.toLowerCase(c);
        }

        [JavaBoxMethodMap(typeof(mapChar), "GetTypeCode", true)]
        public TypeCode GetTypeCode()
        {
            return TypeCode.Char;
        }
        
        /// <summary>Indicates whether the specified Unicode character is categorized as a control character.</summary><returns>true if <paramref name="c" /> is a control character; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "IsControl")]
        public static bool IsControl(char c)
        {
            return javaChar.getType(c) == javaChar.CONTROL;
        }
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as a control character.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is a control character; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "IsControl")]
        public static bool IsControl(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return IsControl(s[index]);
        }
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as a decimal digit.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is a decimal digit; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "IsDigit")]
        public static bool IsDigit(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return IsDigit(s[index]);
        }
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as a Unicode letter.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is a letter; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "IsLetter")]
        public static bool IsLetter(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return IsLetter(s[index]);
        }
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as a letter or a decimal digit.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is a letter or a decimal digit; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "IsLetterOrDigit")]
        public static bool IsLetterOrDigit(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return IsLetterOrDigit(s[index]);
        }
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as a lowercase letter.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is a lowercase letter; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "IsLower")]
        public static bool IsLower(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return IsLower(s[index]);
        }
        
        /// <summary>Indicates whether the specified Unicode character is categorized as a number.</summary><returns>true if <paramref name="c" /> is a number; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "IsNumber")]
        public static bool IsNumber(char c)
        {
            switch (javaChar.getType(c))
            {
                case javaChar.DECIMAL_DIGIT_NUMBER:
                case javaChar.LETTER_NUMBER:
                case javaChar.OTHER_NUMBER:
                    return true;

                default:
                    return false;
            }
        }
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as a number.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is a number; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "IsNumber")]
        public static bool IsNumber(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return IsNumber(s[index]);
        }
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as a punctuation mark.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is a punctuation mark; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "IsPunctuation")]
        public static bool IsPunctuation(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return IsPunctuation(s[index]);
        }
        
        /// <summary>Indicates whether the specified Unicode character is categorized as a separator character.</summary><returns>true if <paramref name="c" /> is a separator character; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "IsSeparator")]
        public static bool IsSeparator(char c)
        {
            switch (javaChar.getType(c))
            {
                case javaChar.SPACE_SEPARATOR:
                case javaChar.LINE_SEPARATOR:
                case javaChar.PARAGRAPH_SEPARATOR:
                    return true;

                default:
                    return false;
            }
        }
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as a separator character.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is a separator character; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "IsSeparator")]
        public static bool IsSeparator(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return IsSeparator(s[index]);
        }
        
        /// <summary>Indicates whether the specified character has a surrogate code unit.</summary><returns>true if <paramref name="c" /> is either a high surrogate or a low surrogate; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        [MethodMap(typeof(javaChar), "isSurrogate")]
        public static bool IsSurrogate(char c)
        {
            return javaChar.isSurrogate(c);
        }
        
        /// <summary>Indicates whether the character at the specified position in a specified string has a surrogate code unit.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is a either a high surrogate or a low surrogate; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "IsSurrogate")]
        public static bool IsSurrogate(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return IsSurrogate(s[index]);
        }
        
        /// <summary>Indicates whether the specified Unicode character is categorized as a symbol character.</summary><returns>true if <paramref name="c" /> is a symbol character; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "IsSymbol")]
        public static bool IsSymbol(char c)
        {
            switch (javaChar.getType(c))
            {
                case javaChar.MATH_SYMBOL:
                case javaChar.CURRENCY_SYMBOL:
                case javaChar.MODIFIER_SYMBOL:
                case javaChar.OTHER_SYMBOL:
                    return true;
                    
                default:
                    return false;
            }
        }
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as a symbol character.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is a symbol character; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "IsSymbol")]
        public static bool IsSymbol(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return IsSymbol(s[index]);
        }
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as an uppercase letter.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is an uppercase letter; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "IsUpper")]
        public static bool IsUpper(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return IsUpper(s[index]);
        }
        
        /// <summary>Indicates whether the character at the specified position in a specified string is categorized as white space.</summary><returns>true if the character at position <paramref name="index" /> in <paramref name="s" /> is white space; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "IsWhiteSpace")]
        public static bool IsWhiteSpace(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return IsWhiteSpace(s[index]);
        }

        /// <summary>Categorizes a specified Unicode character into a group identified by one of the <see cref="T:System.Globalization.UnicodeCategory" /> values.</summary><returns>A <see cref="T:System.Globalization.UnicodeCategory" /> value that identifies the group that contains <paramref name="c" />.</returns><param name="c">The Unicode character to categorize. </param><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "GetUnicodeCategory")]
        public static UnicodeCategory GetUnicodeCategory(char c)
        {
            return mapChar.GetUnicodeCategory(c);
        }
        
        /// <summary>Categorizes the character at the specified position in a specified string into a group identified by one of the <see cref="T:System.Globalization.UnicodeCategory" /> values.</summary><returns>A <see cref="T:System.Globalization.UnicodeCategory" /> enumerated constant that identifies the group that contains the character at position <paramref name="index" /> in <paramref name="s" />.</returns><param name="s">A <see cref="T:System.String" />. </param><param name="index">The character position in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "GetUnicodeCategory")]
        public static UnicodeCategory GetUnicodeCategory(string s, int index)
        {
            return mapChar.GetUnicodeCategory(s, index);
        }
        
        /// <summary>Converts the specified numeric Unicode character to a double-precision floating point number.</summary><returns>The numeric value of <paramref name="c" /> if that character represents a number; otherwise, -1.0.</returns><param name="c">The Unicode character to convert. </param><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "GetNumericValue")]
        public static double GetNumericValue(char c)
        {
            return (double)javaChar.getNumericValue(c);
        }
        
        /// <summary>Converts the numeric Unicode character at the specified position in a specified string to a double-precision floating point number.</summary><returns>The numeric value of the character at position <paramref name="index" /> in <paramref name="s" /> if that character represents a number; otherwise, -1.</returns><param name="s">A <see cref="T:System.String" />. </param><param name="index">The character position in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "GetNumericValue")]
        public static double GetNumericValue(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return (double)javaChar.getNumericValue(s[index]);
        }
        
        /// <summary>Indicates whether the specified <see cref="T:System.Char" /> object is a high surrogate.</summary><returns>true if the numeric value of the <paramref name="c" /> parameter ranges from U+D800 through U+DBFF; otherwise, false.</returns><param name="c">The Unicode character to evaluate. </param><filterpriority>1</filterpriority>
        [MethodMap(typeof(javaChar), "isHighSurrogate")]
        public static bool IsHighSurrogate(char c)
        {
            return javaChar.isHighSurrogate(c);
        }
        
        /// <summary>Indicates whether the <see cref="T:System.Char" /> object at the specified position in a string is a high surrogate.</summary><returns>true if the numeric value of the specified character in the <paramref name="s" /> parameter ranges from U+D800 through U+DBFF; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is not a position within <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "IsHighSurrogate")]
        public static bool IsHighSurrogate(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return javaChar.isHighSurrogate(s[index]);
        }
        
        /// <summary>Indicates whether the specified <see cref="T:System.Char" /> object is a low surrogate.</summary><returns>true if the numeric value of the <paramref name="c" /> parameter ranges from U+DC00 through U+DFFF; otherwise, false.</returns><param name="c">The character to evaluate. </param><filterpriority>1</filterpriority>
        [MethodMap(typeof(javaChar), "isLowSurrogate")]
        public static bool IsLowSurrogate(char c)
        {
            return javaChar.isLowSurrogate(c);
        }
        
        /// <summary>Indicates whether the <see cref="T:System.Char" /> object at the specified position in a string is a low surrogate.</summary><returns>true if the numeric value of the specified character in the <paramref name="s" /> parameter ranges from U+DC00 through U+DFFF; otherwise, false.</returns><param name="s">A string. </param><param name="index">The position of the character to evaluate in <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is not a position within <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "IsLowSurrogate")]
        public static bool IsLowSurrogate(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return javaChar.isLowSurrogate(s[index]);
        }

        /// <summary>Indicates whether two adjacent <see cref="T:System.Char" /> objects at a specified position in a string form a surrogate pair.</summary><returns>true if the <paramref name="s" /> parameter includes adjacent characters at positions <paramref name="index" /> and <paramref name="index" /> + 1, and the numeric value of the character at position <paramref name="index" /> ranges from U+D800 through U+DBFF, and the numeric value of the character at position <paramref name="index" />+1 ranges from U+DC00 through U+DFFF; otherwise, false.</returns><param name="s">A string. </param><param name="index">The starting position of the pair of characters to evaluate within <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is not a position within <paramref name="s" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "IsSurrogatePair")]
        public static bool IsSurrogatePair(string s, int index)
        {
            if (s == null)
            {
                throw new ArgumentNullException("s");
            }
            if (index < 0 || index >= s.Length)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            if (index + 1 < s.Length)
            {
                return (IsSurrogatePair(s[index], s[index + 1]));
            }
            return (false);
        }

        /// <summary>Indicates whether the two specified <see cref="T:System.Char" /> objects form a surrogate pair.</summary><returns>true if the numeric value of the <paramref name="highSurrogate" /> parameter ranges from U+D800 through U+DBFF, and the numeric value of the <paramref name="lowSurrogate" /> parameter ranges from U+DC00 through U+DFFF; otherwise, false.</returns><param name="highSurrogate">The character to evaluate as the high surrogate of a surrogate pair. </param><param name="lowSurrogate">The character to evaluate as the low surrogate of a surrogate pair. </param><filterpriority>1</filterpriority>
        [MethodMap(typeof(javaChar), "isLowSurrogate")]
        public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate)
        {
            return javaChar.isSurrogatePair(highSurrogate, lowSurrogate);
        }

        internal const int UNICODE_PLANE00_END = 0x00ffff;
        // The starting codepoint for Unicode plane 1.  Plane 1 contains 0x010000 ~ 0x01ffff.
        internal const int UNICODE_PLANE01_START = 0x10000;
        // The end codepoint for Unicode plane 16.  This is the maximum code point value allowed for Unicode.
        // Plane 16 contains 0x100000 ~ 0x10ffff.
        internal const int UNICODE_PLANE16_END = 0x10ffff;

        internal const int HIGH_SURROGATE_START = 0x00d800;
        internal const int LOW_SURROGATE_END = 0x00dfff;

        /// <summary>Converts the specified Unicode code point into a UTF-16 encoded string.</summary><returns>A string consisting of one <see cref="T:System.Char" /> object or a surrogate pair of <see cref="T:System.Char" /> objects equivalent to the code point specified by the <paramref name="utf32" /> parameter.</returns><param name="utf32">A 21-bit Unicode code point. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="utf32" /> is not a valid 21-bit Unicode code point ranging from U+0 through U+10FFFF, excluding the surrogate pair range from U+D800 through U+DFFF. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "ConvertFromUtf32")]
        public static string ConvertFromUtf32(int utf32)
        {// For UTF32 values from U+00D800 ~ U+00DFFF, we should throw.  They
            // are considered as irregular code unit sequence, but they are not illegal.
            if ((utf32 < 0 || utf32 > UNICODE_PLANE16_END) || (utf32 >= HIGH_SURROGATE_START && utf32 <= LOW_SURROGATE_END))
            {
                throw new ArgumentOutOfRangeException("utf32", Environment.GetResourceString("ArgumentOutOfRange_InvalidUTF32"));
            }

            if (utf32 < UNICODE_PLANE01_START)
            {
                // This is a BMP character.
                return (Char.ToString((char)utf32));
            }
            // This is a sumplementary character.  Convert it to a surrogate pair in UTF-16.
            utf32 -= UNICODE_PLANE01_START;
            char[] surrogate = new char[2];
            surrogate[0] = (char)((utf32 / 0x400) + (int)CharUnicodeInfo.HIGH_SURROGATE_START);
            surrogate[1] = (char)((utf32 % 0x400) + (int)CharUnicodeInfo.LOW_SURROGATE_START);
            return (new String(surrogate));
        }
        
        
        /// <summary>Converts the value of a UTF-16 encoded surrogate pair into a Unicode code point.</summary><returns>The 21-bit Unicode code point represented by the <paramref name="highSurrogate" /> and <paramref name="lowSurrogate" /> parameters.</returns><param name="highSurrogate">A high surrogate code unit (that is, a code unit ranging from U+D800 through U+DBFF). </param><param name="lowSurrogate">A low surrogate code unit (that is, a code unit ranging from U+DC00 through U+DFFF). </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="highSurrogate" /> is not in the range U+D800 through U+DBFF, or <paramref name="lowSurrogate" /> is not in the range U+DC00 through U+DFFF. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "ConvertToUtf32")]
        public static int ConvertToUtf32(char highSurrogate, char lowSurrogate)
        {
            if (!IsHighSurrogate(highSurrogate))
            {
                throw new ArgumentOutOfRangeException("highSurrogate", Environment.GetResourceString("ArgumentOutOfRange_InvalidHighSurrogate"));
            }
            if (!IsLowSurrogate(lowSurrogate))
            {
                throw new ArgumentOutOfRangeException("lowSurrogate", Environment.GetResourceString("ArgumentOutOfRange_InvalidLowSurrogate"));
            }
            return (((highSurrogate - CharUnicodeInfo.HIGH_SURROGATE_START) * 0x400) + (lowSurrogate - CharUnicodeInfo.LOW_SURROGATE_START) + UNICODE_PLANE01_START);
        }
        
        
        /// <summary>Converts the value of a UTF-16 encoded character or surrogate pair at a specified position in a string into a Unicode code point.</summary><returns>The 21-bit Unicode code point represented by the character or surrogate pair at the position in the <paramref name="s" /> parameter specified by the <paramref name="index" /> parameter.</returns><param name="s">A string that contains a character or surrogate pair. </param><param name="index">The index position of the character or surrogate pair in <paramref name="s" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is not a position within <paramref name="s" />. </exception><exception cref="T:System.ArgumentException">The specified index position contains a surrogate pair, and either the first character in the pair is not a valid high surrogate or the second character in the pair is not a valid low surrogate. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapChar), "ConvertToUtf32")]
        public static int ConvertToUtf32(string s, int index)
        {
            if (s == null)
            {
                throw new ArgumentNullException("s");
            }

            if (index < 0 || index >= s.Length)
            {
                throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
            }
            // Check if the character at index is a high surrogate.
            int temp1 = (int)s[index] - CharUnicodeInfo.HIGH_SURROGATE_START;
            if (temp1 >= 0 && temp1 <= 0x7ff)
            {
                // Found a surrogate char.
                if (temp1 <= 0x3ff)
                {
                    // Found a high surrogate.
                    if (index < s.Length - 1)
                    {
                        int temp2 = (int)s[index + 1] - CharUnicodeInfo.LOW_SURROGATE_START;
                        if (temp2 >= 0 && temp2 <= 0x3ff)
                        {
                            // Found a low surrogate.
                            return ((temp1 * 0x400) + temp2 + UNICODE_PLANE01_START);
                        }
                        else
                        {
                            throw new ArgumentException(Environment.GetResourceString("Argument_InvalidHighSurrogate", index), "s");
                        }
                    }
                    else
                    {
                        // Found a high surrogate at the end of the string.
                        throw new ArgumentException(Environment.GetResourceString("Argument_InvalidHighSurrogate", index), "s");
                    }
                }
                else
                {
                    // Find a low surrogate at the character pointed by index.
                    throw new ArgumentException(Environment.GetResourceString("Argument_InvalidLowSurrogate", index), "s");
                }
            }
            // Not a high-surrogate or low-surrogate. Genereate the UTF32 value for the BMP characters.
            return ((int)s[index]);
        }
        #endregion

        TypeCode IConvertible.GetTypeCode()
        {
            return TypeCode.Char;
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Char", "Boolean"));
        }

        /// <internalonly/>
        char IConvertible.ToChar(IFormatProvider provider)
        {
            return m_value;
        }

        /// <internalonly/>
        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte(m_value);
        }

        /// <internalonly/>
        byte IConvertible.ToByte(IFormatProvider provider)
        {
            return Convert.ToByte(m_value);
        }

        /// <internalonly/>
        short IConvertible.ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16(m_value);
        }

        /// <internalonly/>
        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16(m_value);
        }

        /// <internalonly/>
        int IConvertible.ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32(m_value);
        }

        /// <internalonly/>
        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(m_value);
        }

        /// <internalonly/>
        long IConvertible.ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64(m_value);
        }

        /// <internalonly/>
        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64(m_value);
        }

        /// <internalonly/>
        float IConvertible.ToSingle(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Char", "Single"));
        }

        /// <internalonly/>
        double IConvertible.ToDouble(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Char", "Double"));
        }

        /// <internalonly/>
        Decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Char", "Decimal"));
        }

        /// <internalonly/>
        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Char", "DateTime"));
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();    //TODO: Char - IConvertible.ToType
        }
    }
}
