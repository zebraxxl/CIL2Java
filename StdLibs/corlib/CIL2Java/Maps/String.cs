using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using javaString = java.lang.String;
using javaStringBuilder = java.lang.StringBuilder;

namespace CIL2Java.Maps
{
    public class String : IComparable, ICloneable, IConvertible, IComparable<javaString>, IEnumerable<char>, IEquatable<javaString>
    {
        #region Interfaces methods
        private javaString self;

        private class JavaCharEnumerator : IEnumerator, IEnumerator<char>
        {
            private javaString str;
            private int index;
            private int length;

            public JavaCharEnumerator(javaString str)
            {
                this.str = str;
                this.index = -1;
                this.length = str.length();
            }

            public char Current
            {
                get
                {
                    if ((index == -1) || (index >= length))
                        throw new InvalidOperationException(Local.GetText("The position is not valid."));
                    return str.charAt(index);
                }
            }

            public void Dispose()
            {
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }

            public bool MoveNext()
            {
                if (index < length - 1)
                {
                    index++;
                    return true;
                }
                index = length;
                return false;
            }

            public void Reset()
            {
                index = -1;
            }
        }

        public static String GetAdapter(javaString self)
        {
            return new String(self);
        }

        public String(javaString self)
        {
            this.self = self;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(String other)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<char> GetEnumerator()
        {
            return new JavaCharEnumerator(self);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new JavaCharEnumerator(self);
        }

        public bool Equals(javaString other)
        {
            throw new NotImplementedException();
        }

        public TypeCode GetTypeCode()
        {
            throw new NotImplementedException();
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public char ToChar(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public byte ToByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public short ToInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public int ToInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public long ToInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public float ToSingle(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public double ToDouble(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public string ToString(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(javaString other)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Join
        public static string Join(string separator, params string[] value)
        {
            if (separator == null)
                throw new ArgumentNullException("separator");
            return Join(separator, value, 0, value.Length);
        }

        public static string Join(string separator, params object[] values)
        {
            if (values == null)
                throw new ArgumentNullException("values");
            if ((values.Length == 0) || (values[0] == null))
                return string.Empty;
            if (separator == null)
                separator = string.Empty;

            javaStringBuilder resultBuilder = new javaStringBuilder();
            resultBuilder.append(values[0].ToString() ?? string.Empty);

            for (int i = 1; i < values.Length; i++)
            {
                resultBuilder.append(separator);
                resultBuilder.append(values[i].ToString() ?? string.Empty);
            }

            return resultBuilder.ToString();
        }

        public static string Join<T>(string separator, IEnumerable<T> values)
        {
            if (values == null)
                throw new ArgumentNullException("values");
            if (separator == null)
                separator = string.Empty;

            javaStringBuilder resultBuilder = new javaStringBuilder();
            bool first = true;
            foreach (T v in values)
            {
                if (first)
                    first = false;
                else
                    resultBuilder.append(separator);

                if (v != null)
                    resultBuilder.append(v);
            }
            return resultBuilder.ToString();
        }

        public static string Join(string separator, IEnumerable<string> values)
        {
            if (values == null)
                throw new ArgumentNullException("values");
            if (separator == null)
                separator = string.Empty;

            javaStringBuilder resultBuilder = new javaStringBuilder();
            bool first = true;
            foreach (string v in values)
            {
                if (first)
                    first = false;
                else
                    resultBuilder.append(separator);

                if (v != null)
                    resultBuilder.append(v);
            }
            return resultBuilder.ToString();
        }

        public static string Join(string separator, string[] value, int startIndex, int count)
        {
            if (value == null)
                throw new ArgumentNullException("value");
            if (startIndex < 0)
                throw new ArgumentOutOfRangeException("startIndex");
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (startIndex > value.Length - count)
                throw new ArgumentOutOfRangeException("startIndex");
            
            if (count == 0)
                return string.Empty;
            
            if (separator == null)
                separator = string.Empty;

            javaStringBuilder resultBuilder = new javaStringBuilder();
            resultBuilder.append(value[startIndex]);

            int endIndex = startIndex + count;
            for (int i = startIndex + 1; i < endIndex; i++)
            {
                resultBuilder.append(separator);
                resultBuilder.append(value[i]);
            }

            return resultBuilder.ToString();
        }
        #endregion

        #region Concat
        private static string ConcatArray(string[] strArray, int resultLength)
        {
            javaStringBuilder builder = new javaStringBuilder(resultLength);

            for (int i = 0; i < strArray.Length; i++)
                builder.append(strArray[i]);
            return builder.ToString();
        }

        public static string Concat(object arg0)
        {
            if (arg0 == null) return string.Empty;
            return arg0.ToString();
        }

        public static string Concat(object arg0, object arg1)
        {
            if (arg0 == null) arg0 = string.Empty;
            if (arg1 == null) arg1 = string.Empty;
            return Intrinsics.ToJavaString(arg0.ToString()).concat(arg0.ToString());
        }

        public static string Concat(object arg0, object arg1, object arg2)
        {
            if (arg0 == null) arg0 = string.Empty;
            if (arg1 == null) arg1 = string.Empty;
            if (arg2 == null) arg2 = string.Empty;
            return Intrinsics.ToJavaString(Intrinsics.ToJavaString(arg0.ToString()).concat(arg0.ToString())).concat(arg2.ToString());
        }

        public static string Concat(object arg0, object arg1, object arg2, object arg3, __arglist)
        {
            ArgIterator iterator = new ArgIterator(__arglist);
            int count = iterator.GetRemainingCount() + 4;
            object[] args = new object[count];

            args[0] = arg0;
            args[1] = arg1;
            args[2] = arg2;
            args[3] = arg3;

            for (int i = 4; i < count; i++)
                args[i] = TypedReference.ToObject(iterator.GetNextArg());

            return Concat(args);
        }

        public static string Concat(params object[] args)
        {
            if (args == null)
                throw new ArgumentNullException("args");

            string[] strArray = new string[args.Length];
            int resultLength = 0;

            for (int i = 0; i < args.Length; i++)
            {
                strArray[i] = args[i] == null ? string.Empty : args[i].ToString();
                if (strArray[i] == null)
                    strArray[i] = string.Empty;
                resultLength += strArray[i].Length;
                if (resultLength < 0)
                    throw new OutOfMemoryException();
            }

            return ConcatArray(strArray, resultLength);
        }

        public static string Concat<T>(IEnumerable<T> values)
        {
            javaStringBuilder builder = new javaStringBuilder();
            foreach (T val in values)
            {
                string text = val.ToString();
                builder.append(text ?? string.Empty);
            }
            return builder.ToString();
        }

        public static string Concat(IEnumerable<string> values)
        {
            javaStringBuilder builder = new javaStringBuilder();
            foreach (string val in values)
                builder.append(val ?? string.Empty);
            return builder.ToString();
        }

        public static string Concat(string str0, string str1)
        {
            if (str0 == null) str0 = string.Empty;
            if (str1 == null) str1 = string.Empty;

            return Intrinsics.ToJavaString(str0).concat(str1);
        }

        public static string Concat(string str0, string str1, string str2)
        {
            if (str0 == null) str0 = string.Empty;
            if (str1 == null) str1 = string.Empty;
            if (str2 == null) str2 = string.Empty;

            return Intrinsics.ToJavaString(Intrinsics.ToJavaString(str0).concat(str1)).concat(str2);
        }

        public static string Concat(string str0, string str1, string str2, string str3)
        {
            if (str0 == null) str0 = string.Empty;
            if (str1 == null) str1 = string.Empty;
            if (str3 == null) str3 = string.Empty;

            return Intrinsics.ToJavaString(Intrinsics.ToJavaString(Intrinsics.ToJavaString(str0).concat(str1)).concat(str2)).concat(str3);
        }

        public static string Concat(params string[] values)
        {
            string[] newValues = new string[values.Length];
            int resultLength = 0;

            for (int i = 0; i < values.Length; i++)
            {
                string newText = values[i] ?? string.Empty;
                newValues[i] = newText;
                resultLength += newText.Length;

                if (resultLength < 0)
                    throw new OutOfMemoryException();
            }

            return ConcatArray(newValues, resultLength);
        }
        #endregion

        #region Equals
        public static bool Equals(string self, string value)
        {
            return self.Equals((object)value);
        }

        public static bool Equals(string self, string value, StringComparison comparisonType)
        {
            throw new NotImplementedException();
        }

        public static bool OperatorEq(string a, string b)
        {
            return a.Equals(b);
        }

        public static bool OperatorNotEq(string a, string b)
        {
            return !a.Equals(b);
        }
        #endregion

        #region As char array
        public static void CopyTo(string self, int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            if (destination == null)
                throw new ArgumentNullException("destination");
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (sourceIndex < 0)
                throw new ArgumentOutOfRangeException("sourceIndex");
            if (count > self.Length - sourceIndex)
                throw new ArgumentOutOfRangeException("count");
            if (destinationIndex > destination.Length - destinationIndex)
                throw new ArgumentOutOfRangeException("destinationIndex");
            Intrinsics.ToJavaString(self).getChars(sourceIndex, sourceIndex + count, destination, destinationIndex);
        }
        
        public static char[] ToCharArray(string self, int startIndex, int length)
        {
            if ((startIndex < 0) || (startIndex > self.Length) || (startIndex > self.Length - length))
                throw new ArgumentOutOfRangeException("startIndex");
            if (length < 0)
                throw new ArgumentOutOfRangeException("length");
            char[] result = new char[length];
            Intrinsics.ToJavaString(self).getChars(startIndex, startIndex + length, result, 0);
            return result;
        }
        #endregion

        #region IsNullOr...
        public static bool IsNullOrEmpty(string value)
        {
            return ((value == null) || (value.Length == 0));
        }

        public static bool IsNullOrWhiteSpace(string value)
        {
            if (value == null)
                return true;
            for (int i = 0; i < value.Length; i++)
                if (!char.IsWhiteSpace(value[i]))
                    return false;
            return true;
        }
        #endregion

        #region Split
        public static string[] Split(string self, params char[] separator)
        {
            return Split(self, separator, int.MaxValue, StringSplitOptions.None);
        }

        public static string[] Split(string self, char[] separator, int count)
        {
            return Split(self, separator, count, StringSplitOptions.None);
        }

        public static string[] Split(string self, char[] separator, StringSplitOptions options)
        {
            return Split(self, separator, int.MaxValue, options);
        }

        public static string[] Split(string self, char[] separator, int count, StringSplitOptions options)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if ((options != StringSplitOptions.None) && (options != StringSplitOptions.RemoveEmptyEntries))
                throw new ArgumentException(Local.GetText("Illegal enum value: {0}.", options));
            if (((self.Length == 0) && (options == StringSplitOptions.RemoveEmptyEntries)) || (count == 0))
                return Utils.EmptyArray<string>.value;
            if (count == 1)
                return new string[] { self };

            List<string> result = new List<string>();

            int pos = 0;
            int last = 0;
            int len = self.Length;

            while (pos < len)
            {
                char ch = self[pos];

                if ((separator != null) && (separator.Length > 0))
                {
                    for (int i = 0; i < separator.Length; i++)
                    {
                        if (ch == separator[i])
                        {
                            result.Add(Intrinsics.ToJavaString(self).substring(last, pos));
                            last = pos + 1;
                            break;
                        }
                    }
                }
                else
                {
                    if (char.IsWhiteSpace(ch))
                    {
                        result.Add(Intrinsics.ToJavaString(self).substring(last, pos));
                        last = pos + 1;
                    }
                }

                pos++;
            }

            //if (last != pos)
                result.Add(Intrinsics.ToJavaString(self).substring(last, pos));

            if (options == StringSplitOptions.RemoveEmptyEntries)
            {
                for (int i = 0; i < result.Count; i++)
                    if (result[i].Length == 0)
                        result.RemoveAt(i--);
            }

            if (result.Count > count)
                result.RemoveRange(count, result.Count - count);

            return result.ToArray();
        }

        public static string[] Split(string self, string[] separator, StringSplitOptions options)
        {
            return Split(self, separator, int.MaxValue, options);
        }

        public static string[] Split(string self, string[] separator, int count, StringSplitOptions options)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Trim
        private static string TrimWorker(string self, char[] trimChars, bool fromStart, bool fromEnd)
        {
            int startIndex = 0;
            int endIndex = self.Length;

            if (fromStart)
            {
                for (int i = 0; i < self.Length; i++)
                {
                    char ch = self[i];
                    for (int j = 0; j < trimChars.Length; j++)
                    {
                        if (ch == trimChars[j])
                        {
                            startIndex = i + 1;
                            break;
                        }
                    }

                    if (startIndex == i)
                        break;
                }
            }

            if (fromEnd)
            {
                for (int i = self.Length - 1; i >= 0; i--)
                {
                    char ch = self[i];
                    for (int j = 0; j < trimChars.Length; j++)
                    {
                        if (ch == trimChars[j])
                        {
                            endIndex = i;
                            break;
                        }
                    }

                    if (endIndex == i + 1)
                        break;
                }
            }

            return Intrinsics.ToJavaString(self).substring(startIndex, endIndex);
        }

        private static string TrimWorker(string self, bool fromStart, bool fromEnd)
        {
            int startIndex = 0;
            int endIndex = self.Length;

            if (fromStart)
            {
                for (int i = 0; i < self.Length; i++)
                {
                    if (char.IsWhiteSpace(self[i]))
                        startIndex = i + 1;
                    else
                        break;
                }
            }

            if (fromEnd)
            {
                for (int i = self.Length - 1; i >= 0; i--)
                {
                    if (char.IsWhiteSpace(self[i]))
                        endIndex = i;
                    else
                        break;
                }
            }

            return Intrinsics.ToJavaString(self).substring(startIndex, endIndex);
        }

        public static string Trim(string self)
        {
            return TrimWorker(self, true, true);
        }

        public static string Trim(string self, params char[] trimChars)
        {
            if ((trimChars == null) || (trimChars.Length == 0))
                return TrimWorker(self, true, true);

            return TrimWorker(self, trimChars, true, true);
        }

        public static string TrimStart(string self, params char[] trimChars)
        {
            if ((trimChars == null) || (trimChars.Length == 0))
                return TrimWorker(self, true, true);

            return TrimWorker(self, trimChars, true, false);
        }

        public static string TrimEnd(string self, params char[] trimChars)
        {
            if ((trimChars == null) || (trimChars.Length == 0))
                return TrimWorker(self, true, true);

            return TrimWorker(self, trimChars, false, true);
        }
        #endregion

        #region Normalization
        private static java.text.Normalizer.Form ToJavaNormalizeForm(NormalizationForm nf)
        {
            switch (nf)
            {
                case NormalizationForm.FormC: return java.text.Normalizer.Form.NFC;
                case NormalizationForm.FormD: return java.text.Normalizer.Form.NFD;
                case NormalizationForm.FormKC: return java.text.Normalizer.Form.NFKC;
                case NormalizationForm.FormKD: return java.text.Normalizer.Form.NFKD;
                default: return java.text.Normalizer.Form.NFC;
            }
        }

        public static bool IsNormalized(string self)
        {
            return java.text.Normalizer.isNormalized(Intrinsics.ToJavaString(self), java.text.Normalizer.Form.NFC);
        }

        public static bool IsNormalized(string self, NormalizationForm normalizationForm)
        {
            return java.text.Normalizer.isNormalized(Intrinsics.ToJavaString(self), ToJavaNormalizeForm(normalizationForm));
        }

        public static string Normalize(string self)
        {
            return java.text.Normalizer.normalize(Intrinsics.ToJavaString(self), java.text.Normalizer.Form.NFC);
        }

        public static string Normalize(string self, NormalizationForm normalizationForm)
        {
            return java.text.Normalizer.normalize(Intrinsics.ToJavaString(self), ToJavaNormalizeForm(normalizationForm));
        }
        #endregion

        #region Compare
        public static int Compare(string strA, string strB)
        {
            return Intrinsics.ToJavaString(strA).compareTo(strB);
        }

        public static int Compare(string strA, string strB, bool ignoreCase)
        {
            if (ignoreCase)
                return Intrinsics.ToJavaString(strA).compareToIgnoreCase(strB);
            return Intrinsics.ToJavaString(strA).compareTo(strB);
        }

        public static int Compare(string strA, string strB, StringComparison comparisonType)
        {
            throw new NotImplementedException();
        }

        public static int Compare(string strA, string strB, CultureInfo culture, CompareOptions options)
        {
            throw new NotImplementedException();
        }

        public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public static int Compare(string strA, int indexA, string strB, int indexB, int length)
        {
            throw new NotImplementedException();
        }

        public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase)
        {
            throw new NotImplementedException();
        }

        public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options)
        {
            throw new NotImplementedException();
        }

        public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType)
        {
            throw new NotImplementedException();
        }

        public static int CompareTo(string self, object value)
        {
            if (value == null)
                return 1;
            if (!(value is string))
                throw new ArgumentException(Local.GetText("value must be string"));
            return Intrinsics.ToJavaString(self).compareTo((string)value);
        }

        public static int CompareOrdinal(string strA, string strB)
        {
            throw new NotImplementedException();
        }

        public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IndexOf
        public static int IndexOf(string self, char value)
        {
            return Intrinsics.ToJavaString(self).indexOf(value);
        }

        public static int IndexOf(string self, char value, int startIndex)
        {
            return Intrinsics.ToJavaString(self).indexOf(value, startIndex);
        }

        public static int IndexOf(string self, char value, int startIndex, int count)
        {
            throw new NotImplementedException();
        }

        public static int IndexOfAny(string self, char[] anyOf)
        {
            throw new NotImplementedException();
        }

        public static int IndexOfAny(string self, char[] anyOf, int startIndex)
        {
            throw new NotImplementedException();
        }

        public static int IndexOfAny(string self, char[] anyOf, int startIndex, int count)
        {
            throw new NotImplementedException();
        }

        public static int IndexOf(string self, string value, int startIndex, int count)
        {
            throw new NotImplementedException();
        }

        public static int IndexOf(string self, string value, StringComparison comparisonType)
        {
            throw new NotImplementedException();
        }

        public static int IndexOf(string self, string value, int startIndex, StringComparison comparisonType)
        {
            throw new NotImplementedException();
        }

        public static int IndexOf(string self, string value, int startIndex, int count, StringComparison comparisonType)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region LastIndexOf
        public int LastIndexOf(string self, char value)
        {
            return Intrinsics.ToJavaString(self).lastIndexOf(value);
        }

        public static int LastIndexOf(string self, char value, int startIndex)
        {
            return Intrinsics.ToJavaString(self).lastIndexOf(value, startIndex);
        }

        public static int LastIndexOf(string self, char value, int startIndex, int count)
        {
            throw new NotImplementedException();
        }

        public static int LastIndexOfAny(string self, char[] anyOf)
        {
            throw new NotImplementedException();
        }

        public static int LastIndexOfAny(string self, char[] anyOf, int startIndex)
        {
            throw new NotImplementedException();
        }

        public static int LastIndexOfAny(string self, char[] anyOf, int startIndex, int count)
        {
            throw new NotImplementedException();
        }

        public static int LastIndexOf(string self, string value, int startIndex, int count)
        {
            throw new NotImplementedException();
        }

        public static int LastIndexOf(string self, string value, StringComparison comparisonType)
        {
            throw new NotImplementedException();
        }

        public static int LastIndexOf(string self, string value, int startIndex, StringComparison comparisonType)
        {
            throw new NotImplementedException();
        }

        public static int LastIndexOf(string self, string value, int startIndex, int count, StringComparison comparisonType)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Pad
        public static string PadLeft(string self, int totalWidth)
        {
            return PadLeft(self, totalWidth, ' ');
        }

        public static string PadLeft(string self, int totalWidth, char paddingChar)
        {
            if (totalWidth < 0)
                throw new ArgumentOutOfRangeException("totalWidth");
            if (totalWidth < self.Length)
                return self;
            if (totalWidth == 0)
                return string.Empty;

            javaStringBuilder result = new javaStringBuilder(totalWidth);
            for (int i = 0; i < totalWidth - self.Length; i++)
                result.append(paddingChar);
            result.append(self);
            return result.ToString();
        }

        public static string PadRight(string self, int totalWidth)
        {
            return PadRight(self, totalWidth, ' ');
        }

        public static string PadRight(string self, int totalWidth, char paddingChar)
        {
            if (totalWidth < 0)
                throw new ArgumentOutOfRangeException("totalWidth");
            if (totalWidth < self.Length)
                return self;
            if (totalWidth == 0)
                return string.Empty;

            javaStringBuilder result = new javaStringBuilder(totalWidth);
            result.append(self);
            for (int i = 0; i < totalWidth - self.Length; i++)
                result.append(paddingChar);
            return result.ToString();
        }
        #endregion

        #region Starts and Ends With
        public static bool StartsWith(string self, string value, StringComparison comparisonType)
        {
            throw new NotImplementedException();
        }

        public static bool StartsWith(string self, string value, bool ignoreCase, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public static bool EndsWith(string self, string value, StringComparison comparisonType)
        {
            throw new NotImplementedException();
        }

        public static bool EndsWith(string self, string value, bool ignoreCase, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Case change
        public static string ToLower(string self, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public static string ToLowerInvariant(string self)
        {
            throw new NotImplementedException();
        }

        public static string ToUpper(string self, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public static string ToUpperInvariant(string self)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Insert, replace and remove
        public static string Insert(string self, int startIndex, string value)
        {
            throw new NotImplementedException();
        }

        public static string Replace(string self, string oldValue, string newValue)
        {
            return Intrinsics.ToJavaString(self).replace(Intrinsics.ToJavaString(oldValue), Intrinsics.ToJavaString(newValue));
        }

        public static string Remove(string self, int startIndex, int count)
        {
            throw new NotImplementedException();
        }

        public static string Remove(string self, int startIndex)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Format
        public static string Format(string format, object arg0)
        {
            throw new NotImplementedException();
        }

        public static string Format(string format, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public static string Format(string format, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public static string Format(string format, params  object[] args)
        {
            throw new NotImplementedException();
        }

        public static string Format(IFormatProvider provider, string format, params  object[] args)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Intern
        public static string Intern(string str)
        {
            return Intrinsics.ToJavaString(str).intern();
        }

        public static string IsInterned(string str)
        {
            throw new NotImplementedException();
        }
        #endregion

        public static string Substring(string self, int startIndex, int length)
        {
            if (startIndex < 0)
                throw new ArgumentOutOfRangeException("startIndex");
            if (startIndex > self.Length)
                throw new ArgumentOutOfRangeException("startIndex");
            if (length < 0)
                throw new ArgumentOutOfRangeException("length");
            if (startIndex > self.Length - length)
                throw new ArgumentOutOfRangeException("length");
            if (length == 0)
                return string.Empty;
            if ((startIndex == 0) && (length == self.Length))
                return self;
            return Intrinsics.ToJavaString(self).substring(startIndex, startIndex + length);
        }

        public static bool Contains(string self, string value)
        {
            return Intrinsics.ToJavaString(self).contains(Intrinsics.ToJavaString(value));
        }

        public static string ToString(string self, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public static object Clone(string self)
        {
            return self;
        }

        public static string Copy(string str)
        {
            return Intrinsics.ToCILString(new javaString(str));
        }
    }
}
