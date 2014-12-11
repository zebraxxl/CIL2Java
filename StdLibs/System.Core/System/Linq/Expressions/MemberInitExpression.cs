using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace System.Linq.Expressions
{
    public sealed class MemberInitExpression : Expression
    {

        public override Type Type
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool CanReduce
        {
            get { throw new NotImplementedException(); }
        }

        public override ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }
    
        public NewExpression NewExpression
        {
            get { throw new NotImplementedException(); }
        }
    
        public ReadOnlyCollection<MemberBinding> Bindings
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
        
        
        public MemberInitExpression Update(NewExpression newExpression, IEnumerable<MemberBinding> bindings)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
