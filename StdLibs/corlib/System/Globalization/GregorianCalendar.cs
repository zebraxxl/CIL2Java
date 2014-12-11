using System.Runtime.InteropServices;
using System;

namespace System.Globalization
{
    /// <summary>Represents the Gregorian calendar.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class GregorianCalendar : Calendar
    {
        /// <summary>Represents the current era. This field is constant.</summary>
        public const int ADEra = 1;
    
        /// <summary>Gets the earliest date and time supported by the <see cref="T:System.Globalization.GregorianCalendar" /> type.</summary><returns>The earliest date and time supported by the <see cref="T:System.Globalization.GregorianCalendar" /> type, which is the first moment of January 1, 0001 C.E. and is equivalent to <see cref="F:System.DateTime.MinValue" />.</returns>
        [ComVisibleAttribute(false)]
        public override DateTime MinSupportedDateTime
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the latest date and time supported by the <see cref="T:System.Globalization.GregorianCalendar" /> type.</summary><returns>The latest date and time supported by the <see cref="T:System.Globalization.GregorianCalendar" /> type, which is the last moment of December 31, 9999 C.E. and is equivalent to <see cref="F:System.DateTime.MaxValue" />.</returns>
        [ComVisibleAttribute(false)]
        public override DateTime MaxSupportedDateTime
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the current calendar is solar-based, lunar-based, or a combination of both.</summary><returns>Always returns <see cref="F:System.Globalization.CalendarAlgorithmType.SolarCalendar" />.</returns>
        [ComVisibleAttribute(false)]
        public override CalendarAlgorithmType AlgorithmType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the <see cref="T:System.Globalization.GregorianCalendarTypes" /> value that denotes the language version of the current <see cref="T:System.Globalization.GregorianCalendar" />.</summary><returns>A <see cref="T:System.Globalization.GregorianCalendarTypes" /> value that denotes the language version of the current <see cref="T:System.Globalization.GregorianCalendar" />.</returns><exception cref="T:System.ArgumentOutOfRangeException">The value specified in a set operation is not a member of the <see cref="T:System.Globalization.GregorianCalendarTypes" /> enumeration.</exception><exception cref="T:System.InvalidOperationException">In a set operation, the current instance is read-only.</exception>
        public virtual GregorianCalendarTypes CalendarType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the list of eras in the <see cref="T:System.Globalization.GregorianCalendar" />.</summary><returns>An array of integers that represents the eras in the <see cref="T:System.Globalization.GregorianCalendar" />.</returns>
        public override int[] Eras
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the last year of a 100-year range that can be represented by a 2-digit year.</summary><returns>The last year of a 100-year range that can be represented by a 2-digit year.</returns><exception cref="T:System.ArgumentOutOfRangeException">The value specified in a set operation is less than 99. -or- The value specified in a set operation is greater than MaxSupportedDateTime.Year.</exception><exception cref="T:System.InvalidOperationException">In a set operation, the current instance is read-only.</exception><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public override int TwoDigitYearMax
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public GregorianCalendar()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Globalization.GregorianCalendar" /> class using the specified <see cref="T:System.Globalization.GregorianCalendarTypes" /> value.</summary><param name="type">The <see cref="T:System.Globalization.GregorianCalendarTypes" /> value that denotes which language version of the calendar to create. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="type" /> is not a member of the <see cref="T:System.Globalization.GregorianCalendarTypes" /> enumeration.</exception>
        public GregorianCalendar(GregorianCalendarTypes type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.DateTime" /> that is the specified number of months away from the specified <see cref="T:System.DateTime" />.</summary><returns>The <see cref="T:System.DateTime" /> that results from adding the specified number of months to the specified <see cref="T:System.DateTime" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to which to add months. </param><param name="months">The number of months to add. </param><exception cref="T:System.ArgumentException">The resulting <see cref="T:System.DateTime" /> is outside the supported range. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="months" /> is less than -120000.-or- <paramref name="months" /> is greater than 120000. </exception>
        public override DateTime AddMonths(DateTime time, int months)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.DateTime" /> that is the specified number of years away from the specified <see cref="T:System.DateTime" />.</summary><returns>The <see cref="T:System.DateTime" /> that results from adding the specified number of years to the specified <see cref="T:System.DateTime" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to which to add years. </param><param name="years">The number of years to add. </param><exception cref="T:System.ArgumentException">The resulting <see cref="T:System.DateTime" /> is outside the supported range. </exception>
        public override DateTime AddYears(DateTime time, int years)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the day of the month in the specified <see cref="T:System.DateTime" />.</summary><returns>An integer from 1 to 31 that represents the day of the month in <paramref name="time" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param>
        public override int GetDayOfMonth(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the day of the week in the specified <see cref="T:System.DateTime" />.</summary><returns>A <see cref="T:System.DayOfWeek" /> value that represents the day of the week in <paramref name="time" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param>
        public override DayOfWeek GetDayOfWeek(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the day of the year in the specified <see cref="T:System.DateTime" />.</summary><returns>An integer from 1 to 366 that represents the day of the year in <paramref name="time" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param>
        public override int GetDayOfYear(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the number of days in the specified month in the specified year in the specified era.</summary><returns>The number of days in the specified month in the specified year in the specified era.</returns><param name="year">An integer that represents the year. </param><param name="month">An integer from 1 to 12 that represents the month. </param><param name="era">An integer that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="era" /> is outside the range supported by the calendar.-or- <paramref name="year" /> is outside the range supported by the calendar.-or- <paramref name="month" /> is outside the range supported by the calendar. </exception>
        public override int GetDaysInMonth(int year, int month, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the number of days in the specified year in the specified era.</summary><returns>The number of days in the specified year in the specified era.</returns><param name="year">An integer that represents the year. </param><param name="era">An integer that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="era" /> is outside the range supported by the calendar.-or- <paramref name="year" /> is outside the range supported by the calendar.</exception>
        public override int GetDaysInYear(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the era in the specified <see cref="T:System.DateTime" />.</summary><returns>An integer that represents the era in <paramref name="time" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param>
        public override int GetEra(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the month in the specified <see cref="T:System.DateTime" />.</summary><returns>An integer from 1 to 12 that represents the month in <paramref name="time" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param>
        public override int GetMonth(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the number of months in the specified year in the specified era.</summary><returns>The number of months in the specified year in the specified era.</returns><param name="year">An integer that represents the year. </param><param name="era">An integer that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="era" /> is outside the range supported by the calendar.-or- <paramref name="year" /> is outside the range supported by the calendar. </exception>
        public override int GetMonthsInYear(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the year in the specified <see cref="T:System.DateTime" />.</summary><returns>An integer that represents the year in <paramref name="time" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param>
        public override int GetYear(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified date in the specified era is a leap day.</summary><returns>true if the specified day is a leap day; otherwise, false.</returns><param name="year">An integer that represents the year. </param><param name="month">An integer from 1 to 12 that represents the month. </param><param name="day">An integer from 1 to 31 that represents the day. </param><param name="era">An integer that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="era" /> is outside the range supported by the calendar. -or- <paramref name="year" /> is outside the range supported by the calendar.-or- <paramref name="month" /> is outside the range supported by the calendar.-or- <paramref name="day" /> is outside the range supported by the calendar. </exception>
        public override bool IsLeapDay(int year, int month, int day, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the leap month for a specified year and era.</summary><returns>Always 0 because the Gregorian calendar does not recognize leap months.</returns><param name="year">A year.</param><param name="era">An era. Specify either <see cref="F:System.Globalization.GregorianCalendar.ADEra" /> or GregorianCalendar.Eras[Calendar.CurrentEra].</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> is less than the Gregorian calendar year 1 or greater than the Gregorian calendar year 9999.-or-<paramref name="era" /> is not <see cref="F:System.Globalization.GregorianCalendar.ADEra" /> or GregorianCalendar.Eras[Calendar.CurrentEra].</exception>
        [ComVisibleAttribute(false)]
        public override int GetLeapMonth(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified month in the specified year in the specified era is a leap month.</summary><returns>This method always returns false, unless overridden by a derived class.</returns><param name="year">An integer that represents the year. </param><param name="month">An integer from 1 to 12 that represents the month. </param><param name="era">An integer that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="era" /> is outside the range supported by the calendar.-or- <paramref name="year" /> is outside the range supported by the calendar.-or- <paramref name="month" /> is outside the range supported by the calendar. </exception>
        public override bool IsLeapMonth(int year, int month, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified year in the specified era is a leap year.</summary><returns>true if the specified year is a leap year; otherwise, false.</returns><param name="year">An integer that represents the year. </param><param name="era">An integer that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="era" /> is outside the range supported by the calendar.-or- <paramref name="year" /> is outside the range supported by the calendar. </exception>
        public override bool IsLeapYear(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.DateTime" /> that is set to the specified date and time in the specified era.</summary><returns>The <see cref="T:System.DateTime" /> that is set to the specified date and time in the current era.</returns><param name="year">An integer that represents the year. </param><param name="month">An integer from 1 to 12 that represents the month. </param><param name="day">An integer from 1 to 31 that represents the day. </param><param name="hour">An integer from 0 to 23 that represents the hour. </param><param name="minute">An integer from 0 to 59 that represents the minute. </param><param name="second">An integer from 0 to 59 that represents the second. </param><param name="millisecond">An integer from 0 to 999 that represents the millisecond. </param><param name="era">An integer that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="era" /> is outside the range supported by the calendar.-or- <paramref name="year" /> is outside the range supported by the calendar.-or- <paramref name="month" /> is outside the range supported by the calendar.-or- <paramref name="day" /> is outside the range supported by the calendar.-or- <paramref name="hour" /> is less than zero or greater than 23.-or- <paramref name="minute" /> is less than zero or greater than 59.-or- <paramref name="second" /> is less than zero or greater than 59.-or- <paramref name="millisecond" /> is less than zero or greater than 999. </exception>
        public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified year to a four-digit year by using the <see cref="P:System.Globalization.GregorianCalendar.TwoDigitYearMax" /> property to determine the appropriate century.</summary><returns>An integer that contains the four-digit representation of <paramref name="year" />.</returns><param name="year">A two-digit or four-digit integer that represents the year to convert. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> is outside the range supported by the calendar. </exception>
        public override int ToFourDigitYear(int year)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
