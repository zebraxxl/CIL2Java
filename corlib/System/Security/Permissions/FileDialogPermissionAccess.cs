using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
    /// <summary>Specifies the type of access to files allowed through the File dialog boxes.</summary>
    [Serializable]
    [FlagsAttribute()]
    [ComVisibleAttribute(true)]
    public enum FileDialogPermissionAccess : int
    {
        /// <summary>No access to files through the File dialog boxes.</summary>
        None = 0,
        /// <summary>Ability to open files through the File dialog boxes.</summary>
        Open = 1,
        /// <summary>Ability to save files through the File dialog boxes.</summary>
        Save = 2,
        /// <summary>Ability to open and save files through the File dialog boxes.</summary>
        OpenSave = 3
    }
}
