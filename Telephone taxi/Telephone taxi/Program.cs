using System.Runtime.CompilerServices;
using Telephone_taxi.Models;
using Telephone_taxi.Repositories;
using Telephone_taxi.Services;

namespace Telephone_taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver();
            Trip trip = new Trip();

            TelephonTaxiService telephonTaxiService = new TelephonTaxiService();
            TelephoneTaxi telephonetaxi = telephonTaxiService.MakeTaxiOffice();

            telephonTaxiService.AddPassenger(telephonetaxi);
            Console.WriteLine("enter passenge code");
            var passengeCode = Console.ReadLine();

            telephonTaxiService.AddDriver(telephonetaxi);
            Console.WriteLine("enter driver code");
            var driverCode = Console.ReadLine();

            PassengerService passengerservice = new PassengerService();

            ManagerService managerservice = new ManagerService();

            telephonetaxi = passengerservice.TripRequest(telephonetaxi, passengeCode);

            Console.WriteLine("enter trip id");
            var tripId = Console.ReadLine();

            telephonetaxi = managerservice.AddPassengerToDriver(telephonetaxi,passengeCode,driverCode,tripId);

            DriverService driverService1=new DriverService();

            Console.WriteLine("1.accept    2.reject    3.finished");
            var tripStatus = Console.ReadLine();

            switch (tripStatus)
            {
                case "1":
                    telephonetaxi = driverService1.AcceptTrip(telephonetaxi, tripId, driverCode);
                    break;
                case "2":
                    telephonetaxi = driverService1.RejectTrip(telephonetaxi, tripId, driverCode);
                    break;
                case "3":
                    telephonetaxi = driverService1.FinishedTrip(telephonetaxi, tripId, driverCode);
                    break;
            }

            telephonetaxi.ShowDetails();

            passengerservice.GetListOfAllTrips(telephonetaxi.Passengers[0]);

            string Taxicode = new TaxiTelephoniRepository().SaveInfo(telephonetaxi);
            TelephoneTaxi Taxi = new TaxiTelephoniRepository().GetTaxiInfo();

            Console.ReadKey();
        }
    }
}
