using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace System.Linq.Expressions
{
    public sealed class RuntimeVariablesExpression : Expression
    {

        public override Type Type
        {
            get { throw new NotImplementedException(); }
        }

        public override ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }
    
        public ReadOnlyCollection<ParameterExpression> Variables
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
        public RuntimeVariablesExpression Update(IEnumerable<ParameterExpression> variables)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
