using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace System.Linq.Expressions
{
    public class NewArrayExpression : Expression
    {

        public override Type Type
        {
            get { throw new NotImplementedException(); }
        }
    
        public ReadOnlyCollection<Expression> Expressions
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
        public NewArrayExpression Update(IEnumerable<Expression> expressions)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
