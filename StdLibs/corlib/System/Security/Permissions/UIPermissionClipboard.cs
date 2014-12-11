using System.Runtime.InteropServices;
using System;

namespace System.Security.Permissions
{
    /// <summary>Specifies the type of clipboard access that is allowed to the calling code.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum UIPermissionClipboard : int
    {
        /// <summary>Clipboard cannot be used.</summary>
        NoClipboard = 0,
        /// <summary>The ability to put data on the clipboard (Copy, Cut) is unrestricted. Intrinsic controls that accept Paste, such as text box, can accept the clipboard data, but user controls that must programmatically read the clipboard cannot.</summary>
        OwnClipboard = 1,
        /// <summary>Clipboard can be used without restriction.</summary>
        AllClipboard = 2
    }
}
