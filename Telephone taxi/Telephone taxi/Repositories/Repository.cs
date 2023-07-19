using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Telephone_taxi.Models;

namespace Telephone_taxi.Repositories
{
    public class TaxiTelephoniRepository
    {
        public string SaveInfo(TelephoneTaxi telephonetaxi)
        {
            string jsonTaxi=JsonSerializer.Serialize(telephonetaxi);
            System.IO.File.WriteAllText(@"D:\Temp2\Taxi.txt", jsonTaxi);
            return jsonTaxi;    
        }

        public TelephoneTaxi GetTaxiInfo()
        {
            string jsonTaxi = File.ReadAllText(@"D:\Temp2\Taxi.txt");
            TelephoneTaxi telephonetaxi=JsonSerializer.Deserialize<TelephoneTaxi>(jsonTaxi);
            return telephonetaxi;
        }
    }
}
