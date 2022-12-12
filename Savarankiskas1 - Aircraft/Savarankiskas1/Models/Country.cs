using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas1.Models
{
    public class Country
    {
        public int countryId { get; set; }
        public string countryName { get; set; }
        public Boolean fromEU { get; set; }

        public Country() 
        {
            countryId = CountryRespository.AllCountries.Count+1;
            countryName = string.Empty;
            fromEU = false;
        }
    }
}
