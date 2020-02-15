using Ado.Net;
using LINQ;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Handler
{

    
   public class TopicHandler
    {
        Topics topics;
        TopicDal topicDal;


        //Constructor
        public TopicHandler()
        {
            topics = new Topics();
            topicDal = new TopicDal();
        }


        //Topic Insertion
        public void TopicInsertion(Topics topics)
        {
            try
            {
                if (topics != null)
                {
                    topicDal.TopicInsertion(topics);
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


        //Topic Deletion

        public void TopicDeletion(int id)
        {
            try
            {

                if (id > 0)
                {
                    topicDal.TopicDeletion(id);
                }
                else
                {
                    Console.WriteLine("Negative Data Found..");
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        //Topic Updation

        public void TopicUpdation(Topics topics)
        {
            try
            {
                if (topics != null)
                {
                    topicDal.UpdateTopic(topics);
                }
                else
                {
                    Console.WriteLine("Null data Found...");
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
                var temp = topicDal.GetTopics();
                if (temp == null)
                {
                    Console.WriteLine("Topic Data Not Found...");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //Get Topic By TopicId

        public void GetTopicByTopicId(int id)
        {
            try
            {
                if (id > 0)
                {
                    var temp = topicDal.GetTopicsByTopicId(id);
                    if (temp == null)
                    {
                        Console.WriteLine("Searching Topic Not Found...");
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


        //Get Topic By CourseId

        public void GetTopicByCourseId(int id)
        {
            try
            {
                if (id > 0)
                {
                    var temp = topicDal.GetTopicsByCourseId(id);
                    if (temp == null)
                    {
                        Console.WriteLine("Searching Topics Not Found....");
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




        //---------------------------------------------------------------------------------------
        //-------------------------------------LINQ SECTION--------------------------------------
        //---------------------------------------------------------------------------------------



            //Count Number Of Topic In DB
        public void CountTopics()
        {
            try
            {
                new TopicLinq().CountTopic();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Get Topic By Topic Id

        public void GetTopicById(int id)
        {
            try
            {
                if (id > 0)
                {
                    new TopicLinq().ReturnTopicById(id);
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

        //Get Topic By Name

        public void GetTopicByName()
        {
            try
            {
                new TopicLinq().TopicArray();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
