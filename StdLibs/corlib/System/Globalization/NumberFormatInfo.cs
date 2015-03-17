using System.Runtime.InteropServices;
using System;
using System.Runtime.Serialization;

namespace System.Globalization
{
    /// <summary>Defines how numeric values are formatted and displayed, depending on the culture.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class NumberFormatInfo : ICloneable, IFormatProvider
    {
    
        /// <summary>Gets the default read-only <see cref="T:System.Globalization.NumberFormatInfo" /> that is culture-independent (invariant).</summary><returns>The default read-only <see cref="T:System.Globalization.NumberFormatInfo" /> that is culture-independent (invariant).</returns>
        public static NumberFormatInfo InvariantInfo
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the number of decimal places to use in currency values.</summary><returns>The number of decimal places to use in currency values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 2.</returns><exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 99. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public int CurrencyDecimalDigits
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the string to use as the decimal separator in currency values.</summary><returns>The string to use as the decimal separator in currency values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is ".".</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception><exception cref="T:System.ArgumentException">The property is being set to an empty string.</exception>
        public string CurrencyDecimalSeparator
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether this <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</summary><returns>true if the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only; otherwise, false.</returns>
        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the number of digits in each group to the left of the decimal in currency values.</summary><returns>The number of digits in each group to the left of the decimal in currency values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is a one-dimensional array with only one element, which is set to 3.</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.ArgumentException">The property is being set and the array contains an entry that is less than 0 or greater than 9.-or- The property is being set and the array contains an entry, other than the last entry, that is set to 0. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public int[] CurrencyGroupSizes
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the number of digits in each group to the left of the decimal in numeric values.</summary><returns>The number of digits in each group to the left of the decimal in numeric values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is a one-dimensional array with only one element, which is set to 3.</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.ArgumentException">The property is being set and the array contains an entry that is less than 0 or greater than 9.-or- The property is being set and the array contains an entry, other than the last entry, that is set to 0. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public int[] NumberGroupSizes
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the number of digits in each group to the left of the decimal in percent values. </summary><returns>The number of digits in each group to the left of the decimal in percent values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is a one-dimensional array with only one element, which is set to 3.</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.ArgumentException">The property is being set and the array contains an entry that is less than 0 or greater than 9.-or- The property is being set and the array contains an entry, other than the last entry, that is set to 0. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public int[] PercentGroupSizes
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the string that separates groups of digits to the left of the decimal in currency values.</summary><returns>The string that separates groups of digits to the left of the decimal in currency values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is ",".</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public string CurrencyGroupSeparator
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the string to use as the currency symbol.</summary><returns>The string to use as the currency symbol. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "¤". </returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public string CurrencySymbol
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a read-only <see cref="T:System.Globalization.NumberFormatInfo" /> that formats values based on the current culture.</summary><returns>A read-only <see cref="T:System.Globalization.NumberFormatInfo" /> based on the <see cref="T:System.Globalization.CultureInfo" /> of the current thread.</returns>
        public static NumberFormatInfo CurrentInfo
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the string that represents the IEEE NaN (not a number) value.</summary><returns>The string that represents the IEEE NaN (not a number) value. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "NaN".</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public string NaNSymbol
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the format pattern for negative currency values.</summary><returns>The format pattern for negative currency values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 0, which represents "($n)", where "$" is the <see cref="P:System.Globalization.NumberFormatInfo.CurrencySymbol" /> and <paramref name="n" /> is a number.</returns><exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 15. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public int CurrencyNegativePattern
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the format pattern for negative numeric values.</summary><returns>The format pattern for negative numeric values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 1, which represents "-n", where <paramref name="n" /> is a number.</returns><exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 4. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public int NumberNegativePattern
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the format pattern for positive percent values.</summary><returns>The format pattern for positive percent values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 0, which represents "n %", where "%" is the <see cref="P:System.Globalization.NumberFormatInfo.PercentSymbol" /> and <paramref name="n" /> is a number.</returns><exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 3. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public int PercentPositivePattern
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the format pattern for negative percent values.</summary><returns>The format pattern for negative percent values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 0, which represents "-n %", where "%" is the <see cref="P:System.Globalization.NumberFormatInfo.PercentSymbol" /> and <paramref name="n" /> is a number.</returns><exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 11. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public int PercentNegativePattern
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the string that represents negative infinity.</summary><returns>The string that represents negative infinity. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "-Infinity".</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public string NegativeInfinitySymbol
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the string that denotes that the associated number is negative.</summary><returns>The string that denotes that the associated number is negative. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "-".</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public string NegativeSign
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the number of decimal places to use in numeric values.</summary><returns>The number of decimal places to use in numeric values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 2.</returns><exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 99. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public int NumberDecimalDigits
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the string to use as the decimal separator in numeric values.</summary><returns>The string to use as the decimal separator in numeric values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is ".".</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception><exception cref="T:System.ArgumentException">The property is being set to an empty string.</exception>
        public string NumberDecimalSeparator
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the string that separates groups of digits to the left of the decimal in numeric values.</summary><returns>The string that separates groups of digits to the left of the decimal in numeric values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is ",".</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public string NumberGroupSeparator
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the format pattern for positive currency values.</summary><returns>The format pattern for positive currency values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 0, which represents "$n", where "$" is the <see cref="P:System.Globalization.NumberFormatInfo.CurrencySymbol" /> and <paramref name="n" /> is a number.</returns><exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 3. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public int CurrencyPositivePattern
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the string that represents positive infinity.</summary><returns>The string that represents positive infinity. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "Infinity".</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public string PositiveInfinitySymbol
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the string that denotes that the associated number is positive.</summary><returns>The string that denotes that the associated number is positive. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "+".</returns><exception cref="T:System.ArgumentNullException">In a set operation, the value to be assigned is null.</exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public string PositiveSign
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the number of decimal places to use in percent values. </summary><returns>The number of decimal places to use in percent values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 2.</returns><exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 99. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public int PercentDecimalDigits
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the string to use as the decimal separator in percent values. </summary><returns>The string to use as the decimal separator in percent values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is ".".</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception><exception cref="T:System.ArgumentException">The property is being set to an empty string.</exception>
        public string PercentDecimalSeparator
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the string that separates groups of digits to the left of the decimal in percent values. </summary><returns>The string that separates groups of digits to the left of the decimal in percent values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is ",".</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public string PercentGroupSeparator
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the string to use as the percent symbol.</summary><returns>The string to use as the percent symbol. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "%".</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public string PercentSymbol
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the string to use as the per mille symbol.</summary><returns>The string to use as the per mille symbol. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "‰", which is the Unicode character U+2030.</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only. </exception>
        public string PerMilleSymbol
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a string array of native digits equivalent to the Western digits 0 through 9.</summary><returns>An array of type <see cref="T:System.String" /> that contains the native equivalent of the Western digits 0 through 9. The default is an array having the elements "0", "1", "2", "3", "4", "5", "6", "7", "8", and "9".</returns><exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception><exception cref="T:System.ArgumentNullException">In a set operation, the value is null.-or-In a set operation, an element of the value array is null.</exception><exception cref="T:System.ArgumentException">In a set operation, the value array does not contain 10 elements.-or-In a set operation, an element of the value array does not contain either a single <see cref="T:System.Char" /> object or a pair of <see cref="T:System.Char" /> objects that comprise a surrogate pair.-or-In a set operation, an element of the value array is not a number digit as defined by the Unicode Standard. That is, the digit in the array element does not have the Unicode Number, Decimal Digit (Nd) General Category value.-or-In a set operation, the numeric value of an element in the value array does not correspond to the element's position in the array. That is, the element at index 0, which is the first element of the array, does not have a numeric value of 0, or the element at index 1 does not have a numeric value of 1. </exception>
        [ComVisibleAttribute(false)]
        public string[] NativeDigits
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value that specifies how the graphical user interface displays the shape of a digit.</summary><returns>One of the enumeration values that specifies the culture-specific digit shape.</returns><exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception><exception cref="T:System.ArgumentException">The value in a set operation is not a valid <see cref="T:System.Globalization.DigitShapes" /> value.</exception>
        [ComVisibleAttribute(false)]
        public DigitShapes DigitSubstitution
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        private const NumberStyles InvalidNumberStyles = ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite
                                                           | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign
                                                           | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint
                                                           | NumberStyles.AllowThousands | NumberStyles.AllowExponent
                                                           | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowHexSpecifier);

        internal static void ValidateParseStyleInteger(NumberStyles style)
        {
            // Check for undefined flags
            if ((style & InvalidNumberStyles) != 0)
            {
                throw new ArgumentException(Environment.GetResourceString("Argument_InvalidNumberStyles"), "style");
            }
            
            if ((style & NumberStyles.AllowHexSpecifier) != 0)
            { // Check for hex number
                if ((style & ~NumberStyles.HexNumber) != 0)
                {
                    throw new ArgumentException(Environment.GetResourceString("Arg_InvalidHexStyle"));
                }
            }
        }
    
    
        public NumberFormatInfo()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the <see cref="T:System.Globalization.NumberFormatInfo" /> associated with the specified <see cref="T:System.IFormatProvider" />.</summary><returns>The <see cref="T:System.Globalization.NumberFormatInfo" /> associated with the specified <see cref="T:System.IFormatProvider" />.</returns><param name="formatProvider">The <see cref="T:System.IFormatProvider" /> used to get the <see cref="T:System.Globalization.NumberFormatInfo" />.-or- null to get <see cref="P:System.Globalization.NumberFormatInfo.CurrentInfo" />. </param>
        public static NumberFormatInfo GetInstance(IFormatProvider formatProvider)
        {
             throw new NotImplementedException();
        }
        
        
        public object Clone()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets an object of the specified type that provides a number formatting service.</summary><returns>The current <see cref="T:System.Globalization.NumberFormatInfo" />, if <paramref name="formatType" /> is the same as the type of the current <see cref="T:System.Globalization.NumberFormatInfo" />; otherwise, null.</returns><param name="formatType">The <see cref="T:System.Type" /> of the required formatting service. </param>
        public object GetFormat(Type formatType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a read-only <see cref="T:System.Globalization.NumberFormatInfo" /> wrapper.</summary><returns>A read-only <see cref="T:System.Globalization.NumberFormatInfo" /> wrapper around <paramref name="nfi" />.</returns><param name="nfi">The <see cref="T:System.Globalization.NumberFormatInfo" /> to wrap. </param><exception cref="T:System.ArgumentNullException"><paramref name="nfi" /> is null. </exception>
        public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
