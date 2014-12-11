using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace System.Linq.Expressions
{
    public sealed class SwitchCase
    {
    
        public ReadOnlyCollection<Expression> TestValues
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression Body
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        public SwitchCase Update(IEnumerable<Expression> testValues, Expression body)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
