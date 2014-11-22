using System.Runtime.InteropServices;
using System.Security.Policy;
using System;

namespace System.Runtime.Hosting
{
    /// <summary>Provides data for manifest-based activation of an application. This class cannot be inherited. </summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class ActivationArguments : EvidenceBase
    {
    
        /// <summary>Gets the application identity for a manifest-activated application.</summary><returns>An object that identifies an application for manifest-based activation.</returns>
        public ApplicationIdentity ApplicationIdentity
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the activation context for manifest-based activation of an application.</summary><returns>An object that identifies a manifest-based activation application.</returns>
        public ActivationContext ActivationContext
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets activation data from the host.</summary><returns>An array of strings containing host-provided activation data.</returns>
        public string[] ActivationData
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Hosting.ActivationArguments" /> class with the specified application identity.</summary><param name="applicationIdentity">An object that identifies the manifest-based activation application.</param><exception cref="T:System.ArgumentNullException"><paramref name="applicationIdentity" /> is null.</exception>
        public ActivationArguments(ApplicationIdentity applicationIdentity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Hosting.ActivationArguments" /> class with the specified application identity and activation data.</summary><param name="applicationIdentity">An object that identifies the manifest-based activation application.</param><param name="activationData">An array of strings containing host-provided activation data.</param><exception cref="T:System.ArgumentNullException"><paramref name="applicationIdentity" /> is null.</exception>
        public ActivationArguments(ApplicationIdentity applicationIdentity, string[] activationData)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Hosting.ActivationArguments" /> class with the specified activation context. </summary><param name="activationData">An object that identifies the manifest-based activation application.</param><exception cref="T:System.ArgumentNullException"><paramref name="activationData" /> is null.</exception>
        public ActivationArguments(ActivationContext activationData)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Hosting.ActivationArguments" /> class with the specified activation context and activation data.</summary><param name="activationContext">An object that identifies the manifest-based activation application.</param><param name="activationData">An array of strings containing host-provided activation data.</param><exception cref="T:System.ArgumentNullException"><paramref name="activationContext" /> is null.</exception>
        public ActivationArguments(ActivationContext activationContext, string[] activationData)
        {
             throw new NotImplementedException();
        }
        
        
        public override EvidenceBase Clone()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
