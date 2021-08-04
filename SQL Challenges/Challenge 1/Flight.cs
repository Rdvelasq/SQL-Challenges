using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenges
{
    public class Flight
    {
        [KEY]
        public int FlightID { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime EstimatedArrivalTime { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public int Capacity { get; set; }
        public int MyProperty { get; set; }
        public string AirlineName { get; set; }

    }

    internal class KEYAttribute : Attribute
    {
    }
}
