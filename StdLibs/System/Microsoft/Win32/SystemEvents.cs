using System;
using System.ComponentModel;

namespace Microsoft.Win32
{
    public sealed class SystemEvents
    {
    
        public static event EventHandler DisplaySettingsChanging;
    
        public static event EventHandler DisplaySettingsChanged;
    
        public static event EventHandler EventsThreadShutdown;
    
        public static event EventHandler InstalledFontsChanged;
    
        [BrowsableAttribute(false)]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [ObsoleteAttribute("This event has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
        public static event EventHandler LowMemory;
    
        public static event EventHandler PaletteChanged;
    
        public static event PowerModeChangedEventHandler PowerModeChanged;
    
        public static event SessionEndedEventHandler SessionEnded;
    
        public static event SessionEndingEventHandler SessionEnding;
    
        public static event SessionSwitchEventHandler SessionSwitch;
    
        public static event EventHandler TimeChanged;
    
        public static event TimerElapsedEventHandler TimerElapsed;
    
        public static event UserPreferenceChangedEventHandler UserPreferenceChanged;
    
        public static event UserPreferenceChangingEventHandler UserPreferenceChanging;
    
    
    
        public static IntPtr CreateTimer(int interval)
        {
             throw new NotImplementedException();
        }
        
        
        public static void InvokeOnEventsThread(Delegate method)
        {
             throw new NotImplementedException();
        }
        
        
        public static void KillTimer(IntPtr timerId)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
