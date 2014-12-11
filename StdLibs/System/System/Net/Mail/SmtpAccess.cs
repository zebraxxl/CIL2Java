using System;

namespace System.Net.Mail
{
    public enum SmtpAccess : int
    {
        None = 0,
        Connect = 1,
        ConnectToUnrestrictedPort = 2
    }
}
