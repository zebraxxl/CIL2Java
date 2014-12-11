using System.Threading;

namespace System.Threading.Tasks
{
    /// <summary>Stores options that configure the operation of methods on the <see cref="T:System.Threading.Tasks.Parallel" /> class.</summary>
    public class ParallelOptions
    {
    
        /// <summary>Gets or sets the <see cref="T:System.Threading.Tasks.TaskScheduler" /> associated with this <see cref="T:System.Threading.Tasks.ParallelOptions" /> instance. Setting this property to null indicates that the current scheduler should be used.</summary><returns>The task scheduler that is associated with this instance.</returns>
        public TaskScheduler TaskScheduler
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the maximum degree of parallelism enabled by this ParallelOptions instance.</summary><returns>An integer that represents the maximum degree of parallelism.</returns><exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when this <see cref="P:System.Threading.Tasks.ParallelOptions.MaxDegreeOfParallelism" /> is set to 0 or some value less than -1.</exception>
        public int MaxDegreeOfParallelism
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the <see cref="T:System.Threading.CancellationToken" /> associated with this <see cref="T:System.Threading.Tasks.ParallelOptions" /> instance.</summary><returns>The token that is associated with this instance.</returns>
        public CancellationToken CancellationToken
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public ParallelOptions()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
