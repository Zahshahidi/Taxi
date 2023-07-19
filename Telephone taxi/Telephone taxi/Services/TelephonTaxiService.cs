using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephone_taxi.Models;

namespace Telephone_taxi.Services
{
    public class TelephonTaxiService
    {
        public TelephoneTaxi AddPassenger(TelephoneTaxi telephoneTaxi)
        {
            Passenger passenger = new Passenger();

            Console.WriteLine("Please enter Passenger Name: ");
            passenger.Name = Console.ReadLine();

            Console.WriteLine("Please enter Passenger Address: ");
            passenger.Address = Console.ReadLine();

            passenger.Code=Guid.NewGuid().ToString();

            Console.WriteLine("Please enter Passenger Destination: ");
            passenger.Destination = Console.ReadLine();

            Console.WriteLine("The code of Passenger is: " + passenger.Code);

            telephoneTaxi.Passengers.Add(passenger);
            return telephoneTaxi;
        }
        public TelephoneTaxi AddDriver(TelephoneTaxi telephoneTaxi)
        {
            Driver driver = new Driver();

            Console.WriteLine("Please enter Driver Name: ");
            driver.Name = Console.ReadLine();

            driver.Code = Guid.NewGuid().ToString();

            Console.WriteLine("Please enter Car Number: ");
            driver.CarNumber = Console.ReadLine();

            Console.WriteLine("The code of driver is: " + driver.Code);

            telephoneTaxi.Drivers.Add(driver);
            return telephoneTaxi;
        }
        public TelephoneTaxi MakeTaxiOffice()
        {
            TelephoneTaxi telephoneTaxi = new TelephoneTaxi();
            return telephoneTaxi;
        }



        
        
    }
}
