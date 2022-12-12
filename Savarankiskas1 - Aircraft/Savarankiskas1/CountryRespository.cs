using Savarankiskas1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas1
{
    public class CountryRespository
    {
        public static List<Country> AllCountries= new List<Country>();


        public static List<Country> Retrieve()
        {
            return AllCountries;
        }

        public static Country Retrieve(int id)
        {
            foreach (Country countryInf in AllCountries)
            {
                if (countryInf.countryId == id)
                    return countryInf;
            }
            return null;
        }
    }
}
