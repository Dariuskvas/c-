using Savarankiskas1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas1
{
    public class CreateReports
    {
        public void createReports()
        {
            Console.WriteLine("Sukurta modeliu:     {0}", ModelRespository.allModels.Count);
            Console.WriteLine("Sukurta kompaniju:   {0}", CompanysRespository.allCompanies.Count);
            Console.WriteLine("Sukurt saliu:        {0}", CountryRespository.AllCountries.Count);
            Console.WriteLine("Sukurta lektuvu:     {0}", AircraftRespository.allAircraft.Count);
            Console.WriteLine("Lektuvai is EU:      {0}", ReportRepository.fromEU.Count);
            Console.WriteLine("Lektuvai ne is EU:   {0}", ReportRepository.fromEU.Count);
            Console.WriteLine("------------------------------------------------------------------");
        }

        public void createListFromEUorNot()
        {
            foreach (var plane in AircraftRespository.allAircraft)
            {
                {
                    if (CountryRespository.Retrieve(plane.countryID).fromEU == true)
                        ReportRepository.fromEU.Add(plane);
                    else
                        ReportRepository.notFromEU.Add(plane);
                }
            }
        }

        public void cxxx(IEnumerable<Aircraft> listsas)
        {
            CreateHTMLTable createHTMLTable = new CreateHTMLTable();

            if (listsas == ReportRepository.fromEU)
                createHTMLTable.createHTMLHead("Lektuvai is EU");
            else
                createHTMLTable.createHTMLHead("Lektuvai ne is EU");

            foreach (var plane2 in listsas)
            {
                int x1 = plane2.id;
                string x2 = ModelRespository.Retrieve(plane2.modelID).planeModel;
                string x3 = CompanysRespository.Retrieve(plane2.companyID).companyName;
                string x4 = CountryRespository.Retrieve(plane2.countryID).countryName;
                Boolean x5 = CountryRespository.Retrieve(plane2.countryID).fromEU;

                createHTMLTable.createHTMLBody(x1, x2, x3, x4, x5);
            }

            createHTMLTable.createHTMLFile();
        }
    }
}
