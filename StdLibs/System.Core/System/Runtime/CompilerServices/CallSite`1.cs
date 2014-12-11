
namespace System.Runtime.CompilerServices
{
    public class CallSite<T> : CallSite
    {
        public T Target;
    
        public T Update
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public static CallSite<T> Create(CallSiteBinder binder)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
