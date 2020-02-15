using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IProduct
    {
        Guid ProductId { get; }

        string Producname { get; set; }
        string ProdutCode { get; set; }
        string Model { set; get; }
        DateTime Producadding { get; set; }
        ProductStatus Status { get; set; }

        ProductType Producttype { get; set; }

         ProductTypeName Productname { get; set; }

    }
}
