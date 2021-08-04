using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenges.Challenge_2
{
    public class Vehicle
    {
        [KEY]
        public int VehicleID { get; set; }
        public string LicensePalte { get; set; }
        public string VIN { get; set; }
        public decimal Miles { get; set; }
    }
}
