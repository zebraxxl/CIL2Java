
namespace System.ComponentModel.Design
{
    public interface IDesignerOptionService
    {
        object GetOptionValue(string pageName, string valueName);
        
        
        void SetOptionValue(string pageName, string valueName, object value);
        
        
    }
}
