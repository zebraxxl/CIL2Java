using System.Collections.Generic;

namespace System.Linq
{
    public class OrderedParallelQuery<TSource> : ParallelQuery<TSource>
    {
    
    
        public override IEnumerator<TSource> GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
