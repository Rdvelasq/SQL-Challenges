using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenges.Bonus
{
    public class Course
    {
        [KEY]
        public int CourseID { get; set; }
        public string Name { get; set; }
        public string CourseCode { get; set; }
    }
}
