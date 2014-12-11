
namespace System.Linq.Expressions
{
    public sealed class MemberAssignment : MemberBinding
    {
        internal MemberAssignment()
            : base(MemberBindingType.MemberBinding, null)
        {

        }
    
        public Expression Expression
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public MemberAssignment Update(Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
