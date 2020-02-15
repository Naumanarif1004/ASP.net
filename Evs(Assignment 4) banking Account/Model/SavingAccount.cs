using System;

namespace Model
{
    public class SavingAccount : IBankingAccount
    {
        public SavingAccount(int accountno, string name, string fname, string address, string cnic, string city, AccountType type, DateTime date,AccountStatus status,string email,string phoneno)
        {
            AccountNo = accountno;
            Username = name;
            FatherName = fname;
            Address = address;
            Cnic = cnic;
            City = city;
            Type = type;
            AccountCreationDate = date;
            Status = status;
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
        public string PhoneNo { get; set; }


        //DEPOSITE METHODE.......
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
        public int Withdraw(int _withdrawPrice, int AccountBalance)
        {
            if ((_withdrawPrice > AccountBalance) || (_withdrawPrice <= 0))
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

        //Tostring Methode..
        public override string ToString()
        {
            return $"\nAccount NO  : {AccountNo}   UserName  : {Username}   Father Name  : {FatherName}  UserCnic  : {Cnic}" +
                $"  User Email Address  : {EmailAddress}  User City  : {City}     UserAddress  : {Address}    AccountType  : {Type}   Account Status  : {Status}   Balance  : {AccountBalance}" +
                $"   SMS Activation  : {SmsActivation}    Email Activation  : {EmailActivation}   Account Creating Date  : {AccountCreationDate}";
        }

       
    }
}
