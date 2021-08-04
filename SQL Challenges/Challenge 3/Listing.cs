using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenges.Challenge_3
{
    public class Listing
    {
        [KEY]
        public int ListingID { get; set; }
        public DateTime DateListed { get; set; }
        public bool IsRental { get; set; }
        [ForeignKey (nameof(House))]
        public int HouseID { get; set; }
        public House House { get; set; }
    }
}
