using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System;
using System.Collections;

namespace System.Linq
{
    public static class Enumerable
    {
        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TResult>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TSource> Take<TSource>(this IEnumerable<TSource> source, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TSource> TakeWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TSource> TakeWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TSource> Skip<TSource>(this IEnumerable<TSource> source, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TSource> SkipWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TSource> SkipWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TSource> Intersect<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TSource> Intersect<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TSource> Reverse<TSource>(this IEnumerable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TSource> AsEnumerable<TSource>(this IEnumerable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this IEnumerable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this IEnumerable<TSource> source, TSource defaultValue)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TResult> OfType<TResult>(this IEnumerable source)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource First<TSource>(this IEnumerable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource First<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource Last<TSource>(this IEnumerable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource Last<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource Single<TSource>(this IEnumerable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource ElementAtOrDefault<TSource>(this IEnumerable<TSource> source, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<int> Range(int start, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TResult> Repeat<TResult>(TResult element, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<TResult> Empty<TResult>()
        {
             throw new NotImplementedException();
        }
        
        
        public static bool Any<TSource>(this IEnumerable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static int Count<TSource>(this IEnumerable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static long LongCount<TSource>(this IEnumerable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static long LongCount<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource Aggregate<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func)
        {
             throw new NotImplementedException();
        }
        
        
        public static TAccumulate Aggregate<TSource, TAccumulate>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
        {
             throw new NotImplementedException();
        }
        
        
        public static TResult Aggregate<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
        {
             throw new NotImplementedException();
        }
        
        
        public static int Sum(this IEnumerable<int> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<int> Sum(this IEnumerable<Nullable<int>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static long Sum(this IEnumerable<long> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<long> Sum(this IEnumerable<Nullable<long>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static float Sum(this IEnumerable<float> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<float> Sum(this IEnumerable<Nullable<float>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static double Sum(this IEnumerable<double> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<double> Sum(this IEnumerable<Nullable<double>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static decimal Sum(this IEnumerable<decimal> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<decimal> Sum(this IEnumerable<Nullable<decimal>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static int Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<int> Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<int>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static long Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<long> Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<long>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static float Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<float> Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<float>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static double Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<double> Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<double>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static decimal Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<decimal> Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<decimal>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static int Min(this IEnumerable<int> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<int> Min(this IEnumerable<Nullable<int>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static long Min(this IEnumerable<long> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<long> Min(this IEnumerable<Nullable<long>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static float Min(this IEnumerable<float> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<float> Min(this IEnumerable<Nullable<float>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static double Min(this IEnumerable<double> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<double> Min(this IEnumerable<Nullable<double>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static decimal Min(this IEnumerable<decimal> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<decimal> Min(this IEnumerable<Nullable<decimal>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource Min<TSource>(this IEnumerable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static int Min<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<int> Min<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<int>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static long Min<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<long> Min<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<long>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static float Min<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<float> Min<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<float>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static double Min<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<double> Min<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<double>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static decimal Min<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<decimal> Min<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<decimal>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static TResult Min<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static int Max(this IEnumerable<int> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<int> Max(this IEnumerable<Nullable<int>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static long Max(this IEnumerable<long> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<long> Max(this IEnumerable<Nullable<long>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static double Max(this IEnumerable<double> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<double> Max(this IEnumerable<Nullable<double>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static float Max(this IEnumerable<float> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<float> Max(this IEnumerable<Nullable<float>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static decimal Max(this IEnumerable<decimal> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<decimal> Max(this IEnumerable<Nullable<decimal>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static TSource Max<TSource>(this IEnumerable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static int Max<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<int> Max<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<int>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static long Max<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<long> Max<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<long>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static float Max<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<float> Max<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<float>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static double Max<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<double> Max<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<double>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static decimal Max<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<decimal> Max<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<decimal>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static TResult Max<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static double Average(this IEnumerable<int> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<double> Average(this IEnumerable<Nullable<int>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static double Average(this IEnumerable<long> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<double> Average(this IEnumerable<Nullable<long>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static float Average(this IEnumerable<float> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<float> Average(this IEnumerable<Nullable<float>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static double Average(this IEnumerable<double> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<double> Average(this IEnumerable<Nullable<double>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static decimal Average(this IEnumerable<decimal> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<decimal> Average(this IEnumerable<Nullable<decimal>> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<double> Average<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<int>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<double> Average<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<long>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static float Average<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<float> Average<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<float>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<double> Average<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<double>> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static decimal Average<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
        {
             throw new NotImplementedException();
        }
        
        
        public static Nullable<decimal> Average<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<decimal>> selector)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
