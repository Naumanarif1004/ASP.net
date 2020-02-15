using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class WithdrawEmailService
    {
        public void TransectionNotification(object source, TransectionEventArgs arg)
        {
            Console.WriteLine($"\n\n\n\t\t\t\t\tEmail To : {arg.transectioN.Email}\n\n Dear : {arg.transectioN.Username}  \n\n Your Transection Is Completed Sucessfuly On  {DateTime.Now.ToLongDateString()}  {DateTime.Now.ToLongTimeString()}." +
                $"\n\n\t\t\tAccount Number           :       {arg.transectioN.AccountNO}" +
                $"\n\n\t\t\tUser Name                :       {arg.transectioN.Username}" +
                $"\n\n\t\t\tTransection TYpes        :       {arg.transectioN.TType}" +
                $"\n\n\t\t\tTransection Blance       :       {arg.transectioN.TransectionBalance}" +
                $"\n\n\t\t\tCurrent Account Balance  :       {arg.transectioN.AccountBalance}");

        }
    }
}
