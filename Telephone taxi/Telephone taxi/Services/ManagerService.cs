using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephone_taxi.Models;

namespace Telephone_taxi.Services
{
    public class ManagerService
    {
        public TelephoneTaxi AddPassengerToDriver(TelephoneTaxi telephoneTaxi,string passgengerCode, string driverCode, string tripId)
        {

            foreach (var driver in telephoneTaxi.Drivers)
            {
               if(driver.Code == driverCode)
               {
                    var passenger = telephoneTaxi.Passengers.Find(x => x.Code == passgengerCode);
                    var trip = passenger.Trips.Find(x => x.Id == tripId);
                    driver.Trips.Add(trip);
               }
            }

            return telephoneTaxi;
        }
    }
}
//Passenger passenger = new Passenger();

//Console.WriteLine("Plz Enter Passenger Name: ");
//passenger.Name = Console.ReadLine();

//Console.WriteLine("Plz Enter Passenger Address: ");
//passenger.Address = Console.ReadLine();

//Console.WriteLine("Plz Enter Passenger Destination: ");
//passenger.Destination = Console.ReadLine();

//telephoneTaxi.Passengers.Add(passenger);

//Driver driver = new Driver();

//Console.WriteLine("Plz Enter Driver Name: ");
//driver.Name = Console.ReadLine();

//driver.Code = Guid.NewGuid().ToString();

//Console.WriteLine("Plz Enter Car Number: ");
//driver.CarNumber = Console.ReadLine();

//Trip trip = new Trip();

//trip.Id = Guid.NewGuid().ToString();

//Console.WriteLine("Please enter Start Time: ");
//trip.StartTime = Convert.ToDateTime(Console.ReadLine());

//Console.WriteLine("Please enter End Time: ");
//trip.EndTime = Convert.ToDateTime(Console.ReadLine());

//Console.WriteLine("Please enter Trip Destination: ");
//trip.Destination = Console.ReadLine();

//driver.Trips.Add(trip);

//telephoneTaxi.Drivers.Add(driver);

//return telephoneTaxi;