using System.ComponentModel;
using System.Runtime.InteropServices;
using System;

namespace System.Diagnostics
{
    [MonitoringDescriptionAttribute("EventLogDesc")]
    [DefaultEventAttribute("EntryWritten")]
    [InstallerTypeAttribute("System.Diagnostics.EventLogInstaller, System.Configuration.Install, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public class EventLog : Component, ISupportInitialize
    {
    
        [MonitoringDescriptionAttribute("LogEntryWritten")]
        public event EntryWrittenEventHandler EntryWritten;
    
    
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [MonitoringDescriptionAttribute("LogEntries")]
        public EventLogEntryCollection Entries
        {
            get { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        public string LogDisplayName
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("LogLog")]
        [DefaultValueAttribute("")]
        [SettingsBindableAttribute(true)]
        [TypeConverterAttribute("System.Diagnostics.Design.LogConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [ReadOnlyAttribute(true)]
        public string Log
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ReadOnlyAttribute(true)]
        [DefaultValueAttribute(".")]
        [MonitoringDescriptionAttribute("LogMachineName")]
        [SettingsBindableAttribute(true)]
        public string MachineName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ComVisibleAttribute(false)]
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public long MaximumKilobytes
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        [ComVisibleAttribute(false)]
        public OverflowAction OverflowAction
        {
            get { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        [ComVisibleAttribute(false)]
        public int MinimumRetentionDays
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("LogMonitoring")]
        [BrowsableAttribute(false)]
        [DefaultValueAttribute(false)]
        public bool EnableRaisingEvents
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        [MonitoringDescriptionAttribute("LogSynchronizingObject")]
        [DefaultValueAttribute(null)]
        public ISynchronizeInvoke SynchronizingObject
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [SettingsBindableAttribute(true)]
        [DefaultValueAttribute("")]
        [ReadOnlyAttribute(true)]
        [TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [MonitoringDescriptionAttribute("LogSource")]
        public string Source
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public EventLog()
        {
             throw new NotImplementedException();
        }
        
        
        public EventLog(string logName)
        {
             throw new NotImplementedException();
        }
        
        
        public EventLog(string logName, string machineName)
        {
             throw new NotImplementedException();
        }
        
        
        public EventLog(string logName, string machineName, string source)
        {
             throw new NotImplementedException();
        }
        
        
        public void BeginInit()
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public void Close()
        {
             throw new NotImplementedException();
        }
        
        
        public static void CreateEventSource(string source, string logName)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This method has been deprecated.  Please use System.Diagnostics.EventLog.CreateEventSource(EventSourceCreationData sourceData) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public static void CreateEventSource(string source, string logName, string machineName)
        {
             throw new NotImplementedException();
        }
        
        
        public static void CreateEventSource(EventSourceCreationData sourceData)
        {
             throw new NotImplementedException();
        }
        
        
        public static void Delete(string logName)
        {
             throw new NotImplementedException();
        }
        
        
        public static void Delete(string logName, string machineName)
        {
             throw new NotImplementedException();
        }
        
        
        public static void DeleteEventSource(string source)
        {
             throw new NotImplementedException();
        }
        
        
        public static void DeleteEventSource(string source, string machineName)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public void EndInit()
        {
             throw new NotImplementedException();
        }
        
        
        public static bool Exists(string logName)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool Exists(string logName, string machineName)
        {
             throw new NotImplementedException();
        }
        
        
        public static EventLog[] GetEventLogs()
        {
             throw new NotImplementedException();
        }
        
        
        public static EventLog[] GetEventLogs(string machineName)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool SourceExists(string source)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool SourceExists(string source, string machineName)
        {
             throw new NotImplementedException();
        }
        
        
        public static string LogNameFromSourceName(string source, string machineName)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public void ModifyOverflowPolicy(OverflowAction action, int retentionDays)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public void RegisterDisplayName(string resourceFile, long resourceId)
        {
             throw new NotImplementedException();
        }
        
        
        public void WriteEntry(string message)
        {
             throw new NotImplementedException();
        }
        
        
        public static void WriteEntry(string source, string message)
        {
             throw new NotImplementedException();
        }
        
        
        public void WriteEntry(string message, EventLogEntryType type)
        {
             throw new NotImplementedException();
        }
        
        
        public static void WriteEntry(string source, string message, EventLogEntryType type)
        {
             throw new NotImplementedException();
        }
        
        
        public void WriteEntry(string message, EventLogEntryType type, int eventID)
        {
             throw new NotImplementedException();
        }
        
        
        public static void WriteEntry(string source, string message, EventLogEntryType type, int eventID)
        {
             throw new NotImplementedException();
        }
        
        
        public void WriteEntry(string message, EventLogEntryType type, int eventID, short category)
        {
             throw new NotImplementedException();
        }
        
        
        public static void WriteEntry(string source, string message, EventLogEntryType type, int eventID, short category)
        {
             throw new NotImplementedException();
        }
        
        
        public static void WriteEntry(string source, string message, EventLogEntryType type, int eventID, short category, byte[] rawData)
        {
             throw new NotImplementedException();
        }
        
        
        public void WriteEntry(string message, EventLogEntryType type, int eventID, short category, byte[] rawData)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public void WriteEvent(EventInstance instance, params  object[] values)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public void WriteEvent(EventInstance instance, byte[] data, params  object[] values)
        {
             throw new NotImplementedException();
        }
        
        
        public static void WriteEvent(string source, EventInstance instance, params  object[] values)
        {
             throw new NotImplementedException();
        }
        
        
        public static void WriteEvent(string source, EventInstance instance, byte[] data, params  object[] values)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
