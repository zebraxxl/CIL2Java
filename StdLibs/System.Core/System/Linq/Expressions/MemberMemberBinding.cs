using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace System.Linq.Expressions
{
    public sealed class MemberMemberBinding : MemberBinding
    {
        internal MemberMemberBinding()
            : base(MemberBindingType.MemberBinding, null)
        {
        }

        public ReadOnlyCollection<MemberBinding> Bindings
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public MemberMemberBinding Update(IEnumerable<MemberBinding> bindings)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
