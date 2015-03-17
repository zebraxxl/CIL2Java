using System;
using System.Collections.Generic;
using System.Globalization;
using javaChar = java.lang.Character;

namespace CIL2Java.Maps
{
    public class CharMap : IComparable, IConvertible, IComparable<Char>, IEquatable<Char>
    {
        private char m_value;

        private CharMap(char value)
        {
            this.m_value = value;
        }

        public static CharMap GetAdapter(javaChar self)
        {
            return new CharMap(self.charValue());
        }


        public static bool Equals(javaChar self, char obj)
        {
            return self.charValue() == obj;
        }

        public static int CompareTo(javaChar self, object value)
        {
            if (value == null)
            {
                return 1;
            }
            if (!(value is Char))
            {
                throw new ArgumentException(Environment.GetResourceString("Arg_MustBeChar"));
            }

            return (self.charValue() - ((char)value));
        }

        public static int CompareTo(javaChar self, char value)
        {
            return (self.charValue() - value);
        }

        public static string ToString(javaChar self, IFormatProvider provider)
        {
            return new string(self.charValue(), 1);
        }


        #region Char static methods
        public static string ToString(char c)
        {
            return new string(c, 1);
        }

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

        public static char ToUpper(char c, CultureInfo culture)
        {
            //TODO: char.ToUpper - use CultureInfo
            return javaChar.toUpperCase(c);
        }
        public static char ToLower(char c, CultureInfo culture)
        {
            return javaChar.toLowerCase(c);
        }

        public static bool IsControl(char c)
        {
            return javaChar.getType(c) == javaChar.CONTROL;
        }

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

        public static bool IsDigit(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return Char.IsDigit(s[index]);
        }

        public static bool IsLetter(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return Char.IsLetter(s[index]);
        }

        public static bool IsLetterOrDigit(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return Char.IsLetterOrDigit(s[index]);
        }

        public static bool IsLower(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return Char.IsLower(s[index]);
        }

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

        public static bool IsSurrogate(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return Char.IsSurrogate(s[index]);
        }

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

        public static bool IsUpper(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return Char.IsUpper(s[index]);
        }

        public static bool IsWhiteSpace(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return Char.IsWhiteSpace(s[index]);
        }

        private static readonly UnicodeCategory[] UnicodeCategoryJava2CLR = { UnicodeCategory.OtherNotAssigned, UnicodeCategory.UppercaseLetter, UnicodeCategory.LowercaseLetter,
                                                                            UnicodeCategory.TitlecaseLetter, UnicodeCategory.ModifierLetter, UnicodeCategory.OtherLetter,
                                                                            UnicodeCategory.NonSpacingMark, UnicodeCategory.EnclosingMark, UnicodeCategory.SpacingCombiningMark,
                                                                            UnicodeCategory.DecimalDigitNumber, UnicodeCategory.LetterNumber, UnicodeCategory.OtherNumber,
                                                                            UnicodeCategory.SpaceSeparator, UnicodeCategory.LineSeparator, UnicodeCategory.ParagraphSeparator,
                                                                            UnicodeCategory.Control, UnicodeCategory.Format, UnicodeCategory.PrivateUse, UnicodeCategory.Surrogate,
                                                                            UnicodeCategory.DashPunctuation, UnicodeCategory.OpenPunctuation, UnicodeCategory.ClosePunctuation,
                                                                            UnicodeCategory.ConnectorPunctuation, UnicodeCategory.OtherPunctuation, UnicodeCategory.MathSymbol,
                                                                            UnicodeCategory.CurrencySymbol, UnicodeCategory.ModifierSymbol, UnicodeCategory.OtherSymbol,
                                                                            UnicodeCategory.InitialQuotePunctuation, UnicodeCategory.FinalQuotePunctuation };

        public static UnicodeCategory GetUnicodeCategory(char c)
        {
            int uc = javaChar.getType(c);

            if (uc >= UnicodeCategoryJava2CLR.Length)
                return UnicodeCategory.OtherNotAssigned;
            else
                return UnicodeCategoryJava2CLR[uc];
        }

        public static UnicodeCategory GetUnicodeCategory(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (((uint)index) >= ((uint)s.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return GetUnicodeCategory(s[index]);
        }

        public static double GetNumericValue(char c)
        {
            return (double)javaChar.getNumericValue(c);
        }

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
                return (javaChar.isSurrogatePair(s[index], s[index + 1]));
            }
            return (false);
        }

        internal const int UNICODE_PLANE00_END = 0x00ffff;
        // The starting codepoint for Unicode plane 1.  Plane 1 contains 0x010000 ~ 0x01ffff.
        internal const int UNICODE_PLANE01_START = 0x10000;
        // The end codepoint for Unicode plane 16.  This is the maximum code point value allowed for Unicode.
        // Plane 16 contains 0x100000 ~ 0x10ffff.
        internal const int UNICODE_PLANE16_END = 0x10ffff;

        internal const int HIGH_SURROGATE_START = 0x00d800;
        internal const int LOW_SURROGATE_END = 0x00dfff;

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
            return (new string(surrogate));
        }

        public static int ConvertToUtf32(char highSurrogate, char lowSurrogate)
        {
            if (!javaChar.isHighSurrogate(highSurrogate))
            {
                throw new ArgumentOutOfRangeException("highSurrogate", Environment.GetResourceString("ArgumentOutOfRange_InvalidHighSurrogate"));
            }
            if (!javaChar.isLowSurrogate(lowSurrogate))
            {
                throw new ArgumentOutOfRangeException("lowSurrogate", Environment.GetResourceString("ArgumentOutOfRange_InvalidLowSurrogate"));
            }
            return (((highSurrogate - CharUnicodeInfo.HIGH_SURROGATE_START) * 0x400) + (lowSurrogate - CharUnicodeInfo.LOW_SURROGATE_START) + UNICODE_PLANE01_START);
        }

        /// <summary>Converts the value of a UTF-16 encoded character or surrogate pair at a specified position in a string into a Unicode code point.</summary><returns>The 21-bit Unicode code point represented by the character or surrogate pair at the position in the <paramref name="s" /> parameter specified by the <paramref name="index" /> parameter.</returns><param name="s">A string that contains a character or surrogate pair. </param><param name="index">The index position of the character or surrogate pair in <paramref name="s" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is not a position within <paramref name="s" />. </exception><exception cref="T:System.ArgumentException">The specified index position contains a surrogate pair, and either the first character in the pair is not a valid high surrogate or the second character in the pair is not a valid low surrogate. </exception><filterpriority>1</filterpriority>
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


        public static TypeCode GetTypeCode(javaChar self)
        {
            return TypeCode.Char;
        }

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

            return (m_value - ((char)value));
        }

        public int CompareTo(char other)
        {
            return m_value - other;
        }

        public bool Equals(char other)
        {
            return m_value == other;
        }

        public TypeCode GetTypeCode()
        {
            return TypeCode.Char;
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Char", "Boolean"));
        }

        /// <internalonly/>
        public char ToChar(IFormatProvider provider)
        {
            return m_value;
        }

        /// <internalonly/>
        public sbyte ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte(m_value);
        }

        /// <internalonly/>
        public byte ToByte(IFormatProvider provider)
        {
            return Convert.ToByte(m_value);
        }

        /// <internalonly/>
        public short ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16(m_value);
        }

        /// <internalonly/>
        public ushort ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16(m_value);
        }

        /// <internalonly/>
        public int ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32(m_value);
        }

        /// <internalonly/>
        public uint ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(m_value);
        }

        /// <internalonly/>
        public long ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64(m_value);
        }

        /// <internalonly/>
        public ulong ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64(m_value);
        }

        /// <internalonly/>
        public float ToSingle(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Char", "Single"));
        }

        /// <internalonly/>
        public double ToDouble(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Char", "Double"));
        }

        /// <internalonly/>
        public Decimal ToDecimal(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Char", "Decimal"));
        }

        /// <internalonly/>
        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Char", "DateTime"));
        }

        public string ToString(IFormatProvider provider)
        {
            return new string(m_value, 1);
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();    //TODO: Char - ToType
        }
    }
}
