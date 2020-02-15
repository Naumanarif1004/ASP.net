using Handler;
using Model;
using System;
using System.Collections.Generic;

namespace ConsoleAppProduct
{
    class ProductMain
    {
        static void Main(string[] args)
        {

            var Handler = new ProductHandler();
            var transectionHandler = new TransectionHandler();
            bool chk1 = true, chk2 = true, chk3 = true, chk4 = true, chk5 = true,
                chk6 = true, chk7 = true, chk8 = true, chk9 = true, chk10 = true;
            IProduct laptop = null;
            IProduct mobile = null;
            var total = 0;
            ITransection transection = new Transection();
            string code = null;
            int choice1, choice2, choice3 = 0;
            int count = 0;
            int price = 0;

            do
            {

                Console.WriteLine("\t\t\t\t\t\t\tProduct Menu");
                Console.WriteLine("\t\t\t\t\t\t----------------------------");
                Console.WriteLine("\t\t\t\t\t\t1. Consumable Product");
                Console.WriteLine("\t\t\t\t\t\t2. Non Consumable Product");
                Console.WriteLine("\t\t\t\t\t\t3. enter any key to exit");
                Console.WriteLine("\t\t\t\t\t\t----------------------------");


                Console.WriteLine("\n\nENTER YOUR CHOICE...");
                choice1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choice1)                                      //switch 1
                {
                    case 1:

                        do
                        {

                            Console.WriteLine("\n\t\t\t\t\t\t\t  Consumable Product Menu");
                            Console.WriteLine("\t\t\t\t\t\t        ----------------------------");
                            Console.WriteLine("\n\t\t\t\t1.  Add New Product");
                            Console.WriteLine("\t\t\t\t2.  Display List Of Onshelf Product");
                            Console.WriteLine("\t\t\t\t3.  Display List Of Product By Product Status Issue/Onshelf/Return");
                            Console.WriteLine("\t\t\t\t4.  Display List Of Product By Product Type Name Mobile/Laptop");
                            Console.WriteLine("\t\t\t\t5.  Remove Produt By Product By Product Status/Onshelf/Issue/Return");
                            Console.WriteLine("\t\t\t\t6.  Remove Product By Product Name/Mobile/Laptop ");
                            Console.WriteLine("\t\t\t\t7.  Update Product By  Product Name/Mobile/Laptop");
                            Console.WriteLine("\t\t\t\t8.  Make Transection");
                            Console.WriteLine("\t\t\t\t9.  Display History of Transection");
                            Console.WriteLine("\t\t\t\t10.  Display Total Price of All transection");
                            Console.WriteLine("\t\t\t\t11. Display Maximum Price Transection");
                            Console.WriteLine("\t\t\t\t12. Display Minmun Price Transection");
                            Console.WriteLine("\t\t\t\t13. Display Averages Price Transection");
                            Console.WriteLine("\t\t\t\t##.  Press any Other Key To Go To Main Menu ");



                            Console.WriteLine("\n\nENTER YOUR CHOICE...");
                            choice2 = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (choice2)                                   //switch 2
                            {
                                case 1:

                                    do
                                    {

                                        Console.WriteLine("\n\t\t\t\tSelect Consumable Product Type Mobile/Laptop To Add");
                                        Console.WriteLine("\t\t\t\t---------------------------------------------------");
                                        Console.WriteLine("\n\t\t\t\t1.Add Mobile");
                                        Console.WriteLine("\t\t\t\t2. Add Laptop");
                                        Console.WriteLine("\t\t\t\t3. Enter any Other key to go to Consumable Product Menu");
                                        Console.WriteLine("\n\nENTER YOUR CHOICE...");
                                        choice3 = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        switch (choice3)
                                        {
                                            case 1:
                                            case 2:
                                                Console.Clear();
                                                Console.WriteLine("\nEnter Product name...");
                                                string name = Console.ReadLine();
                                                Console.WriteLine("Enter Product Code...");
                                                code = Console.ReadLine();
                                                Console.WriteLine("Enter Product Model...");
                                                string model = Console.ReadLine();
                                                if (choice3 == 1)
                                                {
                                                    mobile = new Mobile(name, code, model, ProductStatus.OnShelf, ProductType.Consumbale, ProductTypeName.Mobile, DateTime.Now);
                                                    Handler.AddProduct(mobile);
                                                }
                                                else
                                                    if (choice3 == 2)
                                                {
                                                    laptop = new Laptop(name, code, model, ProductStatus.OnShelf, ProductType.Consumbale, ProductTypeName.Laptop, DateTime.Now);
                                                    Handler.AddProduct(laptop);
                                                }
                                                Console.Clear();
                                                break;
                                            default:
                                                chk3 = false;
                                                break;
                                        }
                                    } while (chk3);

                                    break;
                                case 2:

                                    Console.WriteLine("\n\t\t\t\t\t\t  Display Of Onshelf Product");
                                    Console.WriteLine("\t\t\t\t\t\t  ----------------------------\n");
                                    Handler.DisplayOnshelfProduct();
                                    Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                    string ch = Console.ReadLine();
                                    if (ch == "y" || ch == "Y")
                                    {
                                        chk1 = true;
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        chk1 = false;
                                    }

                                    break;
                                //------------------------------------------------------------------------------------------------------------------------------

                                case 3:
                                    do
                                    {

                                        Console.WriteLine("\n\t\t\t\tDisplay Consumable Product List By Product Status");
                                        Console.WriteLine("\t\t\t\t---------------------------------------------------");
                                        Console.WriteLine("\n\t\t\t\t1.OnShelf");
                                        Console.WriteLine("\t\t\t\t2. Issue");
                                        Console.WriteLine("\t\t\t\t3. Return");
                                        Console.WriteLine("\t\t\t\t4. Enter any Other key to go to Consumable Product Menu");
                                        Console.WriteLine("\n\nENTER YOUR CHOICE...");
                                        choice3 = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        if (choice3 == 1)
                                        {
                                            Console.WriteLine("\n\t\t\t\t\t\t  Display Of Onshelf Product");
                                            Console.WriteLine("\t\t\t\t\t\t  ----------------------------\n");
                                            Handler.GetProducts<Product>(ProductStatus.OnShelf);
                                            Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                            ch = Console.ReadLine();
                                            if (ch == "y" || ch == "Y")
                                            {
                                                chk1 = true;
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                chk1 = false;
                                            }

                                        }
                                        else if (choice3 == 2)
                                        {
                                            Console.WriteLine("\n\t\t\t\t\t\t  Display Of Issue Product");
                                            Console.WriteLine("\t\t\t\t\t\t  ----------------------------\n");
                                            transectionHandler.GetTransections<Transection>(ProductStatus.Issue);
                                            Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                            ch = Console.ReadLine();
                                            if (ch == "y" || ch == "Y")
                                            {
                                                chk1 = true;
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                chk1 = false;
                                            }
                                        }
                                        else if (choice3 == 3)
                                        {
                                            Console.WriteLine("\n\t\t\t\t\t\t  Display Of Return Product");
                                            Console.WriteLine("\t\t\t\t\t\t  ----------------------------\n");
                                            transectionHandler.GetTransections<Transection>(ProductStatus.Return);
                                            Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                            ch = Console.ReadLine();
                                            if (ch == "y" || ch == "Y")
                                            {
                                                chk1 = true;
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                chk1 = false;
                                            }
                                        }
                                        else if ((choice3 > 3) || (choice3 < 1))
                                        {
                                            chk4 = false;
                                        }


                                    } while (chk4);

                                    break;

                                //------------------------------------------------------------------------------------------------------------------------------


                                case 4:

                                    do
                                    {
                                        Console.WriteLine("\n\t\t\t\tDisplay Consumable Product List By Product Type Name");
                                        Console.WriteLine("\t\t\t\t---------------------------------------------------");
                                        Console.WriteLine("\n\t\t\t\t1.Mobile");
                                        Console.WriteLine("\t\t\t\t2. Laptop");
                                        Console.WriteLine("\t\t\t\t3. Enter any Other key to go to Consumable Product Menu");
                                        Console.WriteLine("\n\nENTER YOUR CHOICE...");
                                        choice3 = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        if (choice3 == 1)
                                        {
                                            Console.WriteLine("\n\t\t\t\t\t\t  Display Of Mobiles");
                                            Console.WriteLine("\t\t\t\t\t\t  ----------------------------\n");
                                            Handler.GetProductsByname<Product>(ProductTypeName.Mobile);
                                            transectionHandler.GetTransectionsTypeName<Transection>(ProductTypeName.Mobile);
                                            Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                            ch = Console.ReadLine();
                                            if (ch == "y" || ch == "Y")
                                            {
                                                chk1 = true;
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                chk1 = false;
                                            }
                                        }
                                        else if (choice3 == 2)
                                        {
                                            Console.WriteLine("\n\t\t\t\t\t\t  Display Of Laptops");
                                            Console.WriteLine("\t\t\t\t\t\t  ----------------------------\n");
                                            Handler.GetProductsByname<Product>(ProductTypeName.Laptop);
                                            transectionHandler.GetTransectionsTypeName<Transection>(ProductTypeName.Laptop);
                                            Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                            ch = Console.ReadLine();
                                            if (ch == "y" || ch == "Y")
                                            {
                                                chk1 = true;
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                chk1 = false;
                                            }
                                        }
                                        else if ((choice3 > 2) || (choice3 < 1))
                                        {
                                            chk5 = false;
                                        }


                                    } while (chk5);

                                    break;

                                //------------------------------------------------------------------------------------------


                                case 5:

                                    do
                                    {

                                        Console.WriteLine("\n\t\t\t\tRemove Consumable Product From List By Product Status");
                                        Console.WriteLine("\t\t\t\t---------------------------------------------------");
                                        Console.WriteLine("\n\t\t\t\t1.OnShelf");
                                        Console.WriteLine("\t\t\t\t2. Issue");
                                        Console.WriteLine("\t\t\t\t3. Return");
                                        Console.WriteLine("\t\t\t\t4. Enter any Other key to go to Consumable Product Menu");
                                        Console.WriteLine("\n\nENTER YOUR CHOICE...");
                                        choice3 = Convert.ToInt32(Console.ReadLine());

                                        Console.Clear();
                                        if (choice3 == 1)
                                        {
                                            Console.WriteLine("\n\t\t\t\t\t\t  Display Of Onshelf Product");
                                            Console.WriteLine("\t\t\t\t\t\t  ----------------------------\n");
                                            Handler.GetProducts<Product>(ProductStatus.OnShelf);

                                            Console.WriteLine("\n\nEnter OnShlef Product Code To Remove From List.... ");
                                            code = Console.ReadLine();
                                            var search = Handler.SearchByCode(code);
                                            if (search != null)
                                            {
                                                Handler.RemoveByCode(search);
                                                Console.WriteLine("\nProduct Remove Sucessfullllllllllllllly");
                                                Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                                ch = Console.ReadLine();
                                                if (ch == "y" || ch == "Y")
                                                {
                                                    chk1 = true;
                                                    Console.Clear();
                                                }
                                                else
                                                {
                                                    chk1 = false;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("\n\nThe Product Code You Enter Does Not Exsist In The LIst...");
                                            }
                                        }



                                        else if (choice3 == 2)
                                        {
                                            Console.WriteLine("\n\t\t\t\t\t\t  Display Of Issue Product");
                                            Console.WriteLine("\t\t\t\t\t\t  ----------------------------\n");
                                            transectionHandler.GetTransections<Transection>(ProductStatus.Issue);

                                            Console.WriteLine("\n\nEnter Issue Product Code To Remove From List.... ");
                                            code = Console.ReadLine();
                                            var sEarch = transectionHandler.GetProductTransectionCode(code);
                                            if (sEarch != null)
                                            {
                                                transectionHandler.RemovedTransection(sEarch);
                                                Console.WriteLine("\nProduct Remove Sucessfullllllllllllllly");
                                                Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                                ch = Console.ReadLine();
                                                if (ch == "y" || ch == "Y")
                                                {
                                                    chk1 = true;
                                                    Console.Clear();
                                                }
                                                else
                                                {
                                                    chk1 = false;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("\n\nThe Product Code You Enter Does Not Exsist In The LIst...");
                                            }
                                        }



                                        else if (choice3 == 3)
                                        {
                                            Console.WriteLine("\n\t\t\t\t\t\t  Display Of Return Product");
                                            Console.WriteLine("\t\t\t\t\t\t  ----------------------------\n");
                                            transectionHandler.GetTransections<Transection>(ProductStatus.Return);

                                            Console.WriteLine("\n\nEnter Issue Product Code To Remove From List.... ");
                                            code = Console.ReadLine();
                                            var sEarch = transectionHandler.GetProductTransectionCode(code);
                                            if (sEarch != null)
                                            {
                                                transectionHandler.RemovedTransection(sEarch);
                                                Console.WriteLine("\nProduct Remove Sucessfullllllllllllllly");
                                                Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                                ch = Console.ReadLine();
                                                if (ch == "y" || ch == "Y")
                                                {
                                                    chk1 = true;
                                                    Console.Clear();
                                                }
                                                else
                                                {
                                                    chk1 = false;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("\n\nThe Product Code You Enter Does Not Exsist In The LIst...");
                                            }
                                        }



                                        else if ((choice3 > 3) || (choice3 < 1))
                                        {
                                            chk6 = false;
                                        }




                                    } while (chk6);

                                    break;
                                //------------------------------------------------------------------------------------------------------------------------------

                                case 6:

                                    do
                                    {

                                        Console.WriteLine("\n\t\t\t\tRemove Consumable  Onshelf Product From List By Product Type Name");
                                        Console.WriteLine("\t\t\t\t---------------------------------------------------");
                                        Console.WriteLine("\n\t\t\t\t1.MObile");
                                        Console.WriteLine("\t\t\t\t2. Laptop");
                                        Console.WriteLine("\t\t\t\t4. Enter any Other key to go to Consumable Product Menu");
                                        Console.WriteLine("\n\nENTER YOUR CHOICE...");
                                        choice3 = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();

                                        if (choice3 == 1)
                                        {
                                            Console.WriteLine("\n\t\t\t\t\t\t  Display Of Mobiles");
                                            Console.WriteLine("\t\t\t\t\t\t  ----------------------------\n");
                                            Handler.GetProductsByname<Product>(ProductTypeName.Mobile);

                                            Console.WriteLine("\n\nEnter Mobile  Code To Remove From List.... ");
                                            code = Console.ReadLine();
                                            var search = Handler.SearchByCode(code);
                                            if (search != null)
                                            {
                                                Handler.RemoveByCode(search);
                                                Console.WriteLine("\nProduct Remove Sucessfullllllllllllllly");
                                                Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                                ch = Console.ReadLine();
                                                if (ch == "y" || ch == "Y")
                                                {
                                                    chk1 = true;
                                                    Console.Clear();
                                                }
                                                else
                                                {
                                                    chk1 = false;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("\n\nThe Product Code You Enter Does Not Exsist In The LIst...");
                                            }
                                        }



                                        else if (choice3 == 2)
                                        {
                                            Console.WriteLine("\n\t\t\t\t\t\t  Display Of Laptops");
                                            Console.WriteLine("\t\t\t\t\t\t  ----------------------------\n");
                                            Handler.GetProductsByname<Product>(ProductTypeName.Laptop);

                                            Console.WriteLine("\n\nEnter Laptop Code To Remove From List.... ");
                                            code = Console.ReadLine();
                                            var search = Handler.SearchByCode(code);
                                            if (search != null)
                                            {
                                                Handler.RemoveByCode(search);
                                                Console.WriteLine("\nProduct Remove Sucessfullllllllllllllly");
                                                Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                                ch = Console.ReadLine();
                                                if (ch == "y" || ch == "Y")
                                                {
                                                    chk1 = true;
                                                    Console.Clear();
                                                }
                                                else
                                                {
                                                    chk1 = false;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("\n\nThe Product Code You Enter Does Not Exsist In The LIst...");
                                            }
                                        }

                                        else if ((choice3 > 2) || (choice3 < 1))
                                        {
                                            chk7 = false;
                                        }
                                        if (choice3 == 1)
                                        {
                                            Console.WriteLine("\n\t\t\t\t\t\t  Display Of Onshelf Product");
                                            Console.WriteLine("\t\t\t\t\t\t  ----------------------------\n");
                                            Handler.GetProducts<Product>(ProductStatus.OnShelf);
                                        }
                                        else if (choice3 == 2)
                                        {
                                            Console.WriteLine("\n\t\t\t\t\t\t  Display Of Issue Product");
                                            Console.WriteLine("\t\t\t\t\t\t  ----------------------------\n");
                                            Handler.GetProducts<Product>(ProductStatus.Issue);
                                        }
                                        else if (choice3 == 3)
                                        {
                                            Console.WriteLine("\n\t\t\t\t\t\t  Display Of Return Product");
                                            Console.WriteLine("\t\t\t\t\t\t  ----------------------------\n");
                                            Handler.GetProducts<Product>(ProductStatus.Return);
                                        }
                                        else if ((choice3 > 3) || (choice3 < 1))
                                        {
                                            chk4 = false;
                                        }




                                    } while (chk7);

                                    break;
                                //------------------------------------------------------------------------------------------------------------------------------



                                case 7:

                                    do
                                    {
                                        Console.WriteLine("\n\t\t\t\tUpdate Consumable Product By Product Status");
                                        Console.WriteLine("\t\t\t\t---------------------------------------------------");
                                        Console.WriteLine("\n\t\t\t\t1.Mobile");
                                        Console.WriteLine("\t\t\t\t2. Laptop");
                                        Console.WriteLine("\t\t\t\t4. Enter any Other key to go to Consumable Product Menu");
                                        Console.WriteLine("\n\nENTER YOUR CHOICE...");
                                        choice3 = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        switch (choice3)
                                        {
                                            case 1:
                                                Console.Clear();
                                                Handler.GetProductsByname<Product>(ProductTypeName.Mobile);
                                                Console.WriteLine("\n\nEnter Product Code Want to Update...");
                                                code = Console.ReadLine();
                                                var SEarch = Handler.SearchByCode(code);
                                                if (SEarch != null)
                                                {


                                                    Console.WriteLine("\nEnter New Product name...");
                                                    string nname = Console.ReadLine();
                                                    Console.WriteLine("Enter New Product Code...");
                                                    string ncode = Console.ReadLine();
                                                    Console.WriteLine("Enter NewProduct Model...");
                                                    string nmodel = Console.ReadLine();
                                                    mobile.Producname = nname;
                                                    mobile.ProdutCode = ncode;
                                                    mobile.Model = nmodel;

                                                    Console.WriteLine("\n\nProduct Updated Sucessfullllllllllllly");
                                                    Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                                    ch = Console.ReadLine();
                                                    if (ch == "y" || ch == "Y")
                                                    {
                                                        chk1 = true;
                                                        Console.Clear();
                                                    }
                                                    else
                                                    {
                                                        chk1 = false;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("\n\nThe Product Code You Enter Does Not Exsist In The LIst...");
                                                }
                                                break;
                                            case 2:

                                                Handler.GetProductsByname<Product>(ProductTypeName.Laptop);
                                                Console.WriteLine("\n\nEnter Product Code Want to Update...");
                                                code = Console.ReadLine();
                                                var SeAarch = Handler.SearchByCode(code);
                                                if (SeAarch != null)
                                                {
                                                    Console.WriteLine("\nEnter New Product name...");
                                                    string nname = Console.ReadLine();
                                                    Console.WriteLine("Enter New Product Code...");
                                                    string ncode = Console.ReadLine();
                                                    Console.WriteLine("Enter NewProduct Model...");
                                                    string nmodel = Console.ReadLine();
                                                    laptop.Producname = nname;
                                                    laptop.ProdutCode = ncode;
                                                    laptop.Model = nmodel;
                                                    Console.WriteLine("\n\nProduct Updated Sucessfullllllllllllly");
                                                    Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                                    ch = Console.ReadLine();
                                                    if (ch == "y" || ch == "Y")
                                                    {
                                                        chk1 = true;
                                                        Console.Clear();
                                                    }
                                                    else
                                                    {
                                                        chk1 = false;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("\n\nThe Product Code You Enter Does Not Exsist In The LIst...");
                                                }

                                                break;

                                            default:
                                                chk8 = false;
                                                break;
                                        }


                                    } while (chk8);

                                    break;



                                //------------------------------------------------------------------------------------------------------------------------------


































                                case 8:
                                    do
                                    {
                                        Console.WriteLine("\n\t\t\t\t\tMake new Transection");
                                        Console.WriteLine("\t\t\t\t---------------------------------------------------");
                                        Console.WriteLine("\n\t\t\t\t1.Issue");
                                        Console.WriteLine("\t\t\t\t2. Return");
                                        Console.WriteLine("\t\t\t\t3. Enter any Other key to go to Consumable Product Menu");
                                        Console.WriteLine("\n\nENTER YOUR CHOICE...");
                                        choice3 = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        switch (choice3)
                                        {




                                            //MAKING TRANSECTION OF ISSUE................................


                                            case 1:
                                                Console.WriteLine("------------------------");
                                                Console.WriteLine("1.Mobile");
                                                Console.WriteLine("2.Laptop");
                                                Console.WriteLine("\n\nENTER YOUR CHOICE...");
                                                int choice4 = Convert.ToInt32(Console.ReadLine());
                                                if (choice4 == 1)
                                                {
                                                    Handler.GetProductsByname<Product>(ProductTypeName.Mobile);
                                                    count = 1;
                                                }
                                                else if (choice4 == 2)
                                                {
                                                    Handler.GetProductsByname<Product>(ProductTypeName.Laptop);
                                                    count = 2;
                                                }



                                                Console.WriteLine("\n\nEnter Product Code For Issue Transection");
                                                code = Console.ReadLine();
                                                var searcH = Handler.SearchByCode(code);
                                                if (searcH != null)
                                                {
                                                    string name = searcH.Producname;
                                                    Console.WriteLine("Product Name  " + name);
                                                    string COde = searcH.ProdutCode;
                                                    Console.WriteLine("Product Code  " + COde);
                                                    string model = searcH.Model;
                                                    Console.WriteLine("Product Model  " + model);
                                                    Console.WriteLine("Enter Produt Price");
                                                    price = Int32.Parse(Console.ReadLine());

                                                    transection.SetValue(name, COde, model, ProductStatus.Issue, ProductType.Consumbale, price);


                                                    total = transectionHandler.Transection(price, 0, 1);



                                                    if (count == 1)
                                                    {
                                                        transection.Productname = ProductTypeName.Mobile;
                                                        transectionHandler.AddTransection(transection);
                                                        Console.WriteLine("\n\ntransection Completed Sucessfullllllly");
                                                        Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                                        ch = Console.ReadLine();
                                                        if (ch == "y" || ch == "Y")
                                                        {
                                                            chk1 = true;
                                                            Console.Clear();
                                                        }
                                                        else
                                                        {
                                                            chk1 = false;
                                                        }
                                                    }
                                                    else if (count == 2)
                                                    {
                                                        transection.Productname = ProductTypeName.Laptop;
                                                        transectionHandler.AddTransection(transection);
                                                        Console.WriteLine("\n\ntransection Completed Sucessfullllllly");
                                                        Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                                        ch = Console.ReadLine();
                                                        if (ch == "y" || ch == "Y")
                                                        {
                                                            chk1 = true;
                                                            Console.Clear();
                                                        }
                                                        else
                                                        {
                                                            chk1 = false;
                                                        }

                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("the Prduct code You Enter Does Not Exsist In The List");
                                                }
                                                Handler.RemoveByCode(searcH);
                                                break;





















                                            //MAKING TRANSECTION OF RETURN....................



                                            case 2:
                                                Console.WriteLine("On Returning 10% Cutting");
                                                Console.WriteLine("\n------------------------");
                                                Console.WriteLine("1.Mobile");
                                                Console.WriteLine("2.Laptop");
                                                Console.WriteLine("\n\nENTER YOUR CHOICE...");
                                                int choice5 = Convert.ToInt32(Console.ReadLine());
                                                if (choice5 == 1)
                                                {
                                                    transectionHandler.GetTransectionsTypeName<Transection>(ProductTypeName.Mobile);
                                                    count = 1;
                                                }
                                                else if (choice5 == 2)
                                                {
                                                    transectionHandler.GetTransectionsTypeName<Transection>(ProductTypeName.Laptop);
                                                    count = 2;
                                                }



                                                Console.WriteLine("\n\nEnter Product Code For Return Transection");
                                                code = Console.ReadLine();
                                                var searCh = transectionHandler.GetProductTransectionCode(code);
                                                if (searCh != null)
                                                {

                                                    string name = searCh.Producname;
                                                    string COde = searCh.ProdutCode;
                                                    string model = searCh.Model;

                                                    price = transection.Price;
                                                    int disprice = price * 10 / 100;
                                                    transection.Producname = name;
                                                    transection.ProdutCode = COde;
                                                    transection.Status = ProductStatus.Return;
                                                    transection.TransectionDate = DateTime.Now;
                                                    transection.Price = disprice;
                                                    transection.Model = model;

                                                    transection.Producttype = ProductType.Consumbale;




                                                    total = transectionHandler.Transection(price, disprice, 2);


                                                    if (count == 1)
                                                    {
                                                        mobile = new Mobile(name, COde, model, ProductStatus.OnShelf, ProductType.Consumbale, ProductTypeName.Mobile, DateTime.Now);
                                                        Handler.AddProduct(mobile);
                                                        Console.WriteLine("\n\ntransection Completed Sucessfullllllly");
                                                        Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                                        ch = Console.ReadLine();
                                                        if (ch == "y" || ch == "Y")
                                                        {
                                                            chk1 = true;
                                                            Console.Clear();
                                                        }
                                                        else
                                                        {
                                                            chk1 = false;
                                                        }

                                                    }
                                                    else if (count == 2)
                                                    {
                                                        laptop = new Mobile(name, COde, model, ProductStatus.OnShelf, ProductType.Consumbale, ProductTypeName.Laptop, DateTime.Now);
                                                        Handler.AddProduct(laptop);
                                                        Console.WriteLine("\n\ntransection Completed Sucessfullllllly");
                                                        Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                                        ch = Console.ReadLine();
                                                        if (ch == "y" || ch == "Y")
                                                        {
                                                            chk1 = true;
                                                            Console.Clear();
                                                        }
                                                        else
                                                        {
                                                            chk1 = false;
                                                        }


                                                    }

                                                }
                                                else
                                                {
                                                    Console.WriteLine("the Prduct code You Enter Does Not Exsist In The List");
                                                }

                                                break;

                                            default:
                                                chk9 = false;
                                                break;
                                        }
                                    } while (chk9);


                                    break;




































                                //------------------------------------------------------------------------------------------------------------------------------

                                case 9:
                                    Console.WriteLine("\n\nTransection History\n");
                                    transectionHandler.DisplayTransection();
                                    Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                    ch = Console.ReadLine();
                                    if (ch == "y" || ch == "Y")
                                    {
                                        chk1 = true;
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        chk1 = false;
                                    }
                                    break;
                                //------------------------------------------------------------------------------------------------------------------------------

                                case 10:
                                    Console.WriteLine("\n\nTotal Price  Transection...");
                                    Console.WriteLine(total);

                                    Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                    ch = Console.ReadLine();
                                    if (ch == "y" || ch == "Y")
                                    {
                                        chk1 = true;
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        chk1 = false;
                                    }
                                    break;
                                //------------------------------------------------------------------------------------------------------------------------------

                                case 11:
                                    Console.WriteLine("\n\nMaximum Transection Product\n");

                                    var MaxPrice = transectionHandler.GetMax<Transection>();
                                    Console.WriteLine(transectionHandler.GetTransectionByPrice(MaxPrice));
                                    Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                    ch = Console.ReadLine();
                                    if (ch == "y" || ch == "Y")
                                    {
                                        chk1 = true;
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        chk1 = false;
                                    }
                                    break;
                                //------------------------------------------------------------------------------------------------------------------------------

                                case 12:
                                    Console.WriteLine("\n\nMinmum Transection Product\n");
                                    var MinPrice = transectionHandler.GetMin<Transection>();
                                    Console.WriteLine(transectionHandler.GetTransectionByPrice(MinPrice));

                                    Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                    ch = Console.ReadLine();
                                    if (ch == "y" || ch == "Y")
                                    {
                                        chk1 = true;
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        chk1 = false;
                                    }
                                    break;
                                //------------------------------------------------------------------------------------------------------------------------------
                                case 13:
                                    Console.WriteLine("\nAverage Transection  Price");
                                    Console.WriteLine(transectionHandler.GetAverage<Transection>());

                                    Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                                    ch = Console.ReadLine();
                                    if (ch == "y" || ch == "Y")
                                    {
                                        chk1 = true;
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        chk1 = false;
                                    }
                                    break;

                                default:
                                    chk2 = false;
                                    break;
                                    //------------------------------------------------------------------------------------------------------------------------------


                            }

                        } while (chk2);

                        break;

                    case 2:

                        break;
                    default:
                        chk1 = false;
                        break;
                }

            } while (chk1);

        }


    }
}
