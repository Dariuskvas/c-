using Savarankiskas1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas1
{
    public class CreateAircrafts
    {
        public void createAircrafts()
        {
            String file = @"C:\Users\Darius\Downloads\C--main (1)\C--main\Savarankiskas1\Savarankiskas1\DataFiles\Aircrafts.txt";
            List<string> linePlane = File.ReadAllLines(file).ToList();
            foreach (var plane in linePlane)
            {
                string[] valueOfAircraft = plane.Split(',');

                Aircraft aircraft = new Aircraft()
                {
                    modelID = Convert.ToInt16(valueOfAircraft[0]),
                    companyID = Convert.ToInt16(valueOfAircraft[1]),
                    countryID = Convert.ToInt16(valueOfAircraft[2]),
                };
                AircraftRespository.allAircraft.Add(aircraft);
            }
        }
    }
}
