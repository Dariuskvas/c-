using Savarankiskas1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas1
{
    public class CompanysRespository
    {
        public static List<Company> allCompanies = new List<Company>();

        public static List<Company> Retrieve()
        {
            return allCompanies;
        }

        public static Company Retrieve(int id)
        {
            foreach (Company company in allCompanies)
            {
                if (company.companyId == id)
                    return company;
            }
            return null;
        }
    }
}
