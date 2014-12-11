using System.ComponentModel;
using System.Diagnostics;
using System;

namespace System.Runtime.CompilerServices
{
    [EditorBrowsableAttribute(EditorBrowsableState.Never)]
    [DebuggerStepThroughAttribute()]
    public static class CallSiteOps
    {
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [ObsoleteAttribute("do not use this method", true)]
        public static CallSite<T> CreateMatchmaker<T>(CallSite<T> site)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [ObsoleteAttribute("do not use this method", true)]
        public static bool SetNotMatched(CallSite site)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("do not use this method", true)]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public static bool GetMatch(CallSite site)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [ObsoleteAttribute("do not use this method", true)]
        public static void ClearMatch(CallSite site)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [ObsoleteAttribute("do not use this method", true)]
        public static void AddRule<T>(CallSite<T> site, T rule)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("do not use this method", true)]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public static void UpdateRules<T>(CallSite<T> @this, int matched)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [ObsoleteAttribute("do not use this method", true)]
        public static T[] GetRules<T>(CallSite<T> site)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("do not use this method", true)]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public static RuleCache<T> GetRuleCache<T>(CallSite<T> site)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [ObsoleteAttribute("do not use this method", true)]
        public static void MoveRule<T>(RuleCache<T> cache, T rule, int i)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("do not use this method", true)]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public static T[] GetCachedRules<T>(RuleCache<T> cache)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [ObsoleteAttribute("do not use this method", true)]
        public static T Bind<T>(CallSiteBinder binder, CallSite<T> site, object[] args)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
