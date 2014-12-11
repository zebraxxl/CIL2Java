using System.Runtime.InteropServices;
using System;

namespace System.Globalization
{
    /// <summary>Defines different rules for determining the first week of the year.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum CalendarWeekRule : int
    {
        /// <summary>Indicates that the first week of the year starts on the first day of the year and ends before the following designated first day of the week. The value is 0.</summary>
        FirstDay = 0,
        /// <summary>Indicates that the first week of the year begins on the first occurrence of the designated first day of the week on or after the first day of the year. The value is 1.</summary>
        FirstFullWeek = 1,
        /// <summary>Indicates that the first week of the year is the first week with four or more days before the designated first day of the week. The value is 2.</summary>
        FirstFourDayWeek = 2
    }
}
