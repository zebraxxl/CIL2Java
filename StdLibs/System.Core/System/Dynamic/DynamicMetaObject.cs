using System.Linq.Expressions;
using System;
using System.Collections.Generic;

namespace System.Dynamic
{
    public class DynamicMetaObject
    {
        public static readonly DynamicMetaObject[] EmptyMetaObjects;
    
        public Expression Expression
        {
            get { throw new NotImplementedException(); }
        }
    
        public BindingRestrictions Restrictions
        {
            get { throw new NotImplementedException(); }
        }
    
        public object Value
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool HasValue
        {
            get { throw new NotImplementedException(); }
        }
    
        public Type RuntimeType
        {
            get { throw new NotImplementedException(); }
        }
    
        public Type LimitType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DynamicMetaObject(Expression expression, BindingRestrictions restrictions)
        {
             throw new NotImplementedException();
        }
        
        
        public DynamicMetaObject(Expression expression, BindingRestrictions restrictions, object value)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual DynamicMetaObject BindConvert(ConvertBinder binder)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual DynamicMetaObject BindGetMember(GetMemberBinder binder)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IEnumerable<string> GetDynamicMemberNames()
        {
             throw new NotImplementedException();
        }
        
        
        public static DynamicMetaObject Create(object value, Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
