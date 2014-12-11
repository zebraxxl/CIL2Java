using System;

namespace System.Globalization
{
    /// <summary>Represents time in divisions, such as months, days, and years. Years are calculated as for the Japanese calendar, while days and months are calculated using the lunisolar calendar.</summary>
    [Serializable]
    public class JapaneseLunisolarCalendar : EastAsianLunisolarCalendar
    {
        /// <summary>Specifies the current era.</summary>
        public const int JapaneseEra = 1;
    
        /// <summary>Gets the minimum date and time supported by the <see cref="T:System.Globalization.JapaneseLunisolarCalendar" /> class.</summary><returns>The earliest date and time supported by the <see cref="T:System.Globalization.JapaneseLunisolarCalendar" /> class, which is equivalent to the first moment of January 28, 1960 C.E. in the Gregorian calendar.</returns>
        public override DateTime MinSupportedDateTime
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the maximum date and time supported by the <see cref="T:System.Globalization.JapaneseLunisolarCalendar" /> class.</summary><returns>The latest date and time supported by the <see cref="T:System.Globalization.JapaneseLunisolarCalendar" /> class, which is equivalent to the last moment of January 22, 2050 C.E. in the Gregorian calendar.</returns>
        public override DateTime MaxSupportedDateTime
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of days in the year that precedes the year that is specified by the <see cref="P:System.Globalization.JapaneseLunisolarCalendar.MinSupportedDateTime" /> property.</summary><returns>The number of days in the year that precedes the year specified by <see cref="P:System.Globalization.JapaneseLunisolarCalendar.MinSupportedDateTime" />.</returns>
        protected override int DaysInYearBeforeMinSupportedYear
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the eras that are relevant to the <see cref="T:System.Globalization.JapaneseLunisolarCalendar" /> object.</summary><returns>An array of 32-bit signed integers that specify the relevant eras.</returns>
        public override int[] Eras
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public JapaneseLunisolarCalendar()
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
