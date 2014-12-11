using System.Collections.Generic;

namespace System.Linq
{
    public interface IQueryable<T> : IEnumerable<T>, IQueryable
    {
    }
}
