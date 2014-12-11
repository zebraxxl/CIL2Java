using System.Runtime.InteropServices;
using System;

namespace System.Globalization
{
    /// <summary>Represents a calendar that divides time into months, days, years, and eras, and has dates that are based on cycles of the sun and the moon.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public abstract class EastAsianLunisolarCalendar : Calendar
    {
    
        /// <summary>Gets a value indicating whether the current calendar is solar-based, lunar-based, or a combination of both.</summary><returns>Always returns <see cref="F:System.Globalization.CalendarAlgorithmType.LunisolarCalendar" />.</returns>
        public override CalendarAlgorithmType AlgorithmType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the last year of a 100-year range that can be represented by a 2-digit year.</summary><returns>The last year of a 100-year range that can be represented by a 2-digit year.</returns><exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Globalization.EastAsianLunisolarCalendar" />  is read-only.</exception><exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than 99 or greater than the maximum supported year in the current calendar.</exception>
        public override int TwoDigitYearMax
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Calculates the year in the sexagenary (60-year) cycle that corresponds to the specified date.</summary><returns>A number from 1 through 60 in the sexagenary cycle that corresponds to the <paramref name="date" /> parameter.</returns><param name="time">A <see cref="T:System.DateTime" /> to read.</param>
        public virtual int GetSexagenaryYear(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the celestial stem of the specified year in the sexagenary (60-year) cycle.</summary><returns>A number from 1 through 10.</returns><param name="sexagenaryYear">An integer from 1 through 60 that represents a year in the sexagenary cycle. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="sexagenaryYear" /> is less than 1 or greater than 60.</exception>
        public int GetCelestialStem(int sexagenaryYear)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the terrestrial branch of the specified year in the sexagenary (60-year) cycle.</summary><returns>An integer from 1 through 12.</returns><param name="sexagenaryYear">An integer from 1 through 60 that represents a year in the sexagenary cycle.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="sexagenaryYear" /> is less than 1 or greater than 60.</exception>
        public int GetTerrestrialBranch(int sexagenaryYear)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the number of days in the specified month of the specified year and era.</summary><returns>The number of days in the specified month of the specified year and era.</returns><param name="year">An integer that represents the year. </param><param name="month">An integer from 1 through 12 in a common year, or 1 through 13 in a leap year, that represents the month. </param><param name="era">An integer that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" />, <paramref name="month" />, or <paramref name="era" /> is outside the range supported by this calendar. </exception>
        public override int GetDaysInMonth(int year, int month, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.DateTime" /> that is set to the specified date, time, and era.</summary><returns>A <see cref="T:System.DateTime" /> that is set to the specified date, time, and era.</returns><param name="year">An integer that represents the year. </param><param name="month">An integer from 1 through 13 that represents the month. </param><param name="day">An integer from 1 through 31 that represents the day. </param><param name="hour">An integer from 0 through 23 that represents the hour. </param><param name="minute">An integer from 0 through 59 that represents the minute. </param><param name="second">An integer from 0 through 59 that represents the second. </param><param name="millisecond">An integer from 0 through 999 that represents the millisecond. </param><param name="era">An integer that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" />, <paramref name="month" />, <paramref name="day" />, <paramref name="hour" />, <paramref name="minute" />, <paramref name="second" />, <paramref name="millisecond" />, or <paramref name="era" /> is outside the range supported by this calendar. </exception>
        public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the date that is the specified number of months away from the specified date.</summary><returns>A new <see cref="T:System.DateTime" /> that results from adding the specified number of months to the <paramref name="time" /> parameter.</returns><param name="time">The <see cref="T:System.DateTime" /> to which to add <paramref name="months" />. </param><param name="months">The number of months to add. </param><exception cref="T:System.ArgumentException">The result is outside the supported range of a <see cref="T:System.DateTime" />. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="months" /> is less than -120000 or greater than 120000. -or-<paramref name="time" /> is less than <see cref="P:System.Globalization.Calendar.MinSupportedDateTime" /> or greater than <see cref="P:System.Globalization.Calendar.MaxSupportedDateTime" />.</exception>
        public override DateTime AddMonths(DateTime time, int months)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the date that is the specified number of years away from the specified date.</summary><returns>A new <see cref="T:System.DateTime" /> that results from adding the specified number of years to the <paramref name="time" /> parameter.</returns><param name="time">The <see cref="T:System.DateTime" /> to which to add <paramref name="years" />. </param><param name="years">The number of years to add. </param><exception cref="T:System.ArgumentException">The result is outside the supported range of a <see cref="T:System.DateTime" />. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="time" /> is less than <see cref="P:System.Globalization.Calendar.MinSupportedDateTime" /> or greater than <see cref="P:System.Globalization.Calendar.MaxSupportedDateTime" />.</exception>
        public override DateTime AddYears(DateTime time, int years)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the day of the year in the specified date.</summary><returns>An integer from 1 through 354 in a common year, or 1 through 384 in a leap year, that represents the day of the year specified in the <paramref name="time" /> parameter.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param>
        public override int GetDayOfYear(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the day of the month in the specified date.</summary><returns>An integer from 1 through 31 that represents the day of the month specified in the <paramref name="time" /> parameter.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param>
        public override int GetDayOfMonth(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the number of days in the specified year and era.</summary><returns>The number of days in the specified year and era.</returns><param name="year">An integer that represents the year. </param><param name="era">An integer that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> or <paramref name="era" /> is outside the range supported by this calendar. </exception>
        public override int GetDaysInYear(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the month in the specified date.</summary><returns>An integer from 1 to 13 that represents the month specified in the <paramref name="time" /> parameter.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param>
        public override int GetMonth(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the year in the specified date.</summary><returns>An integer that represents the year in the specified <see cref="T:System.DateTime" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param>
        public override int GetYear(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the day of the week in the specified date.</summary><returns>One of the <see cref="T:System.DayOfWeek" /> values that represents the day of the week specified in the <paramref name="time" /> parameter.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="time" /> is less than <see cref="P:System.Globalization.Calendar.MinSupportedDateTime" /> or greater than <see cref="P:System.Globalization.Calendar.MaxSupportedDateTime" />.</exception>
        public override DayOfWeek GetDayOfWeek(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the number of months in the specified year and era.</summary><returns>The number of months in the specified year in the specified era. The return value is 12 months in a common year or 13 months in a leap year.</returns><param name="year">An integer that represents the year. </param><param name="era">An integer that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> or <paramref name="era" /> is outside the range supported by this calendar. </exception>
        public override int GetMonthsInYear(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified date in the specified era is a leap day.</summary><returns>true if the specified day is a leap day; otherwise, false.</returns><param name="year">An integer that represents the year. </param><param name="month">An integer from 1 through 13 that represents the month. </param><param name="day">An integer from 1 through 31 that represents the day. </param><param name="era">An integer that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" />, <paramref name="month" />, <paramref name="day" />, or <paramref name="era" /> is outside the range supported by this calendar. </exception>
        public override bool IsLeapDay(int year, int month, int day, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified month in the specified year and era is a leap month.</summary><returns>true if the <paramref name="month" /> parameter is a leap month; otherwise, false.</returns><param name="year">An integer that represents the year. </param><param name="month">An integer from 1 through 13 that represents the month. </param><param name="era">An integer that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" />, <paramref name="month" />, or <paramref name="era" /> is outside the range supported by this calendar. </exception>
        public override bool IsLeapMonth(int year, int month, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the leap month for the specified year and era.</summary><returns>A positive integer from 1 through 13 that indicates the leap month in the specified year and era. -or-Zero if this calendar does not support a leap month, or if the <paramref name="year" /> and <paramref name="era" /> parameters do not specify a leap year.</returns><param name="year">An integer that represents the year.</param><param name="era">An integer that represents the era.</param>
        public override int GetLeapMonth(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified year in the specified era is a leap year.</summary><returns>true if the specified year is a leap year; otherwise, false.</returns><param name="year">An integer that represents the year. </param><param name="era">An integer that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> or <paramref name="era" /> is outside the range supported by this calendar. </exception>
        public override bool IsLeapYear(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified year to a four-digit year.</summary><returns>An integer that contains the four-digit representation of the <paramref name="year" /> parameter.</returns><param name="year">A two-digit or four-digit integer that represents the year to convert. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> is outside the range supported by this calendar. </exception>
        public override int ToFourDigitYear(int year)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
