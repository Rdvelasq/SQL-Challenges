using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenges.Challenge_3
{
    public class Listing
    {
        public int ListingID { get; set; }
        public DateTime DateListed { get; set; }
        public bool IsRental { get; set; }
        public int HouseID { get; set; }
        public House House { get; set; }
    }
}
