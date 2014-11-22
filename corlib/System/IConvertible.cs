using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Defines methods that convert the value of the implementing reference or value type to a common language runtime type that has an equivalent value.</summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public interface IConvertible
    {
        TypeCode GetTypeCode();
        
        
        /// <summary>Converts the value of this instance to an equivalent Boolean value using the specified culture-specific formatting information.</summary><returns>A Boolean value equivalent to the value of this instance.</returns><param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param><filterpriority>2</filterpriority>
        bool ToBoolean(IFormatProvider provider);
        
        
        /// <summary>Converts the value of this instance to an equivalent Unicode character using the specified culture-specific formatting information.</summary><returns>A Unicode character equivalent to the value of this instance.</returns><param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param><filterpriority>2</filterpriority>
        char ToChar(IFormatProvider provider);
        
        
        /// <summary>Converts the value of this instance to an equivalent 8-bit signed integer using the specified culture-specific formatting information.</summary><returns>An 8-bit signed integer equivalent to the value of this instance.</returns><param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param><filterpriority>2</filterpriority>
        sbyte ToSByte(IFormatProvider provider);
        
        
        /// <summary>Converts the value of this instance to an equivalent 8-bit unsigned integer using the specified culture-specific formatting information.</summary><returns>An 8-bit unsigned integer equivalent to the value of this instance.</returns><param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param><filterpriority>2</filterpriority>
        byte ToByte(IFormatProvider provider);
        
        
        /// <summary>Converts the value of this instance to an equivalent 16-bit signed integer using the specified culture-specific formatting information.</summary><returns>An 16-bit signed integer equivalent to the value of this instance.</returns><param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param><filterpriority>2</filterpriority>
        short ToInt16(IFormatProvider provider);
        
        
        /// <summary>Converts the value of this instance to an equivalent 16-bit unsigned integer using the specified culture-specific formatting information.</summary><returns>An 16-bit unsigned integer equivalent to the value of this instance.</returns><param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param><filterpriority>2</filterpriority>
        ushort ToUInt16(IFormatProvider provider);
        
        
        /// <summary>Converts the value of this instance to an equivalent 32-bit signed integer using the specified culture-specific formatting information.</summary><returns>An 32-bit signed integer equivalent to the value of this instance.</returns><param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param><filterpriority>2</filterpriority>
        int ToInt32(IFormatProvider provider);
        
        
        /// <summary>Converts the value of this instance to an equivalent 32-bit unsigned integer using the specified culture-specific formatting information.</summary><returns>An 32-bit unsigned integer equivalent to the value of this instance.</returns><param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param><filterpriority>2</filterpriority>
        uint ToUInt32(IFormatProvider provider);
        
        
        /// <summary>Converts the value of this instance to an equivalent 64-bit signed integer using the specified culture-specific formatting information.</summary><returns>An 64-bit signed integer equivalent to the value of this instance.</returns><param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param><filterpriority>2</filterpriority>
        long ToInt64(IFormatProvider provider);
        
        
        /// <summary>Converts the value of this instance to an equivalent 64-bit unsigned integer using the specified culture-specific formatting information.</summary><returns>An 64-bit unsigned integer equivalent to the value of this instance.</returns><param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param><filterpriority>2</filterpriority>
        ulong ToUInt64(IFormatProvider provider);
        
        
        /// <summary>Converts the value of this instance to an equivalent single-precision floating-point number using the specified culture-specific formatting information.</summary><returns>A single-precision floating-point number equivalent to the value of this instance.</returns><param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param><filterpriority>2</filterpriority>
        float ToSingle(IFormatProvider provider);
        
        
        /// <summary>Converts the value of this instance to an equivalent double-precision floating-point number using the specified culture-specific formatting information.</summary><returns>A double-precision floating-point number equivalent to the value of this instance.</returns><param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param><filterpriority>2</filterpriority>
        double ToDouble(IFormatProvider provider);
        
        
        /// <summary>Converts the value of this instance to an equivalent <see cref="T:System.Decimal" /> number using the specified culture-specific formatting information.</summary><returns>A <see cref="T:System.Decimal" /> number equivalent to the value of this instance.</returns><param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param><filterpriority>2</filterpriority>
        decimal ToDecimal(IFormatProvider provider);
        
        
        /// <summary>Converts the value of this instance to an equivalent <see cref="T:System.DateTime" /> using the specified culture-specific formatting information.</summary><returns>A <see cref="T:System.DateTime" /> instance equivalent to the value of this instance.</returns><param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param><filterpriority>2</filterpriority>
        DateTime ToDateTime(IFormatProvider provider);
        
        
        /// <summary>Converts the value of this instance to an equivalent <see cref="T:System.String" /> using the specified culture-specific formatting information.</summary><returns>A <see cref="T:System.String" /> instance equivalent to the value of this instance.</returns><param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param><filterpriority>2</filterpriority>
        string ToString(IFormatProvider provider);
        
        
        /// <summary>Converts the value of this instance to an <see cref="T:System.Object" /> of the specified <see cref="T:System.Type" /> that has an equivalent value, using the specified culture-specific formatting information.</summary><returns>An <see cref="T:System.Object" /> instance of type <paramref name="conversionType" /> whose value is equivalent to the value of this instance.</returns><param name="conversionType">The <see cref="T:System.Type" /> to which the value of this instance is converted. </param><param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param><filterpriority>2</filterpriority>
        object ToType(Type conversionType, IFormatProvider provider);
        
        
    }
}
