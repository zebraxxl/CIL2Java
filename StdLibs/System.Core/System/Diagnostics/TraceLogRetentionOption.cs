using System;

namespace System.Diagnostics
{
    public enum TraceLogRetentionOption : int
    {
        SingleFileUnboundedSize = 2,
        SingleFileBoundedSize = 4,
        UnlimitedSequentialFiles = 0,
        LimitedSequentialFiles = 3,
        LimitedCircularFiles = 1
    }
}
