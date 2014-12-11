using System.Collections.Generic;
using System.Collections;
using System.Linq.Expressions;
using System;

namespace System.Linq
{
    public static class Queryable
    {
        public static IQueryable<TElement> AsQueryable<TElement>(this IEnumerable<TElement> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable AsQueryable(this IEnumerable source)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TSource> Where<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TSource> Where<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int, bool>> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TResult> OfType<TResult>(this IQueryable source)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TResult> Cast<TResult>(this IQueryable source)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TResult> Select<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TResult> Select<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, int, TResult>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TResult> SelectMany<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, IEnumerable<TResult>>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TResult> SelectMany<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, int, IEnumerable<TResult>>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TResult> SelectMany<TSource, TCollection, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, int, IEnumerable<TCollection>>> collectionSelector, Expression<Func<TSource, TCollection, TResult>> resultSelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TResult> SelectMany<TSource, TCollection, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, IEnumerable<TCollection>>> collectionSelector, Expression<Func<TSource, TCollection, TResult>> resultSelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TResult> Join<TOuter, TInner, TKey, TResult>(this IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, TInner, TResult>> resultSelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TResult> Join<TOuter, TInner, TKey, TResult>(this IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, TInner, TResult>> resultSelector, IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, IEnumerable<TInner>, TResult>> resultSelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, IEnumerable<TInner>, TResult>> resultSelector, IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IOrderedQueryable<TSource> OrderBy<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IOrderedQueryable<TSource> OrderBy<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IOrderedQueryable<TSource> OrderByDescending<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IOrderedQueryable<TSource> OrderByDescending<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IOrderedQueryable<TSource> ThenBy<TSource, TKey>(this IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IOrderedQueryable<TSource> ThenBy<TSource, TKey>(this IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IOrderedQueryable<TSource> ThenByDescending<TSource, TKey>(this IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IOrderedQueryable<TSource> ThenByDescending<TSource, TKey>(this IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TSource> Take<TSource>(this IQueryable<TSource> source, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TSource> TakeWhile<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TSource> TakeWhile<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int, bool>> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TSource> Skip<TSource>(this IQueryable<TSource> source, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TSource> SkipWhile<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TSource> SkipWhile<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int, bool>> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector, IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector, Expression<Func<TKey, IEnumerable<TElement>, TResult>> resultSelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TResult> GroupBy<TSource, TKey, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TKey, IEnumerable<TSource>, TResult>> resultSelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TResult> GroupBy<TSource, TKey, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TKey, IEnumerable<TSource>, TResult>> resultSelector, IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector, Expression<Func<TKey, IEnumerable<TElement>, TResult>> resultSelector, IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TSource> Distinct<TSource>(this IQueryable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TSource> Distinct<TSource>(this IQueryable<TSource> source, IEqualityComparer<TSource> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TSource> Concat<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TResult> Zip<TFirst, TSecond, TResult>(this IQueryable<TFirst> source1, IEnumerable<TSecond> source2, Expression<Func<TFirst, TSecond, TResult>> resultSelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TSource> Union<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TSource> Union<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TSource> Intersect<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TSource> Intersect<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TSource> Except<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TSource> Except<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource First<TSource>(this IQueryable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource First<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource FirstOrDefault<TSource>(this IQueryable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource FirstOrDefault<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource Last<TSource>(this IQueryable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource Last<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource LastOrDefault<TSource>(this IQueryable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource LastOrDefault<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource Single<TSource>(this IQueryable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource Single<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource SingleOrDefault<TSource>(this IQueryable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource SingleOrDefault<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource ElementAt<TSource>(this IQueryable<TSource> source, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource ElementAtOrDefault<TSource>(this IQueryable<TSource> source, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TSource> DefaultIfEmpty<TSource>(this IQueryable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TSource> DefaultIfEmpty<TSource>(this IQueryable<TSource> source, TSource defaultValue)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool Contains<TSource>(this IQueryable<TSource> source, TSource item)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool Contains<TSource>(this IQueryable<TSource> source, TSource item, IEqualityComparer<TSource> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IQueryable<TSource> Reverse<TSource>(this IQueryable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool SequenceEqual<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool SequenceEqual<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool Any<TSource>(this IQueryable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool Any<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool All<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static int Count<TSource>(this IQueryable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static int Count<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static long LongCount<TSource>(this IQueryable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static long LongCount<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource Min<TSource>(this IQueryable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static TResult Min<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource Max<TSource>(this IQueryable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static TResult Max<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static int Sum(this IQueryable<int> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<int> Sum(this IQueryable<Nullable<int>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static long Sum(this IQueryable<long> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<long> Sum(this IQueryable<Nullable<long>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static float Sum(this IQueryable<float> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<float> Sum(this IQueryable<Nullable<float>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static double Sum(this IQueryable<double> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<double> Sum(this IQueryable<Nullable<double>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static decimal Sum(this IQueryable<decimal> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<decimal> Sum(this IQueryable<Nullable<decimal>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static int Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<int> Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, Nullable<int>>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static long Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<long> Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, Nullable<long>>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static float Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<float> Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, Nullable<float>>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static double Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<double> Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, Nullable<double>>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static decimal Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<decimal> Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, Nullable<decimal>>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static double Average(this IQueryable<int> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<double> Average(this IQueryable<Nullable<int>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static double Average(this IQueryable<long> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<double> Average(this IQueryable<Nullable<long>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static float Average(this IQueryable<float> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<float> Average(this IQueryable<Nullable<float>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static double Average(this IQueryable<double> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<double> Average(this IQueryable<Nullable<double>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static decimal Average(this IQueryable<decimal> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<decimal> Average(this IQueryable<Nullable<decimal>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static double Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<double> Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, Nullable<int>>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static float Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<float> Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, Nullable<float>>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static double Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<double> Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, Nullable<long>>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static double Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<double> Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, Nullable<double>>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static decimal Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<decimal> Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, Nullable<decimal>>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource Aggregate<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, TSource, TSource>> func)
        {
             throw new NotImplementedException();
        }
        
        
        public static TAccumulate Aggregate<TSource, TAccumulate>(this IQueryable<TSource> source, TAccumulate seed, Expression<Func<TAccumulate, TSource, TAccumulate>> func)
        {
             throw new NotImplementedException();
        }
        
        
        public static TResult Aggregate<TSource, TAccumulate, TResult>(this IQueryable<TSource> source, TAccumulate seed, Expression<Func<TAccumulate, TSource, TAccumulate>> func, Expression<Func<TAccumulate, TResult>> selector)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
