using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
    /// <summary>Implements a base class that holds the configuration information used to activate an instance of a remote type.</summary>
    [ComVisibleAttribute(true)]
    public class TypeEntry
    {
    
        /// <summary>Gets the full type name of the object type configured to be a remote-activated type.</summary><returns>The full type name of the object type configured to be a remote-activated type.</returns>
        public string TypeName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the assembly name of the object type configured to be a remote-activated type.</summary><returns>The assembly name of the object type configured to be a remote-activated type.</returns>
        public string AssemblyName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        protected TypeEntry()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
