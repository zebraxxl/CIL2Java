using System.Runtime.InteropServices;
using System;

namespace System.Runtime.Serialization
{
    /// <summary>Provides the connection between an instance of <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and the formatter-provided class best suited to parse the data inside the <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
    [ComVisibleAttribute(true)]
    public interface IFormatterConverter
    {
        /// <summary>Converts a value to the given <see cref="T:System.Type" />.</summary><returns>The converted <paramref name="value" />.</returns><param name="value">The object to be converted. </param><param name="type">The <see cref="T:System.Type" /> into which <paramref name="value" /> is to be converted. </param>
        object Convert(object value, Type type);
        
        
        /// <summary>Converts a value to the given <see cref="T:System.TypeCode" />.</summary><returns>The converted <paramref name="value" />.</returns><param name="value">The object to be converted. </param><param name="typeCode">The <see cref="T:System.TypeCode" /> into which <paramref name="value" /> is to be converted. </param>
        object Convert(object value, TypeCode typeCode);
        
        
        /// <summary>Converts a value to a <see cref="T:System.Boolean" />.</summary><returns>The converted <paramref name="value" />.</returns><param name="value">The object to be converted. </param>
        bool ToBoolean(object value);
        
        
        /// <summary>Converts a value to a Unicode character.</summary><returns>The converted <paramref name="value" />.</returns><param name="value">The object to be converted. </param>
        char ToChar(object value);
        
        
        /// <summary>Converts a value to a <see cref="T:System.SByte" />.</summary><returns>The converted <paramref name="value" />.</returns><param name="value">The object to be converted. </param>
        sbyte ToSByte(object value);
        
        
        /// <summary>Converts a value to an 8-bit unsigned integer.</summary><returns>The converted <paramref name="value" />.</returns><param name="value">The object to be converted. </param>
        byte ToByte(object value);
        
        
        /// <summary>Converts a value to a 16-bit signed integer.</summary><returns>The converted <paramref name="value" />.</returns><param name="value">The object to be converted. </param>
        short ToInt16(object value);
        
        
        /// <summary>Converts a value to a 16-bit unsigned integer.</summary><returns>The converted <paramref name="value" />.</returns><param name="value">The object to be converted. </param>
        ushort ToUInt16(object value);
        
        
        /// <summary>Converts a value to a 32-bit signed integer.</summary><returns>The converted <paramref name="value" />.</returns><param name="value">The object to be converted. </param>
        int ToInt32(object value);
        
        
        /// <summary>Converts a value to a 32-bit unsigned integer.</summary><returns>The converted <paramref name="value" />.</returns><param name="value">The object to be converted. </param>
        uint ToUInt32(object value);
        
        
        /// <summary>Converts a value to a 64-bit signed integer.</summary><returns>The converted <paramref name="value" />.</returns><param name="value">The object to be converted. </param>
        long ToInt64(object value);
        
        
        /// <summary>Converts a value to a 64-bit unsigned integer.</summary><returns>The converted <paramref name="value" />.</returns><param name="value">The object to be converted. </param>
        ulong ToUInt64(object value);
        
        
        /// <summary>Converts a value to a single-precision floating-point number.</summary><returns>The converted <paramref name="value" />.</returns><param name="value">The object to be converted. </param>
        float ToSingle(object value);
        
        
        /// <summary>Converts a value to a double-precision floating-point number.</summary><returns>The converted <paramref name="value" />.</returns><param name="value">The object to be converted. </param>
        double ToDouble(object value);
        
        
        /// <summary>Converts a value to a <see cref="T:System.Decimal" />.</summary><returns>The converted <paramref name="value" />.</returns><param name="value">The object to be converted. </param>
        decimal ToDecimal(object value);
        
        
        /// <summary>Converts a value to a <see cref="T:System.DateTime" />.</summary><returns>The converted <paramref name="value" />.</returns><param name="value">The object to be converted. </param>
        DateTime ToDateTime(object value);
        
        
        /// <summary>Converts a value to a <see cref="T:System.String" />.</summary><returns>The converted <paramref name="value" />.</returns><param name="value">The object to be converted. </param>
        string ToString(object value);
        
        
    }
}
