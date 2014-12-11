using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
    /// <summary>Identifies the activation context for the current application. This class cannot be inherited. </summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(false)]
    public sealed class ActivationContext : IDisposable, ISerializable
    {
        public enum ContextForm : int
        {
            Loose = 0,
            StoreBounded = 1
        }
    
    
        /// <summary>Gets the application identity for the current application.</summary><returns>An <see cref="T:System.ApplicationIdentity" /> object that identifies the current application.</returns><filterpriority>1</filterpriority>
        public ApplicationIdentity Identity
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the form, or store context, for the current application. </summary><returns>One of the enumeration values. </returns><filterpriority>1</filterpriority>
        public ContextForm Form
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the ClickOnce application manifest for the current application.</summary><returns>A byte array that contains the ClickOnce application manifest for the application that is associated with this <see cref="T:System.ActivationContext" />.</returns>
        public byte[] ApplicationManifestBytes
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the ClickOnce deployment manifest for the current application.</summary><returns>A byte array that contains the ClickOnce deployment manifest for the application that is associated with this <see cref="T:System.ActivationContext" />.</returns>
        public byte[] DeploymentManifestBytes
        {
            get { throw new NotImplementedException(); }
        }
    
    
        ~ActivationContext()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.ActivationContext" /> class using the specified application identity.</summary><returns>An object with the specified application identity.</returns><param name="identity">An object that identifies an application.</param><exception cref="T:System.ArgumentNullException"><paramref name="identity" /> is null. </exception><exception cref="T:System.ArgumentException">No deployment or application identity is specified in <paramref name="identity" />.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public static ActivationContext CreatePartialActivationContext(ApplicationIdentity identity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.ActivationContext" /> class using the specified application identity and array of manifest paths.</summary><returns>An object with the specified application identity and array of manifest paths.</returns><param name="identity">An object that identifies an application.</param><param name="manifestPaths">A string array of manifest paths for the application.</param><exception cref="T:System.ArgumentNullException"><paramref name="identity" /> is null. -or-<paramref name="manifestPaths" /> is null. </exception><exception cref="T:System.ArgumentException">No deployment or application identity is specified in <paramref name="identity" />.-or-<paramref name="identity" /> does not match the identity in the manifests.-or-<paramref name="identity" /> does not have the same number of components as the manifest paths.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public static ActivationContext CreatePartialActivationContext(ApplicationIdentity identity, string[] manifestPaths)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }



        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
