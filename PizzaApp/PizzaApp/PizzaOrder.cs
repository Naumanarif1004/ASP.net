using System;
using System.Collections.Generic;
using System.Text;

namespace FizzaApp
{
    public class FizzaOrder:Order, IOrderFizza
    {
        int balance;
        public FizzaOrder(int orderno, string otype, string oname, DateTime date):base(orderno, otype,oname,DateTime.Now)
        {

        }
        public int OrderNo { get; set; }
        public string OrderType { get; set;}
        public DateTime Ordereddate { get; set; }
        public string OrderName { get; set ; }
        public int Price { get; set; }
        public int MemberCod { get; set; }
        //------------------------------------------------------------------------------------------

        public bool Fizzaorder(int Customerprice, int FizzaPrice)
        {
            if (Customerprice > 0)
            {
                if (FizzaPrice == Customerprice)
                {

                    Console.WriteLine("YOUR ORDER IS SUCESSFULLY COMPLETED...");
                    return true;
                }
                else if (FizzaPrice > Customerprice)

                {
                    balance = FizzaPrice - Customerprice;
                    Console.WriteLine("YOU HAVE [" + balance + "] MORE BALANCE REQUIRED TO COMPLETE THIS ORDER... ");
                    return false;
                }
                else if (Customerprice > FizzaPrice)
                {
                    balance = Customerprice - FizzaPrice;
                    Console.WriteLine("PLEASE RECIVED [" + balance + "] REMAINING BALANCE... ");
                    return true;
                }

            }
            else 
            {
                Console.WriteLine("negative entry....try again");
                return false;
            }
            return false;
        }

    }
}
