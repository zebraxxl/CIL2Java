using System;

namespace System.Globalization
{
    /// <summary>Represents the Saudi Hijri (Um Al Qura) calendar.</summary>
    [Serializable]
    public class UmAlQuraCalendar : Calendar
    {
        /// <summary>Represents the current era. This field is constant.</summary>
        public const int UmAlQuraEra = 1;
    
        /// <summary>Gets the earliest date and time supported by this calendar.</summary><returns>The earliest date and time supported by the <see cref="T:System.Globalization.UmAlQuraCalendar" /> class, which is equivalent to the first moment of April 30, 1900 C.E. in the Gregorian calendar.</returns>
        public override DateTime MinSupportedDateTime
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the latest date and time supported by this calendar.</summary><returns>The latest date and time supported by the <see cref="T:System.Globalization.UmAlQuraCalendar" /> class, which is equivalent to the last moment of May 13, 2029 C.E. in the Gregorian calendar.</returns>
        public override DateTime MaxSupportedDateTime
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the current calendar is solar-based, lunar-based, or a combination of both.</summary><returns>Always returns <see cref="F:System.Globalization.CalendarAlgorithmType.LunarCalendar" />.</returns>
        public override CalendarAlgorithmType AlgorithmType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of days in the year that precedes the year that is specified by the <see cref="P:System.Globalization.UmAlQuraCalendar.MinSupportedDateTime" /> property.</summary><returns>The number of days in the year that precedes the year specified by <see cref="P:System.Globalization.UmAlQuraCalendar.MinSupportedDateTime" />.</returns>
        protected override int DaysInYearBeforeMinSupportedYear
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a list of the eras that are supported by the current <see cref="T:System.Globalization.UmAlQuraCalendar" />.</summary><returns>An array that consists of a single element having a value that is <see cref="F:System.Globalization.UmAlQuraCalendar.UmAlQuraEra" />.</returns>
        public override int[] Eras
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the last year of a 100-year range that can be represented by a 2-digit year.</summary><returns>The last year of a 100-year range that can be represented by a 2-digit year.</returns><exception cref="T:System.InvalidOperationException">This calendar is read-only.</exception><exception cref="T:System.ArgumentOutOfRangeException">In a set operation, the Um Al Qura calendar year value is less than 1318 but not 99, or is greater than 1450.</exception><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public override int TwoDigitYearMax
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public UmAlQuraCalendar()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates a date that is a specified number of months away from a specified initial date.</summary><returns>The date yielded by adding the number of months specified by the <paramref name="months" /> parameter to the date specified by the <paramref name="time" /> parameter.</returns><param name="time">The date to which to add months. The <see cref="T:System.Globalization.UmAlQuraCalendar" /> class supports only dates from 04/30/1900 00.00.00 (Gregorian date) through 05/13/2029 23:59:59 (Gregorian date).</param><param name="months">The positive or negative number of months to add. </param><exception cref="T:System.ArgumentException">The resulting date is outside the range supported by the <see cref="T:System.Globalization.UmAlQuraCalendar" /> class. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="months" /> is less than -120,000 or greater than 120,000. -or-<paramref name="time" /> is outside the range supported by this calendar.</exception>
        public override DateTime AddMonths(DateTime time, int months)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates a date that is a specified number of years away from a specified initial date.</summary><returns>The date yielded by adding the number of years specified by the <paramref name="years" /> parameter to the date specified by the <paramref name="time" /> parameter.</returns><param name="time">The date to which to add years. The <see cref="T:System.Globalization.UmAlQuraCalendar" /> class supports only dates from 04/30/1900 00.00.00 (Gregorian date) through 05/13/2029 23:59:59 (Gregorian date).</param><param name="years">The positive or negative number of years to add. </param><exception cref="T:System.ArgumentException">The resulting date is outside the range supported by the <see cref="T:System.Globalization.UmAlQuraCalendar" /> class. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="years" /> is less than -10,000 or greater than 10,000. -or-<paramref name="time" /> is outside the range supported by this calendar.</exception>
        public override DateTime AddYears(DateTime time, int years)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the day of the month on which a specified date occurs.</summary><returns>An integer from 1 through 30 that represents the day of the month specified by the <paramref name="time" /> parameter. </returns><param name="time">The date value to read. The <see cref="T:System.Globalization.UmAlQuraCalendar" /> class supports only dates from 04/30/1900 00.00.00 (Gregorian date) through 05/13/2029 23:59:59 (Gregorian date).</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="time" /> is outside the range supported by this calendar. </exception>
        public override int GetDayOfMonth(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the day of the week on which a specified date occurs.</summary><returns>A <see cref="T:System.DayOfWeek" /> value that represents the day of the week specified by the <paramref name="time" /> parameter.</returns><param name="time">The date value to read. The <see cref="T:System.Globalization.UmAlQuraCalendar" /> class supports only dates from 04/30/1900 00.00.00 (Gregorian date) through 05/13/2029 23:59:59 (Gregorian date).</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="time" /> is outside the range supported by this calendar. </exception>
        public override DayOfWeek GetDayOfWeek(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the day of the year on which a specified date occurs.</summary><returns>An integer from 1 through 355 that represents the day of the year specified by the <paramref name="time" /> parameter.</returns><param name="time">The date value to read. The <see cref="T:System.Globalization.UmAlQuraCalendar" /> class supports only dates from 04/30/1900 00.00.00 (Gregorian date) through 05/13/2029 23:59:59 (Gregorian date).</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="time" /> is outside the range supported by this calendar. </exception>
        public override int GetDayOfYear(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the number of days in the specified month of the specified year and era.</summary><returns>The number of days in the specified month in the specified year and era. The return value is 29 in a common year and 30 in a leap year.</returns><param name="year">A year. </param><param name="month">An integer from 1 through 12 that represents a month. </param><param name="era">An era. Specify UmAlQuraCalendar.Eras[UmAlQuraCalendar.CurrentEra] or <see cref="F:System.Globalization.UmAlQuraCalendar.UmAlQuraEra" />.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" />, <paramref name="month" />, or <paramref name="era" /> is outside the range supported by the <see cref="T:System.Globalization.UmAlQuraCalendar" /> class. </exception>
        public override int GetDaysInMonth(int year, int month, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the number of days in the specified year of the specified era.</summary><returns>The number of days in the specified year and era. The number of days is 354 in a common year or 355 in a leap year.</returns><param name="year">A year. </param><param name="era">An era. Specify UmAlQuraCalendar.Eras[UmAlQuraCalendar.CurrentEra] or <see cref="F:System.Globalization.UmAlQuraCalendar.UmAlQuraEra" />.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> or <paramref name="era" /> is outside the range supported by the <see cref="T:System.Globalization.UmAlQuraCalendar" /> class. </exception>
        public override int GetDaysInYear(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the era in which a specified date occurs.</summary><returns>Always returns the <see cref="F:System.Globalization.UmAlQuraCalendar.UmAlQuraEra" /> value.</returns><param name="time">The date value to read. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="time" /> is outside the range supported by this calendar. </exception>
        public override int GetEra(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the month in which a specified date occurs.</summary><returns>An integer from 1 through 12 that represents the month in the date specified by the <paramref name="time" /> parameter.</returns><param name="time">The date value to read. The <see cref="T:System.Globalization.UmAlQuraCalendar" /> class supports only dates from 04/30/1900 00.00.00 (Gregorian date) through 05/13/2029 23:59:59 (Gregorian date).</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="time" /> is outside the range supported by this calendar. </exception>
        public override int GetMonth(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the number of months in the specified year of the specified era.</summary><returns>Always 12.</returns><param name="year">A year. </param><param name="era">An era. Specify UmAlQuaraCalendar.Eras[UmAlQuraCalendar.CurrentEra] or <see cref="F:System.Globalization.UmAlQuraCalendar.UmAlQuraEra" />.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> is outside the range supported by this calendar. </exception><exception cref="T:System.ArgumentException"><paramref name="era" /> is outside the range supported by this calendar. </exception>
        public override int GetMonthsInYear(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the year of a date represented by a specified <see cref="T:System.DateTime" />.</summary><returns>An integer that represents the year specified by the <paramref name="time" /> parameter.</returns><param name="time">The date value to read. The <see cref="T:System.Globalization.UmAlQuraCalendar" /> class supports only dates from 04/30/1900 00.00.00 (Gregorian date) through 05/13/2029 23:59:59 (Gregorian date).</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="time" /> is outside the range supported by this calendar. </exception>
        public override int GetYear(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified date is a leap day.</summary><returns>true if the specified day is a leap day; otherwise, false. The return value is always false because the <see cref="T:System.Globalization.UmAlQuraCalendar" /> class does not support leap days.</returns><param name="year">A year. </param><param name="month">An integer from 1 through 12 that represents a month. </param><param name="day">An integer from 1 through 30 that represents a day. </param><param name="era">An era. Specify UmAlQuraCalendar.Eras[UmAlQuraCalendar.CurrentEra] or <see cref="F:System.Globalization.UmAlQuraCalendar.UmAlQuraEra" />.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" />, <paramref name="month" />, <paramref name="day" />, or <paramref name="era" /> is outside the range supported by the <see cref="T:System.Globalization.UmAlQuraCalendar" /> class. </exception>
        public override bool IsLeapDay(int year, int month, int day, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the leap month for a specified year and era.</summary><returns>Always 0 because the <see cref="T:System.Globalization.UmAlQuraCalendar" /> class does not support leap months.</returns><param name="year">A year.</param><param name="era">An era. Specify UmAlQuraCalendar.Eras[UmAlQuraCalendar.CurrentEra] or <see cref="F:System.Globalization.UmAlQuraCalendar.UmAlQuraEra" />.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> is less than 1318 or greater than 1450.-or-<paramref name="era" /> is not UmAlQuraCalendar.Eras[UmAlQuraCalendar.CurrentEra] or <see cref="F:System.Globalization.UmAlQuraCalendar.UmAlQuraEra" />.</exception>
        public override int GetLeapMonth(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified month in the specified year and era is a leap month.</summary><returns>Always false because the <see cref="T:System.Globalization.UmAlQuraCalendar" /> class does not support leap months.</returns><param name="year">A year. </param><param name="month">An integer from 1 through 12 that represents a month. </param><param name="era">An era. Specify UmAlQuraCalendar.Eras[UmAlQuraCalendar.CurrentEra] or <see cref="F:System.Globalization.UmAlQuraCalendar.UmAlQuraEra" />.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" />, <paramref name="month" />, or <paramref name="era" /> is outside the range supported by the <see cref="T:System.Globalization.UmAlQuraCalendar" /> class. </exception>
        public override bool IsLeapMonth(int year, int month, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified year in the specified era is a leap year.</summary><returns>true if the specified year is a leap year; otherwise, false.</returns><param name="year">A year. </param><param name="era">An era. Specify UmAlQuraCalendar.Eras[UmAlQuraCalendar.CurrentEra] or <see cref="F:System.Globalization.UmAlQuraCalendar.UmAlQuraEra" />.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> or <paramref name="era" /> is outside the range supported by the <see cref="T:System.Globalization.UmAlQuraCalendar" /> class. </exception>
        public override bool IsLeapYear(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.DateTime" /> that is set to the specified date, time, and era.</summary><returns>The <see cref="T:System.DateTime" /> that is set to the specified date and time in the current era.</returns><param name="year">A year. </param><param name="month">An integer from 1 through 12 that represents a month. </param><param name="day">An integer from 1 through 29 that represents a day. </param><param name="hour">An integer from 0 through 23 that represents an hour. </param><param name="minute">An integer from 0 through 59 that represents a minute. </param><param name="second">An integer from 0 through 59 that represents a second. </param><param name="millisecond">An integer from 0 through 999 that represents a millisecond. </param><param name="era">An era. Specify UmAlQuraCalendar.Eras[UmAlQuraCalendar.CurrentEra] or <see cref="F:System.Globalization.UmAlQuraCalendar.UmAlQuraEra" />.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" />, <paramref name="month" />, <paramref name="day" />, or <paramref name="era" /> is outside the range supported by the <see cref="T:System.Globalization.UmAlQuraCalendar" /> class.-or- <paramref name="hour" /> is less than zero or greater than 23.-or- <paramref name="minute" /> is less than zero or greater than 59.-or- <paramref name="second" /> is less than zero or greater than 59.-or- <paramref name="millisecond" /> is less than zero or greater than 999. </exception>
        public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified year to a four-digit year by using the <see cref="P:System.Globalization.UmAlQuraCalendar.TwoDigitYearMax" /> property to determine the appropriate century.</summary><returns>If the <paramref name="year" /> parameter is a 2-digit year, the return value is the corresponding 4-digit year. If the <paramref name="year" /> parameter is a 4-digit year, the return value is the unchanged <paramref name="year" /> parameter.</returns><param name="year">A 2-digit year from 0 through 99, or a 4-digit Um Al Qura calendar year from 1318 through 1450.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> is outside the range supported by this calendar. </exception>
        public override int ToFourDigitYear(int year)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
