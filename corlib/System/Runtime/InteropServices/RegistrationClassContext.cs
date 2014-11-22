using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Specifies the set of execution contexts in which a class object will be made available for requests to construct instances.</summary>
    [FlagsAttribute()]
    public enum RegistrationClassContext : int
    {
        /// <summary>The code that creates and manages objects of this class is a DLL that runs in the same process as the caller of the function specifying the class context.</summary>
        InProcessServer = 1,
        /// <summary>The code that manages objects of this class is an in-process handler.</summary>
        InProcessHandler = 2,
        /// <summary>The EXE code that creates and manages objects of this class runs on same machine but is loaded in a separate process space.</summary>
        LocalServer = 4,
        /// <summary>Not used.</summary>
        InProcessServer16 = 8,
        /// <summary>A remote machine context.</summary>
        RemoteServer = 16,
        /// <summary>Not used.</summary>
        InProcessHandler16 = 32,
        /// <summary>Not used.</summary>
        Reserved1 = 64,
        /// <summary>Not used.</summary>
        Reserved2 = 128,
        /// <summary>Not used.</summary>
        Reserved3 = 256,
        /// <summary>Not used.</summary>
        Reserved4 = 512,
        /// <summary>Disallows the downloading of code from the Directory Service or the Internet.</summary>
        NoCodeDownload = 1024,
        /// <summary>Not used.</summary>
        Reserved5 = 2048,
        /// <summary>Specifies whether activation fails if it uses custom marshaling.</summary>
        NoCustomMarshal = 4096,
        /// <summary>Allows the downloading of code from the Directory Service or the Internet.</summary>
        EnableCodeDownload = 8192,
        /// <summary>Overrides the logging of failures.</summary>
        NoFailureLog = 16384,
        /// <summary>Disables activate-as-activator (AAA) activations for this activation only.</summary>
        DisableActivateAsActivator = 32768,
        /// <summary>Enables activate-as-activator (AAA) activations for this activation only.</summary>
        EnableActivateAsActivator = 65536,
        /// <summary>Begin this activation from the default context of the current apartment.</summary>
        FromDefaultContext = 131072
    }
}
