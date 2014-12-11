using System;
using System.Reflection;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace System.Linq.Expressions
{
    public class MethodCallExpression : Expression
    {

        public override ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }

        public override Type Type
        {
            get { throw new NotImplementedException(); }
        }
    
        public MethodInfo Method
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression Object
        {
            get { throw new NotImplementedException(); }
        }
    
        public ReadOnlyCollection<Expression> Arguments
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public MethodCallExpression Update(Expression @object, IEnumerable<Expression> arguments)
        {
             throw new NotImplementedException();
        }
        
        
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
