using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas1.Models
{
    public class Company
    {
        public int companyId { get; set; }
        public string companyName { get; set; }

        public Company()
        {
            companyId = CompanysRespository.allCompanies.Count+1;
            companyName= string.Empty;
        }
    }
}
