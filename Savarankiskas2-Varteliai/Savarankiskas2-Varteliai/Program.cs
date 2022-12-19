// See https://aka.ms/new-console-template for more information
using Savarankiskas2_Varteliai;
using Savarankiskas2_Varteliai.DataSimulation;

CreateUser createUser = new CreateUser();
createUser.createUser();

CreateGates createGates = new CreateGates();
createGates.createGates();

CreatePermits createPermits = new CreatePermits();
createPermits.createPermits();

CheckPermitions checkPermitions = new CheckPermitions();
checkPermitions.colectDataFromUserCard(1, 1);
checkPermitions.colectDataFromUserCard(1, 1);
checkPermitions.colectDataFromUserCard(1, 2);
checkPermitions.colectDataFromUserCard(1, 3);
checkPermitions.colectDataFromUserCard(1, 4);
checkPermitions.colectDataFromUserCard(1, 1);
checkPermitions.colectDataFromUserCard(6, 4);
checkPermitions.colectDataFromUserCard(6, 1);
checkPermitions.colectDataFromUserCard(6, 2);
checkPermitions.colectDataFromUserCard(6, 3);
checkPermitions.colectDataFromUserCard(6, 4);

RegisterUserScan registerUserScan= new RegisterUserScan();
registerUserScan.printList();

CreateRandomDataToProgram createRandomDataToProgram = new CreateRandomDataToProgram();
createRandomDataToProgram.createRandomDataToProgram();
