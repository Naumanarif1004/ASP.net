using Enumeration;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Handler
{
    public class HandlerClass
    {
        IEnumerable<IPerson> obj=null;
        private List<Person> _person;
        Person P = new Person();
        public HandlerClass()
        {
            _person = new List<Person>();
        }

        public void Insert(Person p)
        {
            var person = p as Person;


            try
            {
                _person.Add(person);
            }
            catch (Exception ex)
            {

                throw new Exception("Error In Handler Class Insertion Method...",ex);
            }
            
        }

        public void display()
        {
            try
            {
                foreach (var person in _person)
                {
                    Console.WriteLine(person);
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error Ocurred IN Handler Class Display Method",ex);
            }
        }
        public void DisplayByAge()
        {
            var PersonAge = from p in _person
                            where p.Age > 10 && p.Age < 30
                            select new { Name = p.Name };
            PersonAge.ToList().ForEach(p => Console.WriteLine(p.Name));

        }
        public void DisplayGroupById()
        {
            var GroupedById = from p in _person
                              where p.Id > 0
                              group p by p.Id into pg
                              orderby pg.Key
                              select new { pg.Key, pg };
            foreach (var pgroup in GroupedById)
            {
                Console.WriteLine("Person Id {0} ", pgroup.Key);
                pgroup.pg.ToList().ForEach(p => Console.WriteLine(p.Name));
            }

        }
        public void GroupedByAge()
        {
            var GroupedByAge = from p in _person
                               where p.Age > 20
                               group p by p.Age into pg
                               orderby pg.Key
                               select new { pg.Key, pg };
            foreach (var Agegroup in GroupedByAge)
            {
                Console.WriteLine("Person Age {0} ", Agegroup.Key);
                Agegroup.pg.ToList().ForEach(p => Console.WriteLine(p.Name));
            }

        }
        public void CountPerson()
        {
            var Count = from p in _person
                        where p.Age > 20
                        group p by p.Id into pg
                        orderby pg.Key
                        select new { pg.Key,
                            count = pg.Count() };

            foreach (var countP in Count)
            {
                Console.WriteLine($"Name  {countP.Key}  [] Count  {countP.count}");
            }

        }
        public void DisplayIsAdult()
        {
            var IsAdult = from p in _person
                          where p.IsAdult = true && p.IsAdult != false
                          group p by p.Name into pg
                          orderby pg.Key
                          select new { Name = pg.Key, Age = P.Age };
            foreach (var isadult in IsAdult)
            {
                Console.WriteLine($"Name  {isadult.Name}");
                IsAdult.ToList().ForEach(p => Console.WriteLine(p.Age));

            }
        }
            public void NameCount(string name)
            {
            
            var syed = from p in _person
                       where p.Name == name
                       group p by p.Name into pg
                       orderby pg.Key,pg.Count()
                       select new {
                          Name= pg.Key,
                       count=pg.Count()};
            foreach (var Syed in syed)
            {
                Console.WriteLine($"Person Name  {Syed.Name}  ---- Count  {Syed.count}");
               
            }

            }

          public Person Search(int id,bool Ignorance=false)
        {
            return _person.FirstOrDefault(s => string.Compare(s.Id.ToString() , id.ToString())==0);
        }

        public void Delete(Person p)
        {
            _person.Remove(p);
        }

        public   IEnumerable<IPerson> GetPerson<Person>(PersonType type)
        {
            obj= _person.Where(p => p.personType == type);
            foreach(var i in obj)
            {
                Console.WriteLine(i);
            }
            return obj;
        }
    }
}
    

