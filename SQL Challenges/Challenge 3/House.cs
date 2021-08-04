using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenges.Challenge_3
{
    public class House
    {
        [KEY]
        public int HouseID { get; set; }
        public short NumberOfBedrooms { get; set; }
        public short NumberOfBaths { get; set; }
        public short EstimatedValue { get; set; }

    }
}
