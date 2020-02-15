using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IBankingAccount
    {
        int AccountNo { get; set; }
        string Username { get; set; }
        string FatherName { get; set; }
        string Address { get; set; }
        string Cnic { get; set; }
        string City { get; set; }
        int AccountBalance { get; set; }
        AccountType Type { get; set; }
        AccountStatus Status { get; set; }
        ActivationSms SmsActivation { get; set; }
        ActivationEmail EmailActivation { get; set; }
        DateTime AccountCreationDate { get; set; }
        string EmailAddress { get; set; }
        string PhoneNo { get; set; }

        int Withdraw(int _withdrawPrice,int AccountBalance);
        int Deposite(int DepositePrice, int AccountBalance);
    }
}
