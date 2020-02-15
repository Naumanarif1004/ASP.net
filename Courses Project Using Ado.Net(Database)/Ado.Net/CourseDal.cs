using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Ado.Net
{
    public class CourseDal
    {
        public List<Courses> courseList;
        public Courses courses;
        public CourseDal()
        {
            courses = new Courses();
        }

        //Return List Of Courses
        public List<Courses> GetCourses()
        {
            try
            {
                string txt = "SELECT * FROM Course_Table";
                SqlCommand sqlCommand = new SqlCommand(txt, new DalConnection().GetConnection());
                return FeatchData(sqlCommand);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        //Return List OF Courses By SubjectId
        

            public List<Courses> GetCoursesBySubjectId(int SubjectId)
        {
            try
            {
                string txt = "SELECT * Course_Table FROM WHERE SubjectId=@Sid";
                SqlCommand sqlCommand = new SqlCommand(txt, new DalConnection().GetConnection());
                sqlCommand.Parameters.AddWithValue("@Sid", SubjectId);
                return FeatchData(sqlCommand);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Return Course By CourseId

            public Courses GetCourseById(int CourseId)
        {
            string txt = "SELECT * FROM Course_Table WHERE CourseId=@Cid";
            SqlCommand sqlCommand = new SqlCommand(txt, new DalConnection().GetConnection());
            sqlCommand.Parameters.AddWithValue("@Cid", CourseId);
            var temp = FeatchData(sqlCommand);
            return (temp!=null)?temp[0] : null;
        }



        //Featch Course Data From Database 
        private List<Courses> FeatchData(SqlCommand sqlCommand)
        {
            try
            {
                courseList = null;
                using (var sqlConnection = sqlCommand.Connection)
                {
                    sqlConnection.Open();
                    var DataReader = sqlCommand.ExecuteReader();
                    if (DataReader.HasRows)
                    {
                        int count = 0;
                        while (DataReader.Read())
                        {
                            courses.CourseId = Convert.ToInt32(DataReader["CourseId"]);
                            courses.Title = Convert.ToString(DataReader["CourseName"]);
                            courses.Price = Convert.ToInt32(DataReader["CoursePrice"]);
                            courses.Duration = Convert.ToInt32(DataReader["CourseDuration"]);
                            courses.IsFeatured = Convert.ToBoolean(DataReader["IssFeatured"]);
                            courses.Created = Convert.ToDateTime(DataReader["CourseCreated"]);
                            courses.SubjectId = Convert.ToInt32(DataReader["SubjectId"]);
                            count++;



                            Console.WriteLine("\n\n\t\t\t\t\t\t\t\t---------Course[" + count + "] Detail------");
                            Console.WriteLine("\nCourse Id : " + Convert.ToInt32(DataReader["CourseId"]) + " -------Course Name : " + Convert.ToString(DataReader["CourseName"]) + " ------Course Price : " + Convert.ToInt32(DataReader["CoursePrice"]) + "" +
                                " -----Course Duration : " + Convert.ToInt32(DataReader["CourseDuration"]) + "  ------- Course Created Date : " + Convert.ToDateTime(DataReader["CourseCreated"]) + "IssFeatured : " + Convert.ToBoolean(DataReader["IssFeatured"]) + " ------Subject Id : " + Convert.ToInt32(DataReader["SubjectId"]));


                            courseList.Add(courses);
                        }
                    }
                }
                return courseList;
            }
            catch (Exception  ex)
            {

                throw ex;
            }
        }


        //Course Insertion
        public void CourseInsertion(Courses courses)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Course_Insertion", new DalConnection().GetConnection());
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@CourseId", courses.CourseId);
                sqlCommand.Parameters.AddWithValue("@CourseCreated", courses.Created);
                sqlCommand.Parameters.AddWithValue("@CourseName", courses.Title);
                sqlCommand.Parameters.AddWithValue("@CoursePrice", courses.Price);
                sqlCommand.Parameters.AddWithValue("@CourseDuration", courses.Duration);
                sqlCommand.Parameters.AddWithValue("@Issfeatured", courses.IsFeatured);
                sqlCommand.Parameters.AddWithValue("@SubjectId", courses.SubjectId);
                using (var sqlConnection = sqlCommand.Connection)
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    Console.WriteLine("Course Insertd Sucessfullllly");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Course deletion
        public void CourseDeletion(int id)
        {
            try
            {

                SqlCommand sqlCommand = new SqlCommand("Course_Deletion", new DalConnection().GetConnection());
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@CourseId", id);
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
