using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Specifies the culture, case, and sort rules to be used by certain overloads of the <see cref="M:System.String.Compare(System.String,System.String)" /> and <see cref="M:System.String.Equals(System.Object)" /> methods.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum StringComparison : int
    {
        /// <summary>Compare strings using culture-sensitive sort rules and the current culture.</summary>
        CurrentCulture = 0,
        /// <summary>Compare strings using culture-sensitive sort rules, the current culture, and ignoring the case of the strings being compared.</summary>
        CurrentCultureIgnoreCase = 1,
        /// <summary>Compare strings using culture-sensitive sort rules and the invariant culture.</summary>
        InvariantCulture = 2,
        /// <summary>Compare strings using culture-sensitive sort rules, the invariant culture, and ignoring the case of the strings being compared.</summary>
        InvariantCultureIgnoreCase = 3,
        /// <summary>Compare strings using ordinal sort rules.</summary>
        Ordinal = 4,
        /// <summary>Compare strings using ordinal sort rules and ignoring the case of the strings being compared.</summary>
        OrdinalIgnoreCase = 5
    }
}
