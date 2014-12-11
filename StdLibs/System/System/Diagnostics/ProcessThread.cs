using System.ComponentModel;
using System;

namespace System.Diagnostics
{
    [DesignerAttribute("System.Diagnostics.Design.ProcessThreadDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public class ProcessThread : Component
    {
    
        [MonitoringDescriptionAttribute("ThreadBasePriority")]
        public int BasePriority
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ThreadCurrentPriority")]
        public int CurrentPriority
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ThreadId")]
        public int Id
        {
            get { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        public int IdealProcessor
        {
            set { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ThreadPriorityBoostEnabled")]
        public bool PriorityBoostEnabled
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ThreadPriorityLevel")]
        public ThreadPriorityLevel PriorityLevel
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ThreadPrivilegedProcessorTime")]
        public TimeSpan PrivilegedProcessorTime
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ThreadStartAddress")]
        public IntPtr StartAddress
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ThreadStartTime")]
        public DateTime StartTime
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ThreadThreadState")]
        public ThreadState ThreadState
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ThreadTotalProcessorTime")]
        public TimeSpan TotalProcessorTime
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ThreadUserProcessorTime")]
        public TimeSpan UserProcessorTime
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ThreadWaitReason")]
        public ThreadWaitReason WaitReason
        {
            get { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        public IntPtr ProcessorAffinity
        {
            set { throw new NotImplementedException(); }
        }
    
    
        public void ResetIdealProcessor()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
