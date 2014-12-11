using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace System.Dynamic
{
    public sealed class CallInfo
    {
    
        public int ArgumentCount
        {
            get { throw new NotImplementedException(); }
        }
    
        public ReadOnlyCollection<string> ArgumentNames
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CallInfo(int argCount, params  string[] argNames)
        {
             throw new NotImplementedException();
        }
        
        
        public CallInfo(int argCount, IEnumerable<string> argNames)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
