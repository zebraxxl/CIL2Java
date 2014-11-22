using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System;

namespace System.Collections.Concurrent
{
    /// <summary>Provides common partitioning strategies for arrays, lists, and enumerables.</summary>
    public static class Partitioner
    {
    
        public static OrderablePartitioner<TSource> Create<TSource>(IList<TSource> list, bool loadBalance)
        {
             throw new NotImplementedException();
        }
        
        
        public static OrderablePartitioner<TSource> Create<TSource>(TSource[] array, bool loadBalance)
        {
             throw new NotImplementedException();
        }
        
        
        public static OrderablePartitioner<TSource> Create<TSource>(IEnumerable<TSource> source)
        {
             throw new NotImplementedException();
        }
        
        
        public static OrderablePartitioner<TSource> Create<TSource>(IEnumerable<TSource> source, EnumerablePartitionerOptions partitionerOptions)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a partitioner that chunks the user-specified range.</summary><returns>A partitioner.</returns><param name="fromInclusive">The lower, inclusive bound of the range.</param><param name="toExclusive">The upper, exclusive bound of the range.</param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="toExclusive" /> argument is less than or equal to the <paramref name="fromInclusive" /> argument.</exception>
        public static OrderablePartitioner<Tuple<long, long>> Create(long fromInclusive, long toExclusive)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a partitioner that chunks the user-specified range.</summary><returns>A partitioner.</returns><param name="fromInclusive">The lower, inclusive bound of the range.</param><param name="toExclusive">The upper, exclusive bound of the range.</param><param name="rangeSize">The size of each subrange.</param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="toExclusive" /> argument is less than or equal to the <paramref name="fromInclusive" /> argument.-or-The <paramref name="rangeSize" /> argument is less than or equal to 0.</exception>
        public static OrderablePartitioner<Tuple<long, long>> Create(long fromInclusive, long toExclusive, long rangeSize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a partitioner that chunks the user-specified range.</summary><returns>A partitioner.</returns><param name="fromInclusive">The lower, inclusive bound of the range.</param><param name="toExclusive">The upper, exclusive bound of the range.</param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="toExclusive" /> argument is less than or equal to the <paramref name="fromInclusive" /> argument.</exception>
        public static OrderablePartitioner<Tuple<int, int>> Create(int fromInclusive, int toExclusive)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a partitioner that chunks the user-specified range.</summary><returns>A partitioner.</returns><param name="fromInclusive">The lower, inclusive bound of the range.</param><param name="toExclusive">The upper, exclusive bound of the range.</param><param name="rangeSize">The size of each subrange.</param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="toExclusive" /> argument is less than or equal to the <paramref name="fromInclusive" /> argument.-or-The <paramref name="rangeSize" /> argument is less than or equal to 0.</exception>
        public static OrderablePartitioner<Tuple<int, int>> Create(int fromInclusive, int toExclusive, int rangeSize)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
