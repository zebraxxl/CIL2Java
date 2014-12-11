using System;

namespace System.Diagnostics
{
    public enum ThreadWaitReason : int
    {
        Executive = 0,
        FreePage = 1,
        PageIn = 2,
        SystemAllocation = 3,
        ExecutionDelay = 4,
        Suspended = 5,
        UserRequest = 6,
        EventPairHigh = 7,
        EventPairLow = 8,
        LpcReceive = 9,
        LpcReply = 10,
        VirtualMemory = 11,
        PageOut = 12,
        Unknown = 13
    }
}
