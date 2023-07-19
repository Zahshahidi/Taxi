using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephone_taxi.Models;

namespace Telephone_taxi.Services
{
    public class PassengerService
    {
        public TelephoneTaxi TripRequest(TelephoneTaxi telephoneTaxi, string passegerCode)
        {
            Trip trip = new Trip();

            trip.Id = Guid.NewGuid().ToString();

            Console.WriteLine("Please enter Start Time: ");
            trip.StartTime = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Please enter End Time: ");
            trip.EndTime = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Please enter Trip Destination: ");
            trip.Destination = Console.ReadLine();

            Console.WriteLine("The Id of trip is: " + trip.Id);

            foreach (var passenger in telephoneTaxi.Passengers)
            {
                if (passenger.Code == passegerCode)
                {
                    passenger.Trips.Add(trip);
                }
            }
            return telephoneTaxi;
        }

        public void GetListOfAllTrips(Passenger passenger)
        {
            foreach (Trip trip in passenger.Trips)
            {
                Console.WriteLine("Trip ID: " + trip.Id);
                Console.WriteLine("Start Time: " + trip.StartTime);
                Console.WriteLine("End Time: " + trip.EndTime);
                Console.WriteLine("Destination: " + trip.Destination);
                Console.WriteLine("------------------------");
            }
        }
    }
}

