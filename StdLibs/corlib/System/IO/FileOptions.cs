using System.Runtime.InteropServices;
using System;

namespace System.IO
{
    /// <summary>Represents advanced options for creating a <see cref="T:System.IO.FileStream" /> object.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [FlagsAttribute()]
    public enum FileOptions : int
    {
        /// <summary>Indicates that no additional options should be used when creating a <see cref="T:System.IO.FileStream" /> object.</summary>
        None = 0,
        /// <summary>Indicates that the system should write through any intermediate cache and go directly to disk.</summary>
        WriteThrough = -2147483648,
        /// <summary>Indicates that a file can be used for asynchronous reading and writing. </summary>
        Asynchronous = 1073741824,
        /// <summary>Indicates that the file is accessed randomly. The system can use this as a hint to optimize file caching.</summary>
        RandomAccess = 268435456,
        /// <summary>Indicates that a file is automatically deleted when it is no longer in use.</summary>
        DeleteOnClose = 67108864,
        /// <summary>Indicates that the file is to be accessed sequentially from beginning to end. The system can use this as a hint to optimize file caching. If an application moves the file pointer for random access, optimum caching may not occur; however, correct operation is still guaranteed. </summary>
        SequentialScan = 134217728,
        /// <summary>Indicates that a file is encrypted and can be decrypted only by using the same user account used for encryption.</summary>
        Encrypted = 16384
    }
}
