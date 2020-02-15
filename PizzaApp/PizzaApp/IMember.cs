using System;
using System.Collections.Generic;
using System.Text;

namespace FizzaApp
{
   public  interface IMember
    {
         int MembershipNo { set; get; }
        string MemberName { set; get; }
        string MemberCity { set; get; }
        DateTime MembershipDate { set; get; }
    }
}
