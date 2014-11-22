using System.Security;

namespace System.Runtime
{
    /// <summary>Improves the startup performance of application domains in applications that require the just-in-time (JIT) compiler by performing background compilation of methods that are likely to be executed, based on profiles created during previous compilations. </summary>
    public static class ProfileOptimization
    {
        /// <summary>Enables optimization profiling for the current application domain, and sets the folder where the optimization profile files are stored. On a single-core computer, the method is ignored. </summary><param name="directoryPath">The full path to the folder where profile files are stored for the current application domain. </param>
        [SecurityCriticalAttribute()]
        public static void SetProfileRoot(string directoryPath)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Starts just-in-time (JIT) compilation of the methods that were previously recorded in the specified profile file, on a background thread. Starts the process of recording current method use, which later overwrites the specified profile file. </summary><param name="profile">The file name of the profile to use. </param>
        [SecurityCriticalAttribute()]
        public static void StartProfile(string profile)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
