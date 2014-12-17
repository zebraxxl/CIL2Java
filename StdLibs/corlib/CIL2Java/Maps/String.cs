using System;
using System.Collections;
using System.Collections.Generic;
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
        public static string Concat(string s1, string s2)
        {
            return Intrinsics.ToCILString(Intrinsics.ToJavaString(s1).concat(Intrinsics.ToJavaString(s2)));
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
    }
}
