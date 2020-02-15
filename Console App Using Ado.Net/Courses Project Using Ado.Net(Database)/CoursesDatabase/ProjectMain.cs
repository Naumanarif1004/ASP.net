using Handler;
using ProjectHandler;
using Services;
using System;

namespace CoursesDatabase
{
    class ProjectMain
    {
        static void Main(string[] args)
        {
            int choice=0;
            string ch = null;
            bool chk = true;
            do
            {
                try
                {
                    Console.WriteLine("\n1.insertion Subject");
                    Console.WriteLine("2.Display Subject List");
                    Console.WriteLine("3.Display SubjectById");
                    Console.WriteLine("4.Insertion Course");
                    Console.WriteLine("5.diaply Course List");
                    Console.WriteLine("6.Course Deletion");
                    Console.WriteLine("7.diaply Course By Id");
                    Console.WriteLine("8.Display Courses By SubjecId");
                    Console.WriteLine("9.Display Courses Whoes Price>5000");
                    Console.WriteLine("10.IssFeatured Courses");
                    Console.WriteLine("11.Topic Insertion");
                    Console.WriteLine("12.Display Topic List");
                    Console.WriteLine("13.Delete Topic");
                    Console.WriteLine("14.Update Topic");
                    Console.WriteLine("15.Display Topic By TopicId");
                    Console.WriteLine("16.Display Topics By CourseId");
                    Console.WriteLine("17.Display Topic By Id(LINQ METHOD)");
                    Console.WriteLine("18.Count Topics");
                    Console.WriteLine("19.Get Topic By (Array) Name");
                    Console.WriteLine("\n\nSeclect your choice");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (choice)
                    {
                        case 1:
                            try
                            {
                                new Projecthandler().InsertSubject();
                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                                Console.WriteLine(ex.StackTrace);
                            }
                            break;
                        case 2:
                            try
                            {
                                new Projecthandler().DisplaySubject();
                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                                Console.WriteLine(ex.StackTrace);
                            }
                            break;
                        case 3:
                            try
                            {
                                new Projecthandler().DisplaySubjectById();
                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                                Console.WriteLine(ex.StackTrace);
                            }
                            break;
                        case 4:
                            try
                            {
                                new Projecthandler().CourseInsertion();
                                new CourseHandler().eventHandler += new CourseCreationSms().SubjectCreationSMs;
                                new CourseHandler().eventHandler += new CourseCreationEmail().SubjectCreationEmail;
                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                                Console.WriteLine(ex.StackTrace);
                            }
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            break;
                        case 8:
                            break;
                        case 9:
                            break;
                        case 10:
                            break;
                        case 11:
                      
                            break;
                        case 12:
                            break;
                        case 13:
                            break;
                        case 14:
                            break;
                        case 15:
                            break;
                        case 16:
                            break;
                        case 17:
                            break;
                        case 18:
                            break;
                        case 19:
                            break;

                        default:
                            chk = false;
                            break;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
                finally
                {
                    Console.WriteLine("\n\n\t\t\t\t\t\t do you want to continue[y/n]");
                    ch = Console.ReadLine();
                    if (ch == "y" || ch == "Y")
                    {
                        chk = true;
                        Console.Clear();
                    }
                    else
                    {
                        chk = false;
                    }
                } 
            } while (chk);
        }
        }
    }

