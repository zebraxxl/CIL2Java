using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Represents a Boolean value.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public struct Boolean : IComparable, IConvertible, IComparable<Boolean>, IEquatable<Boolean>
    {
        /// <summary>Represents the Boolean value true as a string. This field is read-only.</summary><filterpriority>1</filterpriority>
        public static readonly string TrueString;
        /// <summary>Represents the Boolean value false as a string. This field is read-only.</summary><filterpriority>1</filterpriority>
        public static readonly string FalseString;
    
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of this instance to its equivalent string representation (either "True" or "False").</summary><returns><see cref="F:System.Boolean.TrueString" /> if the value of this instance is true, or <see cref="F:System.Boolean.FalseString" /> if the value of this instance is false.</returns><param name="provider">(Reserved) An <see cref="T:System.IFormatProvider" /> object. </param><filterpriority>2</filterpriority>
        public string ToString(IFormatProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> is a <see cref="T:System.Boolean" /> and has the same value as this instance; otherwise, false.</returns><param name="obj">An object to compare to this instance. </param><filterpriority>2</filterpriority>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether this instance is equal to a specified <see cref="T:System.Boolean" /> object.</summary><returns>true if <paramref name="obj" /> has the same value as this instance; otherwise, false.</returns><param name="obj">A <see cref="T:System.Boolean" /> value to compare to this instance.</param><filterpriority>2</filterpriority>
        public bool Equals(bool obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares this instance to a specified object and returns an integer that indicates their relationship to one another.</summary><returns>A signed integer that indicates the relative order of this instance and <paramref name="obj" />.Return Value Condition Less than zero This instance is false and <paramref name="obj" /> is true. Zero This instance and <paramref name="obj" /> are equal (either both are true or both are false). Greater than zero This instance is true and <paramref name="obj" /> is false.-or- <paramref name="obj" /> is null. </returns><param name="obj">An object to compare to this instance, or null. </param><exception cref="T:System.ArgumentException"><paramref name="obj" /> is not a <see cref="T:System.Boolean" />. </exception><filterpriority>2</filterpriority>
        public int CompareTo(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares this instance to a specified <see cref="T:System.Boolean" /> object and returns an integer that indicates their relationship to one another.</summary><returns>A signed integer that indicates the relative values of this instance and <paramref name="value" />.Return Value Condition Less than zero This instance is false and <paramref name="value" /> is true. Zero This instance and <paramref name="value" /> are equal (either both are true or both are false). Greater than zero This instance is true and <paramref name="value" /> is false. </returns><param name="value">A <see cref="T:System.Boolean" /> object to compare to this instance. </param><filterpriority>2</filterpriority>
        public int CompareTo(bool value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified string representation of a logical value to its <see cref="T:System.Boolean" /> equivalent, or throws an exception if the string is not equivalent to the value of <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />.</summary><returns>true if <paramref name="value" /> is equivalent to the value of the <see cref="F:System.Boolean.TrueString" /> field; false if <paramref name="value" /> is equivalent to the value of the <see cref="F:System.Boolean.FalseString" /> field.</returns><param name="value">A string containing the value to convert. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="value" /> is not equivalent to the value of the <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" /> field. </exception><filterpriority>1</filterpriority>
        public static bool Parse(string value)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParse(string value, ref bool result)
        {
             throw new NotImplementedException();
        }
        
        
        public TypeCode GetTypeCode()
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
