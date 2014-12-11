using System;

namespace System.Net.Mail
{
    public enum SmtpDeliveryMethod : int
    {
        Network = 0,
        SpecifiedPickupDirectory = 1,
        PickupDirectoryFromIis = 2
    }
}
