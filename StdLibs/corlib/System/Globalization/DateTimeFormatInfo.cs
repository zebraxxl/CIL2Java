using System.Runtime.InteropServices;
using System;
using System.Runtime.Serialization;

namespace System.Globalization
{
    /// <summary>Provides culture-specific information about the format of date and time values.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class DateTimeFormatInfo : ICloneable, IFormatProvider
    {
    
        /// <summary>Gets the default read-only <see cref="T:System.Globalization.DateTimeFormatInfo" /> object that is culture-independent (invariant).</summary><returns>A read-only object that is culture-independent (invariant).</returns>
        public static DateTimeFormatInfo InvariantInfo
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a read-only <see cref="T:System.Globalization.DateTimeFormatInfo" /> object that formats values based on the current culture.</summary><returns>A read-only <see cref="T:System.Globalization.DateTimeFormatInfo" /> object based on the <see cref="T:System.Globalization.CultureInfo" /> object for the current thread.</returns>
        public static DateTimeFormatInfo CurrentInfo
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the string designator for hours that are "ante meridiem" (before noon).</summary><returns>The string designator for hours that are ante meridiem. The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is "AM".</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
        public string AMDesignator
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the calendar to use for the current culture.</summary><returns>The calendar to use for the current culture. The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is a <see cref="T:System.Globalization.GregorianCalendar" /> object.</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a <see cref="T:System.Globalization.Calendar" /> object that is not valid for the current culture. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
        public Calendar Calendar
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the string that separates the components of a date, that is, the year, month, and day.</summary><returns>The string that separates the components of a date, that is, the year, month, and day. The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is "/".</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
        public string DateSeparator
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the first day of the week.</summary><returns>An enumeration value that represents the first day of the week. The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is <see cref="F:System.DayOfWeek.Sunday" />.</returns><exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is not a valid <see cref="T:System.DayOfWeek" /> value. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
        public DayOfWeek FirstDayOfWeek
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value that specifies which rule is used to determine the first calendar week of the year.</summary><returns>A value that determines the first calendar week of the year. The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is <see cref="F:System.Globalization.CalendarWeekRule.FirstDay" />.</returns><exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is not a valid <see cref="T:System.Globalization.CalendarWeekRule" /> value. </exception><exception cref="T:System.InvalidOperationException">In a set operation, the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
        public CalendarWeekRule CalendarWeekRule
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the custom format string for a long date and long time value.</summary><returns>The custom format string for a long date and long time value.</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
        public string FullDateTimePattern
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the custom format string for a long date value.</summary><returns>The custom format string for a long date value.</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
        public string LongDatePattern
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the custom format string for a long time value.</summary><returns>The format pattern for a long time value.</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
        public string LongTimePattern
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the custom format string for a month and day value.</summary><returns>The custom format string for a month and day value.</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
        public string MonthDayPattern
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the string designator for hours that are "post meridiem" (after noon).</summary><returns>The string designator for hours that are "post meridiem" (after noon). The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is "PM".</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
        public string PMDesignator
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the custom format string for a time value that is based on the Internet Engineering Task Force (IETF) Request for Comments (RFC) 1123 specification.</summary><returns>The custom format string for a time value that is based on the IETF RFC 1123 specification.</returns>
        public string RFC1123Pattern
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the custom format string for a short date value.</summary><returns>The custom format string for a short date value.</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
        public string ShortDatePattern
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the custom format string for a short time value.</summary><returns>The custom format string for a short time value.</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
        public string ShortTimePattern
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the custom format string for a sortable date and time value.</summary><returns>The custom format string for a sortable date and time value.</returns>
        public string SortableDateTimePattern
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the string that separates the components of time, that is, the hour, minutes, and seconds.</summary><returns>The string that separates the components of time. The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is ":".</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
        public string TimeSeparator
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the custom format string for a universal, sortable date and time string.</summary><returns>The custom format string for a universal, sortable date and time string.</returns>
        public string UniversalSortableDateTimePattern
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the custom format string for a year and month value.</summary><returns>The custom format string for a year and month value.</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
        public string YearMonthPattern
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a one-dimensional array of type <see cref="T:System.String" /> containing the culture-specific abbreviated names of the days of the week.</summary><returns>A one-dimensional array of type <see cref="T:System.String" /> containing the culture-specific abbreviated names of the days of the week. The array for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> contains "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", and "Sat".</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.ArgumentException">The property is being set to an array that is multidimensional or that has a length that is not exactly 7. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
        public string[] AbbreviatedDayNames
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a string array of the shortest unique abbreviated day names associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary><returns>A string array of day names.</returns><exception cref="T:System.ArgumentException">In a set operation, the array does not have exactly seven elements.</exception><exception cref="T:System.ArgumentNullException">In a set operation, the value array or one of the elements of the value array is null.</exception><exception cref="T:System.InvalidOperationException">In a set operation, the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
        [ComVisibleAttribute(false)]
        public string[] ShortestDayNames
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a one-dimensional string array that contains the culture-specific full names of the days of the week.</summary><returns>A one-dimensional string array that contains the culture-specific full names of the days of the week. The array for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> contains "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", and "Saturday".</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.ArgumentException">The property is being set to an array that is multidimensional or that has a length that is not exactly 7. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
        public string[] DayNames
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a one-dimensional string array that contains the culture-specific abbreviated names of the months.</summary><returns>A one-dimensional string array with 13 elements that contains the culture-specific abbreviated names of the months. For 12-month calendars, the 13th element of the array is an empty string. The array for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> contains "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec", and "".</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.ArgumentException">The property is being set to an array that is multidimensional or that has a length that is not exactly 13. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
        public string[] AbbreviatedMonthNames
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a one-dimensional array of type <see cref="T:System.String" /> containing the culture-specific full names of the months.</summary><returns>A one-dimensional array of type <see cref="T:System.String" /> containing the culture-specific full names of the months. In a 12-month calendar, the 13th element of the array is an empty string. The array for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> contains "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", and "".</returns><exception cref="T:System.ArgumentNullException">The property is being set to null. </exception><exception cref="T:System.ArgumentException">The property is being set to an array that is multidimensional or that has a length that is not exactly 13. </exception><exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
        public string[] MonthNames
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</summary><returns>true if the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only; otherwise, false.</returns>
        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the native name of the calendar associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary><returns>The native name of the calendar used in the culture associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object if that name is available, or the empty string ("") if the native calendar name is not available.</returns>
        [ComVisibleAttribute(false)]
        public string NativeCalendarName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a string array of abbreviated month names associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary><returns>An array of abbreviated month names.</returns><exception cref="T:System.ArgumentException">In a set operation, the array is multidimensional or has a length that is not exactly 13.</exception><exception cref="T:System.ArgumentNullException">In a set operation, the array or one of the elements of the array is null.</exception><exception cref="T:System.InvalidOperationException">In a set operation, the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
        [ComVisibleAttribute(false)]
        public string[] AbbreviatedMonthGenitiveNames
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a string array of month names associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary><returns>A string array of month names.</returns><exception cref="T:System.ArgumentException">In a set operation, the array is multidimensional or has a length that is not exactly 13.</exception><exception cref="T:System.ArgumentNullException">In a set operation, the array or one of its elements is null.</exception><exception cref="T:System.InvalidOperationException">In a set operation, the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
        [ComVisibleAttribute(false)]
        public string[] MonthGenitiveNames
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public DateTimeFormatInfo()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object associated with the specified <see cref="T:System.IFormatProvider" />.</summary><returns>A <see cref="T:System.Globalization.DateTimeFormatInfo" /> object associated with <see cref="T:System.IFormatProvider" />.</returns><param name="provider">The <see cref="T:System.IFormatProvider" /> that gets the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.-or- null to get <see cref="P:System.Globalization.DateTimeFormatInfo.CurrentInfo" />. </param>
        public static DateTimeFormatInfo GetInstance(IFormatProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an object of the specified type that provides a date and time  formatting service.</summary><returns>The current  object, if <paramref name="formatType" /> is the same as the type of the current <see cref="T:System.Globalization.DateTimeFormatInfo" />; otherwise, null.</returns><param name="formatType">The type of the required formatting service. </param>
        public object GetFormat(Type formatType)
        {
             throw new NotImplementedException();
        }
        
        
        public object Clone()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the integer representing the specified era.</summary><returns>The integer representing the era, if <paramref name="eraName" /> is valid; otherwise, -1.</returns><param name="eraName">The string containing the name of the era. </param><exception cref="T:System.ArgumentNullException"><paramref name="eraName" /> is null. </exception>
        public int GetEra(string eraName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the string containing the name of the specified era.</summary><returns>A string containing the name of the era.</returns><param name="era">The integer representing the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="era" /> does not represent a valid era in the calendar specified in the <see cref="P:System.Globalization.DateTimeFormatInfo.Calendar" /> property. </exception>
        public string GetEraName(int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the string containing the abbreviated name of the specified era, if an abbreviation exists.</summary><returns>A string containing the abbreviated name of the specified era, if an abbreviation exists.-or- A string containing the full name of the era, if an abbreviation does not exist.</returns><param name="era">The integer representing the era. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="era" /> does not represent a valid era in the calendar specified in the <see cref="P:System.Globalization.DateTimeFormatInfo.Calendar" /> property. </exception>
        public string GetAbbreviatedEraName(int era)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the culture-specific abbreviated name of the specified day of the week based on the culture associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary><returns>The culture-specific abbreviated name of the day of the week represented by <paramref name="dayofweek" />.</returns><param name="dayofweek">A <see cref="T:System.DayOfWeek" /> value. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="dayofweek" /> is not a valid <see cref="T:System.DayOfWeek" /> value. </exception>
        public string GetAbbreviatedDayName(DayOfWeek dayofweek)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Obtains the shortest abbreviated day name for a specified day of the week associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary><returns>The abbreviated name of the week that corresponds to the <paramref name="dayOfWeek" /> parameter.</returns><param name="dayOfWeek">One of the <see cref="T:System.DayOfWeek" /> values.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="dayOfWeek" /> is not a value in the <see cref="T:System.DayOfWeek" /> enumeration.</exception>
        [ComVisibleAttribute(false)]
        public string GetShortestDayName(DayOfWeek dayOfWeek)
        {
             throw new NotImplementedException();
        }
        
        
        public string[] GetAllDateTimePatterns()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns all the patterns in which date and time values can be formatted using the specified standard format string.</summary><returns>An array containing the standard patterns in which date and time values can be formatted using the specified format string.</returns><param name="format">A standard format string. </param><exception cref="T:System.ArgumentException"><paramref name="format" /> is not a valid standard format string. </exception>
        public string[] GetAllDateTimePatterns(char format)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the culture-specific full name of the specified day of the week based on the culture associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary><returns>The culture-specific full name of the day of the week represented by <paramref name="dayofweek" />.</returns><param name="dayofweek">A <see cref="T:System.DayOfWeek" /> value. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="dayofweek" /> is not a valid <see cref="T:System.DayOfWeek" /> value. </exception>
        public string GetDayName(DayOfWeek dayofweek)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the culture-specific abbreviated name of the specified month based on the culture associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary><returns>The culture-specific abbreviated name of the month represented by <paramref name="month" />.</returns><param name="month">An integer from 1 through 13 representing the name of the month to retrieve. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="month" /> is less than 1 or greater than 13. </exception>
        public string GetAbbreviatedMonthName(int month)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the culture-specific full name of the specified month based on the culture associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary><returns>The culture-specific full name of the month represented by <paramref name="month" />.</returns><param name="month">An integer from 1 through 13 representing the name of the month to retrieve. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="month" /> is less than 1 or greater than 13. </exception>
        public string GetMonthName(int month)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a read-only <see cref="T:System.Globalization.DateTimeFormatInfo" /> wrapper.</summary><returns>A read-only <see cref="T:System.Globalization.DateTimeFormatInfo" /> wrapper.</returns><param name="dtfi">The <see cref="T:System.Globalization.DateTimeFormatInfo" /> object to wrap. </param><exception cref="T:System.ArgumentNullException"><paramref name="dtfi" /> is null. </exception>
        public static DateTimeFormatInfo ReadOnly(DateTimeFormatInfo dtfi)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the custom date and time format strings that correspond to a specified standard format string.</summary><param name="patterns">An array of custom format strings.</param><param name="format">The standard format string associated with the custom format strings specified in the <paramref name="patterns" /> parameter. </param><exception cref="T:System.ArgumentException"><paramref name="patterns" /> is null or a zero-length array.-or-<paramref name="format" /> is not a valid standard format string or is a standard format string whose patterns cannot be set.</exception><exception cref="T:System.ArgumentNullException"><paramref name="patterns" /> has an array element whose value is null.</exception><exception cref="T:System.InvalidOperationException">This <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
        [ComVisibleAttribute(false)]
        public void SetAllDateTimePatterns(string[] patterns, char format)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
