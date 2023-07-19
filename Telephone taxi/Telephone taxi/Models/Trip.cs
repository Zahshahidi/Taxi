using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone_taxi.Models
{
    public class Trip
    {
        public string Id { get; set; } 
        public TripStatus Status { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }   
        public string Destination { get; set; }
    }
}
