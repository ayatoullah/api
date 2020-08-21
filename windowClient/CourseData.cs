using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowClient
{
    class CourseData
    {


        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> duration { get; set; }
        public string description { get; set; }

        public virtual ICollection<StudentData> students { get; set; }
    }
}
