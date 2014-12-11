using System.Runtime.InteropServices;

namespace System.Security.Policy
{
    /// <summary>Provides the application directory as evidence for policy evaluation. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class ApplicationDirectory : EvidenceBase
    {
    
        /// <summary>Gets the path of the application directory.</summary><returns>The path of the application directory.</returns>
        public string Directory
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.ApplicationDirectory" /> class.</summary><param name="name">The path of the application directory. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception>
        public ApplicationDirectory(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether instances of the same type of an evidence object are equivalent.</summary><returns>true if the two instances are equivalent; otherwise, false.</returns><param name="o">An object of same type as the current evidence object. </param>
        public override bool Equals(object o)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override EvidenceBase Clone()
        {
             throw new NotImplementedException();
        }
        
        
        public object Copy()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
