using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data
{
    public class SubjectDAL
    {
        public SubjectDAL()
        {

        }

        

        public List<Subject> GetSubjects()
        {
            string text = "SELECT * FROM Subject";
            SqlCommand scmd = new SqlCommand(text, new ConnectionDal().GetConnection());
            
            return fetchData(scmd);
        }

        public List<Subject> GetSubject(int id)
        {
            string text = "SELECT * FORM Subject WHERE SubjectId=@Id";
            SqlCommand scmd = new SqlCommand(text, new ConnectionDal().GetConnection());
            scmd.Parameters.AddWithValue("@Id", id);
            return fetchData(scmd);
        }



      public List<Subject> fetchData(SqlCommand scmd)
        {
         List<Subject> _Subject=null;
            using (SqlConnection sqlConnection = scmd.Connection)
            {
                var SqlDataReader = scmd.ExecuteReader();
                if(SqlDataReader.HasRows)
                {
                    _Subject = new List<Subject>();
                    while(SqlDataReader.Read())
                    {
                        Subject subject = new Subject();
                        subject.SubjectId = Convert.ToInt32(SqlDataReader["SubjectId"]);
                        subject.Name = Convert.ToString(SqlDataReader["SubjectName"]);
                        subject.Short = Convert.ToString(SqlDataReader["SubjectShort"]);
                        _Subject.Add(subject);
                    }
                    
                }
            }
            return _Subject;
        }

        public void Insert(Subject subject)
        {
            SqlCommand cmd = new SqlCommand("Subject_Insertion", new ConnectionDal().GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SubjectId", subject.SubjectId);
            cmd.Parameters.AddWithValue("@SubjectName", subject.Name);
            cmd.Parameters.AddWithValue("@SubjectShort", subject.Short);
            using (SqlConnection sqlConnection = cmd.Connection)
            {
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void SubjectUpdate(Subject subject)
        {
            SqlCommand cmd = new SqlCommand("Subject_Updation", new ConnectionDal().GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SubjectId", subject.SubjectId);
            cmd.Parameters.AddWithValue("@Name", subject.Name);
            cmd.Parameters.AddWithValue("@Short", subject.Short);
            using (SqlConnection sqlConnection = cmd.Connection)
            {
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void SubjectDel(int id)
        {
            SqlCommand cmd = new SqlCommand("Subject_Updation", new ConnectionDal().GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SubjectId", id);
            using (SqlConnection sqlConnection = cmd.Connection)
            {
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
