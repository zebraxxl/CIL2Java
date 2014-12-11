
namespace System
{
    /// <summary>Describes the console key that was pressed, including the character represented by the console key and the state of the SHIFT, ALT, and CTRL modifier keys.</summary><filterpriority>1</filterpriority>
    [Serializable]
    public struct ConsoleKeyInfo
    {
    
        /// <summary>Gets the Unicode character represented by the current <see cref="T:System.ConsoleKeyInfo" /> object.</summary><returns>An object that corresponds to the console key represented by the current <see cref="T:System.ConsoleKeyInfo" /> object.</returns><filterpriority>1</filterpriority>
        public char KeyChar
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the console key represented by the current <see cref="T:System.ConsoleKeyInfo" /> object.</summary><returns>A value that identifies the console key that was pressed.</returns><filterpriority>1</filterpriority>
        public ConsoleKey Key
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a bitwise combination of <see cref="T:System.ConsoleModifiers" /> values that specifies one or more modifier keys pressed simultaneously with the console key.</summary><returns>A bitwise combination of the enumeration values. There is no default value.</returns><filterpriority>1</filterpriority>
        public ConsoleModifiers Modifiers
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.ConsoleKeyInfo" /> structure using the specified character, console key, and modifier keys.</summary><param name="keyChar">The Unicode character that corresponds to the <paramref name="key" /> parameter. </param><param name="key">The console key that corresponds to the <paramref name="keyChar" /> parameter. </param><param name="shift">true to indicate that a SHIFT key was pressed; otherwise, false. </param><param name="alt">true to indicate that an ALT key was pressed; otherwise, false. </param><param name="control">true to indicate that a CTRL key was pressed; otherwise, false. </param><exception cref="T:System.ArgumentOutOfRangeException">The numeric value of the <paramref name="key" /> parameter is less than 0 or greater than 255.</exception>
        public ConsoleKeyInfo(char keyChar, ConsoleKey key, bool shift, bool alt, bool control)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a value indicating whether the specified object is equal to the current <see cref="T:System.ConsoleKeyInfo" /> object.</summary><returns>true if <paramref name="value" /> is a <see cref="T:System.ConsoleKeyInfo" /> object and is equal to the current <see cref="T:System.ConsoleKeyInfo" /> object; otherwise, false.</returns><param name="value">An object to compare to the current <see cref="T:System.ConsoleKeyInfo" /> object.</param>
        public override bool Equals(object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a value indicating whether the specified <see cref="T:System.ConsoleKeyInfo" /> object is equal to the current <see cref="T:System.ConsoleKeyInfo" /> object.</summary><returns>true if <paramref name="obj" /> is equal to the current <see cref="T:System.ConsoleKeyInfo" /> object; otherwise, false.</returns><param name="obj">An object to compare to the current <see cref="T:System.ConsoleKeyInfo" /> object.</param>
        public bool Equals(ConsoleKeyInfo obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified <see cref="T:System.ConsoleKeyInfo" /> objects are equal.</summary><returns>true if <paramref name="a" /> is equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The first object to compare.</param><param name="b">The second object to compare.</param>
        /// <summary>Indicates whether the specified <see cref="T:System.ConsoleKeyInfo" /> objects are equal.</summary><returns>true if <paramref name="a" /> is equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The first object to compare.</param><param name="b">The second object to compare.</param>
        public static bool operator ==(ConsoleKeyInfo a, ConsoleKeyInfo b)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified <see cref="T:System.ConsoleKeyInfo" /> objects are not equal.</summary><returns>true if <paramref name="a" /> is not equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The first object to compare.</param><param name="b">The second object to compare.</param>
        /// <summary>Indicates whether the specified <see cref="T:System.ConsoleKeyInfo" /> objects are not equal.</summary><returns>true if <paramref name="a" /> is not equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The first object to compare.</param><param name="b">The second object to compare.</param>
        public static bool operator !=(ConsoleKeyInfo a, ConsoleKeyInfo b)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
