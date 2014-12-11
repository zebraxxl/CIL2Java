using System;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Collections.Generic;

namespace System.Linq.Expressions
{
    public sealed class SwitchExpression : Expression
    {

        public override Type Type
        {
            get { throw new NotImplementedException(); }
        }

        public override ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression SwitchValue
        {
            get { throw new NotImplementedException(); }
        }
    
        public ReadOnlyCollection<SwitchCase> Cases
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression DefaultBody
        {
            get { throw new NotImplementedException(); }
        }
    
        public MethodInfo Comparison
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
        public SwitchExpression Update(Expression switchValue, IEnumerable<SwitchCase> cases, Expression defaultBody)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
