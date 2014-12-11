using System.ComponentModel;
using System.Diagnostics;

namespace System.Runtime.CompilerServices
{
    [EditorBrowsableAttribute(EditorBrowsableState.Never)]
    [DebuggerStepThroughAttribute()]
    public sealed class Closure
    {
        public readonly object[] Constants;
        public readonly object[] Locals;
    
        public Closure(object[] constants, object[] locals)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
