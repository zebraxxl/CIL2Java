using System.Collections;
using System.Linq.Expressions;
using System;

namespace System.Linq
{
    public interface IQueryable : IEnumerable
    {
        Expression Expression
        {
            get;
        }
    
        Type ElementType
        {
            get;
        }
    
        IQueryProvider Provider
        {
            get;
        }
    
    
    }
}
