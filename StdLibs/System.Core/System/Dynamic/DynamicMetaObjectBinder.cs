using System.Runtime.CompilerServices;
using System;
using System.Linq.Expressions;
using System.Collections.ObjectModel;

namespace System.Dynamic
{
    public abstract class DynamicMetaObjectBinder : CallSiteBinder
    {
    
        public virtual Type ReturnType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected DynamicMetaObjectBinder()
        {
             throw new NotImplementedException();
        }


        public override Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args);
        
        
        public Expression GetUpdateExpression(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public DynamicMetaObject Defer(DynamicMetaObject target, params  DynamicMetaObject[] args)
        {
             throw new NotImplementedException();
        }
        
        
        public DynamicMetaObject Defer(params  DynamicMetaObject[] args)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
