using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
    /// <summary>Specifies that the type has a visualizer. This class cannot be inherited. </summary><filterpriority>1</filterpriority>
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct, AllowMultiple = true)]
    [ComVisibleAttribute(true)]
    public sealed class DebuggerVisualizerAttribute : Attribute
    {
    
        /// <summary>Gets the fully qualified type name of the visualizer object source.</summary><returns>The fully qualified type name of the visualizer object source.</returns><filterpriority>2</filterpriority>
        public string VisualizerObjectSourceTypeName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the fully qualified type name of the visualizer.</summary><returns>The fully qualified visualizer type name.</returns><filterpriority>2</filterpriority>
        public string VisualizerTypeName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the description of the visualizer.</summary><returns>The description of the visualizer.</returns><filterpriority>2</filterpriority>
        public string Description
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the target type when the attribute is applied at the assembly level.</summary><returns>The type that is the target of the visualizer.</returns><exception cref="T:System.ArgumentNullException">The value cannot be set because it is null.</exception><filterpriority>2</filterpriority>
        public Type Target
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the fully qualified type name when the attribute is applied at the assembly level.</summary><returns>The fully qualified type name of the target type.</returns><filterpriority>2</filterpriority>
        public string TargetTypeName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerVisualizerAttribute" /> class, specifying the type name of the visualizer.</summary><param name="visualizerTypeName">The fully qualified type name of the visualizer.</param>
        public DebuggerVisualizerAttribute(string visualizerTypeName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerVisualizerAttribute" /> class, specifying the type name of the visualizer and the type name of the visualizer object source.</summary><param name="visualizerTypeName">The fully qualified type name of the visualizer.</param><param name="visualizerObjectSourceTypeName">The fully qualified type name of the visualizer object source.</param>
        public DebuggerVisualizerAttribute(string visualizerTypeName, string visualizerObjectSourceTypeName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerVisualizerAttribute" /> class, specifying the type name of the visualizer and the type of the visualizer object source.</summary><param name="visualizerTypeName">The fully qualified type name of the visualizer.</param><param name="visualizerObjectSource">The type of the visualizer object source.</param><exception cref="T:System.ArgumentNullException"><paramref name="visualizerObjectSource" /> is null.</exception>
        public DebuggerVisualizerAttribute(string visualizerTypeName, Type visualizerObjectSource)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerVisualizerAttribute" /> class, specifying the type of the visualizer.</summary><param name="visualizer">The type of the visualizer.</param><exception cref="T:System.ArgumentNullException">v<paramref name="isualizer" /> is null.</exception>
        public DebuggerVisualizerAttribute(Type visualizer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerVisualizerAttribute" /> class, specifying the type of the visualizer and the type of the visualizer object source.</summary><param name="visualizer">The type of the visualizer.</param><param name="visualizerObjectSource">The type of the visualizer object source.</param><exception cref="T:System.ArgumentNullException">v<paramref name="isualizer" /> is null.</exception><exception cref="T:System.ArgumentNullException"><paramref name="visualizerObjectSource" /> is null.</exception>
        public DebuggerVisualizerAttribute(Type visualizer, Type visualizerObjectSource)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerVisualizerAttribute" /> class, specifying the type of the visualizer and the type name of the visualizer object source.</summary><param name="visualizer">The type of the visualizer.</param><param name="visualizerObjectSourceTypeName">The fully qualified type name of the visualizer object source.</param><exception cref="T:System.ArgumentNullException">v<paramref name="isualizer" /> is null.</exception>
        public DebuggerVisualizerAttribute(Type visualizer, string visualizerObjectSourceTypeName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
