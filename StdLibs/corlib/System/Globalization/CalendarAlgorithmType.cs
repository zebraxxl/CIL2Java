using System.Runtime.InteropServices;
using System;

namespace System.Globalization
{
    /// <summary>Specifies whether a calendar is solar-based, lunar-based, or lunisolar-based.</summary>
    [ComVisibleAttribute(true)]
    public enum CalendarAlgorithmType : int
    {
        /// <summary>An unknown calendar basis.</summary>
        Unknown = 0,
        /// <summary>A solar-based calendar.</summary>
        SolarCalendar = 1,
        /// <summary>A lunar-based calendar.</summary>
        LunarCalendar = 2,
        /// <summary>A lunisolar-based calendar.</summary>
        LunisolarCalendar = 3
    }
}
