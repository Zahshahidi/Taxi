using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephone_taxi.Services;

namespace Telephone_taxi.Models
{
    public class Passenger : BaseModel
    {
        public Passenger()
        {
            Trips = new List<Trip>();
        }

        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string Destination { get; set; }
        public List<Trip> Trips { get; set; }
    }
}




