using System.Collections.Generic;

namespace System.Collections.Concurrent
{
    /// <summary>Represents a particular manner of splitting a data source into multiple partitions.</summary><typeparam name="TSource">Type of the elements in the collection.</typeparam>
    public abstract class Partitioner<TSource>
    {
        /// <summary>Gets whether additional partitions can be created dynamically.</summary><returns>true if the <see cref="T:System.Collections.Concurrent.Partitioner`1" /> can create partitions dynamically as they are requested; false if the <see cref="T:System.Collections.Concurrent.Partitioner`1" /> can only allocate partitions statically.</returns>
        public virtual bool SupportsDynamicPartitions
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Partitions the underlying collection into the given number of partitions.</summary><returns>A list containing <paramref name="partitionCount" /> enumerators.</returns><param name="partitionCount">The number of partitions to create.</param>
        public abstract IList<IEnumerator<TSource>> GetPartitions(int partitionCount);
        
        
        public virtual IEnumerable<TSource> GetDynamicPartitions()
        {
             throw new NotImplementedException();
        }
        
        
        protected Partitioner()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
