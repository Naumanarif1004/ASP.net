using Hadler;
using Model;
using Services;
using System;
using System.Threading;

namespace ConsoleApp
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int[] accountArr = new int[100];
            int index = 0;
            int count = 0;
            int option = 0;
            int acntNo = 0;
            int AccounTno = 0;
            int accounttype = 0;
            int delacntno = 0;
            int amount = 0;
            int ACountno = 0;
            int BAlance = 0;
            IBankingAccount Currentaccount=null;
            IBankingAccount Savingaccount= null;
            ITransection transectionobj = null;
            AccountHandler Accounthandler = new AccountHandler();
            AccountEventArgs accounteventarg = new AccountEventArgs();
            TransectionHandler transectionHandler = new TransectionHandler();
            Random random = new Random();
            bool chk = true, chk1 = true, chk2 = true, chk3 = true, chk4 = true, chk5 = true;
            bool CurrentCreationsms = false,SavingSmsCreation=false,SavingEmailCreation=false, CurrentCreationemial = false, depositesms = false, depositeemial = false, withdrawsms = false, withdrawemail = false;
            int choice = 0, balance = 0;
            string ch = null;
            do
            {

                try
                {
                    Console.WriteLine("\n\t\t\t\t\t\t  Bank Account Menu");
                    Console.WriteLine("\t\t\t\t\t    ----------------------------");
                    Console.WriteLine("\n\t\t\t\t1.   Add New Account");
                    Console.WriteLine("\t\t\t\t2.   Display All Account Summary");
                    Console.WriteLine("\t\t\t\t3.   Display List Of Accounts Current/Saving");
                    Console.WriteLine("\t\t\t\t4.   Display List Of  Saving Account By Status Block/Unblock");
                    Console.WriteLine("\t\t\t\t5.   Display Account Detail By Account Number");
                    Console.WriteLine("\t\t\t\t6.   Remove Account");
                    Console.WriteLine("\t\t\t\t7.   Make Transection");
                    Console.WriteLine("\t\t\t\t8.   Display Complete History Of All Transection");
                    Console.WriteLine("\t\t\t\t##.  Press any Other Key To Go To Main Menu ");



                    Console.WriteLine("\n\nENTER YOUR CHOICE...");
                   
                    choice = Convert.ToInt32(Console.ReadLine());
                   
                    Console.Clear();
                    switch (choice)
                    {

                        //Adding Method Case1.....
                        case 1:
                            Console.WriteLine("\t\t\t\t\t\t\tAccount Types Menu");
                            Console.WriteLine("\t\t\t\t\t\t----------------------------");
                            Console.WriteLine("\t\t\t\t\t\t1. Current Account");
                            Console.WriteLine("\t\t\t\t\t\t2. Saving Account");
                            Console.WriteLine("\t\t\t\t\t\t3. enter any key  Back To Bank Account Menu");
                            //-----------------------------------------------------------------------------------------

                            Console.WriteLine("Choose Your Account Type");
                        accounttype = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();

                            int Accountno = random.Next(1, 1000000);
                            Console.WriteLine("\n\nAccount Creation");
                            Console.WriteLine("\nEnter Username");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter User Father Name");
                            string fname = Console.ReadLine();
                            Console.WriteLine("Enter User Cnic");
                            string cnic = Console.ReadLine();
                            Console.WriteLine("Enter your Phone Number");
                            string Phone = Console.ReadLine();
                            Console.WriteLine("Enter User Address");
                            string address = Console.ReadLine();
                            Console.WriteLine("Enter User EmailAddress");
                            string emailaddress = Console.ReadLine();
                            Console.WriteLine("Enter User City");
                            string city = Console.ReadLine();

                            //ADDING CURRENT ACCOUNT.........................
                            if (accounttype == 1)
                            {
                                Console.WriteLine("Now Make Your First Transection Into Your Current Account");
                                balance = Convert.ToInt32(Console.ReadLine());
                              //Setting Data To Current Account Class
                              Currentaccount = new CurrentAccount(Accountno, name, fname, address, emailaddress, cnic, city, AccountType.Current, DateTime.Now, Phone);
                                Currentaccount.AccountBalance = balance;
                                Console.WriteLine("Do you Want to Activate Your Sms Confirmation For Transection [y/n]");
                                string smschoice = Console.ReadLine();
                                if (smschoice == "y" || smschoice == "Y")
                                {
                                    Currentaccount.SmsActivation = ActivationSms.Yes;
                                    CurrentCreationsms = true;
                                }
                                else
                                {
                                    Currentaccount.SmsActivation = ActivationSms.No;
                                    CurrentCreationsms = false;
                                }
                                Console.WriteLine("Do you Want to Activate Your Email Confirmation For Transection [y/n]");
                                string emailchoice = Console.ReadLine();
                                if (emailchoice == "y" || emailchoice == "Y")
                                {
                                    Currentaccount.EmailActivation = ActivationEmail.Yes;
                                    CurrentCreationemial = true;
                                }
                                else
                                {
                                    Currentaccount.EmailActivation = ActivationEmail.No;
                                    CurrentCreationemial = false;
                                }
                                Console.WriteLine("\n\nYOUR ACCOUNT IS SUCESSFULY CREATED");
                                Thread.Sleep(4000);

                                //Sms ConfiramtionEvent Calling
                                if (CurrentCreationsms == true)
                                {
                                    Console.Clear();
                                    Console.Beep();
                                    Accounthandler._Creation += new AccountCreationSms().Notification;

                                }
                                //Email ConfiramtionEvent Calling
                                if (CurrentCreationemial == true)
                                {
                                    Console.Beep();
                                    Accounthandler._Creation += new AccountCreationEmail().Notification;


                                }

                                //Adding current Account Data To to list
                                Accounthandler.AddAccount(Currentaccount);

                            }





                            //ADDING SAVING ACCOUNT.................................


                            else if (accounttype == 2)
                            {
                                Savingaccount = new SavingAccount(Accountno, name, fname, address, cnic, city, AccountType.Saving, DateTime.Now, AccountStatus.UnBlock, emailaddress, Phone);
                                Console.WriteLine("\nNow Make Your First Transection Into Your Saving Account Transection Must Be More Than PKR 1000");
                                do
                                {
                                    
                                        balance = Convert.ToInt32(Console.ReadLine());
                                   
                                    if (balance < 1000)
                                    {
                                        Console.WriteLine("\nInsert Balance again Your Balance I less Than PKR 1000");

                                    }

                                }
                                while (balance < 1000);
                                Savingaccount.AccountBalance = balance;

                                Console.WriteLine("Do you Want to Activate Your Sms Confirmation For Transection [y/n]");
                                string smschoice = Console.ReadLine();
                                if (smschoice == "y" || smschoice == "Y")
                                {
                                    Savingaccount.SmsActivation = ActivationSms.Yes;
                                    SavingSmsCreation = true;
                                }
                                else
                                {
                                    Savingaccount.SmsActivation = ActivationSms.No;
                                    SavingSmsCreation = false;
                                }
                                Console.WriteLine("Do you Want to Activate Your Email Confirmation For Transection [y/n]");
                                string emailchoice = Console.ReadLine();
                                if (emailchoice == "y" || emailchoice == "Y")
                                {
                                    Savingaccount.EmailActivation = ActivationEmail.Yes;
                                    SavingEmailCreation = true;
                                }
                                else
                                {
                                    Savingaccount.EmailActivation = ActivationEmail.No;
                                    SavingEmailCreation = false;
                                }

                                Console.WriteLine("\n\nYOUR ACCOUNT IS SUCESSFULY CREATED");
                                Thread.Sleep(4000);
                                if (SavingSmsCreation == true)
                                {
                                    Console.Clear();
                                    Console.Beep();
                                    Accounthandler._Creation += new AccountCreationSms().Notification;

                                }
                                //Email ConfiramtionEvent Calling
                                if (SavingEmailCreation == true)
                                {
                                    Console.Beep();
                                    Accounthandler._Creation += new AccountCreationEmail().Notification;


                                }

                                //ADDING VALUE TO LIST....

                                Accounthandler.AddAccount(Savingaccount);
                                Console.WriteLine("\n\nYOUR ACCOUNT IS SUCESSFULY CREATED");
                              
                            }
                            else
                            {
                                chk = false;
                            }

                            break;



                        //case 2.................
                        case 2:
                            //Display Complete Summary Of Accounts
                            Accounthandler.DisplayAllAccount();
                           
                            break;


                        //Dusplay List Of Account BY Account Type
                        case 3:
                            Console.WriteLine("\t\t\t\t\t\t\tDisplay By Account Type");
                            Console.WriteLine("\t\t\t\t\t\t----------------------------");
                            Console.WriteLine("\t\t\t\t\t\t1. Current Account");
                            Console.WriteLine("\t\t\t\t\t\t2. Saving Account");
                            Console.WriteLine("\t\t\t\t\t\t3. enter any key  Back To Bank Account Menu");
                            Console.WriteLine("Enter Your Choice...");
                            choice = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            if (choice == 1)
                            {
                                Accounthandler.GetAccountsByType<SavingAccount>(AccountType.Current);
                               
                            }
                            else if (choice == 2)
                            {
                                Accounthandler.GetAccountsByType<SavingAccount>(AccountType.Saving);
                               
                            }
                            else
                            {
                                chk = false;
                            }
                            break;

                        //Display Saving Account List By Account Status Block/UnBlock
                        case 4:
                            Console.WriteLine("\t\t\t\t\t\t\tDisplay By Account Type");
                            Console.WriteLine("\t\t\t\t\t\t----------------------------");
                            Console.WriteLine("\t\t\t\t\t\t1. UnBlock Saving Account");
                            Console.WriteLine("\t\t\t\t\t\t2. Block Saving Account");
                            Console.WriteLine("\t\t\t\t\t\t3. enter any key  Back To Bank Account Menu");
                            Console.WriteLine("Enter Your Choice...");
                            
                                choice = Convert.ToInt32(Console.ReadLine());
                        
                            Console.Clear();
                            if (choice == 1)
                            {
                                Accounthandler.GetSavingAccountsByStatus<SavingAccount>(AccountStatus.UnBlock);
                              
                            }
                            else if (choice == 2)
                            {
                                Accounthandler.GetSavingAccountsByStatus<SavingAccount>(AccountStatus.Block);
                               
                            }
                            else
                            {

                            }

                            break;



                        //Display Account Detail By Account Number
                        case 5:
                            Console.WriteLine("Enter Your Account No");
                           
                                acntNo = Int32.Parse(Console.ReadLine());
                          
                            var Saccountno = Accounthandler.GetAccountDetail(acntNo);
                            if (Saccountno != null)
                            {
                                Console.WriteLine(Saccountno);

                               
                            }
                            else
                            {
                                Console.WriteLine("The Account Number You Enterd Does Not Exsist........");
                            }
                            break;

                        //Deleting Account From List...
                        case 6:
                            Console.WriteLine("Enter Your Account No To Delete Account");
                           
                                delacntno = Convert.ToInt32(Console.ReadLine());
                           



                            var delAccount = Accounthandler.GetAccountDetail(delacntno);
                            if (delAccount != null)
                            {
                                Thread.Sleep(4000);
                                Console.Clear();
                                Console.Beep();
                                Accounthandler._Creation += new AccountDeletionSms().Notification;


                                Console.Beep();
                                Accounthandler._Creation += new AccountDeletionEmail().Notification;
                                Accounthandler.DeleteAccount(delAccount);

                               


                            }
                            else
                            {
                                Console.WriteLine("The Account Number You Enterd Does Not Exsist........");
                            }
                            break;




                        //Transection........
                        case 7:

                            Console.WriteLine("\t\t\t\t\t\t\tTransection Account Types Menu");
                            Console.WriteLine("\t\t\t\t\t\t----------------------------");
                            Console.WriteLine("\t\t\t\t\t\t1.Saving Account");
                            Console.WriteLine("\t\t\t\t\t\t2.  Current Account");
                            Console.WriteLine("\t\t\t\t\t\t3. enter any key  Back To Bank Account Menu");
                            Console.WriteLine("\nEnter Your Choice...");
                           
                                choice = Convert.ToInt32(Console.ReadLine());
                           
                          
                            Console.Clear();

                            //SAVING ACCOUNT TRANSECTION.....
                            if (choice == 1)
                            {
                                var Accounttype = AccountType.Saving;
                                Console.WriteLine("\t\t\t\t\t\t1.Withdraw Transection");
                                Console.WriteLine("\t\t\t\t\t\t2.Deposite Transection");
                                Console.WriteLine("\nEnter Your Choice...");
                                
                                    choice = Convert.ToInt32(Console.ReadLine());
                              
                                Console.Clear();


                                // Saving WITHDRAW TRANSECTION....
                                if (choice == 1)
                                {
                                    option = 1;
                                    Console.WriteLine("\nEnter Your Account Number For Transection...");
                                   
                                        AccounTno = Int32.Parse(Console.ReadLine());
                                  
                                    var TransectionSearch = Accounthandler.GetAccountDetail(AccounTno);
                                    if (TransectionSearch != null)
                                    {
                                        int AccountBalance = TransectionSearch.AccountBalance;
                                        if ((TransectionSearch.Type == AccountType.Saving))
                                        {
                                            if (TransectionSearch.Status == AccountStatus.UnBlock)
                                            {
                                                for (int i = 0; i < accountArr.Length; i++)
                                                {
                                                    if (AccounTno == accountArr[i])
                                                    {

                                                        count++;
                                                    }
                                                }
                                                if (count > 2)
                                                {
                                                    TransectionSearch.Status = AccountStatus.Block;

                                                    int accountno = TransectionSearch.AccountNo;
                                                    string Name = TransectionSearch.Username;
                                                    string phone = TransectionSearch.PhoneNo;
                                                    string email = TransectionSearch.EmailAddress; Console.WriteLine("\nYOUR ACCOUNT HAS BEEN BLOCKED FOR ONE DAY ....YOU TRY TO WITHDRAW MORE THAN TWO TIME IN A DAY...");
                                                    transectionobj = new Transection(accountno, Name, 0, 0, AccountType.Saving, TransectionType.WithDraw, email, phone);

                                                    Thread.Sleep(4000);
                                                    Console.Beep();
                                                    Console.Beep();
                                                    if (TransectionSearch.SmsActivation == ActivationSms.Yes)
                                                    {
                                                        transectionHandler._TransectionEventHandler += new AccountBlockSms().BlockNotification;
                                                    }
                                                    if (TransectionSearch.EmailActivation == ActivationEmail.Yes)
                                                    {
                                                        transectionHandler._TransectionEventHandler += new AccountBlockEmail().BlockNotification;
                                                    }
                                                    transectionHandler.Blocknotification(transectionobj);
                                                  
                                                }
                                                else
                                                {

                                                    accountArr[index++] = AccounTno;

                                                    Console.WriteLine("\nEnter Amount For Transection...");
                                                   
                                                        amount = Convert.ToInt32(Console.ReadLine());
                                                   
                                                    Console.Clear();
                                                    var returnBalance = transectionHandler.Transection(amount, AccountBalance, option, TransectionSearch);
                                                    int accountno = TransectionSearch.AccountNo;
                                                    string Name = TransectionSearch.Username;
                                                    string phone = TransectionSearch.PhoneNo;
                                                    string email = TransectionSearch.EmailAddress;

                                                    if (returnBalance != 0)
                                                    {
                                                        if (returnBalance != AccountBalance)
                                                        {
                                                            TransectionSearch.AccountBalance = returnBalance;
                                                            transectionobj = new Transection(accountno, Name, amount, returnBalance, AccountType.Saving, TransectionType.WithDraw, email, phone);
                                                            Thread.Sleep(4000);
                                                            Console.Beep();
                                                            Console.Beep();

                                                            if (TransectionSearch.SmsActivation == ActivationSms.Yes)
                                                            {
                                                                transectionHandler._TransectionEventHandler += new WithdrawMessageService().TransectionNotification;
                                                            }
                                                            if (TransectionSearch.EmailActivation == ActivationEmail.Yes)
                                                            {
                                                                transectionHandler._TransectionEventHandler += new WithdrawEmailService().TransectionNotification;
                                                            }

                                                            transectionHandler.AddTransection(transectionobj);

                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Transection Is Failed.");
                                                           
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Transection Is Failed.");
                                                        
                                                    }
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("\nYOUR ACCOUNT IS BLOCK .....YOUR TRANSECTION CANNOT COMPLETED...");
                                               
                                            }


                                        }
                                        else
                                        {
                                            Console.WriteLine("Your Account Type Is Not Saving....Your Transection Cannot Be Completed");
                                           
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nThe Account NUmber You Entered Does Not Exsist");
                                      
                                    }
                                   

                                }
                                // Saving DEPOSITE TRANSECTION...

                                else if (choice == 2)
                                {
                                    option = 2;
                                    Console.WriteLine("Enter Account number For Transection");
                                    ACountno = Convert.ToInt32(Console.ReadLine());
                                    var DepositeSearch = Accounthandler.GetAccountDetail(ACountno);
                                    Accounttype = AccountType.Saving;
                                    if (DepositeSearch != null)
                                    {
                                        if ((DepositeSearch.Type == AccountType.Saving))
                                        {
                                            if (DepositeSearch.Status == AccountStatus.UnBlock)
                                            {
                                                Console.WriteLine("Enter Balance....");

                                              
                                                    BAlance = Convert.ToInt32(Console.ReadLine());
                                               


                                                int accountno = DepositeSearch.AccountNo;
                                                string Name = DepositeSearch.Username;
                                                string phone = DepositeSearch.PhoneNo;
                                                string email = DepositeSearch.EmailAddress;
                                                int Accountbalance = DepositeSearch.AccountBalance;
                                                var returnBalance = transectionHandler.Transection(BAlance, Accountbalance, option, DepositeSearch);
                                                DepositeSearch.AccountBalance = returnBalance;
                                                transectionobj = new Transection(accountno, Name, BAlance, returnBalance, AccountType.Saving, TransectionType.Deposite, email, phone);
                                                Thread.Sleep(4000);
                                                Console.Beep();
                                                Console.Beep();
                                                if (DepositeSearch.SmsActivation == ActivationSms.Yes)
                                                {

                                                    transectionHandler._TransectionEventHandler += new WithdrawMessageService().TransectionNotification;
                                                }

                                                if (DepositeSearch.EmailActivation == ActivationEmail.Yes)
                                                {
                                                    transectionHandler._TransectionEventHandler += new WithdrawEmailService().TransectionNotification; transectionobj = new Transection(accountno, Name, BAlance, returnBalance, AccountType.Saving, TransectionType.WithDraw, email, phone);
                                                }
                                                transectionHandler.AddTransection(transectionobj);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Your Account Is Block ...Your Transection Cannot Be Completed");
                                              
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Your Account Typed Is Not Saving....Your Transection Cannot Be Completed");
                                            
                                        }
                                    }

                                }

                            }

                            //CURRENT ACCOUNT TRANSECTION.....
                            else if (choice == 2)
                            {
                                var Accounttype = AccountType.Current;
                                Console.WriteLine("\t\t\t\t\t\t1.Withdraw Transection");
                                Console.WriteLine("\t\t\t\t\t\t2.Deposite Transection");
                                Console.WriteLine("\nEnter Your Choice...");
                                choice = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();


                                //Current WITHDRAW TRANSECTION....
                                if (choice == 1)
                                {
                                    option = 1;
                                    Console.WriteLine("Enter Account number For Transection");
                                   
                                        ACountno = Convert.ToInt32(Console.ReadLine());
                                   
                                   
                                    var WithdrawSearch = Accounthandler.GetAccountDetail(ACountno);
                                    if (WithdrawSearch != null)
                                    {
                                        if (WithdrawSearch.Type == AccountType.Current)
                                        {
                                            Console.WriteLine("Enter Balance....");
                                           
                                                BAlance = Convert.ToInt32(Console.ReadLine());
                                           


                                            int accountno = WithdrawSearch.AccountNo;
                                            string Name = WithdrawSearch.Username;
                                            string phone = WithdrawSearch.PhoneNo;
                                            string email = WithdrawSearch.EmailAddress;
                                            int Accountbalance = WithdrawSearch.AccountBalance;
                                            var returnBalance = transectionHandler.Transection(BAlance, Accountbalance, option, WithdrawSearch);
                                            transectionobj = new Transection(accountno, Name, BAlance, returnBalance, AccountType.Current, TransectionType.WithDraw, email, phone);
                                            WithdrawSearch.AccountBalance = returnBalance;
                                            Thread.Sleep(4000);
                                            Console.Beep();
                                            Console.Beep();
                                            if (WithdrawSearch.SmsActivation == ActivationSms.Yes)
                                            {

                                                transectionHandler._TransectionEventHandler += new WithdrawMessageService().TransectionNotification;
                                            }

                                            if (WithdrawSearch.EmailActivation == ActivationEmail.Yes)
                                            {
                                                transectionHandler._TransectionEventHandler += new WithdrawEmailService().TransectionNotification; transectionobj = new Transection(accountno, Name, BAlance, returnBalance, AccountType.Saving, TransectionType.WithDraw, email, phone);
                                            }
                                            transectionHandler.AddTransection(transectionobj);

                                            

                                        }

                                    }

                                }

                                //Current Deposite Transection...
                                else if (choice == 2)
                                {
                                    option = 2;

                                    Console.WriteLine("Enter Account number For Transection");
                                    
                                        ACountno = Convert.ToInt32(Console.ReadLine());
                                   
                                    var DepsIteSearch = Accounthandler.GetAccountDetail(ACountno);
                                    if (DepsIteSearch != null)
                                    {
                                        if (DepsIteSearch.Type == AccountType.Current)
                                        {
                                            Console.WriteLine("Enter Balance....");
                                           
                                                BAlance = Convert.ToInt32(Console.ReadLine());
                                           

                                            var currentA = AccountType.Current;
                                            var CurrTraType = TransectionType.Deposite;
                                            int accountno = DepsIteSearch.AccountNo;
                                            string Name = DepsIteSearch.Username;
                                            string phone = DepsIteSearch.PhoneNo;
                                            string email = DepsIteSearch.EmailAddress;
                                            int Accountbalance = DepsIteSearch.AccountBalance;
                                            var returnBalance = transectionHandler.Transection(BAlance, Accountbalance, option, DepsIteSearch);
                                            transectionobj = new Transection(accountno, Name, BAlance, returnBalance, currentA, CurrTraType, email, phone);
                                            DepsIteSearch.AccountBalance = returnBalance;
                                            Thread.Sleep(4000);
                                            Console.Beep();
                                            Console.Beep();
                                            if (DepsIteSearch.SmsActivation == ActivationSms.Yes)
                                            {

                                                transectionHandler._TransectionEventHandler += new WithdrawMessageService().TransectionNotification;
                                            }

                                            if (DepsIteSearch.EmailActivation == ActivationEmail.Yes)
                                            {
                                                transectionHandler._TransectionEventHandler += new WithdrawEmailService().TransectionNotification; transectionobj = new Transection(accountno, Name, BAlance, returnBalance, AccountType.Saving, TransectionType.WithDraw, email, phone);
                                            }
                                            transectionHandler.AddTransection(transectionobj);

                                            

                                        }
                                        else
                                        {
                                            Console.WriteLine("Your Account Types Is Not Current....Your Transection Cannot Be Completed");
                                            
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Account Number You Entered Does Not Exsist....");
                                       
                                    }
                                }

                            }
                            else
                            {
                                chk = false;
                            }
                            break;

                        //Display Transection History
                        case 8:
                            transectionHandler.DisplayTransectionHistory();
                            
                            break;
                            chk = false;

                            break;
                    }

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                 
                }
                finally
                {
                    Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                    ch = Console.ReadLine();
                    if (ch == "y" || ch == "Y")
                    {
                        chk = true;
                        Console.Clear();
                    }
                    else
                    {
                        chk = false;
                    }
                }

            } while (chk);
        }
    }
}
