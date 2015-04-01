using System.Runtime.InteropServices;
using System;
using System.Runtime.Serialization;
using System.Security;

namespace System.Globalization
{
    /// <summary>Defines text properties and behaviors, such as casing, that are specific to a writing system. </summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class TextInfo : ICloneable, IDeserializationCallback
    {
        private java.util.Locale javaLocale;
        private java.text.Collator javaCollator;

        private bool isReadOnly;
        private string listSeparator;
    
        private void verifyWritable()
        {
            if (isReadOnly)
                throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ReadOnly"));
        }

        /// <summary>Gets the American National Standards Institute (ANSI) code page used by the writing system represented by the current <see cref="T:System.Globalization.TextInfo" />.</summary><returns>The ANSI code page used by the writing system represented by the current <see cref="T:System.Globalization.TextInfo" />.</returns>
        public virtual int ANSICodePage
        {
            get { return 1252; }    // As in invariant
        }
    
        /// <summary>Gets the original equipment manufacturer (OEM) code page used by the writing system represented by the current <see cref="T:System.Globalization.TextInfo" />.</summary><returns>The OEM code page used by the writing system represented by the current <see cref="T:System.Globalization.TextInfo" />.</returns>
        public virtual int OEMCodePage
        {
            get { return 437; }     // As in invariant
        }
    
        /// <summary>Gets the Macintosh code page used by the writing system represented by the current <see cref="T:System.Globalization.TextInfo" />.</summary><returns>The Macintosh code page used by the writing system represented by the current <see cref="T:System.Globalization.TextInfo" />.</returns>
        public virtual int MacCodePage
        {
            get { return 10000; }   // As in invariant
        }
    
        /// <summary>Gets the Extended Binary Coded Decimal Interchange Code (EBCDIC) code page used by the writing system represented by the current <see cref="T:System.Globalization.TextInfo" />.</summary><returns>The EBCDIC code page used by the writing system represented by the current <see cref="T:System.Globalization.TextInfo" />.</returns>
        public virtual int EBCDICCodePage
        {
            get { return 37; }     // As in invariant
        }
    
        /// <summary>Gets the culture identifier for the culture associated with the current <see cref="T:System.Globalization.TextInfo" /> object.</summary><returns>A number that identifies the culture from which the current <see cref="T:System.Globalization.TextInfo" /> object was created.</returns>
        [ComVisibleAttribute(false)]
        public int LCID
        {
            get { return 127; }     // As in invariant
        }
    
        /// <summary>Gets the name of the culture associated with the current <see cref="T:System.Globalization.TextInfo" /> object.</summary><returns>The name of a culture. </returns>
        [ComVisibleAttribute(false)]
        public string CultureName
        {
            get { return javaLocale.toLanguageTag(); }
        }
    
        /// <summary>Gets a value indicating whether the current <see cref="T:System.Globalization.TextInfo" /> object is read-only.</summary><returns>true if the current <see cref="T:System.Globalization.TextInfo" /> object is read-only; otherwise, false.</returns>
        [ComVisibleAttribute(false)]
        public bool IsReadOnly
        {
            get { return isReadOnly; }
        }
    
        /// <summary>Gets or sets the string that separates items in a list.</summary><returns>The string that separates items in a list.</returns><exception cref="T:System.ArgumentNullException">The value in a set operation is null.</exception><exception cref="T:System.InvalidOperationException">In a set operation, the current <see cref="T:System.Globalization.TextInfo" /> object is read-only.</exception>
        public virtual string ListSeparator
        {
            get
            {
                if (listSeparator == null)
                    return listSeparator;
                return ","; //As in invariant
            }

            set
            {
                if (value == null)
                    throw new ArgumentNullException("value", Environment.GetResourceString("ArgumentNull_String"));
                verifyWritable();
                listSeparator = value;
            }
        }
    
        /// <summary>Gets a value indicating whether the current <see cref="T:System.Globalization.TextInfo" /> object represents a writing system where text flows from right to left.</summary><returns>true if text flows from right to left; otherwise, false.</returns>
        [ComVisibleAttribute(false)]
        public bool IsRightToLeft
        {
            get { return CIL2Java.Globalization.Utils.isRtlLanguage(javaLocale.toLanguageTag()); }
        }

        internal TextInfo(java.util.Locale javaLocale)
        {
            this.javaLocale = javaLocale;
            this.javaCollator = java.text.Collator.getInstance(javaLocale);
            this.isReadOnly = true;
            this.listSeparator = null;
        }
    
    
        [ComVisibleAttribute(false)]
        public virtual object Clone()
        {
            object o = this.clone();
            ((TextInfo)o).isReadOnly = false;
            return o;
        }
        
        /// <summary>Returns a read-only version of the specified <see cref="T:System.Globalization.TextInfo" /> object.</summary><returns>The <see cref="T:System.Globalization.TextInfo" /> object specified by the <paramref name="textInfo" /> parameter, if <paramref name="textInfo" /> is read-only.-or-A read-only memberwise clone of the <see cref="T:System.Globalization.TextInfo" /> object specified by <paramref name="textInfo" />, if <paramref name="textInfo" /> is not read-only.</returns><param name="textInfo">A <see cref="T:System.Globalization.TextInfo" /> object.</param><exception cref="T:System.ArgumentNullException"><paramref name="textInfo" /> is null.</exception>
        [ComVisibleAttribute(false)]
        public static TextInfo ReadOnly(TextInfo textInfo)
        {
            if (textInfo == null) { throw new ArgumentNullException("textInfo"); }
            if (textInfo.IsReadOnly) { return (textInfo); }

            TextInfo clonedTextInfo = (TextInfo)(textInfo.MemberwiseClone());
            clonedTextInfo.isReadOnly = true;

            return (clonedTextInfo);
        }
        
        /// <summary>Converts the specified character to lowercase.</summary><returns>The specified character converted to lowercase.</returns><param name="c">The character to convert to lowercase. </param>
        [SecuritySafeCriticalAttribute()]
        public virtual char ToLower(char c)
        {
            return Char.ToLower(c);
        }
        
        /// <summary>Converts the specified string to lowercase.</summary><returns>The specified string converted to lowercase.</returns><param name="str">The string to convert to lowercase. </param><exception cref="T:System.ArgumentNullException"><paramref name="str" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public virtual string ToLower(string str)
        {
            return str.ToLower();
        }
        
        /// <summary>Converts the specified character to uppercase.</summary><returns>The specified character converted to uppercase.</returns><param name="c">The character to convert to uppercase. </param>
        [SecuritySafeCriticalAttribute()]
        public virtual char ToUpper(char c)
        {
            return Char.ToUpper(c);
        }
        
        /// <summary>Converts the specified string to uppercase.</summary><returns>The specified string converted to uppercase.</returns><param name="str">The string to convert to uppercase. </param><exception cref="T:System.ArgumentNullException"><paramref name="str" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public virtual string ToUpper(string str)
        {
            return str.ToUpper();
        }
        
        /// <summary>Determines whether the specified object represents the same writing system as the current <see cref="T:System.Globalization.TextInfo" /> object.</summary><returns>true if <paramref name="obj" /> represents the same writing system as the current <see cref="T:System.Globalization.TextInfo" />; otherwise, false.</returns><param name="obj">The object to compare with the current <see cref="T:System.Globalization.TextInfo" />. </param>
        public override bool Equals(object obj)
        {
            TextInfo ti = obj as TextInfo;

            if (ti != null)
            {
                return javaLocale.Equals(ti.javaLocale);
            }

            return false;
        }        
        
        public override int GetHashCode()
        {
            return javaLocale.GetHashCode();
        }
        
        public override string ToString()
        {
            return "TextInfo - " + javaLocale.toLanguageTag();
        }
        
        /// <summary>Converts the specified string to titlecase.</summary><returns>The specified string converted to titlecase.</returns><param name="str">The string to convert to titlecase. </param><exception cref="T:System.ArgumentNullException"><paramref name="str" /> is null. </exception>
        public string ToTitleCase(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException("str");
            }

            if (str.Length == 0)
            {
                return (str);
            }

            java.lang.StringBuilder result = new java.lang.StringBuilder();
            string lowercaseData = null;

            for (int i = 0; i < str.Length; i++)
            {
                UnicodeCategory charType = Char.GetUnicodeCategory(str, i);
                int charLen = Char.IsSurrogate(str, i) ? 2 : 1; ;

                if (Char.IsLetter(str, i))
                {
                    // Do the titlecasing for the first character of the word.
                    i = AddTitlecaseLetter(ref result, ref str, i, charLen) + 1;

                    //
                    // Convert the characters until the end of the this word
                    // to lowercase.
                    //
                    int lowercaseStart = i;

                    //
                    // Use hasLowerCase flag to prevent from lowercasing acronyms (like "URT", "USA", etc)
                    // This is in line with Word 2000 behavior of titlecasing.
                    //
                    bool hasLowerCase = (charType == UnicodeCategory.LowercaseLetter);
                    // Use a loop to find all of the other letters following this letter.
                    while (i < str.Length)
                    {
                        charType = charType = Char.GetUnicodeCategory(str, i);
                        charLen = Char.IsSurrogate(str, i) ? 2 : 1; 

                        if (Char.IsLetter(str, i))
                        {
                            if (charType == UnicodeCategory.LowercaseLetter)
                            {
                                hasLowerCase = true;
                            }
                            i += charLen;
                        }
                        else if (str[i] == '\'')
                        {
                            i++;
                            if (hasLowerCase)
                            {
                                if (lowercaseData == null)
                                {
                                    lowercaseData = this.ToLower(str);
                                }
                                result.append(CIL2Java.Intrinsics.ToJavaString(lowercaseData), lowercaseStart, i - lowercaseStart);
                            }
                            else
                            {
                                result.append(CIL2Java.Intrinsics.ToJavaString(str), lowercaseStart, i - lowercaseStart);
                            }
                            lowercaseStart = i;
                            hasLowerCase = true;
                        }
                        else if (!IsWordSeparator(charType))
                        {
                            // This category is considered to be part of the word.
                            // This is any category that is marked as false in wordSeprator array.
                            i += charLen;
                        }
                        else
                        {
                            // A word separator. Break out of the loop.
                            break;
                        }
                    }

                    int count = i - lowercaseStart;

                    if (count > 0)
                    {
                        if (hasLowerCase)
                        {
                            if (lowercaseData == null)
                            {
                                lowercaseData = this.ToLower(str);
                            }
                            result.append(CIL2Java.Intrinsics.ToJavaString(lowercaseData), lowercaseStart, count);
                        }
                        else
                        {
                            result.append(CIL2Java.Intrinsics.ToJavaString(str), lowercaseStart, count);
                        }
                    }

                    if (i < str.Length)
                    {
                        // not a letter, just append it
                        i = AddNonLetter(ref result, ref str, i, charLen);
                    }
                }
                else
                {
                    // not a letter, just append it
                    i = AddNonLetter(ref result, ref str, i, charLen);
                }
            }
            return (result.ToString());
        }

        private static int AddNonLetter(ref java.lang.StringBuilder result, ref String input, int inputIndex, int charLen)
        {
            if (charLen == 2)
            {
                // Surrogate pair
                result.append(input[inputIndex++]);
                result.append(input[inputIndex]);
            }
            else
            {
                result.append(input[inputIndex]);
            }
            return inputIndex;
        }

        private int AddTitlecaseLetter(ref java.lang.StringBuilder result, ref String input, int inputIndex, int charLen)
        {
            // for surrogate pairs do a simple ToUpper operation on the substring
            if (charLen == 2)
            {
                // Surrogate pair
                result.append(this.ToUpper(input.Substring(inputIndex, charLen)));
                inputIndex++;
            }
            else
            {
                switch (input[inputIndex])
                {
                    //
                    // For AppCompat, the Titlecase Case Mapping data from NDP 2.0 is used below.
                    case (char)0x01C4:  // DZ with Caron -> Dz with Caron
                    case (char)0x01C5:  // Dz with Caron -> Dz with Caron
                    case (char)0x01C6:  // dz with Caron -> Dz with Caron
                        result.append((char)0x01C5);
                        break;
                    case (char)0x01C7:  // LJ -> Lj
                    case (char)0x01C8:  // Lj -> Lj
                    case (char)0x01C9:  // lj -> Lj
                        result.append((char)0x01C8);
                        break;
                    case (char)0x01CA:  // NJ -> Nj
                    case (char)0x01CB:  // Nj -> Nj
                    case (char)0x01CC:  // nj -> Nj
                        result.append((char)0x01CB);
                        break;
                    case (char)0x01F1:  // DZ -> Dz
                    case (char)0x01F2:  // Dz -> Dz
                    case (char)0x01F3:  // dz -> Dz
                        result.append((char)0x01F2);
                        break;
                    default:
                        result.append(this.ToUpper(input[inputIndex]));
                        break;
                }
            }
            return inputIndex;
        }

        //
        // Used in ToTitleCase():
        // When we find a starting letter, the following array decides if a category should be
        // considered as word seprator or not.
        //
        private const int wordSeparatorMask =
            /* false */ (0 << 0) | // UppercaseLetter = 0,
            /* false */ (0 << 1) | // LowercaseLetter = 1,
            /* false */ (0 << 2) | // TitlecaseLetter = 2,
            /* false */ (0 << 3) | // ModifierLetter = 3,
            /* false */ (0 << 4) | // OtherLetter = 4,
            /* false */ (0 << 5) | // NonSpacingMark = 5,
            /* false */ (0 << 6) | // SpacingCombiningMark = 6,
            /* false */ (0 << 7) | // EnclosingMark = 7,
            /* false */ (0 << 8) | // DecimalDigitNumber = 8,
            /* false */ (0 << 9) | // LetterNumber = 9,
            /* false */ (0 << 10) | // OtherNumber = 10,
            /* true  */ (1 << 11) | // SpaceSeparator = 11,
            /* true  */ (1 << 12) | // LineSeparator = 12,
            /* true  */ (1 << 13) | // ParagraphSeparator = 13,
            /* true  */ (1 << 14) | // Control = 14,
            /* true  */ (1 << 15) | // Format = 15,
            /* false */ (0 << 16) | // Surrogate = 16,
            /* false */ (0 << 17) | // PrivateUse = 17,
            /* true  */ (1 << 18) | // ConnectorPunctuation = 18,
            /* true  */ (1 << 19) | // DashPunctuation = 19,
            /* true  */ (1 << 20) | // OpenPunctuation = 20,
            /* true  */ (1 << 21) | // ClosePunctuation = 21,
            /* true  */ (1 << 22) | // InitialQuotePunctuation = 22,
            /* true  */ (1 << 23) | // FinalQuotePunctuation = 23,
            /* true  */ (1 << 24) | // OtherPunctuation = 24,
            /* true  */ (1 << 25) | // MathSymbol = 25,
            /* true  */ (1 << 26) | // CurrencySymbol = 26,
            /* true  */ (1 << 27) | // ModifierSymbol = 27,
            /* true  */ (1 << 28) | // OtherSymbol = 28,
            /* false */ (0 << 29);  // OtherNotAssigned = 29;

        private static bool IsWordSeparator(UnicodeCategory category)
        {
            return (wordSeparatorMask & (1 << (int)category)) != 0;
        }

        void IDeserializationCallback.OnDeserialization(object sender)
        {
            throw new NotImplementedException();
        }
    }
}
