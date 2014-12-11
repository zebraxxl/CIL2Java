using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Contains the type description and process transfer information for a variable, function, or a function parameter.</summary>
    public struct ELEMDESC
    {
        public struct DESCUNION
        {
            public IDLDESC idldesc;
            public PARAMDESC paramdesc;
        
        }
    
        /// <summary>Identifies the type of the element.</summary>
        public TYPEDESC tdesc;
        /// <summary>Contains information about an element.</summary>
        public DESCUNION desc;
    
    }
}
