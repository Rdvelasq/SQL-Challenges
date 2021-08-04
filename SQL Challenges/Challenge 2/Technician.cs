using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenges.Challenge_2
{
    public class Technician
    {
        [KEY]
        public int TechnicianID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal CustomerRating { get; set; }
        [ForeignKey(nameof(Vehicle))]
        public int VehicleID { get; set; }      
        public virtual Vehicle Vehicle { get; set; }
    }
}
