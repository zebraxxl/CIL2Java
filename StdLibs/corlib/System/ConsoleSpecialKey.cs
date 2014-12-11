
namespace System
{
    /// <summary>Specifies combinations of modifier and console keys that can interrupt the current process.</summary><filterpriority>1</filterpriority>
    [Serializable]
    public enum ConsoleSpecialKey : int
    {
        /// <summary>The <see cref="F:System.ConsoleModifiers.Control" /> modifier key plus the <see cref="F:System.ConsoleKey.C" /> console key.</summary>
        ControlC = 0,
        /// <summary>The <see cref="F:System.ConsoleModifiers.Control" /> modifier key plus the BREAK console key.</summary>
        ControlBreak = 1
    }
}
