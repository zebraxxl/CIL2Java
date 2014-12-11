using System.ComponentModel;

namespace System.Timers
{
    [DefaultEventAttribute("Elapsed")]
    [DefaultPropertyAttribute("Interval")]
    public class Timer : Component, ISupportInitialize
    {
    
        [CategoryAttribute("Behavior")]
        [TimersDescriptionAttribute("TimerIntervalElapsed")]
        public event ElapsedEventHandler Elapsed;
    
    
        [TimersDescriptionAttribute("TimerAutoReset")]
        [DefaultValueAttribute(true)]
        [CategoryAttribute("Behavior")]
        public bool AutoReset
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [CategoryAttribute("Behavior")]
        [DefaultValueAttribute(false)]
        [TimersDescriptionAttribute("TimerEnabled")]
        public bool Enabled
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [CategoryAttribute("Behavior")]
        [DefaultValueAttribute(100)]
        [TimersDescriptionAttribute("TimerInterval")]
        [SettingsBindableAttribute(true)]
        public double Interval
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override ISite Site
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [TimersDescriptionAttribute("TimerSynchronizingObject")]
        [DefaultValueAttribute(null)]
        [BrowsableAttribute(false)]
        public ISynchronizeInvoke SynchronizingObject
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public Timer()
        {
             throw new NotImplementedException();
        }
        
        
        public Timer(double interval)
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
        
        
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public void EndInit()
        {
             throw new NotImplementedException();
        }
        
        
        public void Start()
        {
             throw new NotImplementedException();
        }
        
        
        public void Stop()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
