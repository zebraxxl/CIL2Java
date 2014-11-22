using System.Security;

namespace System.Runtime.Remoting.Channels
{
    /// <summary>The <see cref="T:System.Runtime.Remoting.Channels.ISecurableChannel" /> contains one property, <see cref="P:System.Runtime.Remoting.Channels.ISecurableChannel.IsSecured" />, which gets or sets a Boolean value that indicates whether the current channel is secure.</summary>
    public interface ISecurableChannel
    {
        /// <summary>Gets or sets a Boolean value that indicates whether the current channel is secure.</summary><returns>A Boolean value that indicates whether the current channel is secure.</returns>
        bool IsSecured
        {
            get;
            set;
        }
    
    
    }
}
