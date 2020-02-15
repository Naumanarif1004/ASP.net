using Ado.Net;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Handler
{
    public class SubjectHandler
    {
        Subjects subjects;
        SubjectDal subjectDal;


        //Constructor
        public SubjectHandler()
        {
            subjects = new Subjects();
            subjectDal = new SubjectDal();
        }

        //Subject Insertion

        public void Insertion(Subjects subjects)
        {
            try
            {
                if (subjects != null)
                {
                    subjectDal.SubjectInsertion(subjects);
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

        public void GetSubjects()
        {
            try
            {
                var temp = subjectDal.GetSubjects();
                if (temp == null)
                {
                    Console.WriteLine("Subject Data Not Fund...");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void GetSubjectById(int id)
        {
            try
            {

                if (id > 0)
                {
                    var temp = subjectDal.GetSubjectsById(id);
                    if (temp == null)
                    {
                        Console.WriteLine("Search Subject Not Found...");
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
    }
}
