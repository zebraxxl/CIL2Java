using System.Runtime.InteropServices;
using System;

namespace System.Security.Permissions
{
    /// <summary>Specifies categories of functionality potentially harmful to the host if invoked by a method or class.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [FlagsAttribute()]
    public enum HostProtectionResource : int
    {
        /// <summary>Exposes no host resources.</summary>
        None = 0,
        /// <summary>Exposes synchronization.</summary>
        Synchronization = 1,
        /// <summary>Exposes state that might be shared between threads.</summary>
        SharedState = 2,
        /// <summary>Might create or destroy other processes.</summary>
        ExternalProcessMgmt = 4,
        /// <summary>Might exit the current process, terminating the server.</summary>
        SelfAffectingProcessMgmt = 8,
        /// <summary>Creates or manipulates threads other than its own, which might be harmful to the host.</summary>
        ExternalThreading = 16,
        /// <summary>Manipulates threads in a way that only affects user code.</summary>
        SelfAffectingThreading = 32,
        /// <summary>Exposes the security infrastructure.</summary>
        SecurityInfrastructure = 64,
        /// <summary>Exposes the user interface.</summary>
        UI = 128,
        /// <summary>Might cause a resource leak on termination, if not protected by a safe handle or some other means of ensuring the release of resources.</summary>
        MayLeakOnAbort = 256,
        /// <summary>Exposes all host resources.</summary>
        All = 511
    }
}
