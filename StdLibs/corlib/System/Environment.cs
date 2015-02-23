using System.Runtime.InteropServices;
using System.Security;
using System.Collections;
using System.Runtime.ConstrainedExecution;
using javaThread = java.lang.Thread;

namespace System
{
    /// <summary>
    /// Provides information about, and means to manipulate, the current environment and platform. 
    /// This class cannot be inherited.
    /// </summary>
    /// <filterpriority>1</filterpriority>
    [ComVisibleAttribute(true)]
    public static class Environment
    {
        public enum SpecialFolderOption : int
        {
            None = 0,
            Create = 32768,
            DoNotVerify = 16384
        }
    
        [ComVisibleAttribute(true)]
        public enum SpecialFolder : int
        {
            ApplicationData = 26,
            CommonApplicationData = 35,
            LocalApplicationData = 28,
            Cookies = 33,
            Desktop = 0,
            Favorites = 6,
            History = 34,
            InternetCache = 32,
            Programs = 2,
            MyComputer = 17,
            MyMusic = 13,
            MyPictures = 39,
            MyVideos = 14,
            Recent = 8,
            SendTo = 9,
            StartMenu = 11,
            Startup = 7,
            System = 37,
            Templates = 21,
            DesktopDirectory = 16,
            Personal = 5,
            MyDocuments = 5,
            ProgramFiles = 38,
            CommonProgramFiles = 43,
            AdminTools = 48,
            CDBurning = 59,
            CommonAdminTools = 47,
            CommonDocuments = 46,
            CommonMusic = 53,
            CommonOemLinks = 58,
            CommonPictures = 54,
            CommonStartMenu = 22,
            CommonPrograms = 23,
            CommonStartup = 24,
            CommonDesktopDirectory = 25,
            CommonTemplates = 45,
            CommonVideos = 55,
            Fonts = 20,
            NetworkShortcuts = 19,
            PrinterShortcuts = 27,
            UserProfile = 40,
            CommonProgramFilesX86 = 44,
            ProgramFilesX86 = 42,
            Resources = 56,
            LocalizedResources = 57,
            SystemX86 = 41,
            Windows = 36
        }
    
    
        /// <summary>Gets the number of milliseconds elapsed since the system started.</summary><returns>A 32-bit signed integer containing the amount of time in milliseconds that has passed since the last time the computer was started.</returns><filterpriority>1</filterpriority>
        public static int TickCount
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the exit code of the process.</summary><returns>A 32-bit signed integer containing the exit code. The default value is zero.</returns><filterpriority>1</filterpriority>
        public static int ExitCode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the command line for this process.</summary><returns>A string containing command-line arguments.</returns><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="Path" /></PermissionSet>
        public static string CommandLine
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the fully qualified path of the current working directory.</summary><returns>A string containing a directory path.</returns><exception cref="T:System.ArgumentException">Attempted to set to an empty string ("").</exception><exception cref="T:System.ArgumentNullException">Attempted to set to null.</exception><exception cref="T:System.IO.IOException">An I/O error occurred.</exception><exception cref="T:System.IO.DirectoryNotFoundException">Attempted to set a local path that cannot be found.</exception><exception cref="T:System.Security.SecurityException">The caller does not have the appropriate permission.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public static string CurrentDirectory
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the fully qualified path of the system directory.</summary><returns>A string containing a directory path.</returns><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public static string SystemDirectory
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the NetBIOS name of this local computer.</summary><returns>A string containing the name of this computer.</returns><exception cref="T:System.InvalidOperationException">The name of this computer cannot be obtained.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="COMPUTERNAME" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public static string MachineName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of processors on the current machine.</summary><returns>The 32-bit signed integer that specifies the number of processors on the current machine. There is no default. If the current machine contains multiple processor groups, this property returns the number of logical processors that are available for use by the common language runtime (CLR).</returns><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="NUMBER_OF_PROCESSORS" /></PermissionSet>
        public static int ProcessorCount
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the amount of memory for an operating system's page file.</summary><returns>The number of bytes in a system page file.</returns>
        public static int SystemPageSize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the newline string defined for this environment.</summary><returns>A string containing "\r\n" for non-Unix platforms, or a string containing "\n" for Unix platforms.</returns><filterpriority>1</filterpriority>
        public static string NewLine
        {
            get { return java.lang.System.getProperty("line.separator"); }
        }
    
        /// <summary>Gets a <see cref="T:System.Version" /> object that describes the major, minor, build, and revision numbers of the common language runtime.</summary><returns>An object that displays the version of the common language runtime.</returns><filterpriority>1</filterpriority>
        public static Version Version
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the amount of physical memory mapped to the process context.</summary><returns>A 64-bit signed integer containing the number of bytes of physical memory mapped to the process context.</returns><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public static long WorkingSet
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an <see cref="T:System.OperatingSystem" /> object that contains the current platform identifier and version number.</summary><returns>An object that contains the platform identifier and version number.</returns><exception cref="T:System.InvalidOperationException">This property was unable to obtain the system version.-or- The obtained platform identifier is not a member of <see cref="T:System.PlatformID" /></exception><filterpriority>1</filterpriority>
        public static OperatingSystem OSVersion
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets current stack trace information.</summary><returns>A string containing stack trace information. This value can be <see cref="F:System.String.Empty" />.</returns><exception cref="T:System.ArgumentOutOfRangeException">The requested stack trace information is out of range.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PathDiscovery="*AllFiles*" /></PermissionSet>
        public static string StackTrace
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Determines whether the current process is a 64-bit process.</summary><returns>true if the process is 64-bit; otherwise, false.</returns>
        public static bool Is64BitProcess
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Determines whether the current operating system is a 64-bit operating system.</summary><returns>true if the operating system is 64-bit; otherwise, false.</returns>
        public static bool Is64BitOperatingSystem
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the common language runtime (CLR) is shutting down.</summary><returns>true if the CLR is shutting down; otherwise, false.</returns><filterpriority>1</filterpriority>
        public static bool HasShutdownStarted
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the user name of the person who is currently logged on to the Windows operating system.</summary><returns>The user name of the person who is logged on to Windows.</returns><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="UserName" /></PermissionSet>
        public static string UserName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the current process is running in user interactive mode.</summary><returns>true if the current process is running in user interactive mode; otherwise, false.</returns><filterpriority>1</filterpriority>
        public static bool UserInteractive
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the network domain name associated with the current user.</summary><returns>The network domain name associated with the current user.</returns><exception cref="T:System.PlatformNotSupportedException">The operating system does not support retrieving the network domain name.</exception><exception cref="T:System.InvalidOperationException">The network domain name cannot be retrieved.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="UserName;UserDomainName" /></PermissionSet>
        public static string UserDomainName
        {
            get { throw new NotImplementedException(); }
        }

        internal static String GetResourceString(String key)
        {
            return key;
        }
    
        /// <summary>Gets a unique identifier for the current managed thread.</summary>
        /// <returns>An integer that represents a unique identifier for this managed thread.</returns>
        public static int CurrentManagedThreadId
        {
            get { return (int)javaThread.currentThread().getId(); }
        }
    
    
        /// <summary>Terminates this process and gives the underlying operating system the specified exit code.</summary><param name="exitCode">Exit code to be given to the operating system.</param><exception cref="T:System.Security.SecurityException">The caller does not have sufficient security permission to perform this function.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void Exit(int exitCode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Immediately terminates a process after writing a message to the Windows Application event log, and then includes the message in error reporting to Microsoft.</summary><param name="message">A message that explains why the process was terminated, or null if no explanation is provided.</param>
        [SecurityCriticalAttribute()]
        public static void FailFast(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Immediately terminates a process after writing a message to the Windows Application event log, and then includes the message and exception information in error reporting to Microsoft.</summary><param name="message">A message that explains why the process was terminated, or null if no explanation is provided.</param><param name="exception">An exception that represents the error that caused the termination. This is typically the exception in a catch block.</param>
        [SecurityCriticalAttribute()]
        public static void FailFast(string message, Exception exception)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Replaces the name of each environment variable embedded in the specified string with the string equivalent of the value of the variable, then returns the resulting string.</summary><returns>A string with each environment variable replaced by its value.</returns><param name="name">A string containing the names of zero or more environment variables. Each environment variable is quoted with the percent sign character (%).</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static string ExpandEnvironmentVariables(string name)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static string[] GetCommandLineArgs()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the value of an environment variable from the current process.</summary><returns>The value of the environment variable specified by <paramref name="variable" />, or null if the environment variable is not found.</returns><param name="variable">The name of the environment variable.</param><exception cref="T:System.ArgumentNullException"><paramref name="variable" /> is null.</exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission to perform this operation.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static string GetEnvironmentVariable(string variable)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the value of an environment variable from the current process or from the Windows operating system registry key for the current user or local machine.</summary><returns>The value of the environment variable specified by the <paramref name="variable" /> and <paramref name="target" /> parameters, or null if the environment variable is not found.</returns><param name="variable">The name of an environment variable.</param><param name="target">One of the <see cref="T:System.EnvironmentVariableTarget" /> values.</param><exception cref="T:System.ArgumentNullException"><paramref name="variable" /> is null.</exception><exception cref="T:System.NotSupportedException"><paramref name="target" /> is <see cref="F:System.EnvironmentVariableTarget.User" /> or <see cref="F:System.EnvironmentVariableTarget.Machine" /> and the current operating system is Windows 95, Windows 98, or Windows Me.</exception><exception cref="T:System.ArgumentException"><paramref name="target" /> is not a valid <see cref="T:System.EnvironmentVariableTarget" /> value.</exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission to perform this operation.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static string GetEnvironmentVariable(string variable, EnvironmentVariableTarget target)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static IDictionary GetEnvironmentVariables()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves all environment variable names and their values from the current process, or from the Windows operating system registry key for the current user or local machine.</summary><returns>A dictionary that contains all environment variable names and their values from the source specified by the <paramref name="target" /> parameter; otherwise, an empty dictionary if no environment variables are found.</returns><param name="target">One of the <see cref="T:System.EnvironmentVariableTarget" /> values.</param><exception cref="T:System.Security.SecurityException">The caller does not have the required permission to perform this operation for the specified value of <paramref name="target" />.</exception><exception cref="T:System.NotSupportedException">This method cannot be used on Windows 95 or Windows 98 platforms.</exception><exception cref="T:System.ArgumentException"><paramref name="target" /> contains an illegal value.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static IDictionary GetEnvironmentVariables(EnvironmentVariableTarget target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates, modifies, or deletes an environment variable stored in the current process.</summary><param name="variable">The name of an environment variable.</param><param name="value">A value to assign to <paramref name="variable" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="variable" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="variable" /> contains a zero-length string, an initial hexadecimal zero character (0x00), or an equal sign ("="). -or-The length of <paramref name="variable" /> or <paramref name="value" /> is greater than or equal to 32,767 characters.-or-An error occurred during the execution of this operation.</exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission to perform this operation.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void SetEnvironmentVariable(string variable, string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates, modifies, or deletes an environment variable stored in the current process or in the Windows operating system registry key reserved for the current user or local machine.</summary><param name="variable">The name of an environment variable.</param><param name="value">A value to assign to <paramref name="variable" />.</param><param name="target">One of the <see cref="T:System.EnvironmentVariableTarget" /> values.</param><exception cref="T:System.ArgumentNullException"><paramref name="variable" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="variable" /> contains a zero-length string, an initial hexadecimal zero character (0x00), or an equal sign ("="). -or-The length of <paramref name="variable" /> is greater than or equal to 32,767 characters.-or-<paramref name="target" /> is not a member of the <see cref="T:System.EnvironmentVariableTarget" /> enumeration. -or-<paramref name="target" /> is <see cref="F:System.EnvironmentVariableTarget.Machine" /> or <see cref="F:System.EnvironmentVariableTarget.User" /> and the length of <paramref name="variable" /> is greater than or equal to 255.-or-<paramref name="target" /> is <see cref="F:System.EnvironmentVariableTarget.Process" /> and the length of <paramref name="value" /> is greater than or equal to 32,767 characters. -or-An error occurred during the execution of this operation.</exception><exception cref="T:System.NotSupportedException"><paramref name="target" /> is <see cref="F:System.EnvironmentVariableTarget.User" /> or <see cref="F:System.EnvironmentVariableTarget.Machine" /> and the current operating system is Windows 95, Windows 98, or Windows Me.</exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission to perform this operation.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void SetEnvironmentVariable(string variable, string value, EnvironmentVariableTarget target)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static string[] GetLogicalDrives()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static string GetFolderPath(SpecialFolder folder)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static string GetFolderPath(SpecialFolder folder, SpecialFolderOption option)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
