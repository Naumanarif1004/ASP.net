using System;
using System.Collections.Generic;
using System.Text;

namespace BloodBank
{
    class BloodRecord : IBloodRecord
    {
        public BloodRecord(int bloodno,string bloodg,DateTime date)
        {
            Bloodno = bloodno;
            Bloodname = bloodg;
            AddingDate = date;
        }
        public int Bloodno { get ; set ; }
        public string Bloodname { get ; set ; }
        public DateTime AddingDate { get; set ; }

        public bool BloodgroupChecking(string Bgroup)
        {
            if((Bgroup.Equals("A+")) || (Bgroup.Equals("B+")) || Bgroup.Equals("AB+") || Bgroup.Equals("O+") || Bgroup.Equals("A-") || 
                Bgroup.Equals("B-") || Bgroup.Equals("AB-") || Bgroup.Equals("O-"))
            {
                return true;
            }
            else
            {
                return false;
            }
            return false;
        }
        public override string ToString()
        {
            return $"BLOOD ID:: {Bloodno}-----BLOOG GROUP:: {Bloodname}----ADDING DATE:: {AddingDate}";
        }
    }
}
