using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Supports cloning, which creates a new instance of a class with the same value as an existing instance.</summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public interface ICloneable : java.lang.Cloneable
    {
        object Clone();
        
        
    }
}
