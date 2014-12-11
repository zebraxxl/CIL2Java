using System.Runtime.InteropServices;
using System;
using System.Security;

namespace System.Globalization
{
    /// <summary>Represents the Hijri calendar.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class HijriCalendar : Calendar
    {
        /// <summary>Represents the current era. This field is constant.</summary>
        public static readonly int HijriEra;
    
        /// <summary>Gets the earliest date and time supported by this calendar.</summary><returns>The earliest date and time supported by the <see cref="T:System.Globalization.HijriCalendar" /> type, which is equivalent to the first moment of July 18, 622 C.E. in the Gregorian calendar.</returns>
        [ComVisibleAttribute(false)]
        public override DateTime MinSupportedDateTime
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the latest date and time supported by this calendar.</summary><returns>The latest date and time supported by the <see cref="T:System.Globalization.HijriCalendar" /> type, which is equivalent to the last moment of December 31, 9999 C.E. in the Gregorian calendar.</returns>
        [ComVisibleAttribute(false)]
        public override DateTime MaxSupportedDateTime
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the current calendar is solar-based, lunar-based, or a combination of both.</summary><returns>Always returns <see cref="F:System.Globalization.CalendarAlgorithmType.LunarCalendar" />.</returns>
        [ComVisibleAttribute(false)]
        public override CalendarAlgorithmType AlgorithmType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of days in the year that precedes the year that is specified by the <see cref="P:System.Globalization.HijriCalendar.MinSupportedDateTime" /> property.</summary><returns>The number of days in the year that precedes the year specified by <see cref="P:System.Globalization.HijriCalendar.MinSupportedDateTime" />.</returns>
        protected override int DaysInYearBeforeMinSupportedYear
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the number of days to add or subtract from the calendar to accommodate the variances in the start and the end of Ramadan and to accommodate the date difference between countries/regions.</summary><returns>An integer from -2 to 2 that represents the number of days to add or subtract from the calendar.</returns><exception cref="T:System.ArgumentOutOfRangeException">The property is being set to an invalid value. </exception><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public int HijriAdjustment
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the list of eras in the <see cref="T:System.Globalization.HijriCalendar" />.</summary><returns>An array of integers that represents the eras in the <see cref="T:System.Globalization.HijriCalendar" />.</returns>
        public override int[] Eras
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the last year of a 100-year range that can be represented by a 2-digit year.</summary><returns>The last year of a 100-year range that can be represented by a 2-digit year.</returns><exception cref="T:System.InvalidOperationException">This calendar is read-only.</exception><exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than 100 or greater than 9666.</exception><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public override int TwoDigitYearMax
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public HijriCalendar()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.DateTime" /> that is the specified number of months away from the specified <see cref="T:System.DateTime" />.</summary><returns>The <see cref="T:System.DateTime" /> that results from adding the specified number of months to the specified <see cref="T:System.DateTime" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to add months to. </param><param name="months">The number of months to add. </param><exception cref="T:System.ArgumentException">The resulting <see cref="T:System.DateTime" />.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="months" /> is less than -120000.-or- <paramref name="months" /> is greater than 120000. </exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="\" /></PermissionSet>
        public override DateTime AddMonths(DateTime time, int months)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.DateTime" /> that is the specified number of years away from the specified <see cref="T:System.DateTime" />.</summary><returns>The <see cref="T:System.DateTime" /> that results from adding the specified number of years to the specified <see cref="T:System.DateTime" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to add years to. </param><param name="years">The number of years to add. </param><exception cref="T:System.ArgumentException">The resulting <see cref="T:System.DateTime" /> is outside the supported range. </exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="\" /></PermissionSet>
        public override DateTime AddYears(DateTime time, int years)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the day of the month in the specified <see cref="T:System.DateTime" />.</summary><returns>An integer from 1 to 30 that represents the day of the month in the specified <see cref="T:System.DateTime" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="\" /></PermissionSet>
        public override int GetDayOfMonth(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the day of the week in the specified <see cref="T:System.DateTime" />.</summary><returns>A <see cref="T:System.DayOfWeek" /> value that represents the day of the week in the specified <see cref="T:System.DateTime" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param>
        public override DayOfWeek GetDayOfWeek(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the day of the year in the specified <see cref="T:System.DateTime" />.</summary><returns>An integer from 1 to 355 that represents the day of the year in the specified <see cref="T:System.DateTime" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="\" /></PermissionSet>
        public override int GetDayOfYear(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the number of days in the specified month of the specified year and era.</summary><returns>The number of days in the specified month in the specified year in the specified era.</returns><param name="year">An integer that represents the year. </param><param name="month">An integer from 1 to 12 that represents the month. </param><param name="era">An integer that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="era" /> is outside the range supported by this calendar. -or- <paramref name="year" /> is outside the range supported by this calendar.-or- <paramref name="month" /> is outside the range supported by this calendar. </exception>
        public override int GetDaysInMonth(int year, int month, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the number of days in the specified year and era.</summary><returns>The number of days in the specified year and era. The number of days is 354 in a common year or 355 in a leap year.</returns><param name="year">An integer that represents the year. </param><param name="era">An integer that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> or <paramref name="era" /> is outside the range supported by this calendar. </exception>
        public override int GetDaysInYear(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the era in the specified <see cref="T:System.DateTime" />.</summary><returns>An integer that represents the era in the specified <see cref="T:System.DateTime" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param>
        public override int GetEra(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the month in the specified <see cref="T:System.DateTime" />.</summary><returns>An integer from 1 to 12 that represents the month in the specified <see cref="T:System.DateTime" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="\" /></PermissionSet>
        public override int GetMonth(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the number of months in the specified year and era.</summary><returns>The number of months in the specified year and era.</returns><param name="year">An integer that represents the year. </param><param name="era">An integer that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="era" /> is outside the range supported by this calendar. -or- <paramref name="year" /> is outside the range supported by this calendar. </exception>
        public override int GetMonthsInYear(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the year in the specified <see cref="T:System.DateTime" />.</summary><returns>An integer that represents the year in the specified <see cref="T:System.DateTime" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="\" /></PermissionSet>
        public override int GetYear(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified date is a leap day.</summary><returns>true if the specified day is a leap day; otherwise, false.</returns><param name="year">An integer that represents the year. </param><param name="month">An integer from 1 to 12 that represents the month. </param><param name="day">An integer from 1 to 30 that represents the day. </param><param name="era">An integer that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="era" /> is outside the range supported by this calendar. -or- <paramref name="year" /> is outside the range supported by this calendar.-or- <paramref name="month" /> is outside the range supported by this calendar.-or- <paramref name="day" /> is outside the range supported by this calendar. </exception>
        public override bool IsLeapDay(int year, int month, int day, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the leap month for a specified year and era.</summary><returns>Always 0 because the <see cref="T:System.Globalization.HijriCalendar" /> type does not support the notion of a leap month.</returns><param name="year">A year.</param><param name="era">An era. Specify <see cref="F:System.Globalization.Calendar.CurrentEra" /> or <see cref="F:System.Globalization.HijriCalendar.HijriEra" />.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> is less than the Hijri calendar year 1 or greater than the year 9666.-or-<paramref name="era" /> is not <see cref="F:System.Globalization.Calendar.CurrentEra" /> or <see cref="F:System.Globalization.HijriCalendar.HijriEra" />.</exception>
        [ComVisibleAttribute(false)]
        public override int GetLeapMonth(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified month in the specified year and era is a leap month.</summary><returns>This method always returns false.</returns><param name="year">An integer that represents the year. </param><param name="month">An integer from 1 to 12 that represents the month. </param><param name="era">An integer that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="era" /> is outside the range supported by this calendar. -or- <paramref name="year" /> is outside the range supported by this calendar.-or- <paramref name="month" /> is outside the range supported by this calendar. </exception>
        public override bool IsLeapMonth(int year, int month, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified year in the specified era is a leap year.</summary><returns>true if the specified year is a leap year; otherwise, false.</returns><param name="year">An integer that represents the year. </param><param name="era">An integer that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="era" /> is outside the range supported by this calendar. -or- <paramref name="year" /> is outside the range supported by this calendar. </exception>
        public override bool IsLeapYear(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.DateTime" /> that is set to the specified date, time, and era.</summary><returns>The <see cref="T:System.DateTime" /> that is set to the specified date and time in the current era.</returns><param name="year">An integer that represents the year. </param><param name="month">An integer from 1 to 12 that represents the month. </param><param name="day">An integer from 1 to 30 that represents the day. </param><param name="hour">An integer from 0 to 23 that represents the hour. </param><param name="minute">An integer from 0 to 59 that represents the minute. </param><param name="second">An integer from 0 to 59 that represents the second. </param><param name="millisecond">An integer from 0 to 999 that represents the millisecond. </param><param name="era">An integer that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="era" /> is outside the range supported by this calendar. -or- <paramref name="year" /> is outside the range supported by this calendar.-or- <paramref name="month" /> is outside the range supported by this calendar.-or- <paramref name="day" /> is outside the range supported by this calendar.-or- <paramref name="hour" /> is less than zero or greater than 23.-or- <paramref name="minute" /> is less than zero or greater than 59.-or- <paramref name="second" /> is less than zero or greater than 59.-or- <paramref name="millisecond" /> is less than zero or greater than 999. </exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="\" /></PermissionSet>
        public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified year to a four-digit year by using the <see cref="P:System.Globalization.HijriCalendar.TwoDigitYearMax" /> property to determine the appropriate century.</summary><returns>An integer that contains the four-digit representation of <paramref name="year" />.</returns><param name="year">A two-digit or four-digit integer that represents the year to convert. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> is outside the range supported by this calendar. </exception>
        public override int ToFourDigitYear(int year)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
