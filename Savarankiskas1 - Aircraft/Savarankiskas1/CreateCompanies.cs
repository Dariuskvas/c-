using Savarankiskas1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas1
{
    public class CreateCompanies
    {
        public void createAircraftCompanies()
        {
            String file = @"C:\Users\Darius\Downloads\C--main (1)\C--main\Savarankiskas1\Savarankiskas1\DataFiles\Companies.txt";
            List<string> lineCompanies = File.ReadAllLines(file).ToList();
            foreach (var companylInfo in lineCompanies)
            {
                string[] valueOfCompany = companylInfo.Split(',');

                Company company = new Company()
                {
                    companyName = valueOfCompany[0],
                };
                CompanysRespository.allCompanies.Add(company);
            }
        }

    }
}
