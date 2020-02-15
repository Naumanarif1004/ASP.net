using Ado.Net;
using System;
using System.Linq;
namespace LINQ
{
    public class CoursesLinq
    {

        //IssFeatred Courses
        public void Issfeatured()
        {
            try
            {
                var issFeatured = from c in new CourseDal().GetCourses()
                                  where c.IsFeatured == true && c.IsFeatured != false
                                  group c by c.Title into cg
                                  orderby cg.Key
                                  select new
                                  {
                                      Name = cg.Key
                                  };

                foreach (var issfeatured in issFeatured)
                {
                    Console.WriteLine(issfeatured.Name);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
                            
        }

        //Display Courses By Price >5000

        public void DisplayCoursesByPrice()
        {
            try
            {
                var Price = from c in new CourseDal().GetCourses()
                            where c.Price > 5000
                            group c by c.Title into cg
                            orderby cg.Key
                            select new
                            {
                                Name = cg.Key
                            };
                foreach (var price in Price)
                {
                    Console.WriteLine(price.Name);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
