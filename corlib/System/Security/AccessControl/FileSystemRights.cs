using System;

namespace System.Security.AccessControl
{
    /// <summary>Defines the access rights to use when creating access and audit rules. </summary>
    [FlagsAttribute()]
    public enum FileSystemRights : int
    {
        /// <summary>Specifies the right to open and copy a file or folder.  This does not include the right to read file system attributes, extended file system attributes, or access and audit rules.</summary>
        ReadData = 1,
        /// <summary>Specifies the right to read the contents of a directory.</summary>
        ListDirectory = 1,
        /// <summary>Specifies the right to open and write to a file or folder.  This does not include the right to open and write file system attributes, extended file system attributes, or access and audit rules.</summary>
        WriteData = 2,
        /// <summary>Specifies the right to create a file.  </summary>
        CreateFiles = 2,
        /// <summary>Specifies the right to append data to the end of a file.</summary>
        AppendData = 4,
        /// <summary>Specifies the right to create a folder.  </summary>
        CreateDirectories = 4,
        /// <summary>Specifies the right to open and copy extended file system attributes from a folder or file.  For example, this value specifies the right to view author and content information.  This does not include the right to read data, file system attributes, or access and audit rules.</summary>
        ReadExtendedAttributes = 8,
        /// <summary>Specifies the right to open and write extended file system attributes to a folder or file.  This does not include the ability to write data, attributes, or access and audit rules.</summary>
        WriteExtendedAttributes = 16,
        /// <summary>Specifies the right to run an application file.</summary>
        ExecuteFile = 32,
        /// <summary>Specifies the right to list the contents of a folder and to run applications contained within that folder.</summary>
        Traverse = 32,
        /// <summary>Specifies the right to delete a folder and any files contained within that folder.</summary>
        DeleteSubdirectoriesAndFiles = 64,
        /// <summary>Specifies the right to open and copy file system attributes from a folder or file.  For example, this value specifies the right to view the file creation or modified date.  This does not include the right to read data, extended file system attributes, or access and audit rules.</summary>
        ReadAttributes = 128,
        /// <summary>Specifies the right to open and write file system attributes to a folder or file. This does not include the ability to write data, extended attributes, or access and audit rules.</summary>
        WriteAttributes = 256,
        /// <summary>Specifies the right to delete a folder or file. </summary>
        Delete = 65536,
        /// <summary>Specifies the right to open and copy access and audit rules from a folder or file.  This does not include the right to read data, file system attributes, and extended file system attributes. </summary>
        ReadPermissions = 131072,
        /// <summary>Specifies the right to change the security and audit rules associated with a file or folder.</summary>
        ChangePermissions = 262144,
        /// <summary>Specifies the right to change the owner of a folder or file.  Note that owners of a resource have full access to that resource.</summary>
        TakeOwnership = 524288,
        /// <summary>Specifies whether the application can wait for a file handle to synchronize with the completion of an I/O operation.</summary>
        Synchronize = 1048576,
        /// <summary>Specifies the right to exert full control over a folder or file, and to modify access control and audit rules.  This value represents the right to do anything with a file and is the combination of all rights in this enumeration.</summary>
        FullControl = 2032127,
        /// <summary>Specifies the right to open and copy folders or files as read-only.  This right includes the <see cref="F:System.Security.AccessControl.FileSystemRights.ReadData" /> right, <see cref="F:System.Security.AccessControl.FileSystemRights.ReadExtendedAttributes" /> right, <see cref="F:System.Security.AccessControl.FileSystemRights.ReadAttributes" /> right, and <see cref="F:System.Security.AccessControl.FileSystemRights.ReadPermissions" /> right.</summary>
        Read = 131209,
        /// <summary>Specifies the right to open and copy folders or files as read-only, and to run application files.  This right includes the <see cref="F:System.Security.AccessControl.FileSystemRights.Read" /> right and the <see cref="F:System.Security.AccessControl.FileSystemRights.ExecuteFile" /> right.</summary>
        ReadAndExecute = 131241,
        /// <summary>Specifies the right to create folders and files, and to add or remove data from files.  This right includes the <see cref="F:System.Security.AccessControl.FileSystemRights.WriteData" /> right, <see cref="F:System.Security.AccessControl.FileSystemRights.AppendData" /> right, <see cref="F:System.Security.AccessControl.FileSystemRights.WriteExtendedAttributes" /> right, and <see cref="F:System.Security.AccessControl.FileSystemRights.WriteAttributes" /> right. </summary>
        Write = 278,
        /// <summary>Specifies the right to read, write, list folder contents, delete folders and files, and run application files.  This right includes the <see cref="F:System.Security.AccessControl.FileSystemRights.ReadAndExecute" /> right, the <see cref="F:System.Security.AccessControl.FileSystemRights.Write" /> right, and the <see cref="F:System.Security.AccessControl.FileSystemRights.Delete" /> right.</summary>
        Modify = 197055
    }
}
