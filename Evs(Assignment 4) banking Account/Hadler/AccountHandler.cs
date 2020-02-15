using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hadler
{
    public class AccountHandler
    {
        IEnumerable<IBankingAccount> enumerableobj=null;
        AccountEventArgs Accountargs = new AccountEventArgs();
        private readonly IList<IBankingAccount> _bankAccount;
        public event EventHandler<AccountEventArgs> _Creation;
        
        public AccountHandler()
        {
            _bankAccount = new List<IBankingAccount>();
        }

        //Adding (Account) Method...........
        public void AddAccount(IBankingAccount obj)
        {
            var Account = obj as IBankingAccount;
            if(Account!=null)
            {
                _bankAccount.Add(Account);
                _Creation?.Invoke(this, new AccountEventArgs()
                {
                    account = Account
                }
                    
                    );
              





            }
        }

        //Display (All Account History) Method............
        public void DisplayAllAccount()
        {
            foreach(var i in _bankAccount)
            {
                Console.WriteLine(i);
            }
        }

        //List Account By Account Type (METHOD)....
      public IEnumerable<IBankingAccount> GetAccountsByType<SavingAccount>(AccountType type)
        {
            enumerableobj = _bankAccount.Where(s => s.Type == type);
            foreach(var i in enumerableobj)
            {
                Console.WriteLine(i);
            }
            return enumerableobj;

        }

        //List Saving Account By Status Block/UnBlock  (METHOD).......
        public IEnumerable<IBankingAccount> GetSavingAccountsByStatus<SavingAccount>(AccountStatus status)
        {
            enumerableobj = _bankAccount.Where(s => s.Status == status);
            foreach (var i in enumerableobj)
            {
                Console.WriteLine(i);
            }
            return enumerableobj;

        }


        //Display Account Detail By Account Number (METHOD).....
        public IBankingAccount GetAccountDetail(int accountno,bool IgnoreCase=false)
        {
            return _bankAccount.FirstOrDefault(s => string.Compare(s.AccountNo.ToString(), accountno.ToString()) == 0);
        }

        //Removing Account By Account No (METHOD).......

        public void DeleteAccount(IBankingAccount delAccount)
        {
            if(delAccount!=null)
            {
                _bankAccount.Remove(delAccount);
                _Creation?.Invoke(this, new AccountEventArgs()
                {
                    account = delAccount
                }

                   );

            }
        }


    }
}
