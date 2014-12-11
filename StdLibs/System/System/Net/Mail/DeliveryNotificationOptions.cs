using System;

namespace System.Net.Mail
{
    [FlagsAttribute()]
    public enum DeliveryNotificationOptions : int
    {
        None = 0,
        OnSuccess = 1,
        OnFailure = 2,
        Delay = 4,
        Never = 134217728
    }
}
