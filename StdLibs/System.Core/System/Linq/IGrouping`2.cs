using System.Collections.Generic;

namespace System.Linq
{
    public interface IGrouping<TKey, TElement> : IEnumerable<TElement>
    {
        TKey Key
        {
            get;
        }
    
    
    }
}
