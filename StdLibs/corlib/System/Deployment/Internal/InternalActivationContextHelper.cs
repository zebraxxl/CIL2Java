using System.Runtime.InteropServices;
using System.Security;
using System;

namespace System.Deployment.Internal
{
    /// <summary>Provides access to data from an <see cref="T:System.ActivationContext" /> object.</summary>
    [ComVisibleAttribute(false)]
    public static class InternalActivationContextHelper
    {
        /// <summary>Gets the contents of the application manifest from an <see cref="T:System.ActivationContext" /> object.</summary><returns>The application manifest that is contained by the <see cref="T:System.ActivationContext" /> object.</returns><param name="appInfo">The object containing the manifest.</param>
        [SecuritySafeCriticalAttribute()]
        public static object GetActivationContextData(ActivationContext appInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the manifest of the last deployment component in an <see cref="T:System.ActivationContext" /> object.</summary><returns>The manifest of the last deployment component in the <see cref="T:System.ActivationContext" /> object.</returns><param name="appInfo">The object containing the manifest.</param>
        [SecuritySafeCriticalAttribute()]
        public static object GetApplicationComponentManifest(ActivationContext appInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the manifest of the first deployment component in an <see cref="T:System.ActivationContext" /> object.</summary><returns>The manifest of the first deployment component in the <see cref="T:System.ActivationContext" /> object.</returns><param name="appInfo">The object containing the manifest.</param>
        [SecuritySafeCriticalAttribute()]
        public static object GetDeploymentComponentManifest(ActivationContext appInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Informs an <see cref="T:System.ActivationContext" /> to get ready to be run.</summary><param name="appInfo">The object to inform.</param>
        public static void PrepareForExecution(ActivationContext appInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a value indicating whether this is the first time this <see cref="T:System.ActivationContext" /> object has been run.</summary><returns>true if the <see cref="T:System.ActivationContext" /> indicates it is running for the first time; otherwise, false.</returns><param name="appInfo">The object to examine.</param>
        public static bool IsFirstRun(ActivationContext appInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a byte array containing the raw content of the application manifest..</summary><returns>An array containing the application manifest as raw data.</returns><param name="appInfo">The object to get bytes from.</param>
        public static byte[] GetApplicationManifestBytes(ActivationContext appInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a byte array containing the raw content of the deployment manifest.</summary><returns>An array containing the deployment manifest as raw data.</returns><param name="appInfo">The object to get bytes from.</param>
        public static byte[] GetDeploymentManifestBytes(ActivationContext appInfo)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
