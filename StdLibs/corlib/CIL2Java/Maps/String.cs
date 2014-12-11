using System;
using System.Collections;
using System.Collections.Generic;
using javaString = java.lang.String;

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

        public static javaString Concat(javaString s1, javaString s2)
        {
            return s1.concat(s2);
        }

        public static bool OperatorEq(javaString a, javaString b)
        {
            return a.Equals(b);
        }

        public static bool OperatorNotEq(javaString a, javaString b)
        {
            return !a.Equals(b);
        }
    }
}
