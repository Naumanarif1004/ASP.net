using Ado.Net;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
   public class TopicLinq
    {
      
        //Count The Number Of Topics In DB
        public void CountTopic()
        {

            try
            {
                var Count = from t in new TopicDal().GetTopics()
                            where t.TopicId > 0
                            group t by t.TopicName into ts
                            orderby ts.Count(), ts.Key
                            select new
                            {
                                Name = ts.Key,
                                Count = ts.Count()
                            };
                foreach (var count in Count)
                {
                    Console.WriteLine($"{count.Name}    :   {count.Count}");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Return topic By Id

        public void ReturnTopicById(int id)
        {
            try
            {
                var Return = from t in new TopicDal().GetTopics()
                             where t.TopicId == id
                             group t by t.TopicName into ts
                             orderby ts.Key
                             select new
                             {
                                 Name = ts.Key
                             };

                foreach (var returrn in Return)
                {
                    Console.WriteLine($"{returrn.Name} ");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Return Topic Name Array

        public void TopicArray()
        {
            try
            {
                var Array = from t in new TopicDal().GetTopics()
                            where t.TopicName == "Array"
                            group t by t.TopicId into ts
                            orderby ts.Key
                            select new
                            {
                                Id = ts.Key
                            };
                foreach (var array in Array)
                {
                    Console.WriteLine($"{array.Id} ");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}
