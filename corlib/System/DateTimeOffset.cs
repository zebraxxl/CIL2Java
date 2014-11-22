using System.Runtime.Serialization;
using System.Globalization;

namespace System
{
    /// <summary>Represents a point in time, typically expressed as a date and time of day, relative to Coordinated Universal Time (UTC).</summary><filterpriority>2</filterpriority>
    [Serializable]
    public struct DateTimeOffset : IComparable, IFormattable, ISerializable, IDeserializationCallback, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>
    {
        /// <summary>Represents the earliest possible <see cref="T:System.DateTimeOffset" /> value. This field is read-only.</summary>
        public static readonly DateTimeOffset MinValue;
        /// <summary>Represents the greatest possible value of <see cref="T:System.DateTimeOffset" />. This field is read-only.</summary><exception cref="T:System.ArgumentOutOfRangeException"><see cref="F:System.DateTime.MaxValue" /> is outside the range of the current or specified culture's default calendar.</exception>
        public static readonly DateTimeOffset MaxValue;
    
        /// <summary>Gets a <see cref="T:System.DateTimeOffset" /> object that is set to the current date and time on the current computer, with the offset set to the local time's offset from Coordinated Universal Time (UTC).</summary><returns>A <see cref="T:System.DateTimeOffset" /> object whose date and time is the current local time and whose offset is the local time zone's offset from Coordinated Universal Time (UTC).</returns>
        public static DateTimeOffset Now
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.DateTimeOffset" /> object whose date and time are set to the current Coordinated Universal Time (UTC) date and time and whose offset is <see cref="F:System.TimeSpan.Zero" />.</summary><returns>An object whose date and time is the current Coordinated Universal Time (UTC) and whose offset is <see cref="F:System.TimeSpan.Zero" />.</returns>
        public static DateTimeOffset UtcNow
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.DateTime" /> value that represents the date and time of the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>The date and time of the current <see cref="T:System.DateTimeOffset" /> object.</returns>
        public DateTime DateTime
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.DateTime" /> value that represents the Coordinated Universal Time (UTC) date and time of the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>The Coordinated Universal Time (UTC) date and time of the current <see cref="T:System.DateTimeOffset" /> object.</returns>
        public DateTime UtcDateTime
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.DateTime" /> value that represents the local date and time of the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>The local date and time of the current <see cref="T:System.DateTimeOffset" /> object.</returns>
        public DateTime LocalDateTime
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.DateTime" /> value that represents the date component of the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>A <see cref="T:System.DateTime" /> value that represents the date component of the current <see cref="T:System.DateTimeOffset" /> object.</returns>
        public DateTime Date
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the day of the month represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>The day component of the current <see cref="T:System.DateTimeOffset" /> object, expressed as a value between 1 and 31.</returns>
        public int Day
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the day of the week represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>One of the enumeration values that indicates the day of the week of the current <see cref="T:System.DateTimeOffset" /> object.</returns>
        public DayOfWeek DayOfWeek
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the day of the year represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>The day of the year of the current <see cref="T:System.DateTimeOffset" /> object, expressed as a value between 1 and 366.</returns>
        public int DayOfYear
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the hour component of the time represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>The hour component of the current <see cref="T:System.DateTimeOffset" /> object. This property uses a 24-hour clock; the value ranges from 0 to 23.</returns>
        public int Hour
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the millisecond component of the time represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>The millisecond component of the current <see cref="T:System.DateTimeOffset" /> object, expressed as an integer between 0 and 999.</returns>
        public int Millisecond
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the minute component of the time represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>The minute component of the current <see cref="T:System.DateTimeOffset" /> object, expressed as an integer between 0 and 59.</returns>
        public int Minute
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the month component of the date represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>The month component of the current <see cref="T:System.DateTimeOffset" /> object, expressed as an integer between 1 and 12.</returns>
        public int Month
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the time's offset from Coordinated Universal Time (UTC). </summary><returns>The difference between the current <see cref="T:System.DateTimeOffset" /> object's time value and Coordinated Universal Time (UTC).</returns>
        public TimeSpan Offset
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the second component of the clock time represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>The second component of the <see cref="T:System.DateTimeOffset" /> object, expressed as an integer value between 0 and 59.</returns>
        public int Second
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of ticks that represents the date and time of the current <see cref="T:System.DateTimeOffset" /> object in clock time.</summary><returns>The number of ticks in the <see cref="T:System.DateTimeOffset" /> object's clock time.</returns>
        public long Ticks
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of ticks that represents the date and time of the current <see cref="T:System.DateTimeOffset" /> object in Coordinated Universal Time (UTC).</summary><returns>The number of ticks in the <see cref="T:System.DateTimeOffset" /> object's Coordinated Universal Time (UTC).</returns>
        public long UtcTicks
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the time of day for the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>The time interval of the current date that has elapsed since midnight.</returns>
        public TimeSpan TimeOfDay
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the year component of the date represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>The year component of the current <see cref="T:System.DateTimeOffset" /> object, expressed as an integer value between 0 and 9999.</returns>
        public int Year
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.DateTimeOffset" /> structure using the specified number of ticks and offset.</summary><param name="ticks">A date and time expressed as the number of 100-nanosecond intervals that have elapsed since 12:00:00 midnight on January 1, 0001.</param><param name="offset">The time's offset from Coordinated Universal Time (UTC).</param><exception cref="T:System.ArgumentException"><paramref name="offset" /> is not specified in whole minutes.</exception><exception cref="T:System.ArgumentOutOfRangeException">The <see cref="P:System.DateTimeOffset.UtcDateTime" /> property is earlier than <see cref="F:System.DateTimeOffset.MinValue" /> or later than <see cref="F:System.DateTimeOffset.MaxValue" />.-or-<paramref name="ticks" /> is less than DateTimeOffset.MinValue.Ticks or greater than DateTimeOffset.MaxValue.Ticks.-or-<paramref name="Offset" /> s less than -14 hours or greater than 14 hours.</exception>
        public DateTimeOffset(long ticks, TimeSpan offset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.DateTimeOffset" /> structure using the specified <see cref="T:System.DateTime" /> value.</summary><param name="dateTime">A date and time.   </param><exception cref="T:System.ArgumentOutOfRangeException">The Coordinated Universal Time (UTC) date and time that results from applying the offset is earlier than <see cref="F:System.DateTimeOffset.MinValue" />.-or-The UTC date and time that results from applying the offset is later than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
        public DateTimeOffset(DateTime dateTime)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.DateTimeOffset" /> structure using the specified <see cref="T:System.DateTime" /> value and offset.</summary><param name="dateTime">A date and time.   </param><param name="offset">The time's offset from Coordinated Universal Time (UTC).</param><exception cref="T:System.ArgumentException"><paramref name="dateTime.Kind" /> equals <see cref="F:System.DateTimeKind.Utc" /> and <paramref name="offset" /> does not equal zero.-or-<paramref name="dateTime.Kind" /> equals <see cref="F:System.DateTimeKind.Local" /> and <paramref name="offset" /> does not equal the offset of the system's local time zone.-or-<paramref name="offset" /> is not specified in whole minutes.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> is less than -14 hours or greater than 14 hours.-or-<see cref="P:System.DateTimeOffset.UtcDateTime" /> is less than <see cref="F:System.DateTimeOffset.MinValue" /> or greater than <see cref="F:System.DateTimeOffset.MaxValue" />. </exception>
        public DateTimeOffset(DateTime dateTime, TimeSpan offset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.DateTimeOffset" /> structure using the specified year, month, day, hour, minute, second, and offset.</summary><param name="year">The year (1 through 9999).</param><param name="month">The month (1 through 12).</param><param name="day">The day (1 through the number of days in <paramref name="month" />).</param><param name="hour">The hours (0 through 23).   </param><param name="minute">The minutes (0 through 59).</param><param name="second">The seconds (0 through 59).</param><param name="offset">The time's offset from Coordinated Universal Time (UTC).</param><exception cref="T:System.ArgumentException"><paramref name="offset" /> does not represent whole minutes.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> is less than one or greater than 9999.-or-<paramref name="month" /> is less than one or greater than 12.-or-<paramref name="day" /> is less than one or greater than the number of days in <paramref name="month" />.-or-<paramref name="hour" /> is less than zero or greater than 23.-or-<paramref name="minute" /> is less than 0 or greater than 59.-or-<paramref name="second" /> is less than 0 or greater than 59.-or-<paramref name="offset" /> is less than -14 hours or greater than 14 hours.-or-The <see cref="P:System.DateTimeOffset.UtcDateTime" /> property is earlier than <see cref="F:System.DateTimeOffset.MinValue" /> or later than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
        public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, TimeSpan offset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.DateTimeOffset" /> structure using the specified year, month, day, hour, minute, second, millisecond, and offset.</summary><param name="year">The year (1 through 9999).</param><param name="month">The month (1 through 12).</param><param name="day">The day (1 through the number of days in <paramref name="month" />).</param><param name="hour">The hours (0 through 23).   </param><param name="minute">The minutes (0 through 59).</param><param name="second">The seconds (0 through 59).</param><param name="millisecond">The milliseconds (0 through 999).</param><param name="offset">The time's offset from Coordinated Universal Time (UTC).</param><exception cref="T:System.ArgumentException"><paramref name="offset" /> does not represent whole minutes.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> is less than one or greater than 9999.-or-<paramref name="month" /> is less than one or greater than 12.-or-<paramref name="day" /> is less than one or greater than the number of days in <paramref name="month" />.-or-<paramref name="hour" /> is less than zero or greater than 23.-or-<paramref name="minute" /> is less than 0 or greater than 59.-or-<paramref name="second" /> is less than 0 or greater than 59.-or-<paramref name="millisecond" /> is less than 0 or greater than 999.-or-<paramref name="offset" /> is less than -14 or greater than 14.-or-The <see cref="P:System.DateTimeOffset.UtcDateTime" /> property is earlier than <see cref="F:System.DateTimeOffset.MinValue" /> or later than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
        public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.DateTimeOffset" /> structure using the specified year, month, day, hour, minute, second, millisecond, and offset of a specified calendar.</summary><param name="year">The year.</param><param name="month">The month (1 through 12).</param><param name="day">The day (1 through the number of days in <paramref name="month" />).</param><param name="hour">The hours (0 through 23).   </param><param name="minute">The minutes (0 through 59).</param><param name="second">The seconds (0 through 59).</param><param name="millisecond">The milliseconds (0 through 999).</param><param name="calendar">The calendar that is used to interpret <paramref name="year" />, <paramref name="month" />, and <paramref name="day" />.</param><param name="offset">The time's offset from Coordinated Universal Time (UTC).</param><exception cref="T:System.ArgumentException"><paramref name="offset" /> does not represent whole minutes.</exception><exception cref="T:System.ArgumentNullException"><paramref name="calendar" /> cannot be null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> is less than the <paramref name="calendar" /> parameter's MinSupportedDateTime.Year or greater than MaxSupportedDateTime.Year.-or-<paramref name="month" /> is either less than or greater than the number of months in <paramref name="year" /> in the <paramref name="calendar" />. -or-<paramref name="day" /> is less than one or greater than the number of days in <paramref name="month" />.-or-<paramref name="hour" /> is less than zero or greater than 23.-or-<paramref name="minute" /> is less than 0 or greater than 59.-or-<paramref name="second" /> is less than 0 or greater than 59.-or-<paramref name="millisecond" /> is less than 0 or greater than 999.-or-<paramref name="offset" /> is less than -14 hours or greater than 14 hours.-or-The <paramref name="year" />, <paramref name="month" />, and <paramref name="day" /> parameters cannot be represented as a date and time value.-or-The <see cref="P:System.DateTimeOffset.UtcDateTime" /> property is earlier than <see cref="F:System.DateTimeOffset.MinValue" /> or later than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
        public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, TimeSpan offset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of the current <see cref="T:System.DateTimeOffset" /> object to the date and time specified by an offset value.</summary><returns>An object that is equal to the original <see cref="T:System.DateTimeOffset" /> object (that is, their <see cref="M:System.DateTimeOffset.ToUniversalTime" /> methods return identical points in time) but whose <see cref="P:System.DateTimeOffset.Offset" /> property is set to <paramref name="offset" />.</returns><param name="offset">The offset to convert the <see cref="T:System.DateTimeOffset" /> value to.   </param><exception cref="T:System.ArgumentException">The resulting <see cref="T:System.DateTimeOffset" /> object has a <see cref="P:System.DateTimeOffset.DateTime" /> value earlier than <see cref="F:System.DateTimeOffset.MinValue" />.-or-The resulting <see cref="T:System.DateTimeOffset" /> object has a <see cref="P:System.DateTimeOffset.DateTime" /> value later than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> is less than -14 hours.-or-<paramref name="offset" /> is greater than 14 hours.</exception>
        public DateTimeOffset ToOffset(TimeSpan offset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a specified time interval to a <see cref="T:System.DateTimeOffset" /> object.</summary><returns>An object whose value is the sum of the date and time represented by the current <see cref="T:System.DateTimeOffset" /> object and the time interval represented by <paramref name="timeSpan" />.</returns><param name="timeSpan">A <see cref="T:System.TimeSpan" /> object that represents a positive or a negative time interval.</param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTimeOffset" /> value is less than <see cref="F:System.DateTimeOffset.MinValue" />.-or- The resulting <see cref="T:System.DateTimeOffset" /> value is greater than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
        public DateTimeOffset Add(TimeSpan timeSpan)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a specified number of whole and fractional days to the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>An object whose value is the sum of the date and time represented by the current <see cref="T:System.DateTimeOffset" /> object and the number of days represented by <paramref name="days" />.</returns><param name="days">A number of whole and fractional days. The number can be negative or positive.</param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTimeOffset" /> value is less than <see cref="F:System.DateTimeOffset.MinValue" />.-or- The resulting <see cref="T:System.DateTimeOffset" /> value is greater than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
        public DateTimeOffset AddDays(double days)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a specified number of whole and fractional hours to the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>An object whose value is the sum of the date and time represented by the current <see cref="T:System.DateTimeOffset" /> object and the number of hours represented by <paramref name="hours" />.</returns><param name="hours">A number of whole and fractional hours. The number can be negative or positive.</param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTimeOffset" /> value is less than <see cref="F:System.DateTimeOffset.MinValue" />.-or- The resulting <see cref="T:System.DateTimeOffset" /> value is greater than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
        public DateTimeOffset AddHours(double hours)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a specified number of milliseconds to the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>An object whose value is the sum of the date and time represented by the current <see cref="T:System.DateTimeOffset" /> object and the number of whole milliseconds represented by <paramref name="milliseconds" />.</returns><param name="milliseconds">A number of whole and fractional milliseconds. The number can be negative or positive.   </param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTimeOffset" /> value is less than <see cref="F:System.DateTimeOffset.MinValue" />.-or- The resulting <see cref="T:System.DateTimeOffset" /> value is greater than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
        public DateTimeOffset AddMilliseconds(double milliseconds)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a specified number of whole and fractional minutes to the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>An object whose value is the sum of the date and time represented by the current <see cref="T:System.DateTimeOffset" /> object and the number of minutes represented by <paramref name="minutes" />.</returns><param name="minutes">A number of whole and fractional minutes. The number can be negative or positive.   </param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTimeOffset" /> value is less than <see cref="F:System.DateTimeOffset.MinValue" />.-or- The resulting <see cref="T:System.DateTimeOffset" /> value is greater than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
        public DateTimeOffset AddMinutes(double minutes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a specified number of months to the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>An object whose value is the sum of the date and time represented by the current <see cref="T:System.DateTimeOffset" /> object and the number of months represented by <paramref name="months" />.</returns><param name="months">A number of whole months. The number can be negative or positive.</param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTimeOffset" /> value is less than <see cref="F:System.DateTimeOffset.MinValue" />.-or- The resulting <see cref="T:System.DateTimeOffset" /> value is greater than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
        public DateTimeOffset AddMonths(int months)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a specified number of whole and fractional seconds to the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>An object whose value is the sum of the date and time represented by the current <see cref="T:System.DateTimeOffset" /> object and the number of seconds represented by <paramref name="seconds" />.</returns><param name="seconds">A number of whole and fractional seconds. The number can be negative or positive.</param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTimeOffset" /> value is less than <see cref="F:System.DateTimeOffset.MinValue" />.-or- The resulting <see cref="T:System.DateTimeOffset" /> value is greater than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
        public DateTimeOffset AddSeconds(double seconds)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a specified number of ticks to the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>An object whose value is the sum of the date and time represented by the current <see cref="T:System.DateTimeOffset" /> object and the number of ticks represented by <paramref name="ticks" />.</returns><param name="ticks">A number of 100-nanosecond ticks. The number can be negative or positive.</param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTimeOffset" /> value is less than <see cref="F:System.DateTimeOffset.MinValue" />.-or- The resulting <see cref="T:System.DateTimeOffset" /> value is greater than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
        public DateTimeOffset AddTicks(long ticks)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a specified number of years to the <see cref="T:System.DateTimeOffset" /> object.</summary><returns>An object whose value is the sum of the date and time represented by the current <see cref="T:System.DateTimeOffset" /> object and the number of years represented by <paramref name="years" />.</returns><param name="years">A number of years. The number can be negative or positive.</param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTimeOffset" /> value is less than <see cref="F:System.DateTimeOffset.MinValue" />.-or- The resulting <see cref="T:System.DateTimeOffset" /> value is greater than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
        public DateTimeOffset AddYears(int years)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares two <see cref="T:System.DateTimeOffset" /> objects and indicates whether the first is earlier than the second, equal to the second, or later than the second.</summary><returns>A signed integer that indicates whether the value of the <paramref name="first" /> parameter is earlier than, later than, or the same time as the value of the <paramref name="second" /> parameter, as the following table shows.Return valueMeaningLess than zero<paramref name="first" /> is earlier than <paramref name="second" />.Zero<paramref name="first" /> is equal to <paramref name="second" />.Greater than zero<paramref name="first" /> is later than <paramref name="second" />.</returns><param name="first">The first object to compare.</param><param name="second">The second object to compare.</param>
        public static int Compare(DateTimeOffset first, DateTimeOffset second)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares the current <see cref="T:System.DateTimeOffset" /> object to a specified <see cref="T:System.DateTimeOffset" /> object and indicates whether the current object is earlier than, the same as, or later than the second <see cref="T:System.DateTimeOffset" /> object.</summary><returns>A signed integer that indicates the relationship between the current <see cref="T:System.DateTimeOffset" /> object and <paramref name="other" />, as the following table shows.Return ValueDescriptionLess than zeroThe current <see cref="T:System.DateTimeOffset" /> object is earlier than <paramref name="other" />.ZeroThe current <see cref="T:System.DateTimeOffset" /> object is the same as <paramref name="other" />.Greater than zero.The current <see cref="T:System.DateTimeOffset" /> object is later than <paramref name="other" />.</returns><param name="other">An object to compare with the current <see cref="T:System.DateTimeOffset" /> object.</param>
        public int CompareTo(DateTimeOffset other)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether a <see cref="T:System.DateTimeOffset" /> object represents the same point in time as a specified object.</summary><returns>true if the <paramref name="obj" /> parameter is a <see cref="T:System.DateTimeOffset" /> object and represents the same point in time as the current <see cref="T:System.DateTimeOffset" /> object; otherwise, false.</returns><param name="obj">The object to compare to the current <see cref="T:System.DateTimeOffset" /> object.</param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current <see cref="T:System.DateTimeOffset" /> object represents the same point in time as a specified <see cref="T:System.DateTimeOffset" /> object.</summary><returns>true if both <see cref="T:System.DateTimeOffset" /> objects have the same <see cref="P:System.DateTimeOffset.UtcDateTime" /> value; otherwise, false.</returns><param name="other">An object to compare to the current <see cref="T:System.DateTimeOffset" /> object.   </param>
        public bool Equals(DateTimeOffset other)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current <see cref="T:System.DateTimeOffset" /> object represents the same time and has the same offset as a specified <see cref="T:System.DateTimeOffset" /> object.</summary><returns>true if the current <see cref="T:System.DateTimeOffset" /> object and <paramref name="other" /> have the same date and time value and the same <see cref="P:System.DateTimeOffset.Offset" /> value; otherwise, false.</returns><param name="other">The object to compare to the current <see cref="T:System.DateTimeOffset" /> object. </param>
        public bool EqualsExact(DateTimeOffset other)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether two specified <see cref="T:System.DateTimeOffset" /> objects represent the same point in time.</summary><returns>true if the two <see cref="T:System.DateTimeOffset" /> objects have the same <see cref="P:System.DateTimeOffset.UtcDateTime" /> value; otherwise, false.</returns><param name="first">The first object to compare.</param><param name="second">The second object to compare.</param>
        public static bool Equals(DateTimeOffset first, DateTimeOffset second)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified Windows file time to an equivalent local time.</summary><returns>An object that represents the date and time of <paramref name="fileTime" /> with the offset set to the local time offset.</returns><param name="fileTime">A Windows file time, expressed in ticks.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="filetime" /> is less than zero.-or-<paramref name="filetime" /> is greater than DateTimeOffset.MaxValue.Ticks.</exception>
        public static DateTimeOffset FromFileTime(long fileTime)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified string representation of a date, time, and offset to its <see cref="T:System.DateTimeOffset" /> equivalent.</summary><returns>An object that is equivalent to the date and time that is contained in <paramref name="input" />.</returns><param name="input">A string that contains a date and time to convert.</param><exception cref="T:System.ArgumentException">The offset is greater than 14 hours or less than -14 hours.</exception><exception cref="T:System.ArgumentNullException"><paramref name="input" /> is null.</exception><exception cref="T:System.FormatException"><paramref name="input" /> does not contain a valid string representation of a date and time.-or-<paramref name="input" /> contains the string representation of an offset value without a date or time.</exception>
        public static DateTimeOffset Parse(string input)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTimeOffset" /> equivalent using the specified culture-specific format information.</summary><returns>An object that is equivalent to the date and time that is contained in <paramref name="input" />, as specified by <paramref name="formatProvider" />.</returns><param name="input">A string that contains a date and time to convert.   </param><param name="formatProvider">An object that provides culture-specific format information about <paramref name="input" />.</param><exception cref="T:System.ArgumentException">The offset is greater than 14 hours or less than -14 hours.</exception><exception cref="T:System.ArgumentNullException"><paramref name="input" /> is null.</exception><exception cref="T:System.FormatException"><paramref name="input" /> does not contain a valid string representation of a date and time.-or-<paramref name="input" /> contains the string representation of an offset value without a date or time.</exception>
        public static DateTimeOffset Parse(string input, IFormatProvider formatProvider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTimeOffset" /> equivalent using the specified culture-specific format information and formatting style.</summary><returns>An object that is equivalent to the date and time that is contained in <paramref name="input" /> as specified by <paramref name="formatProvider" /> and <paramref name="styles" />.</returns><param name="input">A string that contains a date and time to convert.   </param><param name="formatProvider">An object that provides culture-specific format information about <paramref name="input" />.</param><param name="styles">A bitwise combination of enumeration values that indicates the permitted format of <paramref name="input" />. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None" />.   </param><exception cref="T:System.ArgumentException">The offset is greater than 14 hours or less than -14 hours.-or-<paramref name="styles" /> is not a valid <see cref="T:System.Globalization.DateTimeStyles" /> value.-or-<paramref name="styles" /> includes an unsupported <see cref="T:System.Globalization.DateTimeStyles" /> value.-or-<paramref name="styles" /> includes <see cref="T:System.Globalization.DateTimeStyles" /> values that cannot be used together.</exception><exception cref="T:System.ArgumentNullException"><paramref name="input" /> is null.</exception><exception cref="T:System.FormatException"><paramref name="input" /> does not contain a valid string representation of a date and time.-or-<paramref name="input" /> contains the string representation of an offset value without a date or time.</exception>
        public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTimeOffset" /> equivalent using the specified format and culture-specific format information. The format of the string representation must match the specified format exactly.</summary><returns>An object that is equivalent to the date and time that is contained in <paramref name="input" /> as specified by <paramref name="format" /> and <paramref name="formatProvider" />.</returns><param name="input">A string that contains a date and time to convert.</param><param name="format">A format specifier that defines the expected format of <paramref name="input" />.</param><param name="formatProvider">An object that supplies culture-specific formatting information about <paramref name="input" />.</param><exception cref="T:System.ArgumentException">The offset is greater than 14 hours or less than -14 hours.</exception><exception cref="T:System.ArgumentNullException"><paramref name="input" /> is null.-or-<paramref name="format" /> is null.</exception><exception cref="T:System.FormatException"><paramref name="input" /> is an empty string ("").-or-<paramref name="input" /> does not contain a valid string representation of a date and time.-or-<paramref name="format" /> is an empty string.-or-The hour component and the AM/PM designator in <paramref name="input" /> do not agree.</exception>
        public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTimeOffset" /> equivalent using the specified format, culture-specific format information, and style. The format of the string representation must match the specified format exactly.</summary><returns>An object that is equivalent to the date and time that is contained in the <paramref name="input" /> parameter, as specified by the <paramref name="format" />, <paramref name="formatProvider" />, and <paramref name="styles" /> parameters.</returns><param name="input">A string that contains a date and time to convert.</param><param name="format">A format specifier that defines the expected format of <paramref name="input" />.</param><param name="formatProvider">An object that supplies culture-specific formatting information about <paramref name="input" />.</param><param name="styles">A bitwise combination of enumeration values that indicates the permitted format of <paramref name="input" />.</param><exception cref="T:System.ArgumentException">The offset is greater than 14 hours or less than -14 hours.-or-The <paramref name="styles" /> parameter includes an unsupported value.-or-The <paramref name="styles" /> parameter contains <see cref="T:System.Globalization.DateTimeStyles" /> values that cannot be used together.</exception><exception cref="T:System.ArgumentNullException"><paramref name="input" /> is null.-or-<paramref name="format" /> is null.</exception><exception cref="T:System.FormatException"><paramref name="input" /> is an empty string ("").-or-<paramref name="input" /> does not contain a valid string representation of a date and time.-or-<paramref name="format" /> is an empty string.-or-The hour component and the AM/PM designator in <paramref name="input" /> do not agree. </exception>
        public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTimeOffset" /> equivalent using the specified formats, culture-specific format information, and style. The format of the string representation must match one of the specified formats exactly.</summary><returns>An object that is equivalent to the date and time that is contained in the <paramref name="input" /> parameter, as specified by the <paramref name="formats" />, <paramref name="formatProvider" />, and <paramref name="styles" /> parameters.</returns><param name="input">A string that contains a date and time to convert.</param><param name="formats">An array of format specifiers that define the expected formats of <paramref name="input" />.</param><param name="formatProvider">An object that supplies culture-specific formatting information about <paramref name="input" />.</param><param name="styles">A bitwise combination of enumeration values that indicates the permitted format of <paramref name="input" />.</param><exception cref="T:System.ArgumentException">The offset is greater than 14 hours or less than -14 hours.-or-<paramref name="styles" /> includes an unsupported value.-or-The <paramref name="styles" /> parameter contains <see cref="T:System.Globalization.DateTimeStyles" /> values that cannot be used together.</exception><exception cref="T:System.ArgumentNullException"><paramref name="input" /> is null.</exception><exception cref="T:System.FormatException"><paramref name="input" /> is an empty string ("").-or-<paramref name="input" /> does not contain a valid string representation of a date and time.-or-No element of <paramref name="formats" /> contains a valid format specifier.-or-The hour component and the AM/PM designator in <paramref name="input" /> do not agree. </exception>
        public static DateTimeOffset ParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Subtracts a <see cref="T:System.DateTimeOffset" /> value that represents a specific date and time from the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>An object that specifies the interval between the two <see cref="T:System.DateTimeOffset" /> objects.</returns><param name="value">An object that represents the value to subtract. </param>
        public TimeSpan Subtract(DateTimeOffset value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Subtracts a specified time interval from the current <see cref="T:System.DateTimeOffset" /> object.</summary><returns>An object that is equal to the date and time represented by the current <see cref="T:System.DateTimeOffset" /> object, minus the time interval represented by <paramref name="value" />.</returns><param name="value">The time interval to subtract.</param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTimeOffset" /> value is less than <see cref="F:System.DateTimeOffset.MinValue" />.-or- The resulting <see cref="T:System.DateTimeOffset" /> value is greater than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
        public DateTimeOffset Subtract(TimeSpan value)
        {
             throw new NotImplementedException();
        }
        
        
        public long ToFileTime()
        {
             throw new NotImplementedException();
        }
        
        
        public DateTimeOffset ToLocalTime()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of the current <see cref="T:System.DateTimeOffset" /> object to its equivalent string representation using the specified format.</summary><returns>A string representation of the value of the current <see cref="T:System.DateTimeOffset" /> object, as specified by <paramref name="format" />.</returns><param name="format">A format string.</param><exception cref="T:System.FormatException">The length of <paramref name="format" /> is one, and it is not one of the standard format specifier characters defined for <see cref="T:System.Globalization.DateTimeFormatInfo" />. -or-<paramref name="format" /> does not contain a valid custom format pattern.</exception><exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by the current culture. </exception>
        public string ToString(string format)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of the current <see cref="T:System.DateTimeOffset" /> object to its equivalent string representation using the specified culture-specific formatting information.</summary><returns>A string representation of the value of the current <see cref="T:System.DateTimeOffset" /> object, as specified by <paramref name="formatProvider" />.</returns><param name="formatProvider">An object that supplies culture-specific formatting information.</param><exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by <paramref name="formatProvider" />. </exception>
        public string ToString(IFormatProvider formatProvider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of the current <see cref="T:System.DateTimeOffset" /> object to its equivalent string representation using the specified format and culture-specific format information.</summary><returns>A string representation of the value of the current <see cref="T:System.DateTimeOffset" /> object, as specified by <paramref name="format" /> and <paramref name="provider" />.</returns><param name="format">A format string.</param><param name="formatProvider">An object that supplies culture-specific formatting information.</param><exception cref="T:System.FormatException">The length of <paramref name="format" /> is one, and it is not one of the standard format specifier characters defined for <see cref="T:System.Globalization.DateTimeFormatInfo" />.-or-<paramref name="format" /> does not contain a valid custom format pattern. </exception><exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by <paramref name="formatProvider" />. </exception>
        public string ToString(string format, IFormatProvider formatProvider)
        {
             throw new NotImplementedException();
        }
        
        
        public DateTimeOffset ToUniversalTime()
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParse(string input, ref DateTimeOffset result)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, ref DateTimeOffset result)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, ref DateTimeOffset result)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles, ref DateTimeOffset result)
        {
             throw new NotImplementedException();
        }
        
        
        public static implicit operator DateTimeOffset(DateTime dateTime)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a specified time interval to a <see cref="T:System.DateTimeOffset" /> object that has a specified date and time, and yields a <see cref="T:System.DateTimeOffset" /> object that has new a date and time.</summary><returns>An object whose value is the sum of the values of <paramref name="dateTimeTz" /> and <paramref name="timeSpan" />.</returns><param name="dateTimeOffset">The object to add the time interval to.</param><param name="timeSpan">The time interval to add.</param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTimeOffset" /> value is less than <see cref="F:System.DateTimeOffset.MinValue" />.-or- The resulting <see cref="T:System.DateTimeOffset" /> value is greater than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
        /// <summary>Adds a specified time interval to a <see cref="T:System.DateTimeOffset" /> object that has a specified date and time, and yields a <see cref="T:System.DateTimeOffset" /> object that has new a date and time.</summary><returns>An object whose value is the sum of the values of <paramref name="dateTimeTz" /> and <paramref name="timeSpan" />.</returns><param name="dateTimeOffset">The object to add the time interval to.</param><param name="timeSpan">The time interval to add.</param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTimeOffset" /> value is less than <see cref="F:System.DateTimeOffset.MinValue" />.-or- The resulting <see cref="T:System.DateTimeOffset" /> value is greater than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
        public static DateTimeOffset operator +(DateTimeOffset dateTimeOffset, TimeSpan timeSpan)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Subtracts a specified time interval from a specified date and time, and yields a new date and time.</summary><returns>An object that is equal to the value of <paramref name="dateTimeOffset" /> minus <paramref name="timeSpan" />.</returns><param name="dateTimeOffset">The date and time object to subtract from.</param><param name="timeSpan">The time interval to subtract.</param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTimeOffset" /> value is less than <see cref="F:System.DateTimeOffset.MinValue" /> or greater than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
        /// <summary>Subtracts a specified time interval from a specified date and time, and yields a new date and time.</summary><returns>An object that is equal to the value of <paramref name="dateTimeOffset" /> minus <paramref name="timeSpan" />.</returns><param name="dateTimeOffset">The date and time object to subtract from.</param><param name="timeSpan">The time interval to subtract.</param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTimeOffset" /> value is less than <see cref="F:System.DateTimeOffset.MinValue" /> or greater than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
        public static DateTimeOffset operator -(DateTimeOffset dateTimeOffset, TimeSpan timeSpan)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Subtracts one <see cref="T:System.DateTimeOffset" /> object from another and yields a time interval.</summary><returns>An object that represents the difference between <paramref name="left" /> and <paramref name="right" />.</returns><param name="left">The minuend.   </param><param name="right">The subtrahend.</param>
        /// <summary>Subtracts one <see cref="T:System.DateTimeOffset" /> object from another and yields a time interval.</summary><returns>An object that represents the difference between <paramref name="left" /> and <paramref name="right" />.</returns><param name="left">The minuend.   </param><param name="right">The subtrahend.</param>
        public static TimeSpan operator -(DateTimeOffset left, DateTimeOffset right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether two specified <see cref="T:System.DateTimeOffset" /> objects represent the same point in time.</summary><returns>true if both <see cref="T:System.DateTimeOffset" /> objects have the same <see cref="P:System.DateTimeOffset.UtcDateTime" /> value; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        /// <summary>Determines whether two specified <see cref="T:System.DateTimeOffset" /> objects represent the same point in time.</summary><returns>true if both <see cref="T:System.DateTimeOffset" /> objects have the same <see cref="P:System.DateTimeOffset.UtcDateTime" /> value; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        public static bool operator ==(DateTimeOffset left, DateTimeOffset right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether two specified <see cref="T:System.DateTimeOffset" /> objects refer to different points in time.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> do not have the same <see cref="P:System.DateTimeOffset.UtcDateTime" /> value; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        /// <summary>Determines whether two specified <see cref="T:System.DateTimeOffset" /> objects refer to different points in time.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> do not have the same <see cref="P:System.DateTimeOffset.UtcDateTime" /> value; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        public static bool operator !=(DateTimeOffset left, DateTimeOffset right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether one specified <see cref="T:System.DateTimeOffset" /> object is less than a second specified <see cref="T:System.DateTimeOffset" /> object.</summary><returns>true if the <see cref="P:System.DateTimeOffset.UtcDateTime" /> value of <paramref name="left" /> is earlier than the <see cref="P:System.DateTimeOffset.UtcDateTime" /> value of <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        /// <summary>Determines whether one specified <see cref="T:System.DateTimeOffset" /> object is less than a second specified <see cref="T:System.DateTimeOffset" /> object.</summary><returns>true if the <see cref="P:System.DateTimeOffset.UtcDateTime" /> value of <paramref name="left" /> is earlier than the <see cref="P:System.DateTimeOffset.UtcDateTime" /> value of <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        public static bool operator <(DateTimeOffset left, DateTimeOffset right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether one specified <see cref="T:System.DateTimeOffset" /> object is less than a second specified <see cref="T:System.DateTimeOffset" /> object.</summary><returns>true if the <see cref="P:System.DateTimeOffset.UtcDateTime" /> value of <paramref name="left" /> is earlier than the <see cref="P:System.DateTimeOffset.UtcDateTime" /> value of <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        /// <summary>Determines whether one specified <see cref="T:System.DateTimeOffset" /> object is less than a second specified <see cref="T:System.DateTimeOffset" /> object.</summary><returns>true if the <see cref="P:System.DateTimeOffset.UtcDateTime" /> value of <paramref name="left" /> is earlier than the <see cref="P:System.DateTimeOffset.UtcDateTime" /> value of <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        public static bool operator <=(DateTimeOffset left, DateTimeOffset right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether one specified <see cref="T:System.DateTimeOffset" /> object is greater than (or later than) a second specified <see cref="T:System.DateTimeOffset" /> object.</summary><returns>true if the <see cref="P:System.DateTimeOffset.UtcDateTime" /> value of <paramref name="left" /> is later than the <see cref="P:System.DateTimeOffset.UtcDateTime" /> value of <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        /// <summary>Determines whether one specified <see cref="T:System.DateTimeOffset" /> object is greater than (or later than) a second specified <see cref="T:System.DateTimeOffset" /> object.</summary><returns>true if the <see cref="P:System.DateTimeOffset.UtcDateTime" /> value of <paramref name="left" /> is later than the <see cref="P:System.DateTimeOffset.UtcDateTime" /> value of <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        public static bool operator >(DateTimeOffset left, DateTimeOffset right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether one specified <see cref="T:System.DateTimeOffset" /> object is greater than or equal to a second specified <see cref="T:System.DateTimeOffset" /> object.</summary><returns>true if the <see cref="P:System.DateTimeOffset.UtcDateTime" /> value of <paramref name="left" /> is the same as or later than the <see cref="P:System.DateTimeOffset.UtcDateTime" /> value of <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        /// <summary>Determines whether one specified <see cref="T:System.DateTimeOffset" /> object is greater than or equal to a second specified <see cref="T:System.DateTimeOffset" /> object.</summary><returns>true if the <see cref="P:System.DateTimeOffset.UtcDateTime" /> value of <paramref name="left" /> is the same as or later than the <see cref="P:System.DateTimeOffset.UtcDateTime" /> value of <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        public static bool operator >=(DateTimeOffset left, DateTimeOffset right)
        {
             throw new NotImplementedException();
        }



        int IComparable.CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        void IDeserializationCallback.OnDeserialization(object sender)
        {
            throw new NotImplementedException();
        }
    }
}
