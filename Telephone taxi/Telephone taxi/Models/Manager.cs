using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone_taxi.Models
{
    public class Manager: BaseModel
    {
        public string FirstName { get; set; }    
        public string LastName { get; set; }    
        public string WorkExperience { get; set; }    
        public DateTime Age { get; set; }

    }
}
