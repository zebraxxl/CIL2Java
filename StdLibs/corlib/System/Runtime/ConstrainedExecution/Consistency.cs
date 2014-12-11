using System;

namespace System.Runtime.ConstrainedExecution
{
    /// <summary>Specifies a reliability contract.</summary>
    [Serializable]
    public enum Consistency : int
    {
        /// <summary>In the face of exceptional conditions, the CLR makes no guarantees regarding state consistency; that is, the condition might corrupt the process.</summary>
        MayCorruptProcess = 0,
        /// <summary>In the face of exceptional conditions, the common language runtime (CLR) makes no guarantees regarding state consistency in the current application domain.</summary>
        MayCorruptAppDomain = 1,
        /// <summary>In the face of exceptional conditions, the method is guaranteed to limit state corruption to the current instance.</summary>
        MayCorruptInstance = 2,
        /// <summary>In the face of exceptional conditions, the method is guaranteed not to corrupt state. </summary>
        WillNotCorruptState = 3
    }
}
