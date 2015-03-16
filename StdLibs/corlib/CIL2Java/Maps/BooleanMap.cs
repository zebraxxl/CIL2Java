using System;
using System.Collections.Generic;
using javaBoolean = java.lang.Boolean;

namespace CIL2Java.Maps
{
    public class BooleanMap : IComparable, IConvertible, IComparable<Boolean>, IEquatable<Boolean>
    {
        private bool value;

        private BooleanMap(bool value)
        {
            this.value = value;
        }

        #region Interface methods
        public static BooleanMap GetAdapter(javaBoolean self)
        {
            return new BooleanMap(self.booleanValue());
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;

            if (!(obj is bool))
                throw new ArgumentException(Environment.GetResourceString("Arg_MustBeBoolean"));

            if (value == (bool)obj)
                return 0;
            else if (!value)
                return -1;
            return 1;
        }

        public TypeCode GetTypeCode()
        {
            return TypeCode.Boolean;
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            return value;
        }

        public char ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Boolean", "Char"));
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte(value);
        }

        public byte ToByte(IFormatProvider provider)
        {
            return Convert.ToByte(value);
        }

        public short ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16(value);
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16(value);
        }

        public int ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32(value);
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(value);
        }

        public long ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64(value);
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64(value);
        }

        public float ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle(value);
        }

        public double ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble(value);
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal(value);
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Boolean", "DateTime"));
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();    //TODO: ToType
        }

        public static TypeCode GetTypeCode(javaBoolean v)
        {
            return TypeCode.Boolean;
        }


        public string ToString(IFormatProvider provider)
        {
            return value ? TrueString : FalseString;
        }

        public int CompareTo(bool value)
        {
            if (this.value == value)
                return 0;
            else if (!this.value)
                return -1;
            return 1;
        }

        public bool Equals(bool obj)
        {
            return value == obj;
        }
        #endregion

        public static readonly string TrueString = "True";
        public static readonly string FalseString = "False";

        public static string ToString(javaBoolean self, IFormatProvider provider)
        {
            return self.booleanValue() ? TrueString : FalseString;
        }

        public static bool Equals(javaBoolean self, bool obj)
        {
            return self.booleanValue() == obj;
        }

        public static int CompareTo(javaBoolean self, object obj)
        {
            bool value = self.booleanValue();

            if (obj == null)
                return 1;

            if (!(obj is bool))
                throw new ArgumentException(Environment.GetResourceString("Arg_MustBeBoolean"));

            if (value == (bool)obj)
                return 0;
            else if (!value)
                return -1;
            return 1;
        }

        public static bool Parse(string value)
        {
            if (value == null)
                throw new ArgumentNullException("value");
            bool result = false;
            if (!TryParse(value, out result))
                throw new FormatException(Environment.GetResourceString("Format_BadBoolean"));
            else
                return result;
        }

        public static bool TryParse(string value, out bool result)
        {
            result = false;
            if (value == null)
                return false;

            // For perf reasons, let's first see if they're equal, then do the
            // trim to get rid of white space, and check again.
            if (TrueString.Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                result = true;
                return true;
            }
            if (FalseString.Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                result = false;
                return true;
            }

            // Special case: Trim whitespace as well as null characters.
            value = TrimWhiteSpaceAndNull(value);

            if (TrueString.Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                result = true;
                return true;
            }

            if (FalseString.Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                result = false;
                return true;
            }

            return false;
        }

        private static string TrimWhiteSpaceAndNull(string value)
        {
            int start = 0;
            int end = value.Length - 1;
            char nullChar = (char)0x0000;

            while (start < value.Length)
            {
                if (!Char.IsWhiteSpace(value[start]) && value[start] != nullChar)
                {
                    break;
                }
                start++;
            }

            while (end >= start)
            {
                if (!Char.IsWhiteSpace(value[end]) && value[end] != nullChar)
                {
                    break;
                }
                end--;
            }

            return value.Substring(start, end - start + 1);
        }
    }
}
