using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Specifies the location where an environment variable is stored or retrieved in a set or get operation.</summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public enum EnvironmentVariableTarget : int
    {
        /// <summary>The environment variable is stored or retrieved from the environment block associated with the current process. </summary>
        Process = 0,
        /// <summary>The environment variable is stored or retrieved from the HKEY_CURRENT_USER\Environment key in the Windows operating system registry. </summary>
        User = 1,
        /// <summary>The environment variable is stored or retrieved from the HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\Session Manager\Environment key in the Windows operating system registry. </summary>
        Machine = 2
    }
}
