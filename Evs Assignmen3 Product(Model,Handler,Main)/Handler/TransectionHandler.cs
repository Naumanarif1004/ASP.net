using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Handler
{
    public sealed class TransectionHandler
    {
        private readonly List<ITransection> _transection;
        IEnumerable<ITransection> IEnumobj;
        Transection transection;
        public TransectionHandler()
        {
            _transection = new List<ITransection>();
            transection = new Transection();
        }



        //Transection Handler Adding Method

        public void AddTransection(ITransection obj)
        {
            var newtransection = obj as ITransection;
            if(newtransection!=null)
            {
                _transection.Add(newtransection);
            }
            else
            {
                throw new ArgumentNullException("empty data found");
            }
        }


        //Transection Display................
        public void DisplayTransection()
        {
            foreach(var i in _transection)
            {
                Console.WriteLine(i);
            }
        }


        //Searching Product By Status Using IEnmerable
        public IEnumerable<ITransection> GetTransections<TTransection>(ProductStatus status) where TTransection:Transection
        {
            IEnumobj= _transection.Where(t => t.Status == status);
            foreach(var i in IEnumobj)
            {
                Console.WriteLine(i);
            }
            return IEnumobj;
        }


        //Searching Product By Prodct Type Name Using IEnmerable
        public IEnumerable<ITransection> GetTransectionsTypeName<TTransection>(ProductTypeName name) where TTransection:Transection

        {
            IEnumobj = _transection.Where(t => t.Productname == name);

            foreach(var i in IEnumobj)
            {
                Console.WriteLine(i);
            }
            return IEnumobj;

        }


        //Transection Calling Methode
        public int  Transection(int price,int Disprice,int option)
        {
            if(option==1)
            {
                return transection.IssueTransection(price);
            }
            else if(option==2)
            {
               return  transection.ReturnTransection(price, Disprice);
            }
            return 1;
        }


        //Searching Transection Product By Code

        public ITransection GetProductTransectionCode(string code,bool IgnoreCase=false)
        {
            return _transection.FirstOrDefault(s => string.Compare(s.ProdutCode, code)==0);
        }


        //Remove transection from Transection LIst
        public void RemovedTransection(ITransection t)
        {
            var removetransection = t as ITransection;
            if (removetransection != null)
            {
                _transection.Remove(removetransection);
            }   
        }



        //Getting Maximum Price
        public double GetMax<TTransection>() where TTransection : Transection
        {
            return _transection.Max(p => p.Price);
        }



        //Getting Minimum Price
        public double GetMin<TTransection>() where TTransection : Transection
        {
            return _transection.Min(p => p.Price);
        }



        //Getting Average Price
        public double GetAverage<TTransection>() where TTransection : Transection
        {
            return _transection.Average(p => p.Price);
        }


        //Getting Transection By searching Price
        public ITransection GetTransectionByPrice(double  price,bool IgnoreCase=false)
        {
            return _transection.FirstOrDefault(s => string.Compare(s.Price.ToString(), price.ToString()) == 0);
        }
    }
}
