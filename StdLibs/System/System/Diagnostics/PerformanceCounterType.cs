using System.ComponentModel;
using System;

namespace System.Diagnostics
{
    public enum PerformanceCounterType : int
    {
        NumberOfItems32 = 65536,
        NumberOfItems64 = 65792,
        NumberOfItemsHEX32 = 0,
        NumberOfItemsHEX64 = 256,
        RateOfCountsPerSecond32 = 272696320,
        RateOfCountsPerSecond64 = 272696576,
        CountPerTimeInterval32 = 4523008,
        CountPerTimeInterval64 = 4523264,
        RawFraction = 537003008,
        RawBase = 1073939459,
        AverageTimer32 = 805438464,
        AverageBase = 1073939458,
        AverageCount64 = 1073874176,
        SampleFraction = 549585920,
        SampleCounter = 4260864,
        SampleBase = 1073939457,
        CounterTimer = 541132032,
        CounterTimerInverse = 557909248,
        Timer100Ns = 542180608,
        Timer100NsInverse = 558957824,
        ElapsedTime = 807666944,
        CounterMultiTimer = 574686464,
        CounterMultiTimerInverse = 591463680,
        CounterMultiTimer100Ns = 575735040,
        CounterMultiTimer100NsInverse = 592512256,
        CounterMultiBase = 1107494144,
        CounterDelta32 = 4195328,
        CounterDelta64 = 4195584
    }
}
