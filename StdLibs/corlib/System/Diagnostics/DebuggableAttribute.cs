using System.Runtime.InteropServices;
using System;

namespace System.Diagnostics
{
    /// <summary>Modifies code generation for runtime just-in-time (JIT) debugging. This class cannot be inherited.</summary><filterpriority>1</filterpriority>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Module, AllowMultiple = false)]
    public sealed class DebuggableAttribute : Attribute
    {
        [FlagsAttribute()]
        [ComVisibleAttribute(true)]
        public enum DebuggingModes : int
        {
            None = 0,
            Default = 1,
            DisableOptimizations = 256,
            IgnoreSymbolStoreSequencePoints = 2,
            EnableEditAndContinue = 4
        }
    
    
        /// <summary>Gets a value that indicates whether the runtime will track information during code generation for the debugger.</summary><returns>true if the runtime will track information during code generation for the debugger; otherwise, false.</returns><filterpriority>2</filterpriority>
        public bool IsJITTrackingEnabled
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the runtime optimizer is disabled.</summary><returns>true if the runtime optimizer is disabled; otherwise, false.</returns><filterpriority>2</filterpriority>
        public bool IsJITOptimizerDisabled
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the debugging modes for the attribute.</summary><returns>A bitwise combination of the <see cref="T:System.Diagnostics.DebuggableAttribute.DebuggingModes" /> values describing the debugging mode for the just-in-time (JIT) compiler. The default is <see cref="F:System.Diagnostics.DebuggableAttribute.DebuggingModes.Default" />. </returns><filterpriority>2</filterpriority>
        public DebuggingModes DebuggingFlags
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggableAttribute" /> class, using the specified tracking and optimization options for the just-in-time (JIT) compiler.</summary><param name="isJITTrackingEnabled">true to enable debugging; otherwise, false. </param><param name="isJITOptimizerDisabled">true to disable the optimizer for execution; otherwise, false. </param>
        public DebuggableAttribute(bool isJITTrackingEnabled, bool isJITOptimizerDisabled)
        {
             throw new NotImplementedException();
        }
        
        
        public DebuggableAttribute(DebuggingModes modes)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
