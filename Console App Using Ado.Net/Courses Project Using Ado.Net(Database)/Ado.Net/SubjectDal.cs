using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Ado.Net
{
    public class SubjectDal
    {
        public List<Subjects> subjectsList;
        Subjects subjects;
        public SubjectDal()
        {
            subjects = new Subjects();
        }

        public List<Subjects> GetSubjects()
        {
            try
            {
                string txt = "SELECT *  FROM Subject_Table";
                SqlCommand sqlCommand = new SqlCommand(txt, new DalConnection().GetConnection());
                return Featchdata(sqlCommand);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public Subjects GetSubjectsById(int id)
        {
            try
            {
                string txt = "SELECT * FROM Subject_Table WHERE SubjectId=@Subjectid";
                SqlCommand sqlCommand = new SqlCommand(txt, new DalConnection().GetConnection());
                sqlCommand.Parameters.AddWithValue("@Subjectid", id);
                var temp = Featchdata(sqlCommand);
                return (temp != null) ? temp[0] : null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private List<Subjects> Featchdata(SqlCommand sqlCommand)
        {
            try
            {
                subjectsList = null;
                using (var sqlConnection = sqlCommand.Connection)
                {
                    var DataReader = sqlCommand.ExecuteReader();
                    if (DataReader.HasRows)
                    {
                        subjectsList = new List<Subjects>();
                        int count = 0;
                        while (DataReader.Read())
                        {
                            subjects.SubjectId = Convert.ToInt32(DataReader["SubjectId"]);
                            subjects.SubjectName = Convert.ToString(DataReader["SubjectName"]);
                            subjects.SubjectCreated = Convert.ToDateTime(DataReader["SubjectCreated"]);
                            subjectsList.Add(subjects);
                            Console.WriteLine("\n\n\t\t\t\t\t\t\t\t---------Course[" + count + "] Detail------");
                            Console.WriteLine("Subject Id : " + Convert.ToInt32(DataReader["SubjectId"]) + "------Subject Name  : " + Convert.ToString(DataReader["SubjectName"]) + "" +
                                "------Subject Created  : " + Convert.ToDateTime(DataReader["SubjectCreated"]));
                            count++;
                        }
                    }
                }
                return subjectsList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void SubjectInsertion(Subjects subjects)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Subject_Insertion", new DalConnection().GetConnection());
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@SubjectId", subjects.SubjectId);
                sqlCommand.Parameters.AddWithValue("@SubjectName", subjects.SubjectName);
                sqlCommand.Parameters.AddWithValue("@SubjectCreated", subjects.SubjectCreated);
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

    }
}
