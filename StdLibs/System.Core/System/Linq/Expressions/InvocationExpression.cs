using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace System.Linq.Expressions
{
    public sealed class InvocationExpression : Expression
    {

        public override Type Type
        {
            get { throw new NotImplementedException(); }
        }

        public override ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression Expression
        {
            get { throw new NotImplementedException(); }
        }
    
        public ReadOnlyCollection<Expression> Arguments
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public InvocationExpression Update(Expression expression, IEnumerable<Expression> arguments)
        {
             throw new NotImplementedException();
        }
        
        
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
