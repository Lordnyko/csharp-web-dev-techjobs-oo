using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    abstract class JobField : Job
    {
        public int Id { get; }
        public static int nextId = 1;
        public string Value { get; set; }

    }
}
