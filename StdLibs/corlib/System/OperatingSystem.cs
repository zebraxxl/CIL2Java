using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
    /// <summary>Represents information about an operating system, such as the version and platform identifier. This class cannot be inherited.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class OperatingSystem : ICloneable, ISerializable
    {
    
        /// <summary>Gets a <see cref="T:System.PlatformID" /> enumeration value that identifies the operating system platform.</summary><returns>One of the <see cref="T:System.PlatformID" /> values.</returns><filterpriority>2</filterpriority>
        public PlatformID Platform
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the service pack version represented by this <see cref="T:System.OperatingSystem" /> object.</summary><returns>The service pack version, if service packs are supported and at least one is installed; otherwise, an empty string (""). </returns><filterpriority>2</filterpriority>
        public string ServicePack
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.Version" /> object that identifies the operating system.</summary><returns>A <see cref="T:System.Version" /> object that describes the major version, minor version, build, and revision numbers for the operating system.</returns><filterpriority>2</filterpriority>
        public Version Version
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the concatenated string representation of the platform identifier, version, and service pack that are currently installed on the operating system. </summary><returns>The string representation of the values returned by the <see cref="P:System.OperatingSystem.Platform" />, <see cref="P:System.OperatingSystem.Version" />, and <see cref="P:System.OperatingSystem.ServicePack" /> properties.</returns><filterpriority>2</filterpriority>
        public string VersionString
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.OperatingSystem" /> class, using the specified platform identifier value and version object.</summary><param name="platform">One of the <see cref="T:System.PlatformID" /> values that indicates the operating system platform. </param><param name="version">A <see cref="T:System.Version" /> object that indicates the version of the operating system. </param><exception cref="T:System.ArgumentNullException"><paramref name="version" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="platform" /> is not a <see cref="T:System.PlatformID" /> enumeration value.</exception>
        public OperatingSystem(PlatformID platform, Version version)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data necessary to deserialize this instance.</summary><param name="info">The object to populate with serialization information.</param><param name="context">The place to store and retrieve serialized data. Reserved for future use.</param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null. </exception><filterpriority>2</filterpriority>
        [SecurityCriticalAttribute()]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public object Clone()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
