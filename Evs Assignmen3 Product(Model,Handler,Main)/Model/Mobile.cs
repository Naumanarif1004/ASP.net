using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Mobile:Product, IProduct
    {
        public Mobile(string Pname, string Pcode, String PModel, ProductStatus status, ProductType type, ProductTypeName typename, DateTime date) : base(Pname, Pcode, PModel, status, type, typename, date)
        {

        }
    }
}
