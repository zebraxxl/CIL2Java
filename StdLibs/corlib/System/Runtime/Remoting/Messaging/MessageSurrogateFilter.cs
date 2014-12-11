using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
    /// <summary>Determines whether the <see cref="T:System.Runtime.Remoting.Messaging.RemotingSurrogateSelector" /> class should ignore a particular <see cref="T:System.Runtime.Remoting.Messaging.IMessage" /> property while creating an <see cref="T:System.Runtime.Remoting.ObjRef" /> for a <see cref="T:System.MarshalByRefObject" /> class.</summary><returns>True if the <see cref="T:System.Runtime.Remoting.Messaging.RemotingSurrogateSelector" /> class should ignore a particular <see cref="T:System.Runtime.Remoting.Messaging.IMessage" /> property while creating an <see cref="T:System.Runtime.Remoting.ObjRef" /> for a <see cref="T:System.MarshalByRefObject" /> class.</returns><param name="key">The key to a particular remoting message property.</param><param name="value">The value of a particular remoting message property.</param>
    [ComVisibleAttribute(true)]
    public delegate bool MessageSurrogateFilter(string key, object value);
}
