using System.ComponentModel;

namespace System.Text.RegularExpressions
{
    [EditorBrowsableAttribute(EditorBrowsableState.Never)]
    public abstract class RegexRunnerFactory
    {
        protected RegexRunnerFactory()
        {
             throw new NotImplementedException();
        }
        
        
        protected abstract RegexRunner CreateInstance();
        
        
    }
}
