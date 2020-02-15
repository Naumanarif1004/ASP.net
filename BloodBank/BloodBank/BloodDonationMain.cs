using System;

namespace BloodBank
{
    class BloodDonationMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter array size.........");
            int size = Int32.Parse(Console.ReadLine());
            BloodDonationHandler handler = new BloodDonationHandler(size);
            bool chk = true;
            bool check = true;
            bool chck = true;
            int j = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t\t\t  Main Menu");
                Console.WriteLine("\t\t\t\t\t\t-----------------------------");
                Console.WriteLine("\t\t\t\t\t\t1. BLOOD RECORD ");
                Console.WriteLine("\t\t\t\t\t\t2. DONATION RECORD ");
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

                            
                            Console.WriteLine("\n\n\t\t\t\t\t\t\tBlood Bank Menu");
                            Console.WriteLine("\t\t\t\t\t\t----------------------------");
                            Console.WriteLine("\t\t\t\t\t\t1. insert new Blood");
                            Console.WriteLine("\t\t\t\t\t\t2. Display list of Blood");
                            Console.WriteLine("\t\t\t\t\t\t3. Search By Bloodgroup ");
                            Console.WriteLine("\t\t\t\t\t\t4. Delete Blood By Blood Id");
                            Console.WriteLine("\t\t\t\t\t\t5. Delete Blood By Blood Group");
                            Console.WriteLine("\t\t\t\t\t\t5. Update Blood");
                            Console.WriteLine("\t\t\t\t\t\t7. enter 7 to go to main menu");
                            Console.WriteLine("\t\t\t\t\t\t-----------------------------");

                            Console.WriteLine("\n\nENTER YOUR CHOICE...");
                            int choi = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (choi)
                            {
                                case 1:
                                    if (j < size)
                                    {
                                        Console.WriteLine("\n\n------insertion-----");
                                        Console.WriteLine("\nenter blood id...");
                                        int id = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("enter blood Blood Group...");
                                        string bloodgrup = Console.ReadLine();
                                        IBloodRecord br1 = new BloodRecord(id, bloodgrup, DateTime.Now);

                                        if (handler.Insertion(br1, bloodgrup) == true)
                                        {
                                            j++;
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("\nYOUR BLOOD BANK IS FULL....NO SPACE FOR ANOTHER INSERTION..");
                                    }
                                    
                                    break;
                                case 2:
                                    
                                    Console.WriteLine("\n\n----display Of Blood Record----\n");
                                    handler.displayBloodrecord();
                                    break;

                                case 3:
                                     
                                    Console.WriteLine("\n\n-----searching For Blood-----");
                                    Console.WriteLine("\nenter blood  Group for searching...");
                                    string bloodgroup = Console.ReadLine();
                                    handler.search(bloodgroup);
                                    
                                    break;

                                case 4:
                                   
                                    Console.WriteLine("\n\n----deleting by BloodId----");
                                    Console.WriteLine("\nenter blood id to delete ...");
                                    int bid = Int32.Parse(Console.ReadLine());
                                    handler.delete(bid);
                                    break;
                                case 5:
                                    Console.WriteLine("\n\n----deleting by Bloodgroup----");
                                    Console.WriteLine("\nenter blood Group to delete ...");
                                    string bgroup = Console.ReadLine();
                                    handler.deletebloodgroup(bgroup);
                                    
                                    break;

                                case 6:
                                    Console.WriteLine("\nenter Blood Id to Update...");
                                    int eid = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("\nenter new  Blood Id...");
                                    int nid = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("enter new  Blood Group...");
                                    string nbloodgrup = Console.ReadLine();
                                    IBloodRecord br = new BloodRecord(nid, nbloodgrup, DateTime.Now);
                                    handler.Update(br, eid);
                                    
                                    break;

                                default:
                                    if (choi == 7)
                                    {
                                        chk = false;
                                    }
                                    break;
                            }

                        } while (chk);
                        break;

                    

                    case 2:
                        do
                        {
                            
                            Console.WriteLine("\t\t\t\t\t\t\t  Blood Donation Menu");
                            Console.WriteLine("\t\t\t\t\t\t-----------------------------");
                            Console.WriteLine("\t\t\t\t\t\t1. Insert Donation RECORD ");
                            Console.WriteLine("\t\t\t\t\t\t2. Display Donation Record ");
                            Console.WriteLine("\t\t\t\t\t\t3. enter 3 to back to main menu");
                            Console.WriteLine("\t\t\t\t\t\t-----------------------------");

                            Console.WriteLine("\n\nENTER YOUR CHOICE...");
                            int choice = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine("\n\nEnter Donating Blood Group...");
                                    string dgroup = Console.ReadLine();
                                    if (handler.search(dgroup) == "yes")
                                    {
                                        Console.WriteLine("\n----------------------------");
                                        Console.WriteLine("...NOW SELECT BLOOD BY ID...");
                                        Console.WriteLine("\nEnter Donating Blood Id");
                                        int bloodid = Int32.Parse(Console.ReadLine());

                                        if ((handler.SearchForDonation(bloodid)) == true)
                                        {
                                            Console.WriteLine("\nEnter Donation  Id");
                                            int do_id = Int32.Parse(Console.ReadLine());
                                            Console.WriteLine("\nEnter Patient Id");
                                            int pid = Int32.Parse(Console.ReadLine());
                                            Console.WriteLine("Enter Patient Name");
                                            string pname = Console.ReadLine();
                                            Console.WriteLine("Enter Patient Dieses");
                                            string pdieses = Console.ReadLine();
                                            Console.WriteLine("Enter Patient City");
                                            string city = Console.ReadLine();
                                            Console.WriteLine("Enter Patient Id");
                                            IDonationreacord dr = new DonationRecord(do_id, pid, pname,bloodid, dgroup, city, pdieses, DateTime.Now);
                                            handler.DonationInsertion(dr);
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n YOU ENTERED INCORRECT BLOOD ID");
                                        }
                                    }


                                    
                                    break;
                                case 2:
                                    
                                    Console.WriteLine("----Donation Record---");
                                    handler.displayDonation();
                                   
                                    break;
                                default:
                                    if (choice == 3)
                                    {
                                        chck = false;
                                    }
                                    break;
                            }
                        } while (chck);
                            break;
                        }
                        

            } while (check);
        }
    }
}
 
