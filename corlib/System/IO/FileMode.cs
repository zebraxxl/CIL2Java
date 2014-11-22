using System.Runtime.InteropServices;
using System;

namespace System.IO
{
    /// <summary>Specifies how the operating system should open a file.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum FileMode : int
    {
        /// <summary>Specifies that the operating system should create a new file. This requires <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Write" /> permission. If the file already exists, an <see cref="T:System.IO.IOException" /> exception is thrown.</summary>
        CreateNew = 1,
        /// <summary>Specifies that the operating system should create a new file. If the file already exists, it will be overwritten. This requires <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Write" /> permission. FileMode.Create is equivalent to requesting that if the file does not exist, use <see cref="F:System.IO.FileMode.CreateNew" />; otherwise, use <see cref="F:System.IO.FileMode.Truncate" />. If the file already exists but is a hidden file, an <see cref="T:System.UnauthorizedAccessException" /> exception is thrown.</summary>
        Create = 2,
        /// <summary>Specifies that the operating system should open an existing file. The ability to open the file is dependent on the value specified by the <see cref="T:System.IO.FileAccess" /> enumeration. A <see cref="T:System.IO.FileNotFoundException" /> exception is thrown if the file does not exist.</summary>
        Open = 3,
        /// <summary>Specifies that the operating system should open a file if it exists; otherwise, a new file should be created. If the file is opened with FileAccess.Read, <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Read" /> permission is required. If the file access is FileAccess.Write, <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Write" /> permission is required. If the file is opened with FileAccess.ReadWrite, both <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Read" /> and <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Write" /> permissions are required.  </summary>
        OpenOrCreate = 4,
        /// <summary>Specifies that the operating system should open an existing file. When the file is opened, it should be truncated so that its size is zero bytes. This requires <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Write" /> permission. Attempts to read from a file opened with FileMode.Truncate cause an <see cref="T:System.ArgumentException" /> exception.</summary>
        Truncate = 5,
        /// <summary>Opens the file if it exists and seeks to the end of the file, or creates a new file. This requires <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Append" /> permission. FileMode.Append can be used only in conjunction with FileAccess.Write. Trying to seek to a position before the end of the file throws an <see cref="T:System.IO.IOException" /> exception, and any attempt to read fails and throws a <see cref="T:System.NotSupportedException" /> exception.</summary>
        Append = 6
    }
}
