using System;
using System.Reflection;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace System.Linq.Expressions
{
    public class NewExpression : Expression
    {
    
        public override Type Type
        {
            get { throw new NotImplementedException(); }
        }

        public override ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }
    
        public ConstructorInfo Constructor
        {
            get { throw new NotImplementedException(); }
        }
    
        public ReadOnlyCollection<Expression> Arguments
        {
            get { throw new NotImplementedException(); }
        }
    
        public ReadOnlyCollection<MemberInfo> Members
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
        public NewExpression Update(IEnumerable<Expression> arguments)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
