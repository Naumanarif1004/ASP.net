using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public enum AccountType
    {
        Current=1,
        Saving
    }

    public enum ActivationSms
    {
        Yes=1,
        No
    }

    public enum ActivationEmail
    {
        Yes=1,
        No
    }

    public enum AccountStatus
    {
        Block=1,
        UnBlock
    }
    public enum TransectionType
    {
        Deposite=1,
        WithDraw
    }
}
