using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephone_taxi.Models;

namespace Telephone_taxi.Services
{
    public class DriverService
    {
        public TelephoneTaxi AcceptTrip(TelephoneTaxi telephoneTaxi, string tripId, string driverCode)
        {
            
            foreach (var driver in telephoneTaxi.Drivers)
            {
                if(driver.Code == driverCode)
                {
                    foreach(var trip in driver.Trips)
                    {
                        if (trip.Id == tripId)
                            trip.Status = TripStatus.Accepted;
                    }    
                }
            }
            return telephoneTaxi;
        }

        public TelephoneTaxi RejectTrip(TelephoneTaxi telephoneTaxi, string tripId, string driverCode)
        {
            foreach (var driver in telephoneTaxi.Drivers)
            {
                if (driver.Code == driverCode)
                {
                    foreach (var trip in driver.Trips)
                    {
                        if (trip.Id == tripId)
                            trip.Status = TripStatus.Rejected;
                    }
                }
            }
            return telephoneTaxi;
        }

        public TelephoneTaxi FinishedTrip(TelephoneTaxi telephoneTaxi, string tripId, string driverCode)
        {
            foreach (var driver in telephoneTaxi.Drivers)
            {
                if (driver.Code == driverCode)
                {
                    foreach (var trip in driver.Trips)
                    {
                        if (trip.Id == tripId)
                            trip.Status = TripStatus.Finished;
                    }
                }
            }
            return telephoneTaxi;
        }
    }
}
