using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Telephone_taxi.Models
{
    public class TelephoneTaxi : BaseModel
    {
        public TelephoneTaxi()
        {
            Drivers=new List<Driver>();
            Passengers=new List<Passenger>();
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public Manager Manager { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Passenger> Passengers { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("*********** TelephonTaxi Mahtab ************");
            Console.WriteLine("Welcome To Mahtab, Register Trip Request: ");
            foreach(Passenger passenger in this.Passengers)
            {
                Console.WriteLine("The Name of Passenger is: " +passenger.Name);
            }

            foreach (Driver driver in this.Drivers)
            {
                Console.WriteLine("The Number of Car is: " +driver.CarNumber);

                foreach (Trip trip in driver.Trips)
                {
                    Console.WriteLine("The trip destination of CarNumber " + driver.CarNumber + " is " + trip.Destination + " and it is " + trip.Status );
                }
            }
            /*Console.WriteLine("*********** PassengerInfo ************");
            foreach (Passenger passenger in this.Passengers)
            {
                Console.WriteLine("List Of  Trips Of " + passenger.Name + " is : ");
                foreach (Trip trip in passenger.Trips)
                {
                    Console.WriteLine("Trip ID: " + trip.Id);
                    Console.WriteLine("Start Time: " + trip.StartTime);
                    Console.WriteLine("End Time: " + trip.EndTime);
                    Console.WriteLine("Destination: " + trip.Destination);
                    Console.WriteLine("------------------------");
                }
            }*/
        }
    }
}
