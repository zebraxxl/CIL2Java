using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Represents the method that handles the <see cref="E:System.AppDomain.AssemblyLoad" /> event of an <see cref="T:System.AppDomain" />.</summary><param name="sender">The source of the event. </param><param name="args">An <see cref="T:System.AssemblyLoadEventArgs" /> that contains the event data. </param><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public delegate void AssemblyLoadEventHandler(object sender, AssemblyLoadEventArgs args);
}
