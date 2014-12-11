using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodePropertyReferenceExpression : CodeExpression
    {
    
        public CodeExpression TargetObject
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string PropertyName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodePropertyReferenceExpression()
        {
             throw new NotImplementedException();
        }
        
        
        public CodePropertyReferenceExpression(CodeExpression targetObject, string propertyName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
