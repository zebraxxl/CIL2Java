using System.ComponentModel;

namespace System.Diagnostics
{
    [Serializable]
    [TypeConverterAttribute("System.Diagnostics.Design.CounterCreationDataConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public class CounterCreationData
    {
    
        //[DefaultValueAttribute(Mono.Cecil.CustomAttributeArgument)]
        [MonitoringDescriptionAttribute("CounterType")]
        public PerformanceCounterType CounterType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("CounterName")]
        [TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [DefaultValueAttribute("")]
        public string CounterName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("CounterHelp")]
        [DefaultValueAttribute("")]
        public string CounterHelp
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CounterCreationData()
        {
             throw new NotImplementedException();
        }
        
        
        public CounterCreationData(string counterName, string counterHelp, PerformanceCounterType counterType)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
