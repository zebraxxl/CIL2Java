using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Describes the callbacks that the type library exporter makes when exporting a type library.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum ExporterEventKind : int
    {
        /// <summary>Specifies that the event is invoked when a type has been exported.</summary>
        NOTIF_TYPECONVERTED = 0,
        /// <summary>Specifies that the event is invoked when a warning occurs during conversion.</summary>
        NOTIF_CONVERTWARNING = 1,
        /// <summary>This value is not supported in this version of the .NET Framework.</summary>
        ERROR_REFTOINVALIDASSEMBLY = 2
    }
}
