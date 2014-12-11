using System;
using System.Linq.Expressions;

namespace System.Dynamic
{
    public abstract class UnaryOperationBinder : DynamicMetaObjectBinder
    {

        public override Type ReturnType
        {
            get { throw new NotImplementedException(); }
        }
    
        public ExpressionType Operation
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected UnaryOperationBinder(ExpressionType operation)
        {
             throw new NotImplementedException();
        }
        
        
        public DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target, DynamicMetaObject errorSuggestion);


        public override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
