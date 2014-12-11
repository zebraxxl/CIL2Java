using System.Runtime.InteropServices;

namespace System.Collections
{
    /// <summary>Exposes the enumerator, which supports a simple iteration over a non-generic collection.</summary><filterpriority>1</filterpriority>
    [GuidAttribute("496B0ABE-CDEE-11d3-88E8-00902754C43A")]
    [ComVisibleAttribute(true)]
    public interface IEnumerable
    {
        [DispIdAttribute(-4)]
        IEnumerator GetEnumerator();
        
        
    }
}
