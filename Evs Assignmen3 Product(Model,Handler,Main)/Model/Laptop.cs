using System;

namespace Model
{
     public class Laptop:Product,IProduct
    {

        public Laptop(string Pname, string Pcode, String PModel, ProductStatus status, ProductType type, ProductTypeName typename, DateTime date):base(Pname, Pcode, PModel, status, type, typename, date)
        {
            
        }

       

    }
}
