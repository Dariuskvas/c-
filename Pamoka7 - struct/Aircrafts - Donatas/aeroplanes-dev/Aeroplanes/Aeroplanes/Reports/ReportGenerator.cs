using Aeroplanes.Models;
using Aeroplanes.Repositories;
using System;
using System.Collections.Generic;

namespace Aeroplanes.Reports
{
    public class ReportGenerator
    {
        public List<Aircraft> aircratsDatabase = AircraftRepository.Retrieve();
        public List<AircraftModel> aircraftsModelsDatabase = AircraftModelRepository.Retrieve();
        public List<Company> companysDatabase = CompanyRepository.Retrieve();
        public List<Country> countrysDatabase = CountryRepository.Retrieve();

       
        public void GenerateReportAircraftInEurope()
        {
            string aircraftTailNumber;
            string modelNumber;
            string modelDescription;
            string ownerComapanyName;
            string companyCountryCode;
            string companyCountryName;
            bool isEuCountry;

            foreach(Aircraft aircraft in aircratsDatabase)
            {
                aircraftTailNumber = aircraft.aircraftRegistrationNumber;
                AircraftModel aircraftModelData = AircraftModelRepository.Retrieve(aircraft.aircraftModelId);
                modelNumber = aircraftModelData.aircraftModelType;
                modelDescription = aircraftModelData.aircraftModelName;
                Company companyData = CompanyRepository.Retrieve(aircraft.aircraftOwnerId);
                ownerComapanyName = companyData.companyName;
                companyCountryCode = CountryRepository.Retrieve(companyData.companyCountryId).countryCode;
                companyCountryName = CountryRepository.Retrieve(companyData.companyCountryId).countryName;
                isEuCountry = CountryRepository.Retrieve(companyData.companyCountryId).isEuropeCountry;
                
                ReportItem reportItem = new ReportItem();
                reportItem.aircraftTailNumber = aircraftTailNumber;
                reportItem.modelNumber = modelNumber;
                reportItem.modelDescription = modelDescription;
                reportItem.ownerComapanyName = ownerComapanyName;
                reportItem.companyCountryCode = companyCountryCode;
                reportItem.companyCountryName = companyCountryName;
                reportItem.isEuropeCountry = isEuCountry;

                ReportItemRepository.report.Add(reportItem);
            }
        }
    }
}