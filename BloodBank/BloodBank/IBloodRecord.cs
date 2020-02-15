using System;
using System.Collections.Generic;
using System.Text;

namespace BloodBank
{
    public interface IBloodRecord
    {
       int Bloodno { get; set; }
        string Bloodname { get; set; }
        DateTime AddingDate { get; set; }

        bool BloodgroupChecking(string Bgroup);
        

    }
}
