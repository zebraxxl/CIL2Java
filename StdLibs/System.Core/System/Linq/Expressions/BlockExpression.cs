using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;

namespace System.Linq.Expressions
{
    public class BlockExpression : Expression
    {
        public ReadOnlyCollection<Expression> Expressions
        {
            get { throw new NotImplementedException(); }
        }
    
        public ReadOnlyCollection<ParameterExpression> Variables
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression Result
        {
            get { throw new NotImplementedException(); }
        }

        public override ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Type Type
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
        public BlockExpression Update(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
