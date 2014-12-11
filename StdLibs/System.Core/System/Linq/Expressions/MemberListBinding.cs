using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace System.Linq.Expressions
{
    public sealed class MemberListBinding : MemberBinding
    {
        internal MemberListBinding()
            : base(MemberBindingType.MemberBinding, null)
        {
        }
    
        public ReadOnlyCollection<ElementInit> Initializers
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public MemberListBinding Update(IEnumerable<ElementInit> initializers)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
