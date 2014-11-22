using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Represents the callback method to invoke when the application domain is initialized.</summary><param name="args">An array of strings to pass as arguments to the callback method.</param><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public delegate void AppDomainInitializer(string[] args);
}
