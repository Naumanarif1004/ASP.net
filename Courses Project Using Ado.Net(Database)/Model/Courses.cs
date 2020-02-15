using System;

namespace Model
{
    public class Courses
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public bool IsFeatured { get; set; }
        public DateTime Created { get; set; }
        public int Duration { get; set; }
        public int SubjectId { get; set; }
        //public Subject Subject { get; set; }
    }
}
