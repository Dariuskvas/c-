using Creat_Object;

CreateTickets createTickets = new CreateTickets();
createTickets.createPremiumTicket(10);
createTickets.createStandardTicket(10);
createTickets.CreateEconomyTicket(3);


SellTicket sellTicket = new SellTicket();
sellTicket.sellPremiumTicket(5);
sellTicket.sellStandardTicket(5);


PrintRaport printRaport = new PrintRaport();
printRaport.printList();

