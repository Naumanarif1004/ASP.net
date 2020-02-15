using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public  class CurrentAccount:IBankingAccount
    {
        public CurrentAccount(int accountno,string name,string fname,string address,string email,string cnic,string city,AccountType type, DateTime date,string phoneno)
        {
            AccountNo = accountno;
            Username = name;
            FatherName = fname;
            Address = address;
            Cnic = cnic;
            City = city;
            Type = type;
            AccountCreationDate = date;
            EmailAddress = email;
            PhoneNo = phoneno;
        }
        public int AccountNo { get; set; }
        public string Username { get; set; }
        public string FatherName { get; set; }
        public string Address { get; set; }
        public string Cnic { get; set; }
        public string City { get; set; }
        public int AccountBalance { get; set; }
        public AccountType Type { get; set; }
        public AccountStatus Status { get; set; }
        public DateTime AccountCreationDate { get; set; }
        public string EmailAddress { get; set; }
        public ActivationSms SmsActivation { get; set; }
        public ActivationEmail EmailActivation { get; set; }
        public string PhoneNo { get ; set ; }



        //Deposite Methode.....
        public int Deposite(int DepositePrice, int AccountBalance)
        {
            if ((DepositePrice < 0))
            {
                Console.WriteLine("You Entered Invalid BalANCE....");
            }
            else
            {
            
                AccountBalance += DepositePrice;
                return AccountBalance;
                
          
           }
            return AccountBalance;
        }



        //Withdraw Methode...
        public int Withdraw(int _withdrawPrice,int AccountBalance)
        {
           if((_withdrawPrice>AccountBalance) ||  (_withdrawPrice<=0))
            {
                Console.WriteLine("You Entered Invalid BalANCE....");
            }
            else
            {
                AccountBalance -= _withdrawPrice;
                return AccountBalance;
            }
            return AccountBalance;
        }



        //TO STRING METHODE..........
        public override string ToString()
        {
            return $"\nAccount NO  : {AccountNo}   UserName  : {Username}   Father Name  : {FatherName}  UserCnic  : {Cnic}" +
                $"  User PhoneNo  : {PhoneNo}   User City  : {City}     UserAddress  : {Address}   User EmailAddress  : {EmailAddress}   AccountType  : {Type}     Balance  : {AccountBalance}" +
                $"   SMS Activation  : {SmsActivation}    Email Activation  : {EmailActivation}   Account Creating Date  : {AccountCreationDate}";
        }
    }
}
