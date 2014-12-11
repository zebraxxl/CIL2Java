using System;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace System.Linq.Expressions
{
    public class DynamicExpression : Expression
    {
    
        public override Type Type
        {
            get { throw new NotImplementedException(); }
        }

        public override ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }
    
        public CallSiteBinder Binder
        {
            get { throw new NotImplementedException(); }
        }
    
        public Type DelegateType
        {
            get { throw new NotImplementedException(); }
        }
    
        public ReadOnlyCollection<Expression> Arguments
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
        public DynamicExpression Update(IEnumerable<Expression> arguments)
        {
             throw new NotImplementedException();
        }


        public new static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, params  Expression[] arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public new static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, IEnumerable<Expression> arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public new static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0)
        {
             throw new NotImplementedException();
        }
        
        
        public new static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1)
        {
             throw new NotImplementedException();
        }
        
        
        public new static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1, Expression arg2)
        {
             throw new NotImplementedException();
        }
        
        
        public new static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
        {
             throw new NotImplementedException();
        }
        
        
        public new static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, IEnumerable<Expression> arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public new static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, params  Expression[] arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public new static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0)
        {
             throw new NotImplementedException();
        }
        
        
        public new static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1)
        {
             throw new NotImplementedException();
        }
        
        
        public new static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2)
        {
             throw new NotImplementedException();
        }
        
        
        public new static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
