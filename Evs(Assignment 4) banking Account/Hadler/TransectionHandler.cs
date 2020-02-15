using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hadler
{
    public sealed class TransectionHandler
    {
        public event EventHandler<TransectionEventArgs> _TransectionEventHandler;
        private IList<ITransection> _transectionlist;

        public TransectionHandler()
        {
            _transectionlist = new List<ITransection>();
        }


        //ADDING TRANSECTION INTO LIST....

        public void AddTransection(ITransection obj)
        {
            var transection1 = obj as ITransection;
            if(transection1!=null)
            {
               _transectionlist.Add(transection1);
                _TransectionEventHandler?.Invoke(this, new TransectionEventArgs()
                {
                    transectioN = transection1
                }
                );
            }
        }


        //Display Transection History....

        public void DisplayTransectionHistory()
        {
            foreach(var i in _transectionlist)
            {
                Console.WriteLine(i);
            }
        }


        // ACCOUNT TRANSECTION.....
        public int Transection(int balance,int accountbalance,int option,IBankingAccount obj)
        {
            if(option==1)
            {
                var Withdrawbalance = obj.Withdraw(balance, accountbalance);
                return Withdrawbalance;
            }
            else if(option==2)
            {
                var DepositeBalnace = obj.Deposite(balance, accountbalance);
                return DepositeBalnace;

            }
            return balance;
          
        }


        //FOR BLOCK ACCOUNT NOTIFICATION...

        public void Blocknotification(ITransection t)
        {
            _TransectionEventHandler?.Invoke(this, new TransectionEventArgs()
            {
                transectioN = t
            }
            );
        }


       
    }
}
