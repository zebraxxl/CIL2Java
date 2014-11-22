using System.Runtime.InteropServices;
using System;

namespace System.Security.Permissions
{
    /// <summary>Specifies access flags for the security permission object.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [FlagsAttribute()]
    public enum SecurityPermissionFlag : int
    {
        /// <summary>No security access.</summary>
        NoFlags = 0,
        /// <summary>Ability to assert that all this code's callers have the requisite permission for the operation.</summary>
        Assertion = 1,
        /// <summary>Ability to call unmanaged code.</summary>
        UnmanagedCode = 2,
        /// <summary>Ability to skip verification of code in this assembly. Code that is unverifiable can be run if this permission is granted.</summary>
        SkipVerification = 4,
        /// <summary>Permission for the code to run. Without this permission, managed code will not be executed.</summary>
        Execution = 8,
        /// <summary>Ability to use certain advanced operations on threads.</summary>
        ControlThread = 16,
        /// <summary>Ability to provide evidence, including the ability to alter the evidence provided by the common language runtime.</summary>
        ControlEvidence = 32,
        /// <summary>Ability to view and modify policy.</summary>
        ControlPolicy = 64,
        /// <summary>Ability to provide serialization services. Used by serialization formatters.</summary>
        SerializationFormatter = 128,
        /// <summary>Ability to specify domain policy.</summary>
        ControlDomainPolicy = 256,
        /// <summary>Ability to manipulate the principal object.</summary>
        ControlPrincipal = 512,
        /// <summary>Ability to create and manipulate an <see cref="T:System.AppDomain" />.</summary>
        ControlAppDomain = 1024,
        /// <summary>Permission to configure Remoting types and channels.</summary>
        RemotingConfiguration = 2048,
        /// <summary>Permission to plug code into the common language runtime infrastructure, such as adding Remoting Context Sinks, Envoy Sinks and Dynamic Sinks.</summary>
        Infrastructure = 4096,
        /// <summary>Permission to perform explicit binding redirection in the application configuration file. This includes redirection of .NET Framework assemblies that have been unified as well as other assemblies found outside the .NET Framework.</summary>
        BindingRedirects = 8192,
        /// <summary>The unrestricted state of the permission.</summary>
        AllFlags = 16383
    }
}
