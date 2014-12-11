using System.ComponentModel;
using System.Runtime.Serialization;
using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
    [Serializable]
    [ToolboxItemAttribute(false)]
    [DesignTimeVisibleAttribute(false)]
    public sealed class EventLogEntry : Component, ISerializable
    {
    
        [MonitoringDescriptionAttribute("LogEntryMachineName")]
        public string MachineName
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("LogEntryData")]
        public byte[] Data
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("LogEntryIndex")]
        public int Index
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("LogEntryCategory")]
        public string Category
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("LogEntryCategoryNumber")]
        public short CategoryNumber
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("LogEntryEventID")]
        [ObsoleteAttribute("This property has been deprecated.  Please use System.Diagnostics.EventLogEntry.InstanceId instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public int EventID
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("LogEntryEntryType")]
        public EventLogEntryType EntryType
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("LogEntryMessage")]
        [EditorAttribute("System.ComponentModel.Design.BinaryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string Message
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("LogEntrySource")]
        public string Source
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("LogEntryReplacementStrings")]
        public string[] ReplacementStrings
        {
            get { throw new NotImplementedException(); }
        }
    
        [ComVisibleAttribute(false)]
        [MonitoringDescriptionAttribute("LogEntryResourceId")]
        public long InstanceId
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("LogEntryTimeGenerated")]
        public DateTime TimeGenerated
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("LogEntryTimeWritten")]
        public DateTime TimeWritten
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("LogEntryUserName")]
        public string UserName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public bool Equals(EventLogEntry otherEntry)
        {
             throw new NotImplementedException();
        }



        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
