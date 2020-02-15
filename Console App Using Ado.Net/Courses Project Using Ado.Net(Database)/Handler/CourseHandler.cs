using Ado.Net;
using Events;
using LINQ;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Handler
{
    public class CourseHandler
    {
        Courses courses;
        CourseDal courseDal;
        public event  EventHandler<CoursetEvents> eventHandler;

        //Constructor
        public CourseHandler()
        {
            courses = new Courses();
            courseDal = new CourseDal();
        }


        //Course Insertion
        public void CourseInsertion(Courses courses)
        {
            try
            {
                if (courses != null)
                {
                    courseDal.CourseInsertion(courses);
                    eventHandler?.Invoke(this, new CoursetEvents()
                    {
                        courses = courses
                    });
                }
                else
                {
                    Console.WriteLine("Null Data Found...");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Course Deletion
        public void CourseDeletion(int id)
        {
            try
            {
                if (id > 0)
                {
                    courseDal.CourseDeletion(id);
                    Console.WriteLine("Course Deleted Sucessfulllllllllly");
                }
                else
                {
                    Console.WriteLine("Neagtive Data Found..");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //Get Courses
        public void GetCourses()
        {
            try
            {
                var temp = courseDal.GetCourses();
                if (temp == null)
                {
                    Console.WriteLine("Courses Data Not Found...");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //Get Courses By Course Id
        public void GetCoursByCourseId(int id)
        {
            try
            {
                if (id > 0)
                {
                    var temp = courseDal.GetCourseById(id);
                    if (temp == null)
                    {
                        Console.WriteLine("Searching Data Not Found...");
                    }
                }
                else
                {
                    Console.WriteLine("Negative Data Found...");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //GetCourses By Subject Id
        public void GetCoursesBySubjectId(int id)
        {
            try
            {
                if (id > 0)
                {
                    var temp = courseDal.GetCoursesBySubjectId(id);
                    if (temp == null)
                    {
                        Console.WriteLine("Searching Data Not Found...");
                    }
                }
                else
                {
                    Console.WriteLine("Negative Data Found....");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //---------------------------------------------------------------------------------------
        //-------------------------------------LINQ SECTION--------------------------------------
        //---------------------------------------------------------------------------------------


            //Display Issfeatured Courses
        public void DisplayIssfeaturedCourses()
        {
            try
            {
                new CoursesLinq().Issfeatured();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //Display Courses Whoes Price >5000

        public void DisplaCoursesByPrice()
        {
            try
            {
                new CoursesLinq().DisplayCoursesByPrice();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}