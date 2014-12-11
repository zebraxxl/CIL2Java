using System.ComponentModel;
using System;
using System.Runtime.InteropServices;
using System.IO;
using System.Security;

namespace System.Diagnostics
{
    [DefaultPropertyAttribute("StartInfo")]
    [DesignerAttribute("System.Diagnostics.Design.ProcessDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [MonitoringDescriptionAttribute("ProcessDesc")]
    [DefaultEventAttribute("Exited")]
    public class Process : Component
    {
    
        [MonitoringDescriptionAttribute("ProcessAssociated")]
        [BrowsableAttribute(true)]
        public event DataReceivedEventHandler OutputDataReceived;
    
        [MonitoringDescriptionAttribute("ProcessAssociated")]
        [BrowsableAttribute(true)]
        public event DataReceivedEventHandler ErrorDataReceived;
    
        [CategoryAttribute("Behavior")]
        [MonitoringDescriptionAttribute("ProcessExited")]
        public event EventHandler Exited;
    
    
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [MonitoringDescriptionAttribute("ProcessBasePriority")]
        public int BasePriority
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessExitCode")]
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public int ExitCode
        {
            get { throw new NotImplementedException(); }
        }
    
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [BrowsableAttribute(false)]
        [MonitoringDescriptionAttribute("ProcessTerminated")]
        public bool HasExited
        {
            get { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        [MonitoringDescriptionAttribute("ProcessExitTime")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public DateTime ExitTime
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessHandle")]
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public IntPtr Handle
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessHandleCount")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public int HandleCount
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessId")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public int Id
        {
            get { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [MonitoringDescriptionAttribute("ProcessMachineName")]
        public string MachineName
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessMainWindowHandle")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public IntPtr MainWindowHandle
        {
            get { throw new NotImplementedException(); }
        }
    
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [MonitoringDescriptionAttribute("ProcessMainWindowTitle")]
        public string MainWindowTitle
        {
            get { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        [MonitoringDescriptionAttribute("ProcessMainModule")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public ProcessModule MainModule
        {
            get { throw new NotImplementedException(); }
        }
    
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [MonitoringDescriptionAttribute("ProcessMaxWorkingSet")]
        public IntPtr MaxWorkingSet
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessMinWorkingSet")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public IntPtr MinWorkingSet
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [MonitoringDescriptionAttribute("ProcessModules")]
        public ProcessModuleCollection Modules
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessNonpagedSystemMemorySize")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [ObsoleteAttribute("This property has been deprecated.  Please use System.Diagnostics.Process.NonpagedSystemMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public int NonpagedSystemMemorySize
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessNonpagedSystemMemorySize")]
        [ComVisibleAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public long NonpagedSystemMemorySize64
        {
            get { throw new NotImplementedException(); }
        }
    
        [ObsoleteAttribute("This property has been deprecated.  Please use System.Diagnostics.Process.PagedMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [MonitoringDescriptionAttribute("ProcessPagedMemorySize")]
        public int PagedMemorySize
        {
            get { throw new NotImplementedException(); }
        }
    
        [ComVisibleAttribute(false)]
        [MonitoringDescriptionAttribute("ProcessPagedMemorySize")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public long PagedMemorySize64
        {
            get { throw new NotImplementedException(); }
        }
    
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [ObsoleteAttribute("This property has been deprecated.  Please use System.Diagnostics.Process.PagedSystemMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        [MonitoringDescriptionAttribute("ProcessPagedSystemMemorySize")]
        public int PagedSystemMemorySize
        {
            get { throw new NotImplementedException(); }
        }
    
        [ComVisibleAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [MonitoringDescriptionAttribute("ProcessPagedSystemMemorySize")]
        public long PagedSystemMemorySize64
        {
            get { throw new NotImplementedException(); }
        }
    
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [ObsoleteAttribute("This property has been deprecated.  Please use System.Diagnostics.Process.PeakPagedMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        [MonitoringDescriptionAttribute("ProcessPeakPagedMemorySize")]
        public int PeakPagedMemorySize
        {
            get { throw new NotImplementedException(); }
        }
    
        [ComVisibleAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [MonitoringDescriptionAttribute("ProcessPeakPagedMemorySize")]
        public long PeakPagedMemorySize64
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessPeakWorkingSet")]
        [ObsoleteAttribute("This property has been deprecated.  Please use System.Diagnostics.Process.PeakWorkingSet64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public int PeakWorkingSet
        {
            get { throw new NotImplementedException(); }
        }
    
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [MonitoringDescriptionAttribute("ProcessPeakWorkingSet")]
        [ComVisibleAttribute(false)]
        public long PeakWorkingSet64
        {
            get { throw new NotImplementedException(); }
        }
    
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [MonitoringDescriptionAttribute("ProcessPeakVirtualMemorySize")]
        [ObsoleteAttribute("This property has been deprecated.  Please use System.Diagnostics.Process.PeakVirtualMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public int PeakVirtualMemorySize
        {
            get { throw new NotImplementedException(); }
        }
    
        [ComVisibleAttribute(false)]
        [MonitoringDescriptionAttribute("ProcessPeakVirtualMemorySize")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public long PeakVirtualMemorySize64
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessPriorityBoostEnabled")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public bool PriorityBoostEnabled
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessPriorityClass")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public ProcessPriorityClass PriorityClass
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessPrivateMemorySize")]
        [ObsoleteAttribute("This property has been deprecated.  Please use System.Diagnostics.Process.PrivateMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public int PrivateMemorySize
        {
            get { throw new NotImplementedException(); }
        }
    
        [ComVisibleAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [MonitoringDescriptionAttribute("ProcessPrivateMemorySize")]
        public long PrivateMemorySize64
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessPrivilegedProcessorTime")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public TimeSpan PrivilegedProcessorTime
        {
            get { throw new NotImplementedException(); }
        }
    
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [MonitoringDescriptionAttribute("ProcessProcessName")]
        public string ProcessName
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessProcessorAffinity")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public IntPtr ProcessorAffinity
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessResponding")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public bool Responding
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessSessionId")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public int SessionId
        {
            get { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [MonitoringDescriptionAttribute("ProcessStartInfo")]
        public ProcessStartInfo StartInfo
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [MonitoringDescriptionAttribute("ProcessStartTime")]
        public DateTime StartTime
        {
            get { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        [DefaultValueAttribute(null)]
        [MonitoringDescriptionAttribute("ProcessSynchronizingObject")]
        public ISynchronizeInvoke SynchronizingObject
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [MonitoringDescriptionAttribute("ProcessThreads")]
        public ProcessThreadCollection Threads
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessTotalProcessorTime")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public TimeSpan TotalProcessorTime
        {
            get { throw new NotImplementedException(); }
        }
    
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [MonitoringDescriptionAttribute("ProcessUserProcessorTime")]
        public TimeSpan UserProcessorTime
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessVirtualMemorySize")]
        [ObsoleteAttribute("This property has been deprecated.  Please use System.Diagnostics.Process.VirtualMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public int VirtualMemorySize
        {
            get { throw new NotImplementedException(); }
        }
    
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [MonitoringDescriptionAttribute("ProcessVirtualMemorySize")]
        [ComVisibleAttribute(false)]
        public long VirtualMemorySize64
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessEnableRaisingEvents")]
        [BrowsableAttribute(false)]
        [DefaultValueAttribute(false)]
        public bool EnableRaisingEvents
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessStandardInput")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [BrowsableAttribute(false)]
        public StreamWriter StandardInput
        {
            get { throw new NotImplementedException(); }
        }
    
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [BrowsableAttribute(false)]
        [MonitoringDescriptionAttribute("ProcessStandardOutput")]
        public StreamReader StandardOutput
        {
            get { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [MonitoringDescriptionAttribute("ProcessStandardError")]
        public StreamReader StandardError
        {
            get { throw new NotImplementedException(); }
        }
    
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [ObsoleteAttribute("This property has been deprecated.  Please use System.Diagnostics.Process.WorkingSet64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        [MonitoringDescriptionAttribute("ProcessWorkingSet")]
        public int WorkingSet
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessWorkingSet")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [ComVisibleAttribute(false)]
        public long WorkingSet64
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public Process()
        {
             throw new NotImplementedException();
        }
        
        
        public bool CloseMainWindow()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public void Close()
        {
             throw new NotImplementedException();
        }
        
        
        public static void EnterDebugMode()
        {
             throw new NotImplementedException();
        }
        
        
        public static void LeaveDebugMode()
        {
             throw new NotImplementedException();
        }
        
        
        public static Process GetProcessById(int processId, string machineName)
        {
             throw new NotImplementedException();
        }
        
        
        public static Process GetProcessById(int processId)
        {
             throw new NotImplementedException();
        }
        
        
        public static Process[] GetProcessesByName(string processName)
        {
             throw new NotImplementedException();
        }
        
        
        public static Process[] GetProcessesByName(string processName, string machineName)
        {
             throw new NotImplementedException();
        }
        
        
        public static Process[] GetProcesses()
        {
             throw new NotImplementedException();
        }
        
        
        public static Process[] GetProcesses(string machineName)
        {
             throw new NotImplementedException();
        }
        
        
        public static Process GetCurrentProcess()
        {
             throw new NotImplementedException();
        }
        
        
        protected void OnExited()
        {
             throw new NotImplementedException();
        }
        
        
        public void Refresh()
        {
             throw new NotImplementedException();
        }
        
        
        public bool Start()
        {
             throw new NotImplementedException();
        }
        
        
        public static Process Start(string fileName, string userName, SecureString password, string domain)
        {
             throw new NotImplementedException();
        }
        
        
        public static Process Start(string fileName, string arguments, string userName, SecureString password, string domain)
        {
             throw new NotImplementedException();
        }
        
        
        public static Process Start(string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public static Process Start(string fileName, string arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public static Process Start(ProcessStartInfo startInfo)
        {
             throw new NotImplementedException();
        }
        
        
        public void Kill()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        public bool WaitForExit(int milliseconds)
        {
             throw new NotImplementedException();
        }
        
        
        public void WaitForExit()
        {
             throw new NotImplementedException();
        }
        
        
        public bool WaitForInputIdle(int milliseconds)
        {
             throw new NotImplementedException();
        }
        
        
        public bool WaitForInputIdle()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public void BeginOutputReadLine()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public void BeginErrorReadLine()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public void CancelOutputRead()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public void CancelErrorRead()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
