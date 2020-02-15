using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Transection : ITransection
    {

        public Transection()
            {
            TransectionId = Guid.NewGuid();
            TransectionDate = DateTime.Now;
        }


       public int    Price { get; set ; }
        public Guid TransectionId { get; set; }
        public DateTime TransectionDate { get; set; }
        public ProductTypeName Productname { get; set; }
        public string Producname { get; set; }
        public string ProdutCode { get; set; }
        public string Model { get; set; }
        public ProductStatus Status { get; set; }
        public ProductType Producttype { get; set; }
        public ProductType Type { get; set; }
        public static int TotalPrice { get; set; }




        //Method for setting value
        public void SetValue(string name,string code,string model,ProductStatus status,ProductType type,int price)
        {

            Producname = name;
            ProdutCode = code;
            Model = model;
            Status = status;
            Producttype = type;
            Price = price;
        }



        //Issue Method
        public int  IssueTransection(int price1)
        {
            return TotalPrice += price1;
        }


        //Return Method
        public int  ReturnTransection(int price1,int DiscPrice)
        {
            return TotalPrice = (TotalPrice - price1) + DiscPrice; ;

        }


        public override string ToString()
        {
            return $"Transection Id  : {TransectionId}     Transection Date  : {TransectionDate}       Produc Type tName  : {Productname}" +
                $"  Product Name  : {Producname}      Product Code  : {ProdutCode}    Product Type  : {Producttype}       Product Status  : {Status}     Product Price  : {Price}";
        }
    }
}
