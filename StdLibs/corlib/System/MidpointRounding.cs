using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Specifies how mathematical rounding methods should process a number that is midway between two numbers.</summary><filterpriority>1</filterpriority>
    [ComVisibleAttribute(true)]
    public enum MidpointRounding : int
    {
        /// <summary>When a number is halfway between two others, it is rounded toward the nearest even number.</summary>
        ToEven = 0,
        /// <summary>When a number is halfway between two others, it is rounded toward the nearest number that is away from zero.</summary>
        AwayFromZero = 1
    }
}
