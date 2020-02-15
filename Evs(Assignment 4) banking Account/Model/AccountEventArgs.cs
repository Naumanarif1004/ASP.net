using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class AccountEventArgs:EventArgs
    {

        public IBankingAccount account { get; set; }
     
       
    }
}
