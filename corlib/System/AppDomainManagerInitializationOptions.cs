using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Specifies the action that a custom application domain manager takes when initializing a new domain.</summary><filterpriority>2</filterpriority>
    [FlagsAttribute()]
    [ComVisibleAttribute(true)]
    public enum AppDomainManagerInitializationOptions : int
    {
        /// <summary>No initialization action.</summary>
        None = 0,
        /// <summary>Register the COM callable wrapper for the current <see cref="T:System.AppDomainManager" /> with the unmanaged host. </summary>
        RegisterWithHost = 1
    }
}
