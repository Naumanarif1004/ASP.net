using Enumeration;
using Handler;
using Model;
using System;
using System.Collections.Generic;

namespace LinqHandler
{
    public class LinqHandlerClass
    {
        Random random = new Random();
        HandlerClass handlerClass = new HandlerClass();
        public void Insertion()
        {
            try
            {
                Person p = new Person();
                Console.WriteLine("\nEnter Person Name");
                string name = Console.ReadLine();
                Console.WriteLine("enter person age");
                int age = Convert.ToInt32(Console.ReadLine());
                p.IsAdult = (age >= 18) ? true : false;
                p.personType = (age >= 25) ? Enumeration.PersonType.Employee : Enumeration.PersonType.Student;
                p.Name = name;
                p.Age = age;
                p.Id = random.Next(1, 100);
                handlerClass.Insert(p);
            }
            catch (Exception ex)
            {

                throw new Exception("Error Ocurred In LinqHandlerClass Insertion Method",ex);
            }
        }
        public void display()
        {
            try
            {
                handlerClass.display();
            }
            catch (Exception ex)
            {

                throw new Exception("Error Ocurred In LinqHandler Class Display Methodes");
            }
        }
        public void displayByage()
        {
            handlerClass.DisplayByAge();
        }
        public void GroupedById()
        {
            handlerClass.DisplayGroupById();
        }

        public void GroupedByAge()
        {
            handlerClass.GroupedByAge();
        }
        public void Count()
        {

            handlerClass.CountPerson();
        }
        public void Isadult()
        {
            handlerClass.DisplayIsAdult();
        }

        public void DisplaySyed()
        {
            try
            {
                Console.WriteLine("Enter Name For Count");
                string name = Console.ReadLine();
                handlerClass.NameCount(name);
            }
            catch (Exception ex)
            {

                throw new Exception("Error Ocurred In LinqHandler Class NAme Counting Mthod,ex");
            }
        }
        public void Delete()
        {
            try
            {
                Console.WriteLine("Enter Person Id To Delete From List");
                int id = Convert.ToInt32(Console.ReadLine());
                var SearchKey = handlerClass.Search(id);
                if (SearchKey != null)
                {
                    handlerClass.Delete(SearchKey);
                    Console.WriteLine("\n\nPerson Deleted Sucessfulllllllllly");
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error Ocurred In Linq HandlerClass Delete Method",ex);
            }
           
        }
        public void SearchByType()
        {
            Console.WriteLine("1.Student  -----  2.Employee   ----Enter Your Choice");
            int ch = Convert.ToInt32(Console.ReadLine());
            var type = (ch == 1) ? PersonType.Student : PersonType.Employee;
            handlerClass.GetPerson<Person>(type);
        }
       
       
    }
}
