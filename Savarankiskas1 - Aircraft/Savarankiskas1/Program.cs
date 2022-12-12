// See https://aka.ms/new-console-template for more information
using Savarankiskas1;

CreateAircrafts createAircrafts = new CreateAircrafts();
createAircrafts.createAircrafts();

CreateModel createModel = new CreateModel();
createModel.createAircraftModels();

CreateCompanies createCompanies= new CreateCompanies();
createCompanies.createAircraftCompanies();

CreateCountries createCountries= new CreateCountries();
createCountries.createCountries();

CreateReports createReports = new CreateReports();
createReports.createListFromEUorNot();
createReports.createReports();

createReports.cxxx(ReportRepository.fromEU);
createReports.cxxx(ReportRepository.notFromEU);

SendEmail sendEmail = new SendEmail();
sendEmail.sendEmail();

