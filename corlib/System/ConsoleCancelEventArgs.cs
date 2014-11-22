
namespace System
{
    /// <summary>Provides data for the <see cref="E:System.Console.CancelKeyPress" /> event. This class cannot be inherited.</summary><filterpriority>2</filterpriority>
    [Serializable]
    public sealed class ConsoleCancelEventArgs : EventArgs
    {
    
        /// <summary>Gets or sets a value that indicates whether simultaneously pressing the <see cref="F:System.ConsoleModifiers.Control" /> modifier key and the <see cref="F:System.ConsoleKey.C" /> console key (Ctrl+C) or the Ctrl+Break keys terminates the current process.</summary><returns>true if the current process should resume when the event handler concludes; false if the current process should terminate.</returns><filterpriority>2</filterpriority>
        public bool Cancel
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the combination of modifier and console keys that interrupted the current process.</summary><returns>One of the enumeration values that specifies the key combination that interrupted the current process. There is no default value.</returns><filterpriority>1</filterpriority>
        public ConsoleSpecialKey SpecialKey
        {
            get { throw new NotImplementedException(); }
        }
    
    
    }
}
