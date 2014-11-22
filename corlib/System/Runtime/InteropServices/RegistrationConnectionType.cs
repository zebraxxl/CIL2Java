using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Defines the types of connections to a class object.</summary>
    [FlagsAttribute()]
    public enum RegistrationConnectionType : int
    {
        /// <summary>Once an application is connected to a class object with CoGetClassObject, the class object is removed from public view so that no other applications can connect to it. This value is commonly used for single document interface (SDI) applications.</summary>
        SingleUse = 0,
        /// <summary>Multiple applications can connect to the class object through calls to CoGetClassObject.</summary>
        MultipleUse = 1,
        /// <summary>Registers separate CLSCTX_LOCAL_SERVER and CLSCTX_INPROC_SERVER class factories.</summary>
        MultiSeparate = 2,
        /// <summary>Suspends registration and activation requests for the specified CLSID until there is a call to CoResumeClassObjects.</summary>
        Suspended = 4,
        /// <summary>The class object is a surrogate process used to run DLL servers.</summary>
        Surrogate = 8
    }
}
