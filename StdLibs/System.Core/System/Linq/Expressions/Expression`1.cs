using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace System.Linq.Expressions
{
    public sealed class Expression<TDelegate> : LambdaExpression
    {
        public new TDelegate Compile()
        {
             throw new NotImplementedException();
        }
        
        
        public new TDelegate Compile(DebugInfoGenerator debugInfoGenerator)
        {
             throw new NotImplementedException();
        }
        
        
        public Expression<TDelegate> Update(Expression body, IEnumerable<ParameterExpression> parameters)
        {
             throw new NotImplementedException();
        }
        
        
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
