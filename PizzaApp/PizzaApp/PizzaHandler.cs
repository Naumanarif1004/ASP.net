using System;
using System.Collections.Generic;
using System.Text;

namespace FizzaApp
{
    class FizzaHandler
    {
       
        string[] fizz = new string[] {"Chicken Tikka","Hot stuff", "Chicken fajita", "Chili Chicken","Behari Chiken","BBQ Buzz","Spicy Ranch" };
        int[] price = new int[] {560,700,940,1000,400,800,750 };
        static int i = 0;
        static int index=0;
        IOrderFizza[] orderfizz;
        IMember[] members;
        int blnce;
        bool check = false;
        bool chk = true;
        static int balance = 10000;
        public FizzaHandler(int size)
        {
            members = new IMember[size];
           orderfizz = new IOrderFizza[size];
        }


        //-----------------------------------------------------------------------------------------------------

        public void AddMemebr(IMember obj)
        {
            var newmember = obj as IMember;
            members[i++] = newmember;
            Console.WriteLine("\nMemnber registered sucessfully.........");
        }

    
        //----------------------------------------------------------------------------------------------------------
        public void Display()
        {
            if (i > 0)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.WriteLine(members[k]);
                }
            }
            else
            {
                Console.WriteLine("membership list is empty...............");
            }
           
        }

        //---------------------------------------------------------------------------------------------

        public int search(int searchkey)
        {
            if (i > 0)
            {
                for (int j = 0; j < i; j++)
                {
                    if (searchkey == members[j].MembershipNo)

                    {
                        Console.WriteLine(members[j]);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("THE MEMBERSHIP CODE YOU ENTERED DOES NOT EXSIST");
                    }

                }
            }
            else
            {
                Console.WriteLine(" membership list is empty...");
            }
            return 0;
        }

        //----------------------------------------------------------------------------------------------

        public int delete(int delkey)
        {
            if (i > 0)
            {
                for (int j = 0; j < i; j++)
                {
                    if (delkey == members[j].MembershipNo)
                    {
                        members[j] = null;
                        Console.WriteLine("\nMemnber deleted sucessfully.........");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("THE MEMBERSHIP CODE YOU ENTERED DOES NOT EXSIST");
                    }
                }
            }
            else
            {
                Console.WriteLine(" membership list is empty...");
            }

            return 0;
        }


        //----------------------------------------------------------------------------------------------

        public void update(int no, IMember mem)
        {
            if (i > 0)
            {
                for (int j = 0; j < i; j++)
                {
                    if (no == members[j].MembershipNo)
                    {
                        members[j] = mem;
                        Console.WriteLine("\nMemnber updated sucessfully.........");
                        break;

                    }
                    else if (j == (i - 1))
                    {
                        Console.WriteLine("THE MEMBERSHIP CODE YOU ENTERED DOES NOT EXSIST");
                    }
                }
            }
            else
            {
                Console.WriteLine(" membership list is empty.....");
            }
        }

        //-----------------------------------------------------------------------------------------------


            public  void ShowFizzaList()
            {
        
            for(int k=0;k<fizz.Length;k++)
            {
                Console.WriteLine("["+(k+1)+"]FIZZA :: "+fizz[k]+" ========== PRICE :: "+price[k]);
            }
            }

        //-------------------------------------------------------------------------------------------
       public int  createNewOrder(IOrderFizza order,int membercode,string name,int price1)
        {
            for(int k=0;k<fizz.Length;k++)
            {
                if(name==fizz[k])
                {
                    blnce = price[k];
                    
                    chk = true;
                    break;
                }
                else
                {
                    if (k == (fizz.Length-1))
                    {
                        Console.WriteLine("\nTHE FIZZA NAME ENTERD DOES NOT EXSIST\n So your Order does not comalete");
                        
                        chk = false;
                    }
                }
            }
            if (chk = true)
            {
                if (i > 0)
                {
                    for (int l = 0; l < i; l++)
                    {

                        if (membercode == members[l].MembershipNo)
                        {
                            check = true;
                            FizzaOrder or = new FizzaOrder(0, null, null, DateTime.Now);
                            
                            or.MemberCod = membercode;
                            if (or.Fizzaorder(price1, blnce) == true)
                            {
                                orderfizz[index] = order;
                            }




                            index++;
                        }
                        else if (l == (i - 1) && (check = false))
                        {
                            Console.WriteLine("\nSORRY----THIS ORDER IS ONLY FOR MEMBERS...KINDLY CREATE YOUR MEMBERSHIP CARD" +
                                "FOR NEXT ORDER");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nSORRY----THIS ORDER IS ONLY FOR MEMBERS...KINDLY CREATE YOUR MEMBERSHIP CARD" +
                                               "FOR NEXT ORDER");
                }
                  
            }

                    return 0;
        }


        //----------------------------------------------------------------------------------------------------

        public void OrderRecord()
        {
            if (index > 0)
            {
                for (int h = 0; h < index; h++)
                {
                    Console.WriteLine(orderfizz[h]);
                }
            }
            else
            {
                Console.WriteLine("orderd list is empty................");
            }
        }
        
    }
}
