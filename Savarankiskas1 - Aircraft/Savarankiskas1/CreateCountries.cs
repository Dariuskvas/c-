using Savarankiskas1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas1
{
    public class CreateCountries
    {
        public void createCountries()
        {
            String file = @"C:\Users\Darius\Downloads\C--main (1)\C--main\Savarankiskas1\Savarankiskas1\DataFiles\Countries.txt";
            List<string> lineCountries = File.ReadAllLines(file).ToList();
            foreach (var countryInfo in lineCountries)
            {
                string[] valueOfCountry = countryInfo.Split(',');

                Country country = new Country()
                {
                    countryName= valueOfCountry[0],
                    fromEU= Convert.ToBoolean(valueOfCountry[1]),
                };
                CountryRespository.AllCountries.Add(country);
            }
        }
    }
}
