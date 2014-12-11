using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace System.Threading.Tasks
{
    /// <summary>Provides support for parallel loops and regions.</summary>
    public static class Parallel
    {
    
        /// <summary>Executes each of the provided actions, possibly in parallel.</summary><param name="actions">An array of <see cref="T:System.Action" /> to execute.</param><exception cref="T:System.ArgumentNullException">The <paramref name="actions" /> argument is null.</exception><exception cref="T:System.AggregateException">The exception that is thrown when any action in the <paramref name="actions" /> array throws an exception.</exception><exception cref="T:System.ArgumentException">The <paramref name="actions" /> array contains a null element.</exception>
        public static void Invoke(params  Action[] actions)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Executes each of the provided actions, possibly in parallel, unless the operation is cancelled by the user.</summary><param name="parallelOptions">An object that configures the behavior of this operation.</param><param name="actions">An array of actions to execute.</param><exception cref="T:System.OperationCanceledException">The <see cref="T:System.Threading.CancellationToken" /> in the <paramref name="parallelOptions" /> is set.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="actions" /> argument is null.-or-The <paramref name="parallelOptions" /> argument is null.</exception><exception cref="T:System.AggregateException">The exception that is thrown when any action in the <paramref name="actions" /> array throws an exception.</exception><exception cref="T:System.ArgumentException">The <paramref name="actions" /> array contains a null element.</exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with the <see cref="T:System.Threading.CancellationToken" /> in the <paramref name="parallelOptions" /> has been disposed.</exception>
        public static void Invoke(ParallelOptions parallelOptions, params  Action[] actions)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult For(int fromInclusive, int toExclusive, Action<int> body)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult For(long fromInclusive, long toExclusive, Action<long> body)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult For(int fromInclusive, int toExclusive, ParallelOptions parallelOptions, Action<int> body)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult For(long fromInclusive, long toExclusive, ParallelOptions parallelOptions, Action<long> body)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult For(int fromInclusive, int toExclusive, Action<int, ParallelLoopState> body)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult For(long fromInclusive, long toExclusive, Action<long, ParallelLoopState> body)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult For(int fromInclusive, int toExclusive, ParallelOptions parallelOptions, Action<int, ParallelLoopState> body)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult For(long fromInclusive, long toExclusive, ParallelOptions parallelOptions, Action<long, ParallelLoopState> body)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult For<TLocal>(int fromInclusive, int toExclusive, Func<TLocal> localInit, Func<int, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult For<TLocal>(long fromInclusive, long toExclusive, Func<TLocal> localInit, Func<long, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult For<TLocal>(int fromInclusive, int toExclusive, ParallelOptions parallelOptions, Func<TLocal> localInit, Func<int, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult For<TLocal>(long fromInclusive, long toExclusive, ParallelOptions parallelOptions, Func<TLocal> localInit, Func<long, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult ForEach<TSource>(IEnumerable<TSource> source, Action<TSource> body)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult ForEach<TSource>(IEnumerable<TSource> source, ParallelOptions parallelOptions, Action<TSource> body)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult ForEach<TSource>(IEnumerable<TSource> source, Action<TSource, ParallelLoopState> body)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult ForEach<TSource>(IEnumerable<TSource> source, ParallelOptions parallelOptions, Action<TSource, ParallelLoopState> body)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult ForEach<TSource>(IEnumerable<TSource> source, Action<TSource, ParallelLoopState, long> body)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult ForEach<TSource>(IEnumerable<TSource> source, ParallelOptions parallelOptions, Action<TSource, ParallelLoopState, long> body)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult ForEach<TSource, TLocal>(IEnumerable<TSource> source, Func<TLocal> localInit, Func<TSource, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult ForEach<TSource, TLocal>(IEnumerable<TSource> source, ParallelOptions parallelOptions, Func<TLocal> localInit, Func<TSource, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult ForEach<TSource, TLocal>(IEnumerable<TSource> source, Func<TLocal> localInit, Func<TSource, ParallelLoopState, long, TLocal, TLocal> body, Action<TLocal> localFinally)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult ForEach<TSource, TLocal>(IEnumerable<TSource> source, ParallelOptions parallelOptions, Func<TLocal> localInit, Func<TSource, ParallelLoopState, long, TLocal, TLocal> body, Action<TLocal> localFinally)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult ForEach<TSource>(Partitioner<TSource> source, Action<TSource> body)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult ForEach<TSource>(Partitioner<TSource> source, Action<TSource, ParallelLoopState> body)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult ForEach<TSource>(OrderablePartitioner<TSource> source, Action<TSource, ParallelLoopState, long> body)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult ForEach<TSource, TLocal>(Partitioner<TSource> source, Func<TLocal> localInit, Func<TSource, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult ForEach<TSource, TLocal>(OrderablePartitioner<TSource> source, Func<TLocal> localInit, Func<TSource, ParallelLoopState, long, TLocal, TLocal> body, Action<TLocal> localFinally)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult ForEach<TSource>(Partitioner<TSource> source, ParallelOptions parallelOptions, Action<TSource> body)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult ForEach<TSource>(Partitioner<TSource> source, ParallelOptions parallelOptions, Action<TSource, ParallelLoopState> body)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult ForEach<TSource>(OrderablePartitioner<TSource> source, ParallelOptions parallelOptions, Action<TSource, ParallelLoopState, long> body)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult ForEach<TSource, TLocal>(Partitioner<TSource> source, ParallelOptions parallelOptions, Func<TLocal> localInit, Func<TSource, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParallelLoopResult ForEach<TSource, TLocal>(OrderablePartitioner<TSource> source, ParallelOptions parallelOptions, Func<TLocal> localInit, Func<TSource, ParallelLoopState, long, TLocal, TLocal> body, Action<TLocal> localFinally)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
