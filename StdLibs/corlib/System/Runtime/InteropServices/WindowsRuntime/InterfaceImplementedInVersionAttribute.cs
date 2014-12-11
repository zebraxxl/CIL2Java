using System;

namespace System.Runtime.InteropServices.WindowsRuntime
{
    /// <summary>Specifies the version of the target type that first implemented the specified interface.</summary>
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Interface, Inherited = false, AllowMultiple = true)]
    public sealed class InterfaceImplementedInVersionAttribute : Attribute
    {
    
        /// <summary>Gets the type of the interface that the target type implements. </summary><returns>The type of the interface. </returns>
        public Type InterfaceType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the major component of the version of the target type that first implemented the interface. </summary><returns>The major component of the version.</returns>
        public byte MajorVersion
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the minor component of the version of the target type that first implemented the interface. </summary><returns>The minor component of the version. </returns>
        public byte MinorVersion
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the build component of the version of the target type that first implemented the interface. </summary><returns>The build component of the version.</returns>
        public byte BuildVersion
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the revision component of the version of the target type that first implemented the interface. </summary><returns>The revision component of the version.</returns>
        public byte RevisionVersion
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.WindowsRuntime.InterfaceImplementedInVersionAttribute" /> class, specifying the interface that the target type implements and the version in which that interface was first implemented. </summary><param name="interfaceType">The interface that was first implemented in the specified version of the target type. </param><param name="majorVersion">The major component of the version of the target type that first implemented <paramref name="interfaceType" />.</param><param name="minorVersion">The minor component of the version of the target type that first implemented <paramref name="interfaceType" />.</param><param name="buildVersion">The build component of the version of the target type that first implemented <paramref name="interfaceType" />.</param><param name="revisionVersion">The revision component of the version of the target type that first implemented <paramref name="interfaceType" />.</param>
        public InterfaceImplementedInVersionAttribute(Type interfaceType, byte majorVersion, byte minorVersion, byte buildVersion, byte revisionVersion)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
