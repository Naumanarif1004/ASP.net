using Model;
using System;

namespace Events
{
    public class CoursetEvents: EventArgs
    {
        public Courses courses { get; set; }

    }
}
