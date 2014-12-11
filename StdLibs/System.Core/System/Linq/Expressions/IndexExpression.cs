using System;
using System.Reflection;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace System.Linq.Expressions
{
    public sealed class IndexExpression : Expression
    {

        public override ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }

        public override Type Type
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression Object
        {
            get { throw new NotImplementedException(); }
        }
    
        public PropertyInfo Indexer
        {
            get { throw new NotImplementedException(); }
        }
    
        public ReadOnlyCollection<Expression> Arguments
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public IndexExpression Update(Expression @object, IEnumerable<Expression> arguments)
        {
             throw new NotImplementedException();
        }
        
        
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
