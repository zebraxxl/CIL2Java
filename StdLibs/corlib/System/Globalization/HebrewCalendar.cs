using System.Runtime.InteropServices;
using System;

namespace System.Globalization
{
    /// <summary>Represents the Hebrew calendar.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class HebrewCalendar : Calendar
    {
        /// <summary>Represents the current era. This field is constant.</summary>
        public static readonly int HebrewEra;
    
        /// <summary>Gets the earliest date and time supported by the <see cref="T:System.Globalization.HebrewCalendar" /> type.</summary><returns>The earliest date and time supported by the <see cref="T:System.Globalization.HebrewCalendar" /> type, which is equivalent to the first moment of January, 1, 1583 C.E. in the Gregorian calendar.</returns>
        public override DateTime MinSupportedDateTime
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the latest date and time supported by the <see cref="T:System.Globalization.HebrewCalendar" /> type.</summary><returns>The latest date and time supported by the <see cref="T:System.Globalization.HebrewCalendar" /> type, which is equivalent to the last moment of September, 29, 2239 C.E. in the Gregorian calendar.</returns>
        public override DateTime MaxSupportedDateTime
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the current calendar is solar-based, lunar-based, or a combination of both.</summary><returns>Always returns <see cref="F:System.Globalization.CalendarAlgorithmType.LunisolarCalendar" />.</returns>
        public override CalendarAlgorithmType AlgorithmType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the list of eras in the <see cref="T:System.Globalization.HebrewCalendar" />.</summary><returns>An array of integers that represents the eras in the <see cref="T:System.Globalization.HebrewCalendar" /> type. The return value is always an array containing one element equal to <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" />. </returns>
        public override int[] Eras
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the last year of a 100-year range that can be represented by a 2-digit year.</summary><returns>The last year of a 100-year range that can be represented by a 2-digit year.</returns><exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Globalization.HebrewCalendar" /> object is read-only.</exception><exception cref="T:System.ArgumentOutOfRangeException">In a set operation, the Hebrew calendar year value is less than 5343 but is not 99, or the year value is greater than 5999. </exception><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public override int TwoDigitYearMax
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public HebrewCalendar()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.DateTime" /> that is the specified number of months away from the specified <see cref="T:System.DateTime" />.</summary><returns>The <see cref="T:System.DateTime" /> that results from adding the specified number of months to the specified <see cref="T:System.DateTime" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to which to add <paramref name="months" />. </param><param name="months">The number of months to add. </param><exception cref="T:System.ArgumentException">The resulting <see cref="T:System.DateTime" /> is outside the supported range. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="months" /> is less than -120,000 or greater than 120,000. </exception>
        public override DateTime AddMonths(DateTime time, int months)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.DateTime" /> that is the specified number of years away from the specified <see cref="T:System.DateTime" />.</summary><returns>The <see cref="T:System.DateTime" /> that results from adding the specified number of years to the specified <see cref="T:System.DateTime" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to which to add <paramref name="years" />. </param><param name="years">The number of years to add. </param><exception cref="T:System.ArgumentException">The resulting <see cref="T:System.DateTime" /> is outside the supported range. </exception>
        public override DateTime AddYears(DateTime time, int years)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the day of the month in the specified <see cref="T:System.DateTime" />.</summary><returns>An integer from 1 to 30 that represents the day of the month in the specified <see cref="T:System.DateTime" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param>
        public override int GetDayOfMonth(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the day of the week in the specified <see cref="T:System.DateTime" />.</summary><returns>A <see cref="T:System.DayOfWeek" /> value that represents the day of the week in the specified <see cref="T:System.DateTime" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param>
        public override DayOfWeek GetDayOfWeek(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the day of the year in the specified <see cref="T:System.DateTime" />.</summary><returns>An integer from 1 to 385 that represents the day of the year in the specified <see cref="T:System.DateTime" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="time" /> is earlier than September 17, 1583 in the Gregorian calendar, or greater than <see cref="P:System.Globalization.HebrewCalendar.MaxSupportedDateTime" />. </exception>
        public override int GetDayOfYear(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the number of days in the specified month in the specified year in the specified era.</summary><returns>The number of days in the specified month in the specified year in the specified era.</returns><param name="year">An integer that represents the year. </param><param name="month">An integer from 1 to 13 that represents the month. </param><param name="era">An integer that represents the era. Specify either <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" /> or Calendar.Eras[Calendar.CurrentEra].</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" />, <paramref name="month" />, or <paramref name="era" /> is outside the range supported by the current <see cref="T:System.Globalization.HebrewCalendar" /> object. </exception>
        public override int GetDaysInMonth(int year, int month, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the number of days in the specified year in the specified era.</summary><returns>The number of days in the specified year in the specified era.</returns><param name="year">An integer that represents the year. </param><param name="era">An integer that represents the era. Specify either <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" /> or HebrewCalendar.Eras[Calendar.CurrentEra].</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> or <paramref name="era" /> is outside the range supported by the current <see cref="T:System.Globalization.HebrewCalendar" /> object. </exception>
        public override int GetDaysInYear(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the era in the specified <see cref="T:System.DateTime" />.</summary><returns>An integer that represents the era in the specified <see cref="T:System.DateTime" />. The return value is always <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param>
        public override int GetEra(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the month in the specified <see cref="T:System.DateTime" />.</summary><returns>An integer from 1 to 13 that represents the month in the specified <see cref="T:System.DateTime" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="time" /> is less than <see cref="P:System.Globalization.HebrewCalendar.MinSupportedDateTime" /> or greater than <see cref="P:System.Globalization.HebrewCalendar.MaxSupportedDateTime" />.</exception>
        public override int GetMonth(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the number of months in the specified year in the specified era.</summary><returns>The number of months in the specified year in the specified era. The return value is either 12 in a common year, or 13 in a leap year.</returns><param name="year">An integer that represents the year. </param><param name="era">An integer that represents the era. Specify either <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" /> or HebrewCalendar.Eras[Calendar.CurrentEra].</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> or <paramref name="era" /> is outside the range supported by the current <see cref="T:System.Globalization.HebrewCalendar" /> object. </exception>
        public override int GetMonthsInYear(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the year in the specified <see cref="T:System.DateTime" /> value.</summary><returns>An integer that represents the year in the specified <see cref="T:System.DateTime" /> value.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="time" /> is outside the range supported by the current <see cref="T:System.Globalization.HebrewCalendar" /> object. </exception>
        public override int GetYear(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified date in the specified era is a leap day.</summary><returns>true if the specified day is a leap day; otherwise, false.</returns><param name="year">An integer that represents the year. </param><param name="month">An integer from 1 to 13 that represents the month. </param><param name="day">An integer from 1 to 30 that represents the day. </param><param name="era">An integer that represents the era. Specify either <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" /> or HebrewCalendar.Eras[Calendar.CurrentEra]..</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" />, <paramref name="month" />, <paramref name="day" />, or <paramref name="era" /> is outside the range supported by this calendar. </exception>
        public override bool IsLeapDay(int year, int month, int day, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the leap month for a specified year and era.</summary><returns>A positive integer that indicates the leap month in the specified year and era. The return value is 7 if the <paramref name="year" /> and <paramref name="era" /> parameters specify a leap year, or 0 if the year is not a leap year.</returns><param name="year">A year.</param><param name="era">An era. Specify either <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" /> or HebrewCalendar.Eras[Calendar.CurrentEra].</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="era" /> is not <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" /> or HebrewCalendar.Eras[Calendar.CurrentEra].-or-<paramref name="year" /> is less than the Hebrew calendar year 5343 or greater than the Hebrew calendar year 5999.</exception>
        public override int GetLeapMonth(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified month in the specified year in the specified era is a leap month.</summary><returns>true if the specified month is a leap month; otherwise, false.</returns><param name="year">An integer that represents the year. </param><param name="month">An integer from 1 to 13 that represents the month. </param><param name="era">An integer that represents the era. Specify either <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" /> or HebrewCalendar.Eras[Calendar.CurrentEra].</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" />, <paramref name="month" />, or <paramref name="era" /> is outside the range supported by this calendar. </exception>
        public override bool IsLeapMonth(int year, int month, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified year in the specified era is a leap year.</summary><returns>true if the specified year is a leap year; otherwise, false.</returns><param name="year">An integer that represents the year. </param><param name="era">An integer that represents the era. Specify either <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" /> or HebrewCalendar.Eras[Calendar.CurrentEra].</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> or <paramref name="era" /> is outside the range supported by this calendar. </exception>
        public override bool IsLeapYear(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.DateTime" /> that is set to the specified date and time in the specified era.</summary><returns>The <see cref="T:System.DateTime" /> that is set to the specified date and time in the current era.</returns><param name="year">An integer that represents the year. </param><param name="month">An integer from 1 to 13 that represents the month. </param><param name="day">An integer from 1 to 30 that represents the day. </param><param name="hour">An integer from 0 to 23 that represents the hour. </param><param name="minute">An integer from 0 to 59 that represents the minute. </param><param name="second">An integer from 0 to 59 that represents the second. </param><param name="millisecond">An integer from 0 to 999 that represents the millisecond. </param><param name="era">An integer that represents the era. Specify either <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" /> or HebrewCalendar.Eras[Calendar.CurrentEra].</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" />, <paramref name="month" />, <paramref name="day" /> or <paramref name="era" /> is outside the range supported by the current <see cref="T:System.Globalization.HebrewCalendar" /> object.-or- <paramref name="hour" /> is less than 0 or greater than 23.-or- <paramref name="minute" /> is less than 0 or greater than 59.-or- <paramref name="second" /> is less than 0 or greater than 59.-or- <paramref name="millisecond" /> is less than 0 or greater than 999. </exception>
        public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified year to a 4-digit year by using the <see cref="P:System.Globalization.HebrewCalendar.TwoDigitYearMax" /> property to determine the appropriate century.</summary><returns>If the <paramref name="year" /> parameter is a 2-digit year, the return value is the corresponding 4-digit year. If the <paramref name="year" /> parameter is a 4-digit year, the return value is the unchanged <paramref name="year" /> parameter.</returns><param name="year">A 2-digit year from 0 through 99, or a 4-digit Hebrew calendar year from 5343 through 5999.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> is less than 0.-or-<paramref name="year" /> is less than <see cref="P:System.Globalization.HebrewCalendar.MinSupportedDateTime" /> or greater than <see cref="P:System.Globalization.HebrewCalendar.MaxSupportedDateTime" />. </exception>
        public override int ToFourDigitYear(int year)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
