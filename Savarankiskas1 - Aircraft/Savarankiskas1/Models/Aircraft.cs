 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas1.Models
{
    public class Aircraft
    {
        public int id { get; set; }
        public int modelID { get; set; }
        public int companyID { get; set; }
        public int countryID { get; set; }

        public Aircraft()
        {
            id= AircraftRespository.allAircraft.Count+1;
            modelID= 0;
            companyID= 0;
            countryID= 0;
        }

    }
}
