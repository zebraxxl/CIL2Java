using System.Runtime.InteropServices;
using CIL2Java.Attributes;
using javaBoolean = java.lang.Boolean;
using mapBoolean = CIL2Java.Maps.BooleanMap;

namespace System
{
    /// <summary>Represents a Boolean value.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [JavaBoxTypeMap(typeof(javaBoolean))]
    [JavaBoxedInterfacesMap(typeof(mapBoolean))]
    public struct Boolean : IComparable, IConvertible, IComparable<Boolean>, IEquatable<Boolean>
    {
        private bool value;

        private Boolean(bool value)
        {
            this.value = value;
        }

        [return: Boxed]
        public static bool valueOf(bool value)
        {
            return new Boolean(value);
        }

        //TODO: JavaBoxedFieldMap
        /// <summary>Represents the Boolean value true as a string. This field is read-only.</summary><filterpriority>1</filterpriority>
        public static readonly string TrueString = "True";
        /// <summary>Represents the Boolean value false as a string. This field is read-only.</summary><filterpriority>1</filterpriority>
        public static readonly string FalseString = "False";
    
        [JavaBoxMethodMap(typeof(javaBoolean), "hashCode")]
        public override int GetHashCode()
        {
            return value ? 1 : 0;   //But java will return 1231 or 1237 - stange, very strange Java :-)
        }        
        
        [JavaBoxMethodMap(typeof(javaBoolean), "toString")]
        public override string ToString()
        {
            return value ? TrueString : FalseString;
        }
        
        /// <summary>Converts the value of this instance to its equivalent string representation (either "True" or "False").</summary><returns><see cref="F:System.Boolean.TrueString" /> if the value of this instance is true, or <see cref="F:System.Boolean.FalseString" /> if the value of this instance is false.</returns><param name="provider">(Reserved) An <see cref="T:System.IFormatProvider" /> object. </param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapBoolean), "toString", true)]
        public string ToString(IFormatProvider provider)
        {
            return value ? TrueString : FalseString;
        }
        
        /// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> is a <see cref="T:System.Boolean" /> and has the same value as this instance; otherwise, false.</returns><param name="obj">An object to compare to this instance. </param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(javaBoolean), "equals")]
        public override bool Equals(object obj)
        {
            if (!(obj is Boolean))
                return false;
            return value == ((Boolean)obj).value;
        }
        
        /// <summary>Returns a value indicating whether this instance is equal to a specified <see cref="T:System.Boolean" /> object.</summary><returns>true if <paramref name="obj" /> has the same value as this instance; otherwise, false.</returns><param name="obj">A <see cref="T:System.Boolean" /> value to compare to this instance.</param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapBoolean), "equals", true)]
        public bool Equals(bool obj)
        {
            return value == obj;
        }
        
        
        /// <summary>Compares this instance to a specified object and returns an integer that indicates their relationship to one another.</summary><returns>A signed integer that indicates the relative order of this instance and <paramref name="obj" />.Return Value Condition Less than zero This instance is false and <paramref name="obj" /> is true. Zero This instance and <paramref name="obj" /> are equal (either both are true or both are false). Greater than zero This instance is true and <paramref name="obj" /> is false.-or- <paramref name="obj" /> is null. </returns><param name="obj">An object to compare to this instance, or null. </param><exception cref="T:System.ArgumentException"><paramref name="obj" /> is not a <see cref="T:System.Boolean" />. </exception><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapBoolean), "CompareTo", true)]
        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;

            if (!(obj is Boolean))
                throw new ArgumentException(Environment.GetResourceString("Arg_MustBeBoolean"));

            if (value == ((Boolean)obj).value)
                return 0;
            else if (!value)
                return -1;
            return 1;
        }
        
        /// <summary>Compares this instance to a specified <see cref="T:System.Boolean" /> object and returns an integer that indicates their relationship to one another.</summary><returns>A signed integer that indicates the relative values of this instance and <paramref name="value" />.Return Value Condition Less than zero This instance is false and <paramref name="value" /> is true. Zero This instance and <paramref name="value" /> are equal (either both are true or both are false). Greater than zero This instance is true and <paramref name="value" /> is false. </returns><param name="value">A <see cref="T:System.Boolean" /> object to compare to this instance. </param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapBoolean), "CompareTo", true)]
        public int CompareTo(bool value)
        {
            if (this.value == value)
                return 0;
            else if (!this.value)
                return -1;
            return 1;
        }
        


        /// <summary>Converts the specified string representation of a logical value to its <see cref="T:System.Boolean" /> equivalent, or throws an exception if the string is not equivalent to the value of <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />.</summary><returns>true if <paramref name="value" /> is equivalent to the value of the <see cref="F:System.Boolean.TrueString" /> field; false if <paramref name="value" /> is equivalent to the value of the <see cref="F:System.Boolean.FalseString" /> field.</returns><param name="value">A string containing the value to convert. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="value" /> is not equivalent to the value of the <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" /> field. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapBoolean), "Parse")]
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

        [JavaBoxMethodMap(typeof(mapBoolean), "TryParse")]
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


        [JavaBoxMethodMap(typeof(mapBoolean), "GetTypeCode", true)]
        public TypeCode GetTypeCode()
        {
            return TypeCode.Boolean;
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            return value;
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Boolean", "Char"));
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte(value);
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            return Convert.ToByte(value);
        }

        short IConvertible.ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16(value);
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16(value);
        }

        int IConvertible.ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32(value);
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(value);
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64(value);
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64(value);
        }

        float IConvertible.ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle(value);
        }

        double IConvertible.ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble(value);
        }

        decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal(value);
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Boolean", "DateTime"));
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();    //TODO: ToType
        }
    }
}
