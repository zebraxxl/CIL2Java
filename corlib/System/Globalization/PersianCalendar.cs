using System;

namespace System.Globalization
{
    /// <summary>Represents the Persian calendar.</summary>
    [Serializable]
    public class PersianCalendar : Calendar
    {
        /// <summary>Represents the current era. This field is constant.</summary>
        public static readonly int PersianEra;
    
        /// <summary>Gets the earliest date and time supported by the <see cref="T:System.Globalization.PersianCalendar" /> class.</summary><returns>The earliest date and time supported by the <see cref="T:System.Globalization.PersianCalendar" /> class, which is equivalent to the first moment of March 21, 622 C.E. in the Gregorian calendar.</returns>
        public override DateTime MinSupportedDateTime
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the latest date and time supported by the <see cref="T:System.Globalization.PersianCalendar" /> class.</summary><returns>The latest date and time supported by the <see cref="T:System.Globalization.PersianCalendar" /> class, which is equivalent to the last moment of December 31, 9999 C.E. in the Gregorian calendar.</returns>
        public override DateTime MaxSupportedDateTime
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the current calendar is solar-based, lunar-based, or lunisolar-based.</summary><returns>Always returns <see cref="F:System.Globalization.CalendarAlgorithmType.SolarCalendar" />.</returns>
        public override CalendarAlgorithmType AlgorithmType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the list of eras in a <see cref="T:System.Globalization.PersianCalendar" /> object.</summary><returns>An array of integers that represents the eras in a <see cref="T:System.Globalization.PersianCalendar" /> object. The array consists of a single element having a value of <see cref="F:System.Globalization.PersianCalendar.PersianEra" />.</returns>
        public override int[] Eras
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the last year of a 100-year range that can be represented by a 2-digit year.</summary><returns>The last year of a 100-year range that can be represented by a 2-digit year.</returns><exception cref="T:System.InvalidOperationException">This calendar is read-only.</exception><exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than 100 or greater than 9378.</exception>
        public override int TwoDigitYearMax
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public PersianCalendar()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.DateTime" /> object that is offset the specified number of months from the specified <see cref="T:System.DateTime" /> object.</summary><returns>A <see cref="T:System.DateTime" /> object that represents the date yielded by adding the number of months specified by the <paramref name="months" /> parameter to the date specified by the <paramref name="time" /> parameter.</returns><param name="time">The <see cref="T:System.DateTime" /> to which to add months. </param><param name="months">The positive or negative number of months to add. </param><exception cref="T:System.ArgumentException">The resulting <see cref="T:System.DateTime" /> is outside the supported range. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="months" /> is less than -120,000 or greater than 120,000. </exception>
        public override DateTime AddMonths(DateTime time, int months)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.DateTime" /> object that is offset the specified number of years from the specified <see cref="T:System.DateTime" /> object.</summary><returns>The <see cref="T:System.DateTime" /> object that results from adding the specified number of years to the specified <see cref="T:System.DateTime" /> object.</returns><param name="time">The <see cref="T:System.DateTime" /> to which to add years. </param><param name="years">The positive or negative number of years to add. </param><exception cref="T:System.ArgumentException">The resulting <see cref="T:System.DateTime" /> is outside the supported range. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="years" /> is less than -10,000 or greater than 10,000. </exception>
        public override DateTime AddYears(DateTime time, int years)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the day of the month in the specified <see cref="T:System.DateTime" /> object.</summary><returns>An integer from 1 through 31 that represents the day of the month in the specified <see cref="T:System.DateTime" /> object.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="time" /> parameter represents a date less than <see cref="P:System.Globalization.PersianCalendar.MinSupportedDateTime" /> or greater than <see cref="P:System.Globalization.PersianCalendar.MaxSupportedDateTime" />.</exception>
        public override int GetDayOfMonth(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the day of the week in the specified <see cref="T:System.DateTime" /> object.</summary><returns>A <see cref="T:System.DayOfWeek" /> value that represents the day of the week in the specified <see cref="T:System.DateTime" /> object.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param>
        public override DayOfWeek GetDayOfWeek(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the day of the year in the specified <see cref="T:System.DateTime" /> object.</summary><returns>An integer from 1 through 366 that represents the day of the year in the specified <see cref="T:System.DateTime" /> object.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="time" /> parameter represents a date less than <see cref="P:System.Globalization.PersianCalendar.MinSupportedDateTime" /> or greater than <see cref="P:System.Globalization.PersianCalendar.MaxSupportedDateTime" />.</exception>
        public override int GetDayOfYear(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the number of days in the specified month of the specified year and era.</summary><returns>The number of days in the specified month of the specified year and era.</returns><param name="year">An integer from 1 through 9378 that represents the year. </param><param name="month">An integer that represents the month, and ranges from 1 through 12 if <paramref name="year" /> is not 9378, or 1 through 10 if <paramref name="year" /> is 9378.</param><param name="era">An integer from 0 through 1 that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" />, <paramref name="month" />, or <paramref name="era" /> is outside the range supported by this calendar. </exception>
        public override int GetDaysInMonth(int year, int month, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the number of days in the specified year of the specified era.</summary><returns>The number of days in the specified year and era. The number of days is 365 in a common year or 366 in a leap year.</returns><param name="year">An integer from 1 through 9378 that represents the year. </param><param name="era">An integer from 0 through 1 that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> or <paramref name="era" /> is outside the range supported by this calendar. </exception>
        public override int GetDaysInYear(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the era in the specified <see cref="T:System.DateTime" /> object.</summary><returns>Always returns <see cref="F:System.Globalization.PersianCalendar.PersianEra" />.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="time" /> parameter represents a date less than <see cref="P:System.Globalization.PersianCalendar.MinSupportedDateTime" /> or greater than <see cref="P:System.Globalization.PersianCalendar.MaxSupportedDateTime" />.</exception>
        public override int GetEra(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the month in the specified <see cref="T:System.DateTime" /> object.</summary><returns>An integer from 1 through 12 that represents the month in the specified <see cref="T:System.DateTime" /> object.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="time" /> parameter represents a date less than <see cref="P:System.Globalization.PersianCalendar.MinSupportedDateTime" /> or greater than <see cref="P:System.Globalization.PersianCalendar.MaxSupportedDateTime" />.</exception>
        public override int GetMonth(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the number of months in the specified year of the specified era.</summary><returns>Returns 10 if the <paramref name="year" /> parameter is 9378; otherwise, always returns 12.</returns><param name="year">An integer from 1 through 9378 that represents the year. </param><param name="era">An integer from 0 through 1 that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> or <paramref name="era" /> is outside the range supported by this calendar. </exception>
        public override int GetMonthsInYear(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the year in the specified <see cref="T:System.DateTime" /> object.</summary><returns>An integer from 1 through 9378 that represents the year in the specified <see cref="T:System.DateTime" />. </returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="time" /> parameter represents a date less than <see cref="P:System.Globalization.PersianCalendar.MinSupportedDateTime" /> or greater than <see cref="P:System.Globalization.PersianCalendar.MaxSupportedDateTime" />.</exception>
        public override int GetYear(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified date is a leap day.</summary><returns>true if the specified day is a leap day; otherwise, false.</returns><param name="year">An integer from 1 through 9378 that represents the year. </param><param name="month">An integer that represents the month and ranges from 1 through 12 if <paramref name="year" /> is not 9378, or 1 through 10 if <paramref name="year" /> is 9378.</param><param name="day">An integer from 1 through 31 that represents the day. </param><param name="era">An integer from 0 through 1 that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" />, <paramref name="month" />, <paramref name="day" />, or <paramref name="era" /> is outside the range supported by this calendar. </exception>
        public override bool IsLeapDay(int year, int month, int day, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the leap month for a specified year and era.</summary><returns>The return value is always 0.</returns><param name="year">An integer from 1 through 9378 that represents the year to convert. </param><param name="era">An integer from 0 through 1 that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> or <paramref name="era" /> is outside the range supported by this calendar. </exception>
        public override int GetLeapMonth(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified month in the specified year and era is a leap month.</summary><returns>Always returns false because the <see cref="T:System.Globalization.PersianCalendar" /> class does not support the notion of a leap month.</returns><param name="year">An integer from 1 through 9378 that represents the year. </param><param name="month">An integer that represents the month and ranges from 1 through 12 if <paramref name="year" /> is not 9378, or 1 through 10 if <paramref name="year" /> is 9378.</param><param name="era">An integer from 0 through 1 that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" />, <paramref name="month" />, or <paramref name="era" /> is outside the range supported by this calendar. </exception>
        public override bool IsLeapMonth(int year, int month, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified year in the specified era is a leap year.</summary><returns>true if the specified year is a leap year; otherwise, false.</returns><param name="year">An integer from 1 through 9378 that represents the year. </param><param name="era">An integer from 0 through 1 that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> or <paramref name="era" /> is outside the range supported by this calendar. </exception>
        public override bool IsLeapYear(int year, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.DateTime" /> object that is set to the specified date, time, and era.</summary><returns>A <see cref="T:System.DateTime" /> object that is set to the specified date and time in the current era.</returns><param name="year">An integer from 1 through 9378 that represents the year. </param><param name="month">An integer from 1 through 12 that represents the month. </param><param name="day">An integer from 1 through 31 that represents the day. </param><param name="hour">An integer from 0 through 23 that represents the hour. </param><param name="minute">An integer from 0 through 59 that represents the minute. </param><param name="second">An integer from 0 through 59 that represents the second. </param><param name="millisecond">An integer from 0 through 999 that represents the millisecond. </param><param name="era">An integer from 0 through 1 that represents the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" />, <paramref name="month" />, <paramref name="day" />, <paramref name="hour" />, <paramref name="minute" />, <paramref name="second" />, <paramref name="millisecond" />, or <paramref name="era" /> is outside the range supported by this calendar.</exception>
        public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified year to a four-digit year representation.</summary><returns>An integer that contains the four-digit representation of <paramref name="year" />.</returns><param name="year">An integer from 1 through 9378 that represents the year to convert. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year" /> is less than 0 or greater than 9378. </exception>
        public override int ToFourDigitYear(int year)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
