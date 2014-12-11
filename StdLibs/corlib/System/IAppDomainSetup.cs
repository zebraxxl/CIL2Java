using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Represents assembly binding information that can be added to an instance of <see cref="T:System.AppDomain" />.</summary><filterpriority>2</filterpriority>
    [GuidAttribute("27FFF232-A7A8-40dd-8D4A-734AD59FCD41")]
    [ComVisibleAttribute(true)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAppDomainSetup
    {
        /// <summary>Gets or sets the name of the directory containing the application.</summary><returns>A <see cref="T:System.String" /> containg the name of the application base directory.</returns><filterpriority>2</filterpriority>
        string ApplicationBase
        {
            get;
            set;
        }
    
        /// <summary>Gets or sets the name of the application.</summary><returns>A <see cref="T:System.String" /> that is the name of the application.</returns><filterpriority>2</filterpriority>
        string ApplicationName
        {
            get;
            set;
        }
    
        /// <summary>Gets and sets the name of an area specific to the application where files are shadow copied.</summary><returns>A <see cref="T:System.String" /> that is the fully-qualified name of the directory path and file name where files are shadow copied.</returns><filterpriority>2</filterpriority>
        string CachePath
        {
            get;
            set;
        }
    
        /// <summary>Gets and sets the name of the configuration file for an application domain.</summary><returns>A <see cref="T:System.String" /> that specifies the name of the configuration file.</returns><filterpriority>2</filterpriority>
        string ConfigurationFile
        {
            get;
            set;
        }
    
        /// <summary>Gets or sets the directory where dynamically generated files are stored and accessed.</summary><returns>A <see cref="T:System.String" /> that specifies the directory containing dynamic assemblies.</returns><filterpriority>2</filterpriority>
        string DynamicBase
        {
            get;
            set;
        }
    
        /// <summary>Gets or sets the location of the license file associated with this domain.</summary><returns>A <see cref="T:System.String" /> that specifies the name of the license file.</returns><filterpriority>2</filterpriority>
        string LicenseFile
        {
            get;
            set;
        }
    
        /// <summary>Gets or sets the list of directories that is combined with the <see cref="P:System.AppDomainSetup.ApplicationBase" /> directory to probe for private assemblies.</summary><returns>A <see cref="T:System.String" /> containing a list of directory names, where each name is separated by a semicolon.</returns><filterpriority>2</filterpriority>
        string PrivateBinPath
        {
            get;
            set;
        }
    
        /// <summary>Gets or sets the private binary directory path used to locate an application.</summary><returns>A <see cref="T:System.String" /> containing a list of directory names, where each name is separated by a semicolon.</returns><filterpriority>2</filterpriority>
        string PrivateBinPathProbe
        {
            get;
            set;
        }
    
        /// <summary>Gets or sets the names of the directories containing assemblies to be shadow copied.</summary><returns>A <see cref="T:System.String" /> containing a list of directory names, where each name is separated by a semicolon.</returns><filterpriority>2</filterpriority>
        string ShadowCopyDirectories
        {
            get;
            set;
        }
    
        /// <summary>Gets or sets a string that indicates whether shadow copying is turned on or off.</summary><returns>A <see cref="T:System.String" /> containing the value "true" to indicate that shadow copying is turned on; or "false" to indicate that shadow copying is turned off.</returns><filterpriority>2</filterpriority>
        string ShadowCopyFiles
        {
            get;
            set;
        }
    
    
    }
}
