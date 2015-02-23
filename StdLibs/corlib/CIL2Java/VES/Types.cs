using System;
using System.Collections.Generic;

namespace CIL2Java.VES
{
    public static class Types
    {
        private static java.util.Map jclass2type;

        static Types()
        {
            jclass2type = java.util.Collections.synchronizedMap(new java.util.HashMap());
        }

        public static Type GetTypeForJavaClass(java.lang.Class jclass)
        {
            if (jclass2type.containsKey(jclass))
                return (Type)jclass2type.get(jclass);

            Type t = new InternalTypes.InternalType(jclass);
            jclass2type.put(jclass, t);
            return t;
        }
    }
}
