using System;

namespace System.Diagnostics
{
    public sealed class PerformanceCounterCategory
    {
    
        public string CategoryName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string CategoryHelp
        {
            get { throw new NotImplementedException(); }
        }
    
        public PerformanceCounterCategoryType CategoryType
        {
            get { throw new NotImplementedException(); }
        }
    
        public string MachineName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public PerformanceCounterCategory()
        {
             throw new NotImplementedException();
        }
        
        
        public PerformanceCounterCategory(string categoryName)
        {
             throw new NotImplementedException();
        }
        
        
        public PerformanceCounterCategory(string categoryName, string machineName)
        {
             throw new NotImplementedException();
        }
        
        
        public bool CounterExists(string counterName)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool CounterExists(string counterName, string categoryName)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool CounterExists(string counterName, string categoryName, string machineName)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This method has been deprecated.  Please use System.Diagnostics.PerformanceCounterCategory.Create(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, string counterName, string counterHelp) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, string counterName, string counterHelp)
        {
             throw new NotImplementedException();
        }
        
        
        public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, string counterName, string counterHelp)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This method has been deprecated.  Please use System.Diagnostics.PerformanceCounterCategory.Create(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, CounterCreationDataCollection counterData) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, CounterCreationDataCollection counterData)
        {
             throw new NotImplementedException();
        }
        
        
        public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, CounterCreationDataCollection counterData)
        {
             throw new NotImplementedException();
        }
        
        
        public static void Delete(string categoryName)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool Exists(string categoryName)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool Exists(string categoryName, string machineName)
        {
             throw new NotImplementedException();
        }
        
        
        public PerformanceCounter[] GetCounters()
        {
             throw new NotImplementedException();
        }
        
        
        public PerformanceCounter[] GetCounters(string instanceName)
        {
             throw new NotImplementedException();
        }
        
        
        public static PerformanceCounterCategory[] GetCategories()
        {
             throw new NotImplementedException();
        }
        
        
        public static PerformanceCounterCategory[] GetCategories(string machineName)
        {
             throw new NotImplementedException();
        }
        
        
        public string[] GetInstanceNames()
        {
             throw new NotImplementedException();
        }
        
        
        public bool InstanceExists(string instanceName)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool InstanceExists(string instanceName, string categoryName)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool InstanceExists(string instanceName, string categoryName, string machineName)
        {
             throw new NotImplementedException();
        }
        
        
        public InstanceDataCollectionCollection ReadCategory()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
