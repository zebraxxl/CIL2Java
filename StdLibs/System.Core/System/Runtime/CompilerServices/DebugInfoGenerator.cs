using System.Linq.Expressions;

namespace System.Runtime.CompilerServices
{
    public abstract class DebugInfoGenerator
    {
        public static DebugInfoGenerator CreatePdbGenerator()
        {
             throw new NotImplementedException();
        }
        
        
        public abstract void MarkSequencePoint(LambdaExpression method, int ilOffset, DebugInfoExpression sequencePoint);
        
        
        protected DebugInfoGenerator()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
