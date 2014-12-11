using System.Runtime.InteropServices;
using System;

namespace System.Security.Permissions
{
    /// <summary>Specifies the type of windows that code is allowed to use.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum UIPermissionWindow : int
    {
        /// <summary>Users cannot use any windows or user interface events. No user interface can be used.</summary>
        NoWindows = 0,
        /// <summary>Users can only use <see cref="F:System.Security.Permissions.UIPermissionWindow.SafeSubWindows" /> for drawing, and can only use user input events for user interface within that subwindow. Examples of <see cref="F:System.Security.Permissions.UIPermissionWindow.SafeSubWindows" /> are a <see cref="T:System.Windows.Forms.MessageBox" />, common dialog controls, and a control displayed within a browser.</summary>
        SafeSubWindows = 1,
        /// <summary>Users can only use <see cref="F:System.Security.Permissions.UIPermissionWindow.SafeTopLevelWindows" /> and <see cref="F:System.Security.Permissions.UIPermissionWindow.SafeSubWindows" /> for drawing, and can only use user input events for the user interface within those top-level windows and subwindows. </summary>
        SafeTopLevelWindows = 2,
        /// <summary>Users can use all windows and user input events without restriction.</summary>
        AllWindows = 3
    }
}
