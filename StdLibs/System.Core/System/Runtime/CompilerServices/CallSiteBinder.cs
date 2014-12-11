using System.Linq.Expressions;
using System.Collections.ObjectModel;

namespace System.Runtime.CompilerServices
{
    public abstract class CallSiteBinder
    {
    
        public static LabelTarget UpdateLabel
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected CallSiteBinder()
        {
             throw new NotImplementedException();
        }
        
        
        public abstract Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel);
        
        
        public virtual T BindDelegate<T>(CallSite<T> site, object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        protected void CacheTarget<T>(T target)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
