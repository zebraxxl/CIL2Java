using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace System.Collections.Concurrent
{
    /// <summary>Represents a particular manner of splitting an orderable data source into multiple partitions.</summary><typeparam name="TSource">Type of the elements in the collection.</typeparam>
    public abstract class OrderablePartitioner<TSource> : Partitioner<TSource>
    {
    
        /// <summary>Gets whether elements in each partition are yielded in the order of increasing keys.</summary><returns>true if the elements in each partition are yielded in the order of increasing keys; otherwise false.</returns>
        public bool KeysOrderedInEachPartition
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets whether elements in an earlier partition always come before elements in a later partition.</summary><returns>true if the elements in an earlier partition always come before elements in a later partition; otherwise false.</returns>
        public bool KeysOrderedAcrossPartitions
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets whether order keys are normalized.</summary><returns>true if the keys are normalized; otherwise false.</returns>
        public bool KeysNormalized
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Called from constructors in derived classes to initialize the <see cref="T:System.Collections.Concurrent.OrderablePartitioner`1" /> class with the specified constraints on the index keys.</summary><param name="keysOrderedInEachPartition">Indicates whether the elements in each partition are yielded in the order of increasing keys.</param><param name="keysOrderedAcrossPartitions">Indicates whether elements in an earlier partition always come before elements in a later partition. If true, each element in partition 0 has a smaller order key than any element in partition 1, each element in partition 1 has a smaller order key than any element in partition 2, and so on.</param><param name="keysNormalized">Indicates whether keys are normalized. If true, all order keys are distinct integers in the range [0 .. numberOfElements-1]. If false, order keys must still be distinct, but only their relative order is considered, not their absolute values.</param>
        protected OrderablePartitioner(bool keysOrderedInEachPartition, bool keysOrderedAcrossPartitions, bool keysNormalized)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Partitions the underlying collection into the specified number of orderable partitions.</summary><returns>A list containing <paramref name="partitionCount" /> enumerators.</returns><param name="partitionCount">The number of partitions to create.</param>
        public abstract IList<IEnumerator<KeyValuePair<long, TSource>>> GetOrderablePartitions(int partitionCount);
        
        
        public virtual IEnumerable<KeyValuePair<long, TSource>> GetOrderableDynamicPartitions()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Partitions the underlying collection into the given number of ordered partitions.</summary><returns>A list containing <paramref name="partitionCount" /> enumerators.</returns><param name="partitionCount">The number of partitions to create.</param>
        public override IList<IEnumerator<TSource>> GetPartitions(int partitionCount)
        {
             throw new NotImplementedException();
        }
        
        
        public override IEnumerable<TSource> GetDynamicPartitions()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
