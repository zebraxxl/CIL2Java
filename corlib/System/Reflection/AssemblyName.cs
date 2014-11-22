using System.Runtime.InteropServices;
using System;
using System.Runtime.Serialization;
using System.Globalization;
using System.Configuration.Assemblies;
using System.Security;

namespace System.Reflection
{
    /// <summary>Describes an assembly's unique identity in full.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComDefaultInterfaceAttribute(typeof(_AssemblyName))]
    public sealed class AssemblyName : _AssemblyName, ICloneable, ISerializable, IDeserializationCallback
    {
    
        /// <summary>Gets or sets the simple name of the assembly. This is usually, but not necessarily, the file name of the manifest file of the assembly, minus its extension.</summary><returns>The simple name of the assembly.</returns>
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the major, minor, build, and revision numbers of the assembly.</summary><returns>An object that represents the major, minor, build, and revision numbers of the assembly.</returns>
        public Version Version
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the culture supported by the assembly.</summary><returns>An object that represents the culture supported by the assembly.</returns>
        public CultureInfo CultureInfo
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the name of the culture associated with the assembly.</summary><returns>The culture name.</returns>
        public string CultureName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the location of the assembly as a URL.</summary><returns>A string that is the URL location of the assembly. </returns>
        public string CodeBase
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the URI, including escape characters, that represents the codebase.</summary><returns>A URI with escape characters.</returns>
        public string EscapedCodeBase
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value that identifies the processor and bits-per-word of the platform targeted by an executable.</summary><returns>One of the enumeration values that identifies the processor and bits-per-word of the platform targeted by an executable.</returns>
        public ProcessorArchitecture ProcessorArchitecture
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value that indicates what type of content the assembly contains.</summary><returns>A value that indicates what type of content the assembly contains.</returns>
        [ComVisibleAttribute(false)]
        public AssemblyContentType ContentType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the attributes of the assembly.</summary><returns>A value that represents the attributes of the assembly.</returns>
        public AssemblyNameFlags Flags
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the hash algorithm used by the assembly manifest.</summary><returns>The hash algorithm used by the assembly manifest.</returns>
        public AssemblyHashAlgorithm HashAlgorithm
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the information related to the assembly's compatibility with other assemblies.</summary><returns>A value that represents information about the assembly's compatibility with other assemblies.</returns>
        public AssemblyVersionCompatibility VersionCompatibility
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the public and private cryptographic key pair that is used to create a strong name signature for the assembly.</summary><returns>The public and private cryptographic key pair to be used to create a strong name for the assembly.</returns>
        public StrongNameKeyPair KeyPair
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the full name of the assembly, also known as the display name.</summary><returns>A string that is the full name of the assembly, also known as the display name.</returns>
        public string FullName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public AssemblyName()
        {
             throw new NotImplementedException();
        }
        
        
        public object Clone()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the <see cref="T:System.Reflection.AssemblyName" /> for a given file.</summary><returns>An object that represents the given assembly file.</returns><param name="assemblyFile">The path for the assembly whose <see cref="T:System.Reflection.AssemblyName" /> is to be returned. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyFile" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="assemblyFile" /> is invalid, such as an assembly with an invalid culture. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyFile" /> is not found. </exception><exception cref="T:System.Security.SecurityException">The caller does not have path discovery permission. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyFile" /> is not a valid assembly. </exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different sets of evidence. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static AssemblyName GetAssemblyName(string assemblyFile)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] GetPublicKey()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the public key identifying the assembly.</summary><param name="publicKey">A byte array containing the public key of the assembly. </param>
        public void SetPublicKey(byte[] publicKey)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public byte[] GetPublicKeyToken()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the public key token, which is the last 8 bytes of the SHA-1 hash of the public key under which the application or assembly is signed.</summary><param name="publicKeyToken">A byte array containing the public key token of the assembly. </param>
        public void SetPublicKeyToken(byte[] publicKeyToken)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets serialization information with all the data needed to recreate an instance of this AssemblyName.</summary><param name="info">The object to be populated with serialization information. </param><param name="context">The destination context of the serialization. </param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null. </exception>
        [SecurityCriticalAttribute()]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and is called back by the deserialization event when deserialization is complete.</summary><param name="sender">The source of the deserialization event. </param>
        public void OnDeserialization(object sender)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyName" /> class with the specified display name.</summary><param name="assemblyName">The display name of the assembly, as returned by the <see cref="P:System.Reflection.AssemblyName.FullName" /> property.</param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyName" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="assemblyName" /> is a zero length string.</exception><exception cref="T:System.IO.FileLoadException">The referenced assembly could not be found, or could not be loaded.</exception>
        [SecuritySafeCriticalAttribute()]
        public AssemblyName(string assemblyName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether the loader resolves two assembly names to the same assembly.</summary><returns>true if the loader resolves <paramref name="definition" /> to the same assembly as <paramref name="reference" />; otherwise, false.</returns><param name="reference">The reference assembly name.</param><param name="definition">The assembly name that is compared to the reference assembly.</param>
        [SecuritySafeCriticalAttribute()]
        public static bool ReferenceMatchesDefinition(AssemblyName reference, AssemblyName definition)
        {
             throw new NotImplementedException();
        }



        void _AssemblyName.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _AssemblyName.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _AssemblyName.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _AssemblyName.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }
    }
}
