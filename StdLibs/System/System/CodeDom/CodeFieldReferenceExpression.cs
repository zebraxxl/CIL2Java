using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeFieldReferenceExpression : CodeExpression
    {
    
        public CodeExpression TargetObject
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string FieldName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeFieldReferenceExpression()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeFieldReferenceExpression(CodeExpression targetObject, string fieldName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
