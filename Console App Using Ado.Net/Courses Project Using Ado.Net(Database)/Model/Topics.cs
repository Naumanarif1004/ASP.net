using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Topics
    {
        public int TopicId { get; set; }
        public string TopicName { get; set; }
        public DateTime TopicCreated { get; set; }
        public int CourseId{ get; set; }
    }
}
