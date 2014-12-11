using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeMemberMethod : CodeTypeMember
    {
    
        public event EventHandler PopulateParameters;
    
        public event EventHandler PopulateStatements;
    
        public event EventHandler PopulateImplementationTypes;
    
    
        public CodeTypeReference ReturnType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeStatementCollection Statements
        {
            get { throw new NotImplementedException(); }
        }
    
        public CodeParameterDeclarationExpressionCollection Parameters
        {
            get { throw new NotImplementedException(); }
        }
    
        public CodeTypeReference PrivateImplementationType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeTypeReferenceCollection ImplementationTypes
        {
            get { throw new NotImplementedException(); }
        }
    
        public CodeAttributeDeclarationCollection ReturnTypeCustomAttributes
        {
            get { throw new NotImplementedException(); }
        }
    
        [ComVisibleAttribute(false)]
        public CodeTypeParameterCollection TypeParameters
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeMemberMethod()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
