using System;
using System.Collections.Generic;
using System.Text;

namespace FizzaApp
{
     public abstract class Order:IOrderFizza
    {
        int balance;
        public Order(int orderno,string otype,string oname,DateTime date)
        {
            OrderNo = orderno;
            OrderType = otype;
            OrderName = oname;
            Ordereddate = date;
        }
        public  int OrderNo { get; set; }
        public  string OrderType { get; set; }
        public  DateTime Ordereddate { get; set; }
        public string OrderName { get; set; }
        public int MemberCod { get; set; }



        public bool Fizzaorder(int Customerprice, int FizzaPrice)
        {
            
            return false;
        }

        public override string ToString()
       {
            return $" MEMBER CODE::{MemberCod}----Oder No :: {OrderNo}------Order Type::{OrderType}-----Order Name :: {OrderName}-----Date :: {Ordereddate}";
        }
    }
}
