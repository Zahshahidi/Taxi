using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephone_taxi.Services;

namespace Telephone_taxi.Models
{
    public class Driver: BaseModel
    {
        public Driver()
        {
           Trips =  new List<Trip>();
           Passengers =  new List<Passenger>();
        }

        public string Name { get; set; }
        public string Code { get; set; }
        public string CarNumber { get; set; }
        public List<Trip> Trips { get; set; }
        public List<Passenger> Passengers { get; set; }
    }
}
