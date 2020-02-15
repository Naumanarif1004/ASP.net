using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public enum ProductType
    {
        Consumbale=1,
        NonConsumable
    }

    public enum ProductStatus
    {
        OnShelf=1,
        Issue,
        Return
    }

    public enum ProductTypeName
    {
        Laptop=1,
        Mobile
    }
}
