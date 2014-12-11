using System;

namespace System.Diagnostics.PerformanceData
{
    public enum CounterSetInstanceType : int
    {
        Single = 0,
        Multiple = 2,
        GlobalAggregate = 4,
        GlobalAggregateWithHistory = 11,
        MultipleAggregate = 6,
        InstanceAggregate = 22
    }
}
