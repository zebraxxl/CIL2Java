using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeMemberProperty : CodeTypeMember
    {
    
        public CodeTypeReference PrivateImplementationType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeTypeReferenceCollection ImplementationTypes
        {
            get { throw new NotImplementedException(); }
        }
    
        public CodeTypeReference Type
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool HasGet
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool HasSet
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeStatementCollection GetStatements
        {
            get { throw new NotImplementedException(); }
        }
    
        public CodeStatementCollection SetStatements
        {
            get { throw new NotImplementedException(); }
        }
    
        public CodeParameterDeclarationExpressionCollection Parameters
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeMemberProperty()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
