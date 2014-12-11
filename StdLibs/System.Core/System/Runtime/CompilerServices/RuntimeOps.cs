using System.ComponentModel;
using System.Diagnostics;
using System;
using System.Dynamic;
using System.Linq.Expressions;

namespace System.Runtime.CompilerServices
{
    [EditorBrowsableAttribute(EditorBrowsableState.Never)]
    [DebuggerStepThroughAttribute()]
    public static class RuntimeOps
    {
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [ObsoleteAttribute("do not use this method", true)]
        public static bool ExpandoTryGetValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase, ref object value)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [ObsoleteAttribute("do not use this method", true)]
        public static object ExpandoTrySetValue(ExpandoObject expando, object indexClass, int index, object value, string name, bool ignoreCase)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("do not use this method", true)]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public static bool ExpandoTryDeleteValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [ObsoleteAttribute("do not use this method", true)]
        public static bool ExpandoCheckVersion(ExpandoObject expando, object version)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("do not use this method", true)]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public static void ExpandoPromoteClass(ExpandoObject expando, object oldClass, object newClass)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [ObsoleteAttribute("do not use this method", true)]
        public static Expression Quote(Expression expression, object hoistedLocals, object[] locals)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("do not use this method", true)]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public static IRuntimeVariables MergeRuntimeVariables(IRuntimeVariables first, IRuntimeVariables second, int[] indexes)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("do not use this method", true)]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public static IRuntimeVariables CreateRuntimeVariables(object[] data, long[] indexes)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("do not use this method", true)]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public static IRuntimeVariables CreateRuntimeVariables()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
