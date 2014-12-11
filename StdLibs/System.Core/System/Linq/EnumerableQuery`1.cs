using System.Linq.Expressions;
using System.Collections;
using System;
using System.Collections.Generic;

namespace System.Linq
{
    public class EnumerableQuery<T> : EnumerableQuery, IOrderedQueryable<T>, IQueryProvider
    {
    
    
        public EnumerableQuery(IEnumerable<T> enumerable)
        {
             throw new NotImplementedException();
        }
        
        
        public EnumerableQuery(Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }



        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        Expression IQueryable.Expression
        {
            get { throw new NotImplementedException(); }
        }

        Type IQueryable.ElementType
        {
            get { throw new NotImplementedException(); }
        }

        IQueryProvider IQueryable.Provider
        {
            get { throw new NotImplementedException(); }
        }

        IQueryable IQueryProvider.CreateQuery(Expression expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<TElement> IQueryProvider.CreateQuery<TElement>(Expression expression)
        {
            throw new NotImplementedException();
        }

        object IQueryProvider.Execute(Expression expression)
        {
            throw new NotImplementedException();
        }

        TResult IQueryProvider.Execute<TResult>(Expression expression)
        {
            throw new NotImplementedException();
        }
    }
}
