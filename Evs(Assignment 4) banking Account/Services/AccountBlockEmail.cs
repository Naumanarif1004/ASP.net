using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class AccountBlockEmail
    {
        public void BlockNotification(object source, TransectionEventArgs arg)
        {
            Console.WriteLine($"\n\t\t\tEmail To: {arg.transectioN.Email}\n\nDear {arg.transectioN.Username}\n\n Your Account Of Type  {arg.transectioN.Type}    Account No  : {arg.transectioN.AccountNO}     Has Been Blocked On Date  : {DateTime.Now.ToLongDateString()}  {DateTime.Now.ToLongTimeString()}");
        }
    }
}
