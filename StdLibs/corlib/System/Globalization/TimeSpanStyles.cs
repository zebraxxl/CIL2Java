using System;

namespace System.Globalization
{
    /// <summary>Defines the formatting options that customize string parsing for the <see cref="Overload:System.TimeSpan.ParseExact" /> and <see cref="Overload:System.TimeSpan.TryParseExact" /> methods.</summary>
    [FlagsAttribute()]
    public enum TimeSpanStyles : int
    {
        /// <summary>Indicates that input is interpreted as a negative time interval only if a negative sign is present.</summary>
        None = 0,
        /// <summary>Indicates that input is always interpreted as a negative time interval.</summary>
        AssumeNegative = 1
    }
}
