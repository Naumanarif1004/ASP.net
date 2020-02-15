using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
   public  class AccountCreationSms
    {
        public void Notification(object source, AccountEventArgs ACArgs)
        {
            Console.WriteLine($"\n\t\t\tSMS To: {ACArgs.account.PhoneNo}\n\nDear {ACArgs.account.Username}\n\n Your Account Of Type  {ACArgs.account.Type}    Account No  : {ACArgs.account.AccountNo}   Cnic  : {ACArgs.account.Cnic}  Has Been Sucessfully Created O On Date  : {DateTime.Now.ToLongDateString()}  {DateTime.Now.ToLongTimeString()} " +
                $"\n\n Your Current Account Balance  : {ACArgs.account.AccountBalance}");
        }
    }
}
