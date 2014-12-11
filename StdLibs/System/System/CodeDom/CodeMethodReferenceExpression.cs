using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeMethodReferenceExpression : CodeExpression
    {
    
        public CodeExpression TargetObject
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string MethodName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ComVisibleAttribute(false)]
        public CodeTypeReferenceCollection TypeArguments
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeMethodReferenceExpression()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeMethodReferenceExpression(CodeExpression targetObject, string methodName)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeMethodReferenceExpression(CodeExpression targetObject, string methodName, params  CodeTypeReference[] typeParameters)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
