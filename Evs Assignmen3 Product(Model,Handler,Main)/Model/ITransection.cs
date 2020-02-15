using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface ITransection
    {
        int  Price { get; set; }
        Guid TransectionId { get; set; }
        DateTime TransectionDate { get; set; }
        ProductTypeName Productname { get; set; }
        string Producname { get; set; }
        string ProdutCode { get; set; }
        string Model { set; get; }
        ProductStatus Status { get; set; }
        ProductType Producttype { get; set; }

         void SetValue(string name, string code, string model, ProductStatus status, ProductType type, int price);

    }
}
