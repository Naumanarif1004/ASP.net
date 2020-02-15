using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Data
{
    public class CourseDAl
    {
        public CourseDAl()
        {

        }

        public IList<Courses> _CourseList;

        public IList<Courses> GetCourses()
        {
            string text = "SELECT * FROM Course";
            SqlCommand cmd = new SqlCommand(text, new ConnectionDal().GetConnection());
            return fetchData(cmd);
        }

        public IList<Courses> GetCourse(int id)
        {
            string text = "SELECT * FROM Course WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(text, new ConnectionDal().GetConnection());
            cmd.Parameters.AddWithValue("@id", id);
            return fetchData(cmd);
        }


        //Read data from database......................
        private IList<Courses> fetchData(SqlCommand cmd)
        {
            _CourseList = null;
            using (SqlConnection sqlConnection = cmd.Connection)
            {

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                var SqlDataReader = cmd.ExecuteReader();
                if (SqlDataReader.HasRows)
                {
                    _CourseList = new List<Courses>();
                    while (SqlDataReader.Read())
                    {
                        Courses c = new Courses();
                        c.CourseId = Convert.ToInt32(SqlDataReader["CourseId"]);
                        c.Title = Convert.ToString(SqlDataReader["CourseTitle"]);
                        c.Price = Convert.ToInt32(SqlDataReader["CoursePrice"]);
                        _CourseList.Add(c);
                    }
                }
            }

            return _CourseList;
        }

        public void Insertion(Courses C)

        {
            SqlCommand cmd = new SqlCommand("Insertion_Course", new ConnectionDal().GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CourseId", C.CourseId);
            cmd.Parameters.AddWithValue("@CourseTitle", C.Title);
            cmd.Parameters.AddWithValue("@CourseCreatedDate", C.Created);
            cmd.Parameters.AddWithValue("@CourseDuration", C.Duration);
            cmd.Parameters.AddWithValue("@CoursePrice", C.Price);
            cmd.Parameters.AddWithValue("@SubjectId", new Subject().SubjectId);
            using (SqlConnection connection = cmd.Connection)
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Courses C)
        {
            SqlCommand cmd = new SqlCommand("Update", new ConnectionDal().GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CourseId", C.CourseId);
            cmd.Parameters.AddWithValue("@CourseTitle", C.Title);
            cmd.Parameters.AddWithValue("@CourseCreatedDate", C.Created);
            cmd.Parameters.AddWithValue("@CourseDuration", C.Duration);
            cmd.Parameters.AddWithValue("@CoursePrice", C.Price);
            cmd.Parameters.AddWithValue("@SubjectId", new Subject().SubjectId);
            using (SqlConnection connection = cmd.Connection)
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("Deletion", new ConnectionDal().GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CourseId", id);
            using (SqlConnection connection = cmd.Connection)
            {
                cmd.ExecuteNonQuery();
            }
        }
    }

}
