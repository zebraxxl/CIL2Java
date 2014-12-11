using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata
{
    /// <summary>Specifies the SOAP configuration options for use with the <see cref="T:System.Runtime.Remoting.Metadata.SoapTypeAttribute" /> class.</summary>
    [Serializable]
    [FlagsAttribute()]
    [ComVisibleAttribute(true)]
    public enum SoapOption : int
    {
        /// <summary>The default option indicating that no extra options are selected.</summary>
        None = 0,
        /// <summary>Indicates that type will always be included on SOAP elements. This option is useful when performing SOAP interop with SOAP implementations that require types on all elements.</summary>
        AlwaysIncludeTypes = 1,
        /// <summary>Indicates that the output SOAP string type in a SOAP Envelope is using the XSD prefix, and that the resulting XML does not have an ID attribute for the string.</summary>
        XsdString = 2,
        /// <summary>Indicates that SOAP will be generated without references. This option is currently not implemented.</summary>
        EmbedAll = 4,
        /// <summary>Public reserved option for temporary interop conditions; the use will change.</summary>
        Option1 = 8,
        /// <summary>Public reserved option for temporary interop conditions; the use will change.</summary>
        Option2 = 16
    }
}
