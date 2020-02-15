using System;
using System.Threading;

namespace FizzaApp
{
    class FizzaMain
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("ENTER ARRAY SIZE");
            int size = Convert.ToInt32(Console.ReadLine());
            FizzaHandler handler = new FizzaHandler(size);
            bool chk = true;
            bool check = true;
            IMember obj;
            Random r = new Random();
            IOrderFizza obj2;
            int j = 0;
            bool option = true;
            string  chz;
           
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t\t-----------------------------");
                Console.WriteLine("\t\t\t\t\t\t\t1. ADMIN ");
                Console.WriteLine("\t\t\t\t\t\t\t2. USER ");
                Console.WriteLine("\t\t\t\t\t\t3. enter any key to exit");
                Console.WriteLine("\t\t\t\t\t\t-----------------------------");

                Console.WriteLine("\n\nENTER YOUR CHOICE...");
                 int ch = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (ch)
                {
                    case 1:
                        do
                        {
                            
                            
                        Console.WriteLine("\t\t\t\t\t\t\t  MemberShip Menu");
                        Console.WriteLine("\t\t\t\t\t\t----------------------------");
                        Console.WriteLine("\t\t\t\t\t\t1. insert new Member");
                        Console.WriteLine("\t\t\t\t\t\t2. Display list of Member");
                        Console.WriteLine("\t\t\t\t\t\t3. display Member detail ");
                        Console.WriteLine("\t\t\t\t\t\t4. Update Member");
                        Console.WriteLine("\t\t\t\t\t\t5. Delete Member");
                        Console.WriteLine("\t\t\t\t\t\t6. Display Order Record ");
                        Console.WriteLine("\t\t\t\t\t\t7. enter 7 to go to main menu");
                        Console.WriteLine("\t\t\t\t\t\t-----------------------------");

                            Console.WriteLine("\n\nENTER YOUR CHOICE...");
                            int choi = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch(choi)
                            {
                                case 1:
                                    if (j < size)
                                    {
                                        Console.WriteLine("\n\nREGESTERING NEW MEMBERS..");
                                        Console.WriteLine("\nENTER MEMBERSHIP CODE..");
                                        int code = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("ENTER MEMBER NAME..");
                                        string name = Console.ReadLine();
                                        Console.WriteLine("ENTER MEMBER CITY..");
                                        string city = Console.ReadLine();

                                        obj = new Member(code, name, city, DateTime.Now);
                                        handler.AddMemebr(obj);
                                        Console.WriteLine("\n\n\tDO YOU WANT TO CONTINOUES THIS PROCESS [Y/N]");
                                        chz = Console.ReadLine();
                                        if (chz.Equals("y") || chz.Equals("Y"))
                                        {
                                            check = true;
                                        }
                                        else
                                        {
                                            check = false;
                                        }
                                       
                                        j++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("member list is completed---no space for another member");
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("\t\t\t\t   ....MEMBERSHIP DETAILEAS....");
                                    handler.Display();
                                    Console.WriteLine("\n\n\tDO YOU WANT TO CONTINOUES THIS PROCESS [Y/N]");
                                    chz = Console.ReadLine();
                                    if (chz.Equals("y") || chz.Equals("Y"))
                                    {
                                        check = true;
                                    }
                                    else
                                    {
                                        check = false;
                                    }
                                    Console.Clear();
                                    break;
                                case 3:
                                    handler.Display();
                                    Console.WriteLine("\nENTER MEMBERSHIP CODE FOR MEMEBERSHIP DETAIL..");
                                    int Scode = Convert.ToInt32(Console.ReadLine());
                                    handler.search(Scode);
                                    Console.WriteLine("\n\n\tDO YOU WANT TO CONTINOUES THIS PROCESS [Y/N]");
                                    chz = Console.ReadLine();
                                    if (chz.Equals("y") || chz.Equals("Y"))
                                    {
                                        check = true;
                                    }
                                    else
                                    {
                                        check = false;
                                    }

                                    Console.Clear();
                                    break;
                                case 4:
                                    handler.Display();
                                    Console.WriteLine("\nENTER MEMBERSHIP CODE TO DELETE MEMBER..");
                                    int Dcode = Convert.ToInt32(Console.ReadLine());
                                    handler.delete(Dcode);
                                    Console.WriteLine("\n\n\tDO YOU WANT TO CONTINOUES THIS PROCESS [Y/N]");
                                    chz = Console.ReadLine();
                                    if (chz.Equals("y") || chz.Equals("Y"))
                                    {
                                        check = true;
                                    }
                                    else
                                    {
                                        check = false;
                                    }

                                    Console.Clear();
                                    break;
                                case 5:
                                    handler.Display();
                                    Console.WriteLine("\nENTER MEMBERSHIP CODE TO UPDATE..");
                                    int Ucode = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("\nENTER NEW MEMBERSHIP CODE..");
                                    int ncode = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("ENTER NEW MEMBER NAME..");
                                    string nname = Console.ReadLine();
                                    Console.WriteLine("ENTER NEW MEMBER CITY..");
                                    string ncity = Console.ReadLine();
                                    obj = new Member(ncode,nname,ncity,DateTime.Now);
                                    handler.update(Ucode, obj);
                                    Console.WriteLine("\n\n\tDO YOU WANT TO CONTINOUES THIS PROCESS [Y/N]");
                                    chz = Console.ReadLine();
                                    if (chz.Equals("y") || chz.Equals("Y"))
                                    {
                                        check = true;
                                    }
                                    else
                                    {
                                        check = false;
                                    }

                                    Console.Clear();
                                    break;
                                case 6:
                                    Console.WriteLine("\n\nDISPLAY OF ORDER LIST...");
                                    handler.OrderRecord();
                                    Console.WriteLine("\n\n\tDO YOU WANT TO CONTINOUES THIS PROCESS [Y/N]");
                                    chz = Console.ReadLine();
                                    if (chz.Equals("y") || chz.Equals("Y"))
                                    {
                                        check = true;
                                    }
                                    else
                                    {
                                        check = false;
                                    }

                                    Console.Clear();
                                    break;

                                default:
                                    if (choi == 7)
                                    {
                                        check = false;
                                    }
                                    break;
                            }

                        } while (check);
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("\t\t\t\t\t\t\t  Order Menu");
                        Console.WriteLine("\t\t\t\t\t\t----------------------------");
                        Console.WriteLine("\t\t\t\t\t\t1. Pizza Price List");
                        Console.WriteLine("\t\t\t\t\t\t2. Make new Order");
                        Console.WriteLine("\t\t\t\t\t\t3. Display Order Record ");
                        Console.WriteLine("\t\t\t\t\t\t4. Press 4 to go to main menu  ");
                        Console.WriteLine("\t\t\t\t\t\t-----------------------------");
                        Console.WriteLine("\n\nENTER YOUR CHOICE...");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        
                            switch(choice)
                            {
                                case 1:
                                      Console.WriteLine("\nlist of pizza....and prices");
                                     handler.ShowFizzaList();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("...MAKE NEW ORDER...");
                                    int Oid = 122;
                                    Console.WriteLine("\nENTER Order Name..");
                                    string name = Console.ReadLine();
                                    Console.WriteLine("ENTER Order Type ..");
                                    string type = Console.ReadLine();
                                    Console.WriteLine("ENTER Member code For Order..");
                                    int  mcode = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("ENTER PIZZA PRICE");
                                    int price = Int32.Parse(Console.ReadLine());
                                    obj2 = new FizzaOrder(Oid, type, name, DateTime.Now);
                                    handler.createNewOrder(obj2,mcode, name,price);
                                    break;
                                case 3:
                                    
                                    Console.WriteLine("\n\nDISPLAY OF ORDER LIST...");
                                    handler.OrderRecord();
                                   
                                    break;
                                default:
                                    if (choice == 4)
                                    {
                                        option = false;
                                    }
                                    break;
                            }
                        } while (option);
                        
                        break;
                        
                    default:
                        chk = false;
                        break;
                }

            } while (chk);
        }
    }
}
