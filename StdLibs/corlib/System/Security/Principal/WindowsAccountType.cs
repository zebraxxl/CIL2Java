using System.Runtime.InteropServices;
using System;

namespace System.Security.Principal
{
    /// <summary>Specifies the type of Windows account used.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum WindowsAccountType : int
    {
        /// <summary>A standard user account.</summary>
        Normal = 0,
        /// <summary>A Windows guest account.</summary>
        Guest = 1,
        /// <summary>A Windows system account.</summary>
        System = 2,
        /// <summary>An anonymous account.</summary>
        Anonymous = 3
    }
}
