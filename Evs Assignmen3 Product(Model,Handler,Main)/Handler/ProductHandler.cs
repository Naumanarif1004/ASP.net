using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Handler
{
    public sealed class ProductHandler
    {
        IEnumerable<IProduct> p=null;
        private readonly List<IProduct> _product;

        public ProductHandler()
        {
            _product = new List<IProduct>();
        }


        //PRODUCT ADDING FUNCTION
        public void AddProduct(IProduct obj)
        {
            var product=obj as IProduct;
            if(product==null)
            {
                throw new ArgumentNullException("null data found.......");
            }
            _product.Add(product);
        }


        //DISPLAY ONSHELF PRODUCT
        public void DisplayOnshelfProduct()
        {
            foreach(var item in _product)
            {
                Console.WriteLine(item);
            }
        }



        //DISPLAY LIST OF PRODUCT USING STATUS(SEARCH)
        public IEnumerable<IProduct> GetProducts<TProduct>(ProductStatus status) where TProduct:Product
        {
            p=_product.Where(s => s.Status == status);
            foreach (var item in p)
            {
                Console.WriteLine(item);
            }
            return p;
        }


        //DISPLAY LIST OF PRODUCT USING PRODUCT TYPE NAME(SEARCH)

        public IEnumerable<IProduct> GetProductsByname<TProduct>(ProductTypeName name) where TProduct:Product
        {
           p= _product.Where(n => n.Productname == name);
            foreach(var item in p)
            {
                Console.WriteLine(item);
            }
            return p;
        }


        //Search method.....search by Product code

        public IProduct SearchByCode(string code, bool ignoreCase= false)
        {
            return _product.FirstOrDefault(s => string.Compare(s.ProdutCode, code, ignoreCase) == 0);
        }


        //Remove Method -----remove by IProduct

        public void RemoveByCode(IProduct p)
        {
            var product = p as IProduct;
            if(product!=null)
            {
                _product.Remove(product);
            }
        }
    }
}
