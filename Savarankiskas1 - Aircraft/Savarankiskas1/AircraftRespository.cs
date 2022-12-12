using Savarankiskas1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas1
{
    public static class AircraftRespository
    {
        public static List<Aircraft> allAircraft = new List<Aircraft>();

        public static List<Aircraft> Retrieve()
        {
            return allAircraft;
        }

        public static Aircraft Retrieve(int id)
        {
            foreach (Aircraft aircraft in allAircraft)
            {
                if (aircraft.id == id)
                    return aircraft;
            }
            return null;
        }
    }





}
