using System.ComponentModel;
using System;
using System.Runtime.ConstrainedExecution;

namespace System.Diagnostics
{
    [InstallerTypeAttribute("System.Diagnostics.PerformanceCounterInstaller,System.Configuration.Install, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public sealed class PerformanceCounter : Component, ISupportInitialize
    {
        [ObsoleteAttribute("This field has been deprecated and is not used.  Use machine.config or an application configuration file to set the size of the PerformanceCounter file mapping.")]
        public static int DefaultFileMappingSize;
    
        [DefaultValueAttribute("")]
        [SettingsBindableAttribute(true)]
        [ReadOnlyAttribute(true)]
        [TypeConverterAttribute("System.Diagnostics.Design.CategoryValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string CategoryName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [MonitoringDescriptionAttribute("PC_CounterHelp")]
        [ReadOnlyAttribute(true)]
        public string CounterHelp
        {
            get { throw new NotImplementedException(); }
        }
    
        [SettingsBindableAttribute(true)]
        [ReadOnlyAttribute(true)]
        [DefaultValueAttribute("")]
        [TypeConverterAttribute("System.Diagnostics.Design.CounterNameConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string CounterName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("PC_CounterType")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public PerformanceCounterType CounterType
        {
            get { throw new NotImplementedException(); }
        }

        [DefaultValueAttribute(PerformanceCounterInstanceLifetime.Global)]
        public PerformanceCounterInstanceLifetime InstanceLifetime
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [TypeConverterAttribute("System.Diagnostics.Design.InstanceNameConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [SettingsBindableAttribute(true)]
        [ReadOnlyAttribute(true)]
        [DefaultValueAttribute("")]
        public string InstanceName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        [DefaultValueAttribute(true)]
        [MonitoringDescriptionAttribute("PC_ReadOnly")]
        public bool ReadOnly
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [SettingsBindableAttribute(true)]
        [DefaultValueAttribute(".")]
        [BrowsableAttribute(false)]
        public string MachineName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("PC_RawValue")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [BrowsableAttribute(false)]
        public long RawValue
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public PerformanceCounter()
        {
             throw new NotImplementedException();
        }
        
        
        public PerformanceCounter(string categoryName, string counterName, string instanceName, string machineName)
        {
             throw new NotImplementedException();
        }
        
        
        public PerformanceCounter(string categoryName, string counterName, string instanceName)
        {
             throw new NotImplementedException();
        }
        
        
        public PerformanceCounter(string categoryName, string counterName, string instanceName, bool readOnly)
        {
             throw new NotImplementedException();
        }
        
        
        public PerformanceCounter(string categoryName, string counterName)
        {
             throw new NotImplementedException();
        }
        
        
        public PerformanceCounter(string categoryName, string counterName, bool readOnly)
        {
             throw new NotImplementedException();
        }
        
        
        public void BeginInit()
        {
             throw new NotImplementedException();
        }
        
        
        public void Close()
        {
             throw new NotImplementedException();
        }
        
        
        public static void CloseSharedResources()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public long Decrement()
        {
             throw new NotImplementedException();
        }
        
        
        public void EndInit()
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public long IncrementBy(long value)
        {
             throw new NotImplementedException();
        }
        
        
        public long Increment()
        {
             throw new NotImplementedException();
        }
        
        
        public CounterSample NextSample()
        {
             throw new NotImplementedException();
        }
        
        
        public float NextValue()
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public void RemoveInstance()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
