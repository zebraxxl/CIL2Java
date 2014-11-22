using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Describes the callbacks that the type library importer makes when importing a type library.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum ImporterEventKind : int
    {
        /// <summary>Specifies that the event is invoked when a type has been imported.</summary>
        NOTIF_TYPECONVERTED = 0,
        /// <summary>Specifies that the event is invoked when a warning occurs during conversion.</summary>
        NOTIF_CONVERTWARNING = 1,
        /// <summary>This property is not supported in this version of the .NET Framework.</summary>
        ERROR_REFTOINVALIDTYPELIB = 2
    }
}
