using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public interface IOrderPizza
    {
        int OrderNo { set; get; }
        string OrderType { set; get; }
        DateTime Ordereddate { set; get; }

        string OrderName { set; get;}

        bool Pizzaorder(int blnce, int price1);
        int MemberCod { get; set; }
    }
}
