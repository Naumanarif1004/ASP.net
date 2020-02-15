using Ado.Net;
using Handler;
using LINQ;
using Model;
using System;

namespace ProjectHandler
{
    public class Projecthandler
    {




        //---------------------------------------------------------------------------------------
        //-------------------------------------SUBJECT SECTION-----------------------------------
        //---------------------------------------------------------------------------------------


            //Subject Insertion
        public void InsertSubject()
        {
            try
            {
                Console.WriteLine("Enter Subject Id");
                var id = Console.ReadLine();
                Console.WriteLine("Enter Subject Name");
                var Name = Console.ReadLine();
                var Date = DateTime.Now;
                new SubjectHandler().Insertion(new Subjects()
                {
                    SubjectId = Convert.ToInt32(id),
                    SubjectName = Convert.ToString(Name),
                    SubjectCreated = Convert.ToDateTime(Date)

                });
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //Subject Display.........

        public void DisplaySubject()
        {
            try
            {
                new SubjectHandler().GetSubjects();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //GetSubject By Id

        public void DisplaySubjectById()
        {
            try
            {
                Console.WriteLine("Enter Subejct Id TO Search....");
                var Sid = Console.ReadLine();
                new SubjectHandler().GetSubjectById(Convert.ToInt32(Sid));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }





        //---------------------------------------------------------------------------------------
        //-------------------------------------Course Section-----------------------------------
        //---------------------------------------------------------------------------------------



        //Course Insertion

        public void CourseInsertion()
        {
            try
            {
                var temp = new SubjectDal().GetSubjects();
                if (temp != null)
                {
                    Console.WriteLine("Choose Subject For Course By  Subject Id");
                    var Subjectid = Console.ReadLine();
                    Console.WriteLine("Enter Course Id");
                    var Id = Console.ReadLine();
                    Console.WriteLine("Enter Course Title");
                    var Name = Console.ReadLine();
                    Console.WriteLine("Enter Course Price");
                    var Price = Console.ReadLine();
                    Console.WriteLine("Enter Course Duration");
                    var Duration = Console.ReadLine();
                    Console.WriteLine("Issfeatured  (1:Yes -----2:No");
                    var choice = Convert.ToInt32(Console.ReadLine());
                    var Issfeatured = (choice == 1) ? true : false;
                    var Date = DateTime.Now;
                    new CourseHandler().CourseInsertion(new Courses()
                    {
                        CourseId = Convert.ToInt32(Id),
                        Title = Convert.ToString(Name),
                        Price = Convert.ToInt32(Price),
                        Duration = Convert.ToInt32(Duration),
                        Created = Convert.ToDateTime(Date),
                        IsFeatured = Issfeatured,
                        SubjectId = Convert.ToInt32(Subjectid)


                    });
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //Course Deletion

        public void DeleteCourse()
        {
            try
            {
                var temp = new CourseDal().GetCourses();
                if (temp != null)
                {
                    Console.WriteLine("Enter Id To Delete Course");
                    var id = Console.ReadLine();
                    new CourseHandler().CourseDeletion(Convert.ToInt32(id));
                }
                else
                {
                    Console.WriteLine("Courses Not Found....");
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
                new CourseHandler().GetCourses();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //GetCourses By Id

        public void GetCoursesByCourseId()
        {
            try
            {
                Console.WriteLine("Enter Course Id");
                var Cid = Console.ReadLine();
                new CourseHandler().GetCoursByCourseId(Convert.ToInt32(Cid));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //GetCourses By SubjectId

        public void GetCourseBySubjectId()
        {
            try
            {
                Console.WriteLine("Enter Subject Id");
                var Sid = Console.ReadLine();
                new CourseHandler().GetCoursesBySubjectId(Convert.ToInt32(Sid));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //IssFeatured Courses

            public void IssfeaturedCourses()
        {
            try
            {
                new CourseHandler().DisplayIssfeaturedCourses();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //GetCourses By Price

            public void GetCourseByPrice()
        {
            try
            {

                new CourseHandler().DisplaCoursesByPrice();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //------------------------------------------------------------------------------------
        //-------------------------------------Topic Section----------------------------------
        //------------------------------------------------------------------------------------


        //Topic Insertion

        public void TopicInsertion()
        {
            try
            {

                var temp = new CourseDal().GetCourses();
                if (temp != null)
                {
                    Console.WriteLine("Choose Course By CourseId");
                    var Cid = Console.ReadLine();
                    Console.WriteLine("Enter Topic Id");
                    var Tid = Console.ReadLine();
                    Console.WriteLine("Enter Topic Name");
                    var Name = Console.ReadLine();
                    var Date = DateTime.Now;
                    new TopicHandler().TopicInsertion(new Topics()
                    {
                        TopicId = Convert.ToInt32(Tid),
                        TopicName = Convert.ToString(Name),
                        TopicCreated = Convert.ToDateTime(Date),
                        CourseId = Convert.ToInt32(Cid)
                    });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }


        //Topic Deletion

        public void TopicDeletion()
        {
            try
            {
                var temp = new TopicDal().GetTopics();
                if (temp != null)
                {
                    Console.WriteLine("Enter topic Id To Delete");
                    var Tid = Console.ReadLine();
                    new TopicHandler().TopicDeletion(Convert.ToInt32(Tid));
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        //Topic Updation...
        public void TopicUpdation()
        {
            try
            {
                var temp = new TopicDal().GetTopics();
                if (temp != null)
                {
                    Console.WriteLine("Enter Topic Id");
                    var Tid = Console.ReadLine();
                    Console.WriteLine("Enter Topic Name");
                    var Name = Console.ReadLine();
                    var Date = DateTime.Now;
                    new TopicHandler().TopicInsertion(new Topics()
                    {
                        TopicId = Convert.ToInt32(Tid),
                        TopicName = Convert.ToString(Name),
                        TopicCreated = Convert.ToDateTime(Date)
                    });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
            

        }

        //Get Topics
        public void GetTopics()
        {
            try
            {
                new TopicHandler().GetTopics();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Get Topic By Topic Id

        public void GetTopicbyTopicId()
        {
            try
            {
                Console.WriteLine("Enter Topic Id");
                var Tid = Console.ReadLine();
                new TopicHandler().GetTopicByTopicId(Convert.ToInt32(Tid));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        //Get Topic By CourseId

        public void GetTopicbyCourseId()
        {
            try
            {
                Console.WriteLine("Enter Course Id");
                var Cid = Console.ReadLine();
                new TopicHandler().GetTopicByCourseId(Convert.ToInt32(Cid));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //Count Topics

        public void CountTopics()
        {
            try
            {
                new TopicHandler().CountTopics();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //GetTopicById

        public void GetTopicById()
        {
            try
            {
                Console.WriteLine("Enter Topic Id");
                var id = Console.ReadLine();
                new TopicHandler().GetTopicById(Convert.ToInt32(id));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //GetTopicBy Name
        public void GetTopicbyName()
        {
            try
            {
                new TopicHandler().GetTopicByName();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

