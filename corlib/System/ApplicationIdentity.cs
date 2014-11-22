using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
    /// <summary>Provides the ability to uniquely identify a manifest-activated application. This class cannot be inherited. </summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(false)]
    public sealed class ApplicationIdentity : ISerializable
    {
    
        /// <summary>Gets the full name of the application.</summary><returns>The full name of the application, also known as the display name.</returns><filterpriority>1</filterpriority>
        public string FullName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the location of the deployment manifest as a URL.</summary><returns>The URL of the deployment manifest.</returns><filterpriority>1</filterpriority>
        public string CodeBase
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.ApplicationIdentity" /> class. </summary><param name="applicationIdentityFullName">The full name of the application.</param><exception cref="T:System.ArgumentNullException"><paramref name="applicationIdentityFullName" /> is null.</exception>
        [SecuritySafeCriticalAttribute()]
        public ApplicationIdentity(string applicationIdentityFullName)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }



        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
