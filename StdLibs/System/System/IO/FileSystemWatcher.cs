using System.ComponentModel;

namespace System.IO
{
    [DefaultEventAttribute("Changed")]
    [IODescriptionAttribute("FileSystemWatcherDesc")]
    public class FileSystemWatcher : Component, ISupportInitialize
    {
    
        [IODescriptionAttribute("FSW_Changed")]
        public event FileSystemEventHandler Changed;
    
        [IODescriptionAttribute("FSW_Created")]
        public event FileSystemEventHandler Created;
    
        [IODescriptionAttribute("FSW_Deleted")]
        public event FileSystemEventHandler Deleted;
    
        [BrowsableAttribute(false)]
        public event ErrorEventHandler Error;
    
        [IODescriptionAttribute("FSW_Renamed")]
        public event RenamedEventHandler Renamed;
    
    
        //[DefaultValueAttribute(Mono.Cecil.CustomAttributeArgument)]
        [IODescriptionAttribute("FSW_ChangedFilter")]
        public NotifyFilters NotifyFilter
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [IODescriptionAttribute("FSW_Enabled")]
        [DefaultValueAttribute(false)]
        public bool EnableRaisingEvents
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [SettingsBindableAttribute(true)]
        [IODescriptionAttribute("FSW_Filter")]
        [TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [DefaultValueAttribute("*.*")]
        public string Filter
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [IODescriptionAttribute("FSW_IncludeSubdirectories")]
        [DefaultValueAttribute(false)]
        public bool IncludeSubdirectories
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        [DefaultValueAttribute(8192)]
        public int InternalBufferSize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [IODescriptionAttribute("FSW_Path")]
        [EditorAttribute("System.Diagnostics.Design.FSWPathEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [SettingsBindableAttribute(true)]
        [DefaultValueAttribute("")]
        public string Path
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        public override ISite Site
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [IODescriptionAttribute("FSW_SynchronizingObject")]
        [DefaultValueAttribute(null)]
        [BrowsableAttribute(false)]
        public ISynchronizeInvoke SynchronizingObject
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public FileSystemWatcher()
        {
             throw new NotImplementedException();
        }
        
        
        public FileSystemWatcher(string path)
        {
             throw new NotImplementedException();
        }
        
        
        public FileSystemWatcher(string path, string filter)
        {
             throw new NotImplementedException();
        }
        
        
        public void BeginInit()
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
        
        
        protected void OnChanged(FileSystemEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        protected void OnCreated(FileSystemEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        protected void OnDeleted(FileSystemEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        protected void OnError(ErrorEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        protected void OnRenamed(RenamedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType)
        {
             throw new NotImplementedException();
        }
        
        
        public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
