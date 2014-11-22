using System.Runtime.InteropServices;
using System;

namespace System.Globalization
{
    /// <summary>Represents time in divisions, such as months, days, and years. Years are calculated using the Chinese calendar, while days and months are calculated using the lunisolar calendar.</summary>
    [Serializable]
    public class ChineseLunisolarCalendar : EastAsianLunisolarCalendar
    {
        /// <summary>Specifies the era that corresponds to the current <see cref="T:System.Globalization.ChineseLunisolarCalendar" /> object.</summary>
        public const int ChineseEra = 1;
    
        /// <summary>Gets the minimum date and time supported by the <see cref="T:System.Globalization.ChineseLunisolarCalendar" /> class.</summary><returns>A <see cref="T:System.DateTime" /> type that represents February 19, 1901 in the Gregorian calendar, which is equivalent to the constructor, DateTime(1901, 2, 19).</returns>
        [ComVisibleAttribute(false)]
        public override DateTime MinSupportedDateTime
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the maximum date and time supported by the <see cref="T:System.Globalization.ChineseLunisolarCalendar" /> class.</summary><returns>A <see cref="T:System.DateTime" /> type that represents the last moment on January 28, 2101 in the Gregorian calendar, which is approximately equal to the constructor DateTime(2101, 1, 28, 23, 59, 59, 999).</returns>
        [ComVisibleAttribute(false)]
        public override DateTime MaxSupportedDateTime
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of days in the year that precedes the year that is specified by the <see cref="P:System.Globalization.ChineseLunisolarCalendar.MinSupportedDateTime" />property.</summary><returns>The number of days in the year that precedes the year specified by <see cref="P:System.Globalization.ChineseLunisolarCalendar.MinSupportedDateTime" />.</returns>
        protected override int DaysInYearBeforeMinSupportedYear
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the eras that correspond to the range of dates and times supported by the current <see cref="T:System.Globalization.ChineseLunisolarCalendar" /> object.</summary><returns>An array of 32-bit signed integers that specify the relevant eras. The return value for a <see cref="T:System.Globalization.ChineseLunisolarCalendar" /> object is always an array containing one element equal to the <see cref="F:System.Globalization.ChineseLunisolarCalendar.ChineseEra" /> value.</returns>
        [ComVisibleAttribute(false)]
        public override int[] Eras
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ChineseLunisolarCalendar()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the era that corresponds to the specified <see cref="T:System.DateTime" /> type.</summary><returns>An integer that represents the era in the <paramref name="time" /> parameter.</returns><param name="time">The <see cref="T:System.DateTime" /> type to read. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="time" /> is less than <see cref="P:System.Globalization.ChineseLunisolarCalendar.MinSupportedDateTime" /> or greater than <see cref="P:System.Globalization.ChineseLunisolarCalendar.MaxSupportedDateTime" />.</exception>
        [ComVisibleAttribute(false)]
        public override int GetEra(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
