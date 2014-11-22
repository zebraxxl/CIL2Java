
namespace System
{
    /// <summary>Represents the SHIFT, ALT, and CTRL modifier keys on a keyboard.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [FlagsAttribute()]
    public enum ConsoleModifiers : int
    {
        /// <summary>The left or right ALT modifier key.</summary>
        Alt = 1,
        /// <summary>The left or right SHIFT modifier key.</summary>
        Shift = 2,
        /// <summary>The left or right CTRL modifier key.</summary>
        Control = 4
    }
}
