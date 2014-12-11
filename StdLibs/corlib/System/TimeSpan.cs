using System.Runtime.InteropServices;
using System.Globalization;

namespace System
{
    /// <summary>Represents a time interval.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable
    {
        /// <summary>Represents the number of ticks in 1 millisecond. This field is constant.</summary><filterpriority>1</filterpriority>
        public const long TicksPerMillisecond = 10000;
        /// <summary>Represents the number of ticks in 1 second.</summary><filterpriority>1</filterpriority>
        public const long TicksPerSecond = 10000000;
        /// <summary>Represents the number of ticks in 1 minute. This field is constant.</summary><filterpriority>1</filterpriority>
        public const long TicksPerMinute = 600000000;
        /// <summary>Represents the number of ticks in 1 hour. This field is constant.</summary><filterpriority>1</filterpriority>
        public const long TicksPerHour = 36000000000;
        /// <summary>Represents the number of ticks in 1 day. This field is constant.</summary><filterpriority>1</filterpriority>
        public const long TicksPerDay = 864000000000;
        /// <summary>Represents the zero <see cref="T:System.TimeSpan" /> value. This field is read-only.</summary><filterpriority>1</filterpriority>
        public static readonly TimeSpan Zero;
        /// <summary>Represents the maximum <see cref="T:System.TimeSpan" /> value. This field is read-only.</summary><filterpriority>1</filterpriority>
        public static readonly TimeSpan MaxValue;
        /// <summary>Represents the minimum <see cref="T:System.TimeSpan" /> value. This field is read-only.</summary><filterpriority>1</filterpriority>
        public static readonly TimeSpan MinValue;
    
        /// <summary>Gets the number of ticks that represent the value of the current <see cref="T:System.TimeSpan" /> structure.</summary><returns>The number of ticks contained in this instance.</returns><filterpriority>1</filterpriority>
        public long Ticks
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the days component of the time interval represented by the current <see cref="T:System.TimeSpan" /> structure.</summary><returns>The day component of this instance. The return value can be positive or negative.</returns><filterpriority>1</filterpriority>
        public int Days
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the hours component of the time interval represented by the current <see cref="T:System.TimeSpan" /> structure.</summary><returns>The hour component of the current <see cref="T:System.TimeSpan" /> structure. The return value ranges from -23 through 23.</returns><filterpriority>1</filterpriority>
        public int Hours
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the milliseconds component of the time interval represented by the current <see cref="T:System.TimeSpan" /> structure.</summary><returns>The millisecond component of the current <see cref="T:System.TimeSpan" /> structure. The return value ranges from -999 through 999.</returns><filterpriority>1</filterpriority>
        public int Milliseconds
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the minutes component of the time interval represented by the current <see cref="T:System.TimeSpan" /> structure.</summary><returns>The minute component of the current <see cref="T:System.TimeSpan" /> structure. The return value ranges from -59 through 59.</returns><filterpriority>1</filterpriority>
        public int Minutes
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the seconds component of the time interval represented by the current <see cref="T:System.TimeSpan" /> structure.</summary><returns>The second component of the current <see cref="T:System.TimeSpan" /> structure. The return value ranges from -59 through 59.</returns><filterpriority>1</filterpriority>
        public int Seconds
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value of the current <see cref="T:System.TimeSpan" /> structure expressed in whole and fractional days.</summary><returns>The total number of days represented by this instance.</returns><filterpriority>1</filterpriority>
        public double TotalDays
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value of the current <see cref="T:System.TimeSpan" /> structure expressed in whole and fractional hours.</summary><returns>The total number of hours represented by this instance.</returns><filterpriority>1</filterpriority>
        public double TotalHours
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value of the current <see cref="T:System.TimeSpan" /> structure expressed in whole and fractional milliseconds.</summary><returns>The total number of milliseconds represented by this instance.</returns><filterpriority>1</filterpriority>
        public double TotalMilliseconds
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value of the current <see cref="T:System.TimeSpan" /> structure expressed in whole and fractional minutes.</summary><returns>The total number of minutes represented by this instance.</returns><filterpriority>1</filterpriority>
        public double TotalMinutes
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value of the current <see cref="T:System.TimeSpan" /> structure expressed in whole and fractional seconds.</summary><returns>The total number of seconds represented by this instance.</returns><filterpriority>1</filterpriority>
        public double TotalSeconds
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new <see cref="T:System.TimeSpan" /> to the specified number of ticks.</summary><param name="ticks">A time period expressed in 100-nanosecond units. </param>
        public TimeSpan(long ticks)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new <see cref="T:System.TimeSpan" /> to a specified number of hours, minutes, and seconds.</summary><param name="hours">Number of hours. </param><param name="minutes">Number of minutes. </param><param name="seconds">Number of seconds. </param><exception cref="T:System.ArgumentOutOfRangeException">The parameters specify a <see cref="T:System.TimeSpan" /> value less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
        public TimeSpan(int hours, int minutes, int seconds)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new <see cref="T:System.TimeSpan" /> to a specified number of days, hours, minutes, and seconds.</summary><param name="days">Number of days. </param><param name="hours">Number of hours. </param><param name="minutes">Number of minutes. </param><param name="seconds">Number of seconds. </param><exception cref="T:System.ArgumentOutOfRangeException">The parameters specify a <see cref="T:System.TimeSpan" /> value less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
        public TimeSpan(int days, int hours, int minutes, int seconds)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new <see cref="T:System.TimeSpan" /> to a specified number of days, hours, minutes, seconds, and milliseconds.</summary><param name="days">Number of days. </param><param name="hours">Number of hours. </param><param name="minutes">Number of minutes. </param><param name="seconds">Number of seconds. </param><param name="milliseconds">Number of milliseconds. </param><exception cref="T:System.ArgumentOutOfRangeException">The parameters specify a <see cref="T:System.TimeSpan" /> value less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
        public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a new <see cref="T:System.TimeSpan" /> object whose value is the sum of the specified <see cref="T:System.TimeSpan" /> object and this instance.</summary><returns>A new object that represents the value of this instance plus the value of <paramref name="ts" />.</returns><param name="ts">The time interval to add.</param><exception cref="T:System.OverflowException">The resulting <see cref="T:System.TimeSpan" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception><filterpriority>1</filterpriority>
        public TimeSpan Add(TimeSpan ts)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares two <see cref="T:System.TimeSpan" /> values and returns an integer that indicates whether the first value is shorter than, equal to, or longer than the second value.</summary><returns>One of the following values.Value Description -1 <paramref name="t1" /> is shorter than <paramref name="t2" />. 0 <paramref name="t1" /> is equal to <paramref name="t2" />. 1 <paramref name="t1" /> is longer than <paramref name="t2" />. </returns><param name="t1">The first time interval to compare. </param><param name="t2">The second time interval to compare. </param><filterpriority>1</filterpriority>
        public static int Compare(TimeSpan t1, TimeSpan t2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares this instance to a specified object and returns an integer that indicates whether this instance is shorter than, equal to, or longer than the specified object.</summary><returns>One of the following values.Value Description -1 This instance is shorter than <paramref name="value" />. 0 This instance is equal to <paramref name="value" />. 1 This instance is longer than <paramref name="value" />.-or- <paramref name="value" /> is null. </returns><param name="value">An object to compare, or null. </param><exception cref="T:System.ArgumentException"><paramref name="value" /> is not a <see cref="T:System.TimeSpan" />. </exception><filterpriority>1</filterpriority>
        public int CompareTo(object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares this instance to a specified <see cref="T:System.TimeSpan" /> object and returns an integer that indicates whether this instance is shorter than, equal to, or longer than the <see cref="T:System.TimeSpan" /> object.</summary><returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Value Description A negative integer This instance is shorter than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. A positive integer This instance is longer than <paramref name="value" />. </returns><param name="value">An object to compare to this instance.</param><filterpriority>1</filterpriority>
        public int CompareTo(TimeSpan value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.TimeSpan" /> that represents a specified number of days, where the specification is accurate to the nearest millisecond.</summary><returns>An object that represents <paramref name="value" />.</returns><param name="value">A number of days, accurate to the nearest millisecond. </param><exception cref="T:System.OverflowException"><paramref name="value" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. -or-<paramref name="value" /> is <see cref="F:System.Double.PositiveInfinity" />.-or-<paramref name="value" /> is <see cref="F:System.Double.NegativeInfinity" />.</exception><exception cref="T:System.ArgumentException"><paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />. </exception><filterpriority>1</filterpriority>
        public static TimeSpan FromDays(double value)
        {
             throw new NotImplementedException();
        }
        
        
        public TimeSpan Duration()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary><returns>true if <paramref name="value" /> is a <see cref="T:System.TimeSpan" /> object that represents the same time interval as the current <see cref="T:System.TimeSpan" /> structure; otherwise, false.</returns><param name="value">An object to compare with this instance. </param><filterpriority>1</filterpriority>
        public override bool Equals(object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether this instance is equal to a specified <see cref="T:System.TimeSpan" /> object.</summary><returns>true if <paramref name="obj" /> represents the same time interval as this instance; otherwise, false.</returns><param name="obj">An object to compare with this instance. </param><filterpriority>1</filterpriority>
        public bool Equals(TimeSpan obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether two specified instances of <see cref="T:System.TimeSpan" /> are equal.</summary><returns>true if the values of <paramref name="t1" /> and <paramref name="t2" /> are equal; otherwise, false.</returns><param name="t1">The first time interval to compare. </param><param name="t2">The second time interval to compare. </param><filterpriority>1</filterpriority>
        public static bool Equals(TimeSpan t1, TimeSpan t2)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.TimeSpan" /> that represents a specified number of hours, where the specification is accurate to the nearest millisecond.</summary><returns>An object that represents <paramref name="value" />.</returns><param name="value">A number of hours accurate to the nearest millisecond. </param><exception cref="T:System.OverflowException"><paramref name="value" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. -or-<paramref name="value" /> is <see cref="F:System.Double.PositiveInfinity" />.-or-<paramref name="value" /> is <see cref="F:System.Double.NegativeInfinity" />.</exception><exception cref="T:System.ArgumentException"><paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />. </exception><filterpriority>1</filterpriority>
        public static TimeSpan FromHours(double value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.TimeSpan" /> that represents a specified number of milliseconds.</summary><returns>An object that represents <paramref name="value" />.</returns><param name="value">A number of milliseconds. </param><exception cref="T:System.OverflowException"><paramref name="value" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />.-or-<paramref name="value" /> is <see cref="F:System.Double.PositiveInfinity" />.-or-<paramref name="value" /> is <see cref="F:System.Double.NegativeInfinity" />. </exception><exception cref="T:System.ArgumentException"><paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />. </exception><filterpriority>1</filterpriority>
        public static TimeSpan FromMilliseconds(double value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.TimeSpan" /> that represents a specified number of minutes, where the specification is accurate to the nearest millisecond.</summary><returns>An object that represents <paramref name="value" />.</returns><param name="value">A number of minutes, accurate to the nearest millisecond. </param><exception cref="T:System.OverflowException"><paramref name="value" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />.-or-<paramref name="value" /> is <see cref="F:System.Double.PositiveInfinity" />.-or-<paramref name="value" /> is <see cref="F:System.Double.NegativeInfinity" />. </exception><exception cref="T:System.ArgumentException"><paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />. </exception><filterpriority>1</filterpriority>
        public static TimeSpan FromMinutes(double value)
        {
             throw new NotImplementedException();
        }
        
        
        public TimeSpan Negate()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.TimeSpan" /> that represents a specified number of seconds, where the specification is accurate to the nearest millisecond.</summary><returns>An object that represents <paramref name="value" />.</returns><param name="value">A number of seconds, accurate to the nearest millisecond. </param><exception cref="T:System.OverflowException"><paramref name="value" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />.-or-<paramref name="value" /> is <see cref="F:System.Double.PositiveInfinity" />.-or-<paramref name="value" /> is <see cref="F:System.Double.NegativeInfinity" />. </exception><exception cref="T:System.ArgumentException"><paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />. </exception><filterpriority>1</filterpriority>
        public static TimeSpan FromSeconds(double value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a new <see cref="T:System.TimeSpan" /> object whose value is the difference between the specified <see cref="T:System.TimeSpan" /> object and this instance.</summary><returns>A new time interval whose value is the result of the value of this instance minus the value of <paramref name="ts" />.</returns><param name="ts">The time interval to be subtracted. </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception><filterpriority>1</filterpriority>
        public TimeSpan Subtract(TimeSpan ts)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.TimeSpan" /> that represents a specified time, where the specification is in units of ticks.</summary><returns>An object that represents <paramref name="value" />.</returns><param name="value">A number of ticks that represent a time. </param><filterpriority>1</filterpriority>
        public static TimeSpan FromTicks(long value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a time interval to its <see cref="T:System.TimeSpan" /> equivalent. </summary><returns>A time interval that corresponds to <paramref name="s" />.</returns><param name="s">A string that specifies the time interval to convert. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> has an invalid format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number that is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />.-or- At least one of the days, hours, minutes, or seconds components is outside its valid range. </exception><filterpriority>1</filterpriority>
        public static TimeSpan Parse(string s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a time interval to its <see cref="T:System.TimeSpan" /> equivalent by using the specified culture-specific format information.</summary><returns>A time interval that corresponds to <paramref name="input" />, as specified by <paramref name="formatProvider" />.</returns><param name="input">A string that specifies the time interval to convert.</param><param name="formatProvider">An object that supplies culture-specific formatting information.</param><exception cref="T:System.ArgumentNullException"><paramref name="input" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="input" /> has an invalid format. </exception><exception cref="T:System.OverflowException"><paramref name="input" /> represents a number that is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />.-or- At least one of the days, hours, minutes, or seconds components in <paramref name="input" /> is outside its valid range. </exception>
        public static TimeSpan Parse(string input, IFormatProvider formatProvider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a time interval to its <see cref="T:System.TimeSpan" /> equivalent by using the specified format and culture-specific format information. The format of the string representation must match the specified format exactly.</summary><returns>A time interval that corresponds to <paramref name="input" />, as specified by <paramref name="format" /> and <paramref name="formatProvider" />.</returns><param name="input">A string that specifies the time interval to convert.</param><param name="format">A standard or custom format string that defines the required format of <paramref name="input" />.</param><param name="formatProvider">An object that provides culture-specific formatting information.</param><exception cref="T:System.ArgumentNullException"><paramref name="input" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="input" /> has an invalid format. </exception><exception cref="T:System.OverflowException"><paramref name="input" /> represents a number that is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />.-or- At least one of the days, hours, minutes, or seconds components in <paramref name="input" /> is outside its valid range. </exception>
        public static TimeSpan ParseExact(string input, string format, IFormatProvider formatProvider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a time interval to its <see cref="T:System.TimeSpan" /> equivalent by using the specified array of format strings and culture-specific format information. The format of the string representation must match one of the specified formats exactly.</summary><returns>A time interval that corresponds to <paramref name="input" />, as specified by <paramref name="formats" /> and <paramref name="formatProvider" />.</returns><param name="input">A string that specifies the time interval to convert.</param><param name="formats">A array of standard or custom format strings that defines the required format of <paramref name="input" />.</param><param name="formatProvider">An object that provides culture-specific formatting information.</param><exception cref="T:System.ArgumentNullException"><paramref name="input" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="input" /> has an invalid format. </exception><exception cref="T:System.OverflowException"><paramref name="input" /> represents a number that is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />.-or- At least one of the days, hours, minutes, or seconds components in <paramref name="input" /> is outside its valid range. </exception>
        public static TimeSpan ParseExact(string input, string[] formats, IFormatProvider formatProvider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a time interval to its <see cref="T:System.TimeSpan" /> equivalent by using the specified format, culture-specific format information, and styles. The format of the string representation must match the specified format exactly.</summary><returns>A time interval that corresponds to <paramref name="input" />, as specified by <paramref name="format" />, <paramref name="formatProvider" />, and <paramref name="styles" />.</returns><param name="input">A string that specifies the time interval to convert.</param><param name="format">A standard or custom format string that defines the required format of <paramref name="input" />.</param><param name="formatProvider">An object that provides culture-specific formatting information.</param><param name="styles">A bitwise combination of enumeration values that defines the style elements that may be present in <paramref name="input" />.</param><exception cref="T:System.ArgumentException"><paramref name="styles" /> is an invalid <see cref="T:System.Globalization.TimeSpanStyles" /> value.</exception><exception cref="T:System.ArgumentNullException"><paramref name="input" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="input" /> has an invalid format. </exception><exception cref="T:System.OverflowException"><paramref name="input" /> represents a number that is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />.-or- At least one of the days, hours, minutes, or seconds components in <paramref name="input" /> is outside its valid range. </exception>
        public static TimeSpan ParseExact(string input, string format, IFormatProvider formatProvider, TimeSpanStyles styles)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a time interval to its <see cref="T:System.TimeSpan" /> equivalent by using the specified formats, culture-specific format information, and styles. The format of the string representation must match one of the specified formats exactly. </summary><returns>A time interval that corresponds to <paramref name="input" />, as specified by <paramref name="formats" />, <paramref name="formatProvider" />, and <paramref name="styles" />.</returns><param name="input">A string that specifies the time interval to convert.</param><param name="formats">A array of standard or custom format strings that define the required format of <paramref name="input" />.</param><param name="formatProvider">An object that provides culture-specific formatting information.</param><param name="styles">A bitwise combination of enumeration values that defines the style elements that may be present in input.</param><exception cref="T:System.ArgumentException"><paramref name="styles" /> is an invalid <see cref="T:System.Globalization.TimeSpanStyles" /> value.</exception><exception cref="T:System.ArgumentNullException"><paramref name="input" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="input" /> has an invalid format. </exception><exception cref="T:System.OverflowException"><paramref name="input" /> represents a number that is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />.-or- At least one of the days, hours, minutes, or seconds components in <paramref name="input" /> is outside its valid range. </exception>
        public static TimeSpan ParseExact(string input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParse(string s, ref TimeSpan result)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParse(string input, IFormatProvider formatProvider, ref TimeSpan result)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, ref TimeSpan result)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, ref TimeSpan result)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, TimeSpanStyles styles, ref TimeSpan result)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles, ref TimeSpan result)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of the current <see cref="T:System.TimeSpan" /> object to its equivalent string representation by using the specified format.</summary><returns>The string representation of the current <see cref="T:System.TimeSpan" /> value in the format specified by the <paramref name="format" /> parameter.</returns><param name="format">A standard or custom <see cref="T:System.TimeSpan" /> format string.</param><exception cref="T:System.FormatException">The <paramref name="format" /> parameter is not recognized or is not supported.</exception>
        public string ToString(string format)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of the current <see cref="T:System.TimeSpan" /> object to its equivalent string representation by using the specified format and culture-specific formatting information.</summary><returns>The string representation of the current <see cref="T:System.TimeSpan" /> value, as specified by <paramref name="format" /> and <paramref name="formatProvider" />.</returns><param name="format">A standard or custom <see cref="T:System.TimeSpan" /> format string.</param><param name="formatProvider">An object that supplies culture-specific formatting information.</param><exception cref="T:System.FormatException">The <paramref name="format" /> parameter is not recognized or is not supported.</exception>
        public string ToString(string format, IFormatProvider formatProvider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.TimeSpan" /> whose value is the negated value of the specified instance.</summary><returns>An object that has the same numeric value as this instance, but the opposite sign.</returns><param name="t">The time interval to be negated. </param><exception cref="T:System.OverflowException">The negated value of this instance cannot be represented by a <see cref="T:System.TimeSpan" />; that is, the value of this instance is <see cref="F:System.TimeSpan.MinValue" />. </exception><filterpriority>3</filterpriority>
        /// <summary>Returns a <see cref="T:System.TimeSpan" /> whose value is the negated value of the specified instance.</summary><returns>An object that has the same numeric value as this instance, but the opposite sign.</returns><param name="t">The time interval to be negated. </param><exception cref="T:System.OverflowException">The negated value of this instance cannot be represented by a <see cref="T:System.TimeSpan" />; that is, the value of this instance is <see cref="F:System.TimeSpan.MinValue" />. </exception><filterpriority>3</filterpriority>
        public static TimeSpan operator -(TimeSpan t)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Subtracts a specified <see cref="T:System.TimeSpan" /> from another specified <see cref="T:System.TimeSpan" />.</summary><returns>An object whose value is the result of the value of <paramref name="t1" /> minus the value of <paramref name="t2" />.</returns><param name="t1">The minuend. </param><param name="t2">The subtrahend. </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception><filterpriority>3</filterpriority>
        /// <summary>Subtracts a specified <see cref="T:System.TimeSpan" /> from another specified <see cref="T:System.TimeSpan" />.</summary><returns>An object whose value is the result of the value of <paramref name="t1" /> minus the value of <paramref name="t2" />.</returns><param name="t1">The minuend. </param><param name="t2">The subtrahend. </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception><filterpriority>3</filterpriority>
        public static TimeSpan operator -(TimeSpan t1, TimeSpan t2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the specified instance of <see cref="T:System.TimeSpan" />.</summary><returns>The time interval specified by <paramref name="t" />.</returns><param name="t">The time interval to return. </param><filterpriority>3</filterpriority>
        /// <summary>Returns the specified instance of <see cref="T:System.TimeSpan" />.</summary><returns>The time interval specified by <paramref name="t" />.</returns><param name="t">The time interval to return. </param><filterpriority>3</filterpriority>
        public static TimeSpan operator +(TimeSpan t)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds two specified <see cref="T:System.TimeSpan" /> instances.</summary><returns>An object whose value is the sum of the values of <paramref name="t1" /> and <paramref name="t2" />.</returns><param name="t1">The first time interval to add. </param><param name="t2">The second time interval to add.</param><exception cref="T:System.OverflowException">The resulting <see cref="T:System.TimeSpan" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception><filterpriority>3</filterpriority>
        /// <summary>Adds two specified <see cref="T:System.TimeSpan" /> instances.</summary><returns>An object whose value is the sum of the values of <paramref name="t1" /> and <paramref name="t2" />.</returns><param name="t1">The first time interval to add. </param><param name="t2">The second time interval to add.</param><exception cref="T:System.OverflowException">The resulting <see cref="T:System.TimeSpan" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception><filterpriority>3</filterpriority>
        public static TimeSpan operator +(TimeSpan t1, TimeSpan t2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.TimeSpan" /> instances are equal.</summary><returns>true if the values of <paramref name="t1" /> and <paramref name="t2" /> are equal; otherwise, false.</returns><param name="t1">The first time interval to compare. </param><param name="t2">The second time interval to compare. </param><filterpriority>3</filterpriority>
        /// <summary>Indicates whether two <see cref="T:System.TimeSpan" /> instances are equal.</summary><returns>true if the values of <paramref name="t1" /> and <paramref name="t2" /> are equal; otherwise, false.</returns><param name="t1">The first time interval to compare. </param><param name="t2">The second time interval to compare. </param><filterpriority>3</filterpriority>
        public static bool operator ==(TimeSpan t1, TimeSpan t2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.TimeSpan" /> instances are not equal.</summary><returns>true if the values of <paramref name="t1" /> and <paramref name="t2" /> are not equal; otherwise, false.</returns><param name="t1">The first time interval to compare.</param><param name="t2">The second time interval to compare.</param><filterpriority>3</filterpriority>
        /// <summary>Indicates whether two <see cref="T:System.TimeSpan" /> instances are not equal.</summary><returns>true if the values of <paramref name="t1" /> and <paramref name="t2" /> are not equal; otherwise, false.</returns><param name="t1">The first time interval to compare.</param><param name="t2">The second time interval to compare.</param><filterpriority>3</filterpriority>
        public static bool operator !=(TimeSpan t1, TimeSpan t2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether a specified <see cref="T:System.TimeSpan" /> is less than another specified <see cref="T:System.TimeSpan" />.</summary><returns>true if the value of <paramref name="t1" /> is less than the value of <paramref name="t2" />; otherwise, false.</returns><param name="t1">The first time interval to compare.</param><param name="t2">The second time interval to compare. </param><filterpriority>3</filterpriority>
        /// <summary>Indicates whether a specified <see cref="T:System.TimeSpan" /> is less than another specified <see cref="T:System.TimeSpan" />.</summary><returns>true if the value of <paramref name="t1" /> is less than the value of <paramref name="t2" />; otherwise, false.</returns><param name="t1">The first time interval to compare.</param><param name="t2">The second time interval to compare. </param><filterpriority>3</filterpriority>
        public static bool operator <(TimeSpan t1, TimeSpan t2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether a specified <see cref="T:System.TimeSpan" /> is less than or equal to another specified <see cref="T:System.TimeSpan" />.</summary><returns>true if the value of <paramref name="t1" /> is less than or equal to the value of <paramref name="t2" />; otherwise, false.</returns><param name="t1">The first time interval to compare. </param><param name="t2">The second time interval to compare. </param><filterpriority>3</filterpriority>
        /// <summary>Indicates whether a specified <see cref="T:System.TimeSpan" /> is less than or equal to another specified <see cref="T:System.TimeSpan" />.</summary><returns>true if the value of <paramref name="t1" /> is less than or equal to the value of <paramref name="t2" />; otherwise, false.</returns><param name="t1">The first time interval to compare. </param><param name="t2">The second time interval to compare. </param><filterpriority>3</filterpriority>
        public static bool operator <=(TimeSpan t1, TimeSpan t2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether a specified <see cref="T:System.TimeSpan" /> is greater than another specified <see cref="T:System.TimeSpan" />.</summary><returns>true if the value of <paramref name="t1" /> is greater than the value of <paramref name="t2" />; otherwise, false.</returns><param name="t1">The first time interval to compare. </param><param name="t2">The second time interval to compare. </param><filterpriority>3</filterpriority>
        /// <summary>Indicates whether a specified <see cref="T:System.TimeSpan" /> is greater than another specified <see cref="T:System.TimeSpan" />.</summary><returns>true if the value of <paramref name="t1" /> is greater than the value of <paramref name="t2" />; otherwise, false.</returns><param name="t1">The first time interval to compare. </param><param name="t2">The second time interval to compare. </param><filterpriority>3</filterpriority>
        public static bool operator >(TimeSpan t1, TimeSpan t2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether a specified <see cref="T:System.TimeSpan" /> is greater than or equal to another specified <see cref="T:System.TimeSpan" />.</summary><returns>true if the value of <paramref name="t1" /> is greater than or equal to the value of <paramref name="t2" />; otherwise, false.</returns><param name="t1">The first time interval to compare.</param><param name="t2">The second time interval to compare.</param><filterpriority>3</filterpriority>
        /// <summary>Indicates whether a specified <see cref="T:System.TimeSpan" /> is greater than or equal to another specified <see cref="T:System.TimeSpan" />.</summary><returns>true if the value of <paramref name="t1" /> is greater than or equal to the value of <paramref name="t2" />; otherwise, false.</returns><param name="t1">The first time interval to compare.</param><param name="t2">The second time interval to compare.</param><filterpriority>3</filterpriority>
        public static bool operator >=(TimeSpan t1, TimeSpan t2)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
