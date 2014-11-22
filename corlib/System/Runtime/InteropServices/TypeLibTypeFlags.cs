using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Describes the original settings of the <see cref="T:System.Runtime.InteropServices.TYPEFLAGS" /> in the COM type library from which the type was imported.</summary>
    [Serializable]
    [FlagsAttribute()]
    [ComVisibleAttribute(true)]
    public enum TypeLibTypeFlags : int
    {
        /// <summary>A type description that describes an Application object.</summary>
        FAppObject = 1,
        /// <summary>Instances of the type can be created by ITypeInfo::CreateInstance.</summary>
        FCanCreate = 2,
        /// <summary>The type is licensed.</summary>
        FLicensed = 4,
        /// <summary>The type is predefined. The client application should automatically create a single instance of the object that has this attribute. The name of the variable that points to the object is the same as the class name of the object.</summary>
        FPreDeclId = 8,
        /// <summary>The type should not be displayed to browsers.</summary>
        FHidden = 16,
        /// <summary>The type is a control from which other types will be derived, and should not be displayed to users.</summary>
        FControl = 32,
        /// <summary>The interface supplies both IDispatch and V-table binding.</summary>
        FDual = 64,
        /// <summary>The interface cannot add members at run time.</summary>
        FNonExtensible = 128,
        /// <summary>The types used in the interface are fully compatible with Automation, including vtable binding support.</summary>
        FOleAutomation = 256,
        /// <summary>This flag is intended for system-level types or types that type browsers should not display.</summary>
        FRestricted = 512,
        /// <summary>The class supports aggregation.</summary>
        FAggregatable = 1024,
        /// <summary>The object supports IConnectionPointWithDefault, and has default behaviors.</summary>
        FReplaceable = 2048,
        /// <summary>Indicates that the interface derives from IDispatch, either directly or indirectly.</summary>
        FDispatchable = 4096,
        /// <summary>Indicates base interfaces should be checked for name resolution before checking child interfaces. This is the reverse of the default behavior.</summary>
        FReverseBind = 8192
    }
}
