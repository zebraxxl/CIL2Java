
namespace System.Diagnostics
{
    [SwitchLevelAttribute(typeof(TraceLevel))]
    public class TraceSwitch : Switch
    {
        public TraceLevel Level
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool TraceError
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool TraceWarning
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool TraceInfo
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool TraceVerbose
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public TraceSwitch(string displayName, string description)
        {
             throw new NotImplementedException();
        }
        
        
        public TraceSwitch(string displayName, string description, string defaultSwitchValue)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void OnSwitchSettingChanged()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void OnValueChanged()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
