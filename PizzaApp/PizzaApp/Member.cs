using System;
using System.Collections.Generic;
using System.Text;

namespace FizzaApp
{
    public   class Member : IMember
    {

        public Member(int memebershipno,string name,string city,DateTime date)
        {
            MembershipNo = memebershipno;
            MemberName = name;
            MemberCity = city;
            MembershipDate = date;
        }

        public int MembershipNo { get; set; }
        public string MemberName { get; set; }
        public string MemberCity { get; set ; }
        public DateTime MembershipDate { get; set; }
        
        public override string ToString()
        {
            return $"\n " +
                $"MEMBERSHIPNO::{MembershipNo}----MEMBERNAME::{MemberName}---MEMBERCITY::{MemberCity}::--MEMEBERSHIPDATE::{MembershipDate}";
        }
    }
}
