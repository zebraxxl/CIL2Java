using System;
using System.Linq.Expressions;

namespace System.Dynamic
{
    public abstract class BinaryOperationBinder : DynamicMetaObjectBinder
    {

        public override Type ReturnType
        {
            get { throw new NotImplementedException(); }
        }
    
        public ExpressionType Operation
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected BinaryOperationBinder(ExpressionType operation)
        {
             throw new NotImplementedException();
        }
        
        
        public DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg, DynamicMetaObject errorSuggestion);


        public override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
