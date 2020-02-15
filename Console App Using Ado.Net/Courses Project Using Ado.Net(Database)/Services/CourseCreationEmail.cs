using Events;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class CourseCreationEmail
    {
        public void SubjectCreationEmail(object source , CoursetEvents courseEvents)
        {
            Console.WriteLine("Email :--------------------------");
            Console.WriteLine($"\n\t\t\tCourse Id: {courseEvents.courses.CourseId} -----Course Name :  {courseEvents.courses.Title}  ----- Course Price  :   {courseEvents.courses.Price}   Course Duration  :  {courseEvents.courses.Duration}   -----Created Date  : {courseEvents.courses.Created}");
        }
    }
}
