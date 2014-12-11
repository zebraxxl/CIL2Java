using System;

namespace System.Globalization
{
    /// <summary>Represents the Taiwan lunisolar calendar. As for the Taiwan calendar, years are calculated using the Gregorian calendar, while days and months are calculated using the lunisolar calendar.</summary>
    [Serializable]
    public class TaiwanLunisolarCalendar : EastAsianLunisolarCalendar
    {
    
        /// <summary>Gets the minimum date and time supported by the <see cref="T:System.Globalization.TaiwanLunisolarCalendar" /> class.</summary><returns>The earliest date and time supported by the <see cref="T:System.Globalization.TaiwanLunisolarCalendar" /> class, which is equivalent to the first moment of February 18, 1912 C.E. in the Gregorian calendar.</returns>
        public override DateTime MinSupportedDateTime
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the maximum date and time supported by the <see cref="T:System.Globalization.TaiwanLunisolarCalendar" /> class.</summary><returns>The latest date and time supported by the <see cref="T:System.Globalization.TaiwanLunisolarCalendar" /> class, which is equivalent to the last moment of February 10, 2051 C.E. in the Gregorian calendar.</returns>
        public override DateTime MaxSupportedDateTime
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of days in the year that precedes the year specified by <see cref="P:System.Globalization.TaiwanLunisolarCalendar.MinSupportedDateTime" />.</summary><returns>The number of days in the year that precedes the year specified by <see cref="P:System.Globalization.TaiwanLunisolarCalendar.MinSupportedDateTime" />.</returns>
        protected override int DaysInYearBeforeMinSupportedYear
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the eras that are relevant to the current <see cref="T:System.Globalization.TaiwanLunisolarCalendar" /> object.</summary><returns>An array that consists of a single element having a value that is always the current era.</returns>
        public override int[] Eras
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public TaiwanLunisolarCalendar()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the era that corresponds to the specified <see cref="T:System.DateTime" />.</summary><returns>An integer that represents the era specified in the <paramref name="time" /> parameter.</returns><param name="time">The <see cref="T:System.DateTime" /> to read. </param>
        public override int GetEra(DateTime time)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
