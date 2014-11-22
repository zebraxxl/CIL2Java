
namespace System
{
    /// <summary>Provides an <see cref="T:System.IProgress`1" /> that invokes callbacks for each reported progress value.</summary><typeparam name="T">Specifies the type of the progress report value.</typeparam>
    public class Progress<T> : IProgress<T>
    {
    
        /// <summary>Raised for each reported progress value.</summary>
        public event EventHandler<T> ProgressChanged;
    
    
        public Progress()
        {
             throw new NotImplementedException();
        }
        
        
        public Progress(Action<T> handler)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnReport(T value)
        {
             throw new NotImplementedException();
        }



        void IProgress<T>.Report(T value)
        {
            throw new NotImplementedException();
        }
    }
}
