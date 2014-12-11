using System.Runtime.InteropServices;
using System;
using System.ComponentModel;

namespace System.ComponentModel.Design
{
    [ComVisibleAttribute(true)]
    public interface IDesignerHost : IServiceContainer
    {
        event EventHandler Activated;
    
        event EventHandler Deactivated;
    
        event EventHandler LoadComplete;
    
        event DesignerTransactionCloseEventHandler TransactionClosed;
    
        event DesignerTransactionCloseEventHandler TransactionClosing;
    
        event EventHandler TransactionOpened;
    
        event EventHandler TransactionOpening;
    
    
        bool Loading
        {
            get;
        }
    
        bool InTransaction
        {
            get;
        }
    
        IContainer Container
        {
            get;
        }
    
        IComponent RootComponent
        {
            get;
        }
    
        string RootComponentClassName
        {
            get;
        }
    
        string TransactionDescription
        {
            get;
        }
    
    
        void Activate();
        
        
        IComponent CreateComponent(Type componentClass);
        
        
        IComponent CreateComponent(Type componentClass, string name);
        
        
        DesignerTransaction CreateTransaction();
        
        
        DesignerTransaction CreateTransaction(string description);
        
        
        void DestroyComponent(IComponent component);
        
        
        IDesigner GetDesigner(IComponent component);
        
        
        Type GetType(string typeName);
        
        
    }
}
