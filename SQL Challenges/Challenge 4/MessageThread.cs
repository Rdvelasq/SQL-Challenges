using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenges.Challenge_4
{
    public class MessageThread
    {
        [KEY]
        public int MessageThreadID { get; set; }
        public DateTime dateTime { get; set; }
        public DateTime Modified { get; set; }
        public List<User> Users { get; set; }
    }
}
