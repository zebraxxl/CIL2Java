using System.Runtime.InteropServices;
using System;

namespace System.IO
{
    /// <summary>Defines constants for drive types, including CDRom, Fixed, Network, NoRootDirectory, Ram, Removable, and Unknown.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum DriveType : int
    {
        /// <summary>The type of drive is unknown.</summary>
        Unknown = 0,
        /// <summary>The drive does not have a root directory.</summary>
        NoRootDirectory = 1,
        /// <summary>The drive is a removable storage device, such as a floppy disk drive or a USB flash drive.</summary>
        Removable = 2,
        /// <summary>The drive is a fixed disk.</summary>
        Fixed = 3,
        /// <summary>The drive is a network drive.</summary>
        Network = 4,
        /// <summary>The drive is an optical disc device, such as a CD or DVD-ROM.</summary>
        CDRom = 5,
        /// <summary>The drive is a RAM disk.</summary>
        Ram = 6
    }
}
