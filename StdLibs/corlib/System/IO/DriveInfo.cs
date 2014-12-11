using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.IO
{
    /// <summary>Provides access to information on a drive.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class DriveInfo : ISerializable
    {
    
        /// <summary>Gets the name of a drive.</summary><returns>The name of the drive.</returns><filterpriority>1</filterpriority>
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the drive type.</summary><returns>One of the <see cref="T:System.IO.DriveType" /> values. </returns><filterpriority>1</filterpriority>
        public DriveType DriveType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the file system, such as NTFS or FAT32.</summary><returns>The name of the file system on the specified drive.</returns><exception cref="T:System.UnauthorizedAccessException">Access to the drive information is denied.</exception><exception cref="T:System.IO.DriveNotFoundException">The drive does not exist or is not mapped.</exception><exception cref="T:System.IO.IOException">An I/O error occurred (for example, a disk error or a drive was not ready). </exception><filterpriority>1</filterpriority>
        public string DriveFormat
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether a drive is ready.</summary><returns>true if the drive is ready; false if the drive is not ready.</returns><filterpriority>1</filterpriority>
        public bool IsReady
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Indicates the amount of available free space on a drive.</summary><returns>The amount of free space available on the drive, in bytes.</returns><exception cref="T:System.UnauthorizedAccessException">Access to the drive information is denied.</exception><exception cref="T:System.IO.IOException">An I/O error occurred (for example, a disk error or a drive was not ready). </exception><filterpriority>1</filterpriority>
        public long AvailableFreeSpace
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the total amount of free space available on a drive.</summary><returns>The total free space available on a drive, in bytes.</returns><exception cref="T:System.UnauthorizedAccessException">Access to the drive information is denied.</exception><exception cref="T:System.IO.DriveNotFoundException">The drive is not mapped or does not exist.</exception><exception cref="T:System.IO.IOException">An I/O error occurred (for example, a disk error or a drive was not ready). </exception><filterpriority>1</filterpriority>
        public long TotalFreeSpace
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the total size of storage space on a drive.</summary><returns>The total size of the drive, in bytes.</returns><exception cref="T:System.UnauthorizedAccessException">Access to the drive information is denied.</exception><exception cref="T:System.IO.DriveNotFoundException">The drive is not mapped or does not exist. </exception><exception cref="T:System.IO.IOException">An I/O error occurred (for example, a disk error or a drive was not ready). </exception><filterpriority>1</filterpriority>
        public long TotalSize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the root directory of a drive.</summary><returns>A <see cref="T:System.IO.DirectoryInfo" /> object that contains the root directory of the drive.</returns><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public DirectoryInfo RootDirectory
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the volume label of a drive.</summary><returns>The volume label.</returns><exception cref="T:System.IO.IOException">An I/O error occurred (for example, a disk error or a drive was not ready). </exception><exception cref="T:System.IO.DriveNotFoundException">The drive is not mapped or does not exist.</exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><exception cref="T:System.UnauthorizedAccessException">The volume label is being set on a network or CD-ROM drive.-or-Access to the drive information is denied.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public string VolumeLabel
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Provides access to information on the specified drive.</summary><param name="driveName">A valid drive path or drive letter. This can be either uppercase or lowercase, 'a' to 'z'. A null value is not valid. </param><exception cref="T:System.ArgumentNullException">The drive letter cannot be null. </exception><exception cref="T:System.ArgumentException">The first letter of <paramref name="driveName" /> is not an uppercase or lowercase letter from 'a' to 'z'.-or-<paramref name="driveName" /> does not refer to a valid drive.</exception>
        [SecuritySafeCriticalAttribute()]
        public DriveInfo(string driveName)
        {
             throw new NotImplementedException();
        }
        
        
        public static DriveInfo[] GetDrives()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }



        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
