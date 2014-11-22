using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Describes the exceptions that occur during IDispatch::Invoke.</summary>
    public struct EXCEPINFO
    {
        /// <summary>Represents an error code identifying the error.</summary>
        public short wCode;
        /// <summary>This field is reserved; it must be set to 0.</summary>
        public short wReserved;
        /// <summary>Indicates the name of the source of the exception. Typically, this is an application name.</summary>
        public string bstrSource;
        /// <summary>Describes the error intended for the customer.</summary>
        public string bstrDescription;
        /// <summary>Contains the fully-qualified drive, path, and file name of a Help file that contains more information about the error.</summary>
        public string bstrHelpFile;
        /// <summary>Indicates the Help context ID of the topic within the Help file.</summary>
        public int dwHelpContext;
        /// <summary>This field is reserved; it must be set to null.</summary>
        public IntPtr pvReserved;
        /// <summary>Represents a pointer to a function that takes an <see cref="T:System.Runtime.InteropServices.EXCEPINFO" /> structure as an argument and returns an HRESULT value. If deferred fill-in is not desired, this field is set to null.</summary>
        public IntPtr pfnDeferredFillIn;
        /// <summary>A return value describing the error.</summary>
        public int scode;
    
    }
}
