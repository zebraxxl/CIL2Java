using System.Security;
using System.IO;
using System.Text;
using javaSystem = java.lang.System;

namespace System
{
    /// <summary>Represents the standard input, output, and error streams for console applications. This class cannot be inherited.</summary><filterpriority>1</filterpriority>
    public static class Console
    {
    
        /// <summary>Occurs when the <see cref="F:System.ConsoleModifiers.Control" /> modifier key (Ctrl) and either the <see cref="F:System.ConsoleKey.C" /> console key (C) or the Break key are pressed simultaneously (Ctrl+C or Ctrl+Break).</summary><filterpriority>1</filterpriority>
        public static event ConsoleCancelEventHandler CancelKeyPress;
    
    
        /// <summary>Gets a value that indicates whether input has been redirected from the standard input stream.</summary><returns>true if input is redirected; otherwise, false.</returns>
        public static bool IsInputRedirected
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether output has been redirected from the standard output stream.</summary><returns>true if output is redirected; otherwise, false.</returns>
        public static bool IsOutputRedirected
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the error output stream has been redirected from the standard error stream.</summary><returns>true if error output is redirected; otherwise, false.</returns>
        public static bool IsErrorRedirected
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the standard input stream.</summary><returns>A <see cref="T:System.IO.TextReader" /> that represents the standard input stream.</returns><filterpriority>1</filterpriority>
        public static TextReader In
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the standard output stream.</summary><returns>A <see cref="T:System.IO.TextWriter" /> that represents the standard output stream.</returns><filterpriority>1</filterpriority>
        public static TextWriter Out
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the standard error output stream.</summary><returns>A <see cref="T:System.IO.TextWriter" /> that represents the standard error output stream.</returns><filterpriority>1</filterpriority>
        public static TextWriter Error
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the encoding the console uses to read input. </summary><returns>The encoding used to read console input.</returns><exception cref="T:System.ArgumentNullException">The property value in a set operation is null.</exception><exception cref="T:System.IO.IOException">An error occurred during the execution of this operation.</exception><exception cref="T:System.Security.SecurityException">Your application does not have permission to perform this operation.</exception><filterpriority>1</filterpriority>
        public static Encoding InputEncoding
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the encoding the console uses to write output. </summary><returns>The encoding used to write console output.</returns><exception cref="T:System.ArgumentNullException">The property value in a set operation is null.</exception><exception cref="T:System.IO.IOException">An error occurred during the execution of this operation.</exception><exception cref="T:System.Security.SecurityException">Your application does not have permission to perform this operation.</exception><filterpriority>1</filterpriority>
        public static Encoding OutputEncoding
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the background color of the console.</summary><returns>A <see cref="T:System.ConsoleColor" /> that specifies the background color of the console; that is, the color that appears behind each character. The default is black.</returns><exception cref="T:System.ArgumentException">The color specified in a set operation is not a valid member of <see cref="T:System.ConsoleColor" />. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows" /></PermissionSet>
        public static ConsoleColor BackgroundColor
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the foreground color of the console.</summary><returns>A <see cref="T:System.ConsoleColor" /> that specifies the foreground color of the console; that is, the color of each character that is displayed. The default is gray.</returns><exception cref="T:System.ArgumentException">The color specified in a set operation is not a valid member of <see cref="T:System.ConsoleColor" />. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows" /></PermissionSet>
        public static ConsoleColor ForegroundColor
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the height of the buffer area.</summary><returns>The current height, in rows, of the buffer area.</returns><exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than or equal to zero.-or- The value in a set operation is greater than or equal to <see cref="F:System.Int16.MaxValue" />.-or- The value in a set operation is less than <see cref="P:System.Console.WindowTop" /> + <see cref="P:System.Console.WindowHeight" />. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static int BufferHeight
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the width of the buffer area.</summary><returns>The current width, in columns, of the buffer area.</returns><exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than or equal to zero.-or- The value in a set operation is greater than or equal to <see cref="F:System.Int16.MaxValue" />.-or- The value in a set operation is less than <see cref="P:System.Console.WindowLeft" /> + <see cref="P:System.Console.WindowWidth" />. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static int BufferWidth
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the height of the console window area.</summary><returns>The height of the console window measured in rows.</returns><exception cref="T:System.ArgumentOutOfRangeException">The value of the <see cref="P:System.Console.WindowWidth" /> property or the value of the <see cref="P:System.Console.WindowHeight" /> property is less than or equal to 0.-or-The value of the <see cref="P:System.Console.WindowHeight" /> property plus the value of the <see cref="P:System.Console.WindowTop" /> property is greater than or equal to <see cref="F:System.Int16.MaxValue" />.-or-The value of the <see cref="P:System.Console.WindowWidth" /> property or the value of the <see cref="P:System.Console.WindowHeight" /> property is greater than the largest possible window width or height for the current screen resolution and console font.</exception><exception cref="T:System.IO.IOException">Error reading or writing information.</exception><filterpriority>1</filterpriority>
        public static int WindowHeight
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the width of the console window.</summary><returns>The width of the console window measured in columns.</returns><exception cref="T:System.ArgumentOutOfRangeException">The value of the <see cref="P:System.Console.WindowWidth" /> property or the value of the <see cref="P:System.Console.WindowHeight" /> property is less than or equal to 0.-or-The value of the <see cref="P:System.Console.WindowHeight" /> property plus the value of the <see cref="P:System.Console.WindowTop" /> property is greater than or equal to <see cref="F:System.Int16.MaxValue" />.-or-The value of the <see cref="P:System.Console.WindowWidth" /> property or the value of the <see cref="P:System.Console.WindowHeight" /> property is greater than the largest possible window width or height for the current screen resolution and console font.</exception><exception cref="T:System.IO.IOException">Error reading or writing information.</exception><filterpriority>1</filterpriority>
        public static int WindowWidth
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the largest possible number of console window columns, based on the current font and screen resolution.</summary><returns>The width of the largest possible console window measured in columns.</returns><filterpriority>1</filterpriority>
        public static int LargestWindowWidth
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the largest possible number of console window rows, based on the current font and screen resolution.</summary><returns>The height of the largest possible console window measured in rows.</returns><filterpriority>1</filterpriority>
        public static int LargestWindowHeight
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the leftmost position of the console window area relative to the screen buffer.</summary><returns>The leftmost console window position measured in columns.</returns><exception cref="T:System.ArgumentOutOfRangeException">In a set operation, the value to be assigned is less than zero.-or-As a result of the assignment, <see cref="P:System.Console.WindowLeft" /> plus <see cref="P:System.Console.WindowWidth" /> would exceed <see cref="P:System.Console.BufferWidth" />. </exception><exception cref="T:System.IO.IOException">Error reading or writing information.</exception><filterpriority>1</filterpriority>
        public static int WindowLeft
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the top position of the console window area relative to the screen buffer.</summary><returns>The uppermost console window position measured in rows.</returns><exception cref="T:System.ArgumentOutOfRangeException">In a set operation, the value to be assigned is less than zero.-or-As a result of the assignment, <see cref="P:System.Console.WindowTop" /> plus <see cref="P:System.Console.WindowHeight" /> would exceed <see cref="P:System.Console.BufferHeight" />.</exception><exception cref="T:System.IO.IOException">Error reading or writing information.</exception><filterpriority>1</filterpriority>
        public static int WindowTop
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the column position of the cursor within the buffer area.</summary><returns>The current position, in columns, of the cursor.</returns><exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than zero.-or- The value in a set operation is greater than or equal to <see cref="P:System.Console.BufferWidth" />. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static int CursorLeft
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the row position of the cursor within the buffer area.</summary><returns>The current position, in rows, of the cursor.</returns><exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than zero.-or- The value in a set operation is greater than or equal to <see cref="P:System.Console.BufferHeight" />. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred.</exception><filterpriority>1</filterpriority>
        public static int CursorTop
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the height of the cursor within a character cell.</summary><returns>The size of the cursor expressed as a percentage of the height of a character cell. The property value ranges from 1 to 100.</returns><exception cref="T:System.ArgumentOutOfRangeException">The value specified in a set operation is less than 1 or greater than 100. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows" /></PermissionSet>
        public static int CursorSize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether the cursor is visible.</summary><returns>true if the cursor is visible; otherwise, false.</returns><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows" /></PermissionSet>
        public static bool CursorVisible
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the title to display in the console title bar.</summary><returns>The string to be displayed in the title bar of the console. The maximum length of the title string is 24500 characters.</returns><exception cref="T:System.InvalidOperationException">In a get operation, the retrieved title is longer than 24500 characters. </exception><exception cref="T:System.ArgumentOutOfRangeException">In a set operation, the specified title is longer than 24500 characters. </exception><exception cref="T:System.ArgumentNullException">In a set operation, the specified title is null. </exception><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows" /></PermissionSet>
        public static string Title
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether a key press is available in the input stream.</summary><returns>true if a key press is available; otherwise, false.</returns><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><exception cref="T:System.InvalidOperationException">Standard input is redirected to a file instead of the keyboard. </exception><filterpriority>1</filterpriority>
        public static bool KeyAvailable
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the NUM LOCK keyboard toggle is turned on or turned off.</summary><returns>true if NUM LOCK is turned on; false if NUM LOCK is turned off.</returns><filterpriority>1</filterpriority>
        public static bool NumberLock
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the CAPS LOCK keyboard toggle is turned on or turned off.</summary><returns>true if CAPS LOCK is turned on; false if CAPS LOCK is turned off.</returns><filterpriority>1</filterpriority>
        public static bool CapsLock
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether the combination of the <see cref="F:System.ConsoleModifiers.Control" /> modifier key and <see cref="F:System.ConsoleKey.C" /> console key (Ctrl+C) is treated as ordinary input or as an interruption that is handled by the operating system.</summary><returns>true if Ctrl+C is treated as ordinary input; otherwise, false.</returns><exception cref="T:System.IO.IOException">Unable to get or set the input mode of the console input buffer. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows" /></PermissionSet>
        public static bool TreatControlCAsInput
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public static void Beep()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Plays the sound of a beep of a specified frequency and duration through the console speaker.</summary><param name="frequency">The frequency of the beep, ranging from 37 to 32767 hertz.</param><param name="duration">The duration of the beep measured in milliseconds.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="frequency" /> is less than 37 or more than 32767 hertz.-or-<paramref name="duration" /> is less than or equal to zero.</exception><exception cref="T:System.Security.HostProtectionException">This method was executed on a server, such as SQL Server, that does not permit access to the console.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static void Beep(int frequency, int duration)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static void ResetColor()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies a specified source area of the screen buffer to a specified destination area.</summary><param name="sourceLeft">The leftmost column of the source area. </param><param name="sourceTop">The topmost row of the source area. </param><param name="sourceWidth">The number of columns in the source area. </param><param name="sourceHeight">The number of rows in the source area. </param><param name="targetLeft">The leftmost column of the destination area. </param><param name="targetTop">The topmost row of the destination area. </param><exception cref="T:System.ArgumentOutOfRangeException">One or more of the parameters is less than zero.-or- <paramref name="sourceLeft" /> or <paramref name="targetLeft" /> is greater than or equal to <see cref="P:System.Console.BufferWidth" />.-or- <paramref name="sourceTop" /> or <paramref name="targetTop" /> is greater than or equal to <see cref="P:System.Console.BufferHeight" />.-or- <paramref name="sourceTop" /> + <paramref name="sourceHeight" /> is greater than or equal to <see cref="P:System.Console.BufferHeight" />.-or- <paramref name="sourceLeft" /> + <paramref name="sourceWidth" /> is greater than or equal to <see cref="P:System.Console.BufferWidth" />. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows" /></PermissionSet>
        public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies a specified source area of the screen buffer to a specified destination area.</summary><param name="sourceLeft">The leftmost column of the source area. </param><param name="sourceTop">The topmost row of the source area. </param><param name="sourceWidth">The number of columns in the source area. </param><param name="sourceHeight">The number of rows in the source area. </param><param name="targetLeft">The leftmost column of the destination area. </param><param name="targetTop">The topmost row of the destination area. </param><param name="sourceChar">The character used to fill the source area. </param><param name="sourceForeColor">The foreground color used to fill the source area. </param><param name="sourceBackColor">The background color used to fill the source area. </param><exception cref="T:System.ArgumentOutOfRangeException">One or more of the parameters is less than zero.-or- <paramref name="sourceLeft" /> or <paramref name="targetLeft" /> is greater than or equal to <see cref="P:System.Console.BufferWidth" />.-or- <paramref name="sourceTop" /> or <paramref name="targetTop" /> is greater than or equal to <see cref="P:System.Console.BufferHeight" />.-or- <paramref name="sourceTop" /> + <paramref name="sourceHeight" /> is greater than or equal to <see cref="P:System.Console.BufferHeight" />.-or- <paramref name="sourceLeft" /> + <paramref name="sourceWidth" /> is greater than or equal to <see cref="P:System.Console.BufferWidth" />. </exception><exception cref="T:System.ArgumentException">One or both of the color parameters is not a member of the <see cref="T:System.ConsoleColor" /> enumeration. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the height and width of the screen buffer area to the specified values.</summary><param name="width">The width of the buffer area measured in columns. </param><param name="height">The height of the buffer area measured in rows. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="height" /> or <paramref name="width" /> is less than or equal to zero.-or- <paramref name="height" /> or <paramref name="width" /> is greater than or equal to <see cref="F:System.Int16.MaxValue" />.-or- <paramref name="width" /> is less than <see cref="P:System.Console.WindowLeft" /> + <see cref="P:System.Console.WindowWidth" />.-or- <paramref name="height" /> is less than <see cref="P:System.Console.WindowTop" /> + <see cref="P:System.Console.WindowHeight" />. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void SetBufferSize(int width, int height)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the height and width of the console window to the specified values.</summary><param name="width">The width of the console window measured in columns. </param><param name="height">The height of the console window measured in rows. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="width" /> or <paramref name="height" /> is less than or equal to zero.-or- <paramref name="width" /> plus <see cref="P:System.Console.WindowLeft" /> or <paramref name="height" /> plus <see cref="P:System.Console.WindowTop" /> is greater than or equal to <see cref="F:System.Int16.MaxValue" />. -or-<paramref name="width" /> or <paramref name="height" /> is greater than the largest possible window width or height for the current screen resolution and console font.</exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void SetWindowSize(int width, int height)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the position of the console window relative to the screen buffer.</summary><param name="left">The column position of the upper left  corner of the console window. </param><param name="top">The row position of the upper left corner of the console window. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="left" /> or <paramref name="top" /> is less than zero.-or- <paramref name="left" /> + <see cref="P:System.Console.WindowWidth" /> is greater than <see cref="P:System.Console.BufferWidth" />.-or- <paramref name="top" /> + <see cref="P:System.Console.WindowHeight" /> is greater than <see cref="P:System.Console.BufferHeight" />. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void SetWindowPosition(int left, int top)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the position of the cursor.</summary><param name="left">The column position of the cursor. </param><param name="top">The row position of the cursor. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="left" /> or <paramref name="top" /> is less than zero.-or- <paramref name="left" /> is greater than or equal to <see cref="P:System.Console.BufferWidth" />.-or- <paramref name="top" /> is greater than or equal to <see cref="P:System.Console.BufferHeight" />. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void SetCursorPosition(int left, int top)
        {
             throw new NotImplementedException();
        }
        
        
        public static ConsoleKeyInfo ReadKey()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Obtains the next character or function key pressed by the user. The pressed key is optionally displayed in the console window.</summary><returns>A <see cref="T:System.ConsoleKeyInfo" /> object that describes the <see cref="T:System.ConsoleKey" /> constant and Unicode character, if any, that correspond to the pressed console key. The <see cref="T:System.ConsoleKeyInfo" /> object also describes, in a bitwise combination of <see cref="T:System.ConsoleModifiers" /> values, whether one or more Shift, Alt, or Ctrl modifier keys was pressed simultaneously with the console key.</returns><param name="intercept">Determines whether to display the pressed key in the console window. true to not display the pressed key; otherwise, false. </param><exception cref="T:System.InvalidOperationException">The <see cref="P:System.Console.In" /> property is redirected from some stream other than the console.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static ConsoleKeyInfo ReadKey(bool intercept)
        {
             throw new NotImplementedException();
        }
        
        
        public static Stream OpenStandardError()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Acquires the standard error stream, which is set to a specified buffer size.</summary><returns>The standard error stream.</returns><param name="bufferSize">The internal stream buffer size. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize" /> is less than or equal to zero. </exception><filterpriority>1</filterpriority>
        public static Stream OpenStandardError(int bufferSize)
        {
             throw new NotImplementedException();
        }
        
        
        public static Stream OpenStandardInput()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Acquires the standard input stream, which is set to a specified buffer size.</summary><returns>The standard input stream.</returns><param name="bufferSize">The internal stream buffer size. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize" /> is less than or equal to zero. </exception><filterpriority>1</filterpriority>
        public static Stream OpenStandardInput(int bufferSize)
        {
             throw new NotImplementedException();
        }
        
        
        public static Stream OpenStandardOutput()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Acquires the standard output stream, which is set to a specified buffer size.</summary><returns>The standard output stream.</returns><param name="bufferSize">The internal stream buffer size. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize" /> is less than or equal to zero. </exception><filterpriority>1</filterpriority>
        public static Stream OpenStandardOutput(int bufferSize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the <see cref="P:System.Console.In" /> property to the specified <see cref="T:System.IO.TextReader" /> object.</summary><param name="newIn">A stream that is the new standard input. </param><exception cref="T:System.ArgumentNullException"><paramref name="newIn" /> is null. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void SetIn(TextReader newIn)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the <see cref="P:System.Console.Out" /> property to the specified <see cref="T:System.IO.TextWriter" /> object.</summary><param name="newOut">A stream that is the new standard output. </param><exception cref="T:System.ArgumentNullException"><paramref name="newOut" /> is null. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void SetOut(TextWriter newOut)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the <see cref="P:System.Console.Error" /> property to the specified <see cref="T:System.IO.TextWriter" /> object.</summary><param name="newError">A stream that is the new standard error output. </param><exception cref="T:System.ArgumentNullException"><paramref name="newError" /> is null. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void SetError(TextWriter newError)
        {
             throw new NotImplementedException();
        }
        
        
        public static int Read()
        {
             throw new NotImplementedException();
        }
        
        
        public static string ReadLine()
        {
             throw new NotImplementedException();
        }
        
        
        public static void WriteLine()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified Boolean value, followed by the current line terminator, to the standard output stream.</summary><param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void WriteLine(bool value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the specified Unicode character, followed by the current line terminator, value to the standard output stream.</summary><param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void WriteLine(char value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the specified array of Unicode characters, followed by the current line terminator, to the standard output stream.</summary><param name="buffer">A Unicode character array. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void WriteLine(char[] buffer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the specified subarray of Unicode characters, followed by the current line terminator, to the standard output stream.</summary><param name="buffer">An array of Unicode characters. </param><param name="index">The starting position in <paramref name="buffer" />. </param><param name="count">The number of characters to write. </param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="index" /> plus <paramref name="count" /> specify a position that is not within <paramref name="buffer" />. </exception><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void WriteLine(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified <see cref="T:System.Decimal" /> value, followed by the current line terminator, to the standard output stream.</summary><param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void WriteLine(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified double-precision floating-point value, followed by the current line terminator, to the standard output stream.</summary><param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void WriteLine(double value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified single-precision floating-point value, followed by the current line terminator, to the standard output stream.</summary><param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void WriteLine(float value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified 32-bit signed integer value, followed by the current line terminator, to the standard output stream.</summary><param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void WriteLine(int value)
        {
            javaSystem.@out.println(value);
        }
        
        
        /// <summary>Writes the text representation of the specified 32-bit unsigned integer value, followed by the current line terminator, to the standard output stream.</summary><param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void WriteLine(uint value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified 64-bit signed integer value, followed by the current line terminator, to the standard output stream.</summary><param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void WriteLine(long value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified 64-bit unsigned integer value, followed by the current line terminator, to the standard output stream.</summary><param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void WriteLine(ulong value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream.</summary><param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void WriteLine(object value)
        {
            javaSystem.@out.println(value.ToString());
        }
        
        
        /// <summary>Writes the specified string value, followed by the current line terminator, to the standard output stream.</summary><param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void WriteLine(string value)
        {
            javaSystem.@out.println(value);
        }
        
        
        /// <summary>Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream using the specified format information.</summary><param name="format">A composite format string (see Remarks).</param><param name="arg0">An object to write using <paramref name="format" />. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><exception cref="T:System.ArgumentNullException"><paramref name="format" /> is null. </exception><exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid. </exception><filterpriority>1</filterpriority>
        public static void WriteLine(string format, object arg0)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified objects, followed by the current line terminator, to the standard output stream using the specified format information.</summary><param name="format">A composite format string (see Remarks).</param><param name="arg0">The first object to write using <paramref name="format" />. </param><param name="arg1">The second object to write using <paramref name="format" />. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><exception cref="T:System.ArgumentNullException"><paramref name="format" /> is null. </exception><exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid. </exception><filterpriority>1</filterpriority>
        public static void WriteLine(string format, object arg0, object arg1)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified objects, followed by the current line terminator, to the standard output stream using the specified format information.</summary><param name="format">A composite format string (see Remarks).</param><param name="arg0">The first object to write using <paramref name="format" />. </param><param name="arg1">The second object to write using <paramref name="format" />. </param><param name="arg2">The third object to write using <paramref name="format" />. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><exception cref="T:System.ArgumentNullException"><paramref name="format" /> is null. </exception><exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid. </exception><filterpriority>1</filterpriority>
        public static void WriteLine(string format, object arg0, object arg1, object arg2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified objects and variable-length parameter list, followed by the current line terminator, to the standard output stream using the specified format information.</summary><param name="format">A composite format string (see Remarks).</param><param name="arg0">The first object to write using <paramref name="format" />. </param><param name="arg1">The second object to write using <paramref name="format" />. </param><param name="arg2">The third object to write using <paramref name="format" />. </param><param name="arg3">The fourth object to write using <paramref name="format" />. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><exception cref="T:System.ArgumentNullException"><paramref name="format" /> is null. </exception><exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid. </exception><filterpriority>1</filterpriority>
        public static void WriteLine(string format, object arg0, object arg1, object arg2, object arg3)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified array of objects, followed by the current line terminator, to the standard output stream using the specified format information.</summary><param name="format">A composite format string (see Remarks).</param><param name="arg">An array of objects to write using <paramref name="format" />. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><exception cref="T:System.ArgumentNullException"><paramref name="format" /> or <paramref name="arg" /> is null. </exception><exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid. </exception><filterpriority>1</filterpriority>
        public static void WriteLine(string format, params  object[] arg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified object to the standard output stream using the specified format information.</summary><param name="format">A composite format string (see Remarks). </param><param name="arg0">An object to write using <paramref name="format" />. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><exception cref="T:System.ArgumentNullException"><paramref name="format" /> is null. </exception><exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid. </exception><filterpriority>1</filterpriority>
        public static void Write(string format, object arg0)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified objects to the standard output stream using the specified format information.</summary><param name="format">A composite format string (see Remarks).</param><param name="arg0">The first object to write using <paramref name="format" />. </param><param name="arg1">The second object to write using <paramref name="format" />. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><exception cref="T:System.ArgumentNullException"><paramref name="format" /> is null. </exception><exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid. </exception><filterpriority>1</filterpriority>
        public static void Write(string format, object arg0, object arg1)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified objects to the standard output stream using the specified format information.</summary><param name="format">A composite format string (see Remarks).</param><param name="arg0">The first object to write using <paramref name="format" />. </param><param name="arg1">The second object to write using <paramref name="format" />. </param><param name="arg2">The third object to write using <paramref name="format" />. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><exception cref="T:System.ArgumentNullException"><paramref name="format" /> is null. </exception><exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid. </exception><filterpriority>1</filterpriority>
        public static void Write(string format, object arg0, object arg1, object arg2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified objects and variable-length parameter list to the standard output stream using the specified format information.</summary><param name="format">A composite format string (see Remarks).</param><param name="arg0">The first object to write using <paramref name="format" />. </param><param name="arg1">The second object to write using <paramref name="format" />. </param><param name="arg2">The third object to write using <paramref name="format" />. </param><param name="arg3">The fourth object to write using <paramref name="format" />. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><exception cref="T:System.ArgumentNullException"><paramref name="format" /> is null. </exception><exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid. </exception><filterpriority>1</filterpriority>
        public static void Write(string format, object arg0, object arg1, object arg2, object arg3)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified array of objects to the standard output stream using the specified format information.</summary><param name="format">A composite format string (see Remarks).</param><param name="arg">An array of objects to write using <paramref name="format" />. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><exception cref="T:System.ArgumentNullException"><paramref name="format" /> or <paramref name="arg" /> is null. </exception><exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid. </exception><filterpriority>1</filterpriority>
        public static void Write(string format, params  object[] arg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified Boolean value to the standard output stream.</summary><param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void Write(bool value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the specified Unicode character value to the standard output stream.</summary><param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void Write(char value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the specified array of Unicode characters to the standard output stream.</summary><param name="buffer">A Unicode character array. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void Write(char[] buffer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the specified subarray of Unicode characters to the standard output stream.</summary><param name="buffer">An array of Unicode characters. </param><param name="index">The starting position in <paramref name="buffer" />. </param><param name="count">The number of characters to write. </param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="index" /> plus <paramref name="count" /> specify a position that is not within <paramref name="buffer" />. </exception><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void Write(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified double-precision floating-point value to the standard output stream.</summary><param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void Write(double value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified <see cref="T:System.Decimal" /> value to the standard output stream.</summary><param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void Write(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified single-precision floating-point value to the standard output stream.</summary><param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void Write(float value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified 32-bit signed integer value to the standard output stream.</summary><param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void Write(int value)
        {
            javaSystem.@out.print(value);
        }
        
        
        /// <summary>Writes the text representation of the specified 32-bit unsigned integer value to the standard output stream.</summary><param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void Write(uint value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified 64-bit signed integer value to the standard output stream.</summary><param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void Write(long value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified 64-bit unsigned integer value to the standard output stream.</summary><param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void Write(ulong value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of the specified object to the standard output stream.</summary><param name="value">The value to write, or null. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void Write(object value)
        {
            javaSystem.@out.print(value.ToString());
        }
        
        
        /// <summary>Writes the specified string value to the standard output stream.</summary><param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
        public static void Write(string value)
        {
            javaSystem.@out.print(value);
        }
        
        
    }
}
