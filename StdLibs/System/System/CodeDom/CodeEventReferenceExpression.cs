using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeEventReferenceExpression : CodeExpression
    {
    
        public CodeExpression TargetObject
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string EventName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeEventReferenceExpression()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeEventReferenceExpression(CodeExpression targetObject, string eventName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
