using System.Runtime.InteropServices;

namespace System.Collections
{
    /// <summary>Supports a simple iteration over a nongeneric collection.</summary><filterpriority>1</filterpriority>
    [GuidAttribute("496B0ABF-CDEE-11d3-88E8-00902754C43A")]
    [ComVisibleAttribute(true)]
    public interface IEnumerator
    {
        /// <summary>Gets the current element in the collection.</summary><returns>The current element in the collection.</returns><filterpriority>2</filterpriority>
        object Current
        {
            get;
        }
    
    
        bool MoveNext();
        
        
        void Reset();
        
        
    }
}
