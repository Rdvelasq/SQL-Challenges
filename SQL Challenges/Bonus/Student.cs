using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenges.Bonus
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MyProperty { get; set; }
        public List<Course> Courses { get; set; }
        public Professor Professor { get; set; }
    }
}
