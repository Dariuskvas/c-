
using TicketingSystem;
using TicketingSystem.Models;
using TicketingSystem.Models.Tickets;

TicketRepository.products.Add(new BudgetTicket());
TicketRepository.products.Add(new EconomyTicket());
TicketRepository.products.Add(new PremiumTicket());

List<BudgetTicket> budgetTickets= new List<BudgetTicket>() { new BudgetTicket(), 
                                                             new BudgetTicket(),    
                                                             new BudgetTicket(),
                                                             new BudgetTicket() 
};

List<EconomyTicket> economyTickets = new List<EconomyTicket>() { new EconomyTicket(),
                                                                 new EconomyTicket()
};

List<PremiumTicket> premiumTicket = new List<PremiumTicket>() { new PremiumTicket() };

ShoppingCart shoppingCart= new ShoppingCart() { creationDate = new DateTime(2021,04,20), budgetTickets = budgetTickets, economyTickets = economyTickets, premiumTickets = premiumTicket };

List<BudgetTicket> budgetTickets1 = new List<BudgetTicket>() { new BudgetTicket(),
                                                             new BudgetTicket(),
                                                             new BudgetTicket(),
                                                             new BudgetTicket()
};

List<EconomyTicket> economyTickets1 = new List<EconomyTicket>() { new EconomyTicket(),
                                                                 new EconomyTicket()
};

List<PremiumTicket> premiumTicket1 = new List<PremiumTicket>() { new PremiumTicket() };

ShoppingCart shoppingCart1 = new ShoppingCart() { creationDate = new DateTime(2022, 10, 11), budgetTickets = budgetTickets, economyTickets = economyTickets, premiumTickets = premiumTicket };

TicketService ticketRepository = new TicketService();
ticketRepository.SellTicket(shoppingCart);
ticketRepository.SellTicket(shoppingCart1);

TicketReportService ticketReportService = new TicketReportService();
ticketReportService.GenerateReport();

Console.ReadKey();