using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowClient
{
    class StudentData
    {
        public int student_id { get; set; }
        public string student_name { get; set; }
        public Nullable<int> course_id { get; set; }
        public string address { get; set; }

        public virtual CourseData course { get; set; }
    }
}
