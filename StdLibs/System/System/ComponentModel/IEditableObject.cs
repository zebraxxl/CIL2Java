
namespace System.ComponentModel
{
    public interface IEditableObject
    {
        void BeginEdit();
        
        
        void EndEdit();
        
        
        void CancelEdit();
        
        
    }
}
