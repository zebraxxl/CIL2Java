using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Contexts
{
    /// <summary>Represents the method that will handle the requests of execution of some code in another context.</summary>
    [ComVisibleAttribute(true)]
    public delegate void CrossContextDelegate();
}
