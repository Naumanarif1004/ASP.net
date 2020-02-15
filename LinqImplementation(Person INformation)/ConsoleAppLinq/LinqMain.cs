using LinqHandler;
using System;

namespace ConsoleAppLinq
{
    class LinqMain
    {
        static void Main(string[] args)
        {
            LinqHandlerClass linqHandlerClass = new LinqHandlerClass();
            bool chk = true;
            int choice;
            string ch;
           
                do
                {
                try
                {
                    Console.WriteLine("Person Menu");
                    Console.WriteLine("1.insertion");
                    Console.WriteLine("2.display all");
                    Console.WriteLine("3.diaply person List of age b/w 10 and 30");
                    Console.WriteLine("4.diaply person List Group By Id");
                    Console.WriteLine("5.diaply person List Group By Age");
                    Console.WriteLine("6.Count of A person");
                    Console.WriteLine("7.Display Adult Persons List");
                    Console.WriteLine("8.Name Count");
                    Console.WriteLine("9.Delete Result By Id");
                    Console.WriteLine("10.Display List Of Person By Type");
                    Console.WriteLine("11.press any other key to exsist");
                    Console.WriteLine("\n\nSeclect your choice");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            try
                            {
                                Console.WriteLine("\nInsertion");
                                linqHandlerClass.Insertion();
                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                            }
                            break;
                        case 2:
                            Console.WriteLine("\nDisplay Complete List of Persons");
                            linqHandlerClass.display();
                            break;
                        case 3:
                            Console.WriteLine("\nPerson name of age b/w 10 and 30");
                            linqHandlerClass.displayByage();
                            break;
                        case 4:
                            Console.WriteLine("\nDisplay By Id");
                            linqHandlerClass.GroupedById();
                            break;
                        case 5:
                            Console.WriteLine("\nDisplay By Age");
                            linqHandlerClass.GroupedByAge();
                            break;
                        case 6:
                            Console.WriteLine("\nCount of Person");
                            linqHandlerClass.Count();
                            break;
                        case 7:
                            Console.WriteLine("\nDisplay Of Adult Persons");
                            linqHandlerClass.Isadult();
                            break;
                        case 8:
                            try
                            {
                                Console.WriteLine("Name Counting");
                                linqHandlerClass.DisplaySyed();
                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                            }
                            break;
                        case 9:
                            try
                            {
                                linqHandlerClass.Delete();
                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                            }
                            break;
                        case 10:
                            Console.WriteLine("Display Person By Type");
                            linqHandlerClass.SearchByType();
                            break;
                        default:
                            break;
                    }

                }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
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
