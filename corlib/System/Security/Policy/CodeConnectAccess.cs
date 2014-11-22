using System.Runtime.InteropServices;

namespace System.Security.Policy
{
    /// <summary>Specifies the network resource access that is granted to code.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class CodeConnectAccess
    {
        /// <summary>Contains the value used to represent the default port.</summary>
        public static readonly int DefaultPort;
        /// <summary>Contains the value used to represent the port value in the URI where code originated.</summary>
        public static readonly int OriginPort;
        /// <summary>Contains the value used to represent the scheme in the URL where the code originated.</summary>
        public static readonly string OriginScheme;
        /// <summary>Contains the string value that represents the scheme wildcard.</summary>
        public static readonly string AnyScheme;
    
        /// <summary>Gets the URI scheme represented by the current instance.</summary><returns>A <see cref="T:System.String" /> that identifies a URI scheme, converted to lowercase.</returns>
        public string Scheme
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the port represented by the current instance.</summary><returns>A <see cref="T:System.Int32" /> value that identifies a computer port used in conjunction with the <see cref="P:System.Security.Policy.CodeConnectAccess.Scheme" /> property.</returns>
        public int Port
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.CodeConnectAccess" /> class. </summary><param name="allowScheme">The URI scheme represented by the current instance.</param><param name="allowPort">The port represented by the current instance.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="allowScheme" /> is null.-or-<paramref name="allowScheme" /> is an empty string ("").-or-<paramref name="allowScheme" /> contains characters that are not permitted in schemes.-or-<paramref name="allowPort" /> is less than 0.-or-<paramref name="allowPort" /> is greater than 65,535.</exception>
        public CodeConnectAccess(string allowScheme, int allowPort)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.Security.Policy.CodeConnectAccess" /> instance that represents access to the specified port using the code's scheme of origin.</summary><returns>A <see cref="T:System.Security.Policy.CodeConnectAccess" /> instance for the specified port.</returns><param name="allowPort">The port represented by the returned instance.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="allowPort" /> is less than 0.-or-<paramref name="allowPort" /> is greater than 65,535.</exception>
        public static CodeConnectAccess CreateOriginSchemeAccess(int allowPort)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.Security.Policy.CodeConnectAccess" /> instance that represents access to the specified port using any scheme.</summary><returns>A <see cref="T:System.Security.Policy.CodeConnectAccess" /> instance for the specified port.</returns><param name="allowPort">The port represented by the returned instance.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="allowPort" /> is less than 0.-or-<paramref name="allowPort" /> is greater than 65,535.</exception>
        public static CodeConnectAccess CreateAnySchemeAccess(int allowPort)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether two <see cref="T:System.Security.Policy.CodeConnectAccess" /> objects represent the same scheme and port.</summary><returns>true if the two objects represent the same scheme and port; otherwise, false.</returns><param name="o">The object to compare to the current <see cref="T:System.Security.Policy.CodeConnectAccess" /> object.</param>
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
