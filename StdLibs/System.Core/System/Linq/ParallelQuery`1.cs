using System.Collections.Generic;

namespace System.Linq
{
    public class ParallelQuery<TSource> : ParallelQuery, IEnumerable<TSource>
    {
        public virtual IEnumerator<TSource> GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
