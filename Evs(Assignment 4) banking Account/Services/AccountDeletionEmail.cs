using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class AccountDeletionEmail
    {
        public void Notification(object source, AccountEventArgs ACArgs)
        {
            Console.WriteLine($"\n\n\t\t\tEmail To  : {ACArgs.account.EmailAddress}\n\nDear {ACArgs.account.Username}\n\n Your Account Of Type ::  {ACArgs.account.Type}    Account No  : {ACArgs.account.AccountNo}   Cnic  : {ACArgs.account.Cnic}  Has Been Deleted From BankAccounts  On Date  : {DateTime.Now.ToLongDateString()}  {DateTime.Now.ToLongTimeString()}");
        }
    }
}
