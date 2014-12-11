using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace System.Linq.Expressions
{
    public sealed class ListInitExpression : Expression
    {

        public override ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }

        public override Type Type
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool CanReduce
        {
            get { throw new NotImplementedException(); }
        }
    
        public NewExpression NewExpression
        {
            get { throw new NotImplementedException(); }
        }
    
        public ReadOnlyCollection<ElementInit> Initializers
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
        public override Expression Reduce()
        {
             throw new NotImplementedException();
        }
        
        
        public ListInitExpression Update(NewExpression newExpression, IEnumerable<ElementInit> initializers)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
