using System.Reflection.Emit;
using System.Reflection;
using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Provides a set of services that convert a managed assembly to a COM type library and vice versa.</summary>
    [ComVisibleAttribute(true)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [GuidAttribute("F1C3BF78-C3E4-11d3-88E7-00902754C43A")]
    public interface ITypeLibConverter
    {
        /// <summary>Converts a COM type library to an assembly.</summary><returns>An <see cref="T:System.Reflection.Emit.AssemblyBuilder" /> object containing the converted type library.</returns><param name="typeLib">The object that implements the ITypeLib interface. </param><param name="asmFileName">The file name of the resulting assembly. </param><param name="flags">A <see cref="T:System.Runtime.InteropServices.TypeLibImporterFlags" /> value indicating any special settings. </param><param name="notifySink"><see cref="T:System.Runtime.InteropServices.ITypeLibImporterNotifySink" /> interface implemented by the caller. </param><param name="publicKey">A byte array containing the public key. </param><param name="keyPair">A <see cref="T:System.Reflection.StrongNameKeyPair" /> object containing the public and private cryptographic key pair. </param><param name="asmNamespace">The namespace for the resulting assembly. </param><param name="asmVersion">The version of the resulting assembly. If null, the version of the type library is used. </param>
        AssemblyBuilder ConvertTypeLibToAssembly(object typeLib, string asmFileName, TypeLibImporterFlags flags, ITypeLibImporterNotifySink notifySink, byte[] publicKey, StrongNameKeyPair keyPair, string asmNamespace, Version asmVersion);
        
        
        /// <summary>Converts an assembly to a COM type library.</summary><returns>An object that implements the ITypeLib interface.</returns><param name="assembly">The assembly to convert. </param><param name="typeLibName">The file name of the resulting type library. </param><param name="flags">A <see cref="T:System.Runtime.InteropServices.TypeLibExporterFlags" /> value indicating any special settings. </param><param name="notifySink">The <see cref="T:System.Runtime.InteropServices.ITypeLibExporterNotifySink" /> interface implemented by the caller. </param>
        object ConvertAssemblyToTypeLib(Assembly assembly, string typeLibName, TypeLibExporterFlags flags, ITypeLibExporterNotifySink notifySink);
        
        
        bool GetPrimaryInteropAssembly(Guid g, int major, int minor, int lcid, ref string asmName, ref string asmCodeBase);
        
        
        /// <summary>Converts a COM type library to an assembly.</summary><returns>An <see cref="T:System.Reflection.Emit.AssemblyBuilder" /> object containing the converted type library.</returns><param name="typeLib">The object that implements the ITypeLib interface. </param><param name="asmFileName">The file name of the resulting assembly. </param><param name="flags">A <see cref="T:System.Runtime.InteropServices.TypeLibImporterFlags" /> value indicating any special settings. </param><param name="notifySink"><see cref="T:System.Runtime.InteropServices.ITypeLibImporterNotifySink" /> interface implemented by the caller. </param><param name="publicKey">A byte array containing the public key. </param><param name="keyPair">A <see cref="T:System.Reflection.StrongNameKeyPair" /> object containing the public and private cryptographic key pair. </param><param name="unsafeInterfaces">If true, the interfaces require link time checks for <see cref="F:System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode" /> permission. If false, the interfaces require run time checks that require a stack walk and are more expensive, but help provide greater protection. </param>
        AssemblyBuilder ConvertTypeLibToAssembly(object typeLib, string asmFileName, int flags, ITypeLibImporterNotifySink notifySink, byte[] publicKey, StrongNameKeyPair keyPair, bool unsafeInterfaces);
        
        
    }
}
