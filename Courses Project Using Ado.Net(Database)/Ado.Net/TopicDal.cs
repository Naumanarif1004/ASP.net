using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Ado.Net
{
   public  class TopicDal
    {
        public List<Topics> topicsList;
        public Topics topics;
        public TopicDal()
        {
            topics = new Topics(); 
        }



        //Get Topics
        public List<Topics> GetTopics()
        {
            try
            {

                string txt = "SELECT * FROM Topic_Table";
                SqlCommand sqlCommand = new SqlCommand(txt, new DalConnection().GetConnection());
                return FeatchData(sqlCommand);
            }
            catch (Exception ex)
            {

                throw ex;
            }
          
        }

     //Get Topics By CourseId
     public List<Topics> GetTopicsByCourseId(int Courseid)
        {
            try
            {
                string txt = "SELECT * FROM Topic_Table WHERE CourseId=@CourseId";
                SqlCommand sqlCommand = new SqlCommand(txt, new DalConnection().GetConnection());
                sqlCommand.Parameters.AddWithValue("@CourseId", Courseid);
                return FeatchData(sqlCommand);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Get Topic By TopicId

public Topics GetTopicsByTopicId(int TopicId)
        {
            try
            {
                string txt = "SELECT * FROM Topic_Table WHERE TopicId=@TopicId";
                SqlCommand sqlCommand = new SqlCommand(txt, new DalConnection().GetConnection());
                sqlCommand.Parameters.AddWithValue("@TopicId", TopicId);
                var temp = FeatchData(sqlCommand);
                return (temp != null) ? temp[0] : null;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private List<Topics> FeatchData(SqlCommand sqlCommand)
        {
            try
            {
                using (var Connection = sqlCommand.Connection)
                {
                    Connection.Open();
                    var DataReader = sqlCommand.ExecuteReader();
                    if (DataReader.HasRows)
                    {
                        topicsList = new List<Topics>();
                        int count = 0;
                        while (DataReader.Read())
                        {
                            topics.TopicId = Convert.ToInt32(DataReader["TopicId"]);
                            topics.TopicName = Convert.ToString(DataReader["TopicName"]);
                            topics.TopicCreated = Convert.ToDateTime(DataReader["TopicCreated"]);
                            topics.CourseId = Convert.ToInt32(DataReader["CourseId"]);
                            topicsList.Add(topics);
                            Console.WriteLine("\n\n\t\t\t\t\t\t\t\t---------Topic[" + count + "] Detail------");
                            Console.WriteLine("Topic Id : " + Convert.ToInt32(DataReader["TopicId"]) + "------Topic Name  : " + Convert.ToString(DataReader["TopicName"]) + "" +
                                "Topic Created Date  : " + Convert.ToDateTime(DataReader["TopicCreated"]) + "------Course Id : " + Convert.ToInt32(DataReader["CourseId"]));
                            count++;
                        }

                    }
                }
                return topicsList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }


        //Topic Insertion
        public void TopicInsertion(Topics topics)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Topic_Insertion", new DalConnection().GetConnection());
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@TopicId", topics.TopicId);
                sqlCommand.Parameters.AddWithValue("@TopicName", topics.TopicName);
                sqlCommand.Parameters.AddWithValue("@TopicCreated", topics.TopicCreated);
                sqlCommand.Parameters.AddWithValue("@CourseId", topics.CourseId);
                using (var sqlConnection = sqlCommand.Connection)
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }


        public void TopicDeletion(int id)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Topic_Deletion", new DalConnection().GetConnection());
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@TopicId", id);
                using (var sqlConnection = sqlCommand.Connection)
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    Console.WriteLine("Topic Deleted..........");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void UpdateTopic(Topics topics)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Topic_Updation", new DalConnection().GetConnection());
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@TopicId", topics.TopicId);
                sqlCommand.Parameters.AddWithValue("@TopicName", topics.TopicName);
                sqlCommand.Parameters.AddWithValue("@TopicCreated", topics.TopicCreated);
                sqlCommand.Parameters.AddWithValue("@CourseId", topics.CourseId);
                using (var SqlConnection = sqlCommand.Connection)
                {
                    SqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        
        
       
}
