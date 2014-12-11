using System;
using System.Collections;

namespace System.Diagnostics
{
    public class CorrelationManager
    {
    
        public Guid ActivityId
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public Stack LogicalOperationStack
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public void StartLogicalOperation(object operationId)
        {
             throw new NotImplementedException();
        }
        
        
        public void StartLogicalOperation()
        {
             throw new NotImplementedException();
        }
        
        
        public void StopLogicalOperation()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
