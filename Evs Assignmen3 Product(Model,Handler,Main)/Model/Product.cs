using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public abstract class Product:IProduct
    {
        public Product(string _Pname, string _Pcode, String _PModel, ProductStatus status, ProductType type, ProductTypeName typename, DateTime date)
        {
            ProductId = Guid.NewGuid();
            Producname = _Pname;
            ProdutCode = _Pcode;
            Model = _PModel;
            Status = status;
            Producttype = type;
            Productname = typename;
            Producadding = date;
        }

        public Guid ProductId { get; private set; }

        public string Producname { get; set; }
        public string ProdutCode { get; set; }
        public string Model { get; set; }
        public DateTime Producadding { get; set; }
        public ProductStatus Status { get; set; }
        public ProductType Producttype { get; set; }
        public ProductTypeName Productname { get; set; }


        public override string ToString()
        {
            return $"\nPRODUCT ID  : {ProductId}                  PRODUCT NAME  : {Producname}            PRODUCT CODE  : {ProdutCode }     PRODUCT MODEL  : {Model}" +
                $"     PRODUCT ADDING DATE  : {Producadding}      PRODUCT TYPE NAME  : {Productname}      PRODUCT TYPE  : {Producttype}     PRODUCT STATUS  : {Status}";
        }
    }
}
