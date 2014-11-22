using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Contains information used to uniquely identify a manifest-based application. This class cannot be inherited.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class ApplicationId
    {
    
        /// <summary>Gets the public key token for the application.</summary><returns>A byte array containing the public key token for the application.</returns><filterpriority>2</filterpriority>
        public byte[] PublicKeyToken
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the application.</summary><returns>The name of the application.</returns><filterpriority>2</filterpriority>
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the version of the application.</summary><returns>A <see cref="T:System.Version" /> that specifies the version of the application.</returns><filterpriority>2</filterpriority>
        public Version Version
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the target processor architecture for the application.</summary><returns>The processor architecture of the application.</returns><filterpriority>2</filterpriority>
        public string ProcessorArchitecture
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a string representing the culture information for the application.</summary><returns>The culture information for the application.</returns><filterpriority>2</filterpriority>
        public string Culture
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.ApplicationId" /> class.</summary><param name="publicKeyToken">The array of bytes representing the raw public key data. </param><param name="name">The name of the application. </param><param name="version">A <see cref="T:System.Version" /> object that specifies the version of the application. </param><param name="processorArchitecture">The processor architecture of the application. </param><param name="culture">The culture of the application. </param><exception cref="T:System.ArgumentNullException"><paramref name="name " />is null.-or-<paramref name="version " />is null.-or-<paramref name="publicKeyToken " />is null.</exception><exception cref="T:System.ArgumentException"><paramref name="name " />is an empty string.</exception>
        public ApplicationId(byte[] publicKeyToken, string name, Version version, string processorArchitecture, string culture)
        {
             throw new NotImplementedException();
        }
        
        
        public ApplicationId Copy()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified <see cref="T:System.ApplicationId" /> object is equivalent to the current <see cref="T:System.ApplicationId" />.</summary><returns>true if the specified <see cref="T:System.ApplicationId" /> object is equivalent to the current <see cref="T:System.ApplicationId" />; otherwise, false.</returns><param name="o">The <see cref="T:System.ApplicationId" /> object to compare to the current <see cref="T:System.ApplicationId" />. </param><filterpriority>2</filterpriority>
        public override bool Equals(object o)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
