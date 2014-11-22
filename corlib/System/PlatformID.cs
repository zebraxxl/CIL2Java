using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Identifies the operating system, or platform, supported by an assembly.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum PlatformID : int
    {
        /// <summary>The operating system is Win32s. Win32s is a layer that runs on 16-bit versions of Windows to provide access to 32-bit applications.</summary>
        Win32S = 0,
        /// <summary>The operating system is Windows 95 or Windows 98.</summary>
        Win32Windows = 1,
        /// <summary>The operating system is Windows NT or later.</summary>
        Win32NT = 2,
        /// <summary>The operating system is Windows CE.</summary>
        WinCE = 3,
        /// <summary>The operating system is Unix.</summary>
        Unix = 4,
        /// <summary>The development platform is Xbox 360.</summary>
        Xbox = 5,
        /// <summary>The operating system is Macintosh.</summary>
        MacOSX = 6
    }
}
