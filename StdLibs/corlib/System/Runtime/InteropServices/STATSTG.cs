using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.STATSTG" /> instead.</summary>
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.STATSTG instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public struct STATSTG
    {
        /// <summary>Pointer to a null-terminated string containing the name of the object described by this structure.</summary>
        public string pwcsName;
        /// <summary>Indicates the type of storage object which is one of the values from the STGTY enumeration.</summary>
        public int type;
        /// <summary>Specifies the size in bytes of the stream or byte array.</summary>
        public long cbSize;
        /// <summary>Indicates the last modification time for this storage, stream, or byte array.</summary>
        public FILETIME mtime;
        /// <summary>Indicates the creation time for this storage, stream, or byte array.</summary>
        public FILETIME ctime;
        /// <summary>Indicates the last access time for this storage, stream or byte array </summary>
        public FILETIME atime;
        /// <summary>Indicates the access mode that was specified when the object was opened.</summary>
        public int grfMode;
        /// <summary>Indicates the types of region locking supported by the stream or byte array.</summary>
        public int grfLocksSupported;
        /// <summary>Indicates the class identifier for the storage object.</summary>
        public Guid clsid;
        /// <summary>Indicates the current state bits of the storage object (the value most recently set by the IStorage::SetStateBits method).</summary>
        public int grfStateBits;
        /// <summary>Reserved for future use.</summary>
        public int reserved;
    
    }
}
