using System.Reflection;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace System.Linq.Expressions
{
    public sealed class ElementInit
    {
    
        public MethodInfo AddMethod
        {
            get { throw new NotImplementedException(); }
        }
    
        public ReadOnlyCollection<Expression> Arguments
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        public ElementInit Update(IEnumerable<Expression> arguments)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
