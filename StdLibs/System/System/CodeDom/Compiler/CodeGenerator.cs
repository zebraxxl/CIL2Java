using System.CodeDom;
using System.IO;
using System.Reflection;

namespace System.CodeDom.Compiler
{
    public abstract class CodeGenerator : ICodeGenerator
    {
    
        protected CodeTypeDeclaration CurrentClass
        {
            get { throw new NotImplementedException(); }
        }
    
        protected string CurrentTypeName
        {
            get { throw new NotImplementedException(); }
        }
    
        protected CodeTypeMember CurrentMember
        {
            get { throw new NotImplementedException(); }
        }
    
        protected string CurrentMemberName
        {
            get { throw new NotImplementedException(); }
        }
    
        protected bool IsCurrentInterface
        {
            get { throw new NotImplementedException(); }
        }
    
        protected bool IsCurrentClass
        {
            get { throw new NotImplementedException(); }
        }
    
        protected bool IsCurrentStruct
        {
            get { throw new NotImplementedException(); }
        }
    
        protected bool IsCurrentEnum
        {
            get { throw new NotImplementedException(); }
        }
    
        protected bool IsCurrentDelegate
        {
            get { throw new NotImplementedException(); }
        }
    
        protected int Indent
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        protected abstract string NullToken
        {
            get;
        }
    
        protected TextWriter Output
        {
            get { throw new NotImplementedException(); }
        }
    
        protected CodeGeneratorOptions Options
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected virtual void GenerateDirectives(CodeDirectiveCollection directives)
        {
             throw new NotImplementedException();
        }
        
        
        protected void GenerateNamespaces(CodeCompileUnit e)
        {
             throw new NotImplementedException();
        }
        
        
        protected void GenerateTypes(CodeNamespace e)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        protected void GenerateExpression(CodeExpression e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void GenerateSnippetCompileUnit(CodeSnippetCompileUnit e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void GenerateCompileUnit(CodeCompileUnit e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void GenerateNamespace(CodeNamespace e)
        {
             throw new NotImplementedException();
        }
        
        
        protected void GenerateNamespaceImports(CodeNamespace e)
        {
             throw new NotImplementedException();
        }
        
        
        protected void GenerateStatement(CodeStatement e)
        {
             throw new NotImplementedException();
        }
        
        
        protected void GenerateStatements(CodeStatementCollection stms)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OutputAttributeDeclarations(CodeAttributeDeclarationCollection attributes)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OutputAttributeArgument(CodeAttributeArgument arg)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OutputDirection(FieldDirection dir)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OutputFieldScopeModifier(MemberAttributes attributes)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OutputMemberAccessModifier(MemberAttributes attributes)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OutputMemberScopeModifier(MemberAttributes attributes)
        {
             throw new NotImplementedException();
        }
        
        
        protected abstract void OutputType(CodeTypeReference typeRef);
        
        
        protected virtual void OutputTypeAttributes(TypeAttributes attributes, bool isStruct, bool isEnum)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OutputTypeNamePair(CodeTypeReference typeRef, string name)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OutputIdentifier(string ident)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OutputExpressionList(CodeExpressionCollection expressions)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OutputExpressionList(CodeExpressionCollection expressions, bool newlineBetweenItems)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OutputOperator(CodeBinaryOperatorType op)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OutputParameters(CodeParameterDeclarationExpressionCollection parameters)
        {
             throw new NotImplementedException();
        }
        
        
        protected abstract void GenerateArrayCreateExpression(CodeArrayCreateExpression e);
        
        
        protected abstract void GenerateBaseReferenceExpression(CodeBaseReferenceExpression e);
        
        
        protected virtual void GenerateBinaryOperatorExpression(CodeBinaryOperatorExpression e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void ContinueOnNewLine(string st)
        {
             throw new NotImplementedException();
        }
        
        
        protected abstract void GenerateCastExpression(CodeCastExpression e);
        
        
        protected abstract void GenerateDelegateCreateExpression(CodeDelegateCreateExpression e);
        
        
        protected abstract void GenerateFieldReferenceExpression(CodeFieldReferenceExpression e);
        
        
        protected abstract void GenerateArgumentReferenceExpression(CodeArgumentReferenceExpression e);
        
        
        protected abstract void GenerateVariableReferenceExpression(CodeVariableReferenceExpression e);
        
        
        protected abstract void GenerateIndexerExpression(CodeIndexerExpression e);
        
        
        protected abstract void GenerateArrayIndexerExpression(CodeArrayIndexerExpression e);
        
        
        protected abstract void GenerateSnippetExpression(CodeSnippetExpression e);
        
        
        protected abstract void GenerateMethodInvokeExpression(CodeMethodInvokeExpression e);
        
        
        protected abstract void GenerateMethodReferenceExpression(CodeMethodReferenceExpression e);
        
        
        protected abstract void GenerateEventReferenceExpression(CodeEventReferenceExpression e);
        
        
        protected abstract void GenerateDelegateInvokeExpression(CodeDelegateInvokeExpression e);
        
        
        protected abstract void GenerateObjectCreateExpression(CodeObjectCreateExpression e);
        
        
        protected virtual void GenerateParameterDeclarationExpression(CodeParameterDeclarationExpression e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void GenerateDirectionExpression(CodeDirectionExpression e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void GeneratePrimitiveExpression(CodePrimitiveExpression e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void GenerateSingleFloatValue(float s)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void GenerateDoubleValue(double d)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void GenerateDecimalValue(decimal d)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void GenerateDefaultValueExpression(CodeDefaultValueExpression e)
        {
             throw new NotImplementedException();
        }
        
        
        protected abstract void GeneratePropertyReferenceExpression(CodePropertyReferenceExpression e);
        
        
        protected abstract void GeneratePropertySetValueReferenceExpression(CodePropertySetValueReferenceExpression e);
        
        
        protected abstract void GenerateThisReferenceExpression(CodeThisReferenceExpression e);
        
        
        protected virtual void GenerateTypeReferenceExpression(CodeTypeReferenceExpression e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void GenerateTypeOfExpression(CodeTypeOfExpression e)
        {
             throw new NotImplementedException();
        }
        
        
        protected abstract void GenerateExpressionStatement(CodeExpressionStatement e);
        
        
        protected abstract void GenerateIterationStatement(CodeIterationStatement e);
        
        
        protected abstract void GenerateThrowExceptionStatement(CodeThrowExceptionStatement e);
        
        
        protected virtual void GenerateCommentStatement(CodeCommentStatement e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void GenerateCommentStatements(CodeCommentStatementCollection e)
        {
             throw new NotImplementedException();
        }
        
        
        protected abstract void GenerateComment(CodeComment e);
        
        
        protected abstract void GenerateMethodReturnStatement(CodeMethodReturnStatement e);
        
        
        protected abstract void GenerateConditionStatement(CodeConditionStatement e);
        
        
        protected abstract void GenerateTryCatchFinallyStatement(CodeTryCatchFinallyStatement e);
        
        
        protected abstract void GenerateAssignStatement(CodeAssignStatement e);
        
        
        protected abstract void GenerateAttachEventStatement(CodeAttachEventStatement e);
        
        
        protected abstract void GenerateRemoveEventStatement(CodeRemoveEventStatement e);
        
        
        protected abstract void GenerateGotoStatement(CodeGotoStatement e);
        
        
        protected abstract void GenerateLabeledStatement(CodeLabeledStatement e);
        
        
        protected virtual void GenerateSnippetStatement(CodeSnippetStatement e)
        {
             throw new NotImplementedException();
        }
        
        
        protected abstract void GenerateVariableDeclarationStatement(CodeVariableDeclarationStatement e);
        
        
        protected abstract void GenerateLinePragmaStart(CodeLinePragma e);
        
        
        protected abstract void GenerateLinePragmaEnd(CodeLinePragma e);
        
        
        protected abstract void GenerateEvent(CodeMemberEvent e, CodeTypeDeclaration c);
        
        
        protected abstract void GenerateField(CodeMemberField e);
        
        
        protected abstract void GenerateSnippetMember(CodeSnippetTypeMember e);
        
        
        protected abstract void GenerateEntryPointMethod(CodeEntryPointMethod e, CodeTypeDeclaration c);
        
        
        protected abstract void GenerateMethod(CodeMemberMethod e, CodeTypeDeclaration c);
        
        
        protected abstract void GenerateProperty(CodeMemberProperty e, CodeTypeDeclaration c);
        
        
        protected abstract void GenerateConstructor(CodeConstructor e, CodeTypeDeclaration c);
        
        
        protected abstract void GenerateTypeConstructor(CodeTypeConstructor e);
        
        
        protected abstract void GenerateTypeStart(CodeTypeDeclaration e);
        
        
        protected abstract void GenerateTypeEnd(CodeTypeDeclaration e);
        
        
        protected virtual void GenerateCompileUnitStart(CodeCompileUnit e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void GenerateCompileUnitEnd(CodeCompileUnit e)
        {
             throw new NotImplementedException();
        }
        
        
        protected abstract void GenerateNamespaceStart(CodeNamespace e);
        
        
        protected abstract void GenerateNamespaceEnd(CodeNamespace e);
        
        
        protected abstract void GenerateNamespaceImport(CodeNamespaceImport e);
        
        
        protected abstract void GenerateAttributeDeclarationsStart(CodeAttributeDeclarationCollection attributes);
        
        
        protected abstract void GenerateAttributeDeclarationsEnd(CodeAttributeDeclarationCollection attributes);
        
        
        protected abstract bool Supports(GeneratorSupport support);
        
        
        protected abstract bool IsValidIdentifier(string value);
        
        
        protected virtual void ValidateIdentifier(string value)
        {
             throw new NotImplementedException();
        }
        
        
        protected abstract string CreateEscapedIdentifier(string value);
        
        
        protected abstract string CreateValidIdentifier(string value);
        
        
        protected abstract string GetTypeOutput(CodeTypeReference value);
        
        
        protected abstract string QuoteSnippetString(string value);
        
        
        public static bool IsValidLanguageIndependentIdentifier(string value)
        {
             throw new NotImplementedException();
        }
        
        
        public static void ValidateIdentifiers(CodeObject e)
        {
             throw new NotImplementedException();
        }
        
        
        protected CodeGenerator()
        {
             throw new NotImplementedException();
        }



        bool ICodeGenerator.IsValidIdentifier(string value)
        {
            throw new NotImplementedException();
        }

        void ICodeGenerator.ValidateIdentifier(string value)
        {
            throw new NotImplementedException();
        }

        string ICodeGenerator.CreateEscapedIdentifier(string value)
        {
            throw new NotImplementedException();
        }

        string ICodeGenerator.CreateValidIdentifier(string value)
        {
            throw new NotImplementedException();
        }

        string ICodeGenerator.GetTypeOutput(CodeTypeReference type)
        {
            throw new NotImplementedException();
        }

        bool ICodeGenerator.Supports(GeneratorSupport supports)
        {
            throw new NotImplementedException();
        }

        void ICodeGenerator.GenerateCodeFromExpression(CodeExpression e, TextWriter w, CodeGeneratorOptions o)
        {
            throw new NotImplementedException();
        }

        void ICodeGenerator.GenerateCodeFromStatement(CodeStatement e, TextWriter w, CodeGeneratorOptions o)
        {
            throw new NotImplementedException();
        }

        void ICodeGenerator.GenerateCodeFromNamespace(CodeNamespace e, TextWriter w, CodeGeneratorOptions o)
        {
            throw new NotImplementedException();
        }

        void ICodeGenerator.GenerateCodeFromCompileUnit(CodeCompileUnit e, TextWriter w, CodeGeneratorOptions o)
        {
            throw new NotImplementedException();
        }

        void ICodeGenerator.GenerateCodeFromType(CodeTypeDeclaration e, TextWriter w, CodeGeneratorOptions o)
        {
            throw new NotImplementedException();
        }
    }
}
