using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Models;
using TicketingSystem.Models.Tickets;

namespace TicketingSystem
{
    public class TicketService
    {
        public void SellTicket(ShoppingCart shoppingCart)
        {
            foreach (BudgetTicket budgetTicket in shoppingCart.budgetTickets)
            {
                SoldItem soldItem = new SoldItem() { soldItemId  = budgetTicket.id, transactionDate = shoppingCart.creationDate};
                TicketRepository.soldItems.Add(soldItem);
            }

            foreach (EconomyTicket economyTicket in shoppingCart.economyTickets)
            {
                SoldItem soldItem = new SoldItem() { soldItemId = economyTicket.id, transactionDate = shoppingCart.creationDate };
                TicketRepository.soldItems.Add(soldItem);
            }

            foreach (PremiumTicket premiumTicket in shoppingCart.premiumTickets)
            {
                SoldItem soldItem = new SoldItem() { soldItemId = premiumTicket.id, transactionDate = shoppingCart.creationDate };
                TicketRepository.soldItems.Add(soldItem);
            }
        }

    }
}
