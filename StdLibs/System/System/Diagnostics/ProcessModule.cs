using System.ComponentModel;
using System;

namespace System.Diagnostics
{
    [DesignerAttribute("System.Diagnostics.Design.ProcessModuleDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public class ProcessModule : Component
    {
    
        [MonitoringDescriptionAttribute("ProcModModuleName")]
        public string ModuleName
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcModFileName")]
        public string FileName
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcModBaseAddress")]
        public IntPtr BaseAddress
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcModModuleMemorySize")]
        public int ModuleMemorySize
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcModEntryPointAddress")]
        public IntPtr EntryPointAddress
        {
            get { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        public FileVersionInfo FileVersionInfo
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
