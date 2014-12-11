using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace System.Linq.Expressions
{
    public sealed class TryExpression : Expression
    {

        public override Type Type
        {
            get { throw new NotImplementedException(); }
        }

        public override ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression Body
        {
            get { throw new NotImplementedException(); }
        }
    
        public ReadOnlyCollection<CatchBlock> Handlers
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression Finally
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression Fault
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
        public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression @finally, Expression fault)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
