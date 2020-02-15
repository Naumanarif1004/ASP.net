using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Transection : ITransection
    {
        public Transection(int accuntno,string name,int  transectionbalance,int Accountbalnce,AccountType type,TransectionType ttype,string email,string phone)
        {
            TransectionId = Guid.NewGuid();
            AccountNO = accuntno;
            Username = name;
            TransectionBalance = transectionbalance;
            AccountBalance = Accountbalnce;
            Type = type;
            TType = ttype;
            Phon = phone;
            Email = email;
        }
        public Guid TransectionId { get; set; }
        public int AccountNO { get; set; }
        public string Username { get; set; }
        public int TransectionBalance { get; set; }
        public int AccountBalance { get; set; }
        public DateTime TransectionDate { get; set; }
        public AccountType Type { get; set; }
        public TransectionType TType { get; set; }
        public string Email { get; set ; }
        public string Phon { get ; set ; }

        public override string ToString()
        {
            return $"\nTransection Id  : {TransectionId}    Transection Type  : {TType}    Account No  : {AccountNO}   UserName  : {Username}" +
                $"   Transection Balance  : {TransectionBalance}   Account Balance  : {AccountBalance}  Account Type  : {Type}    Transection Date  : {TransectionDate }";
        }
    }
}
