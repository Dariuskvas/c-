using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Models.Tickets;

namespace TicketingSystem.Models
{
    public class ShoppingCart
    {
        public DateTime creationDate = new DateTime();
        public List<BudgetTicket> budgetTickets = new List<BudgetTicket>();
        public List<EconomyTicket> economyTickets = new List<EconomyTicket>();
        public List<PremiumTicket> premiumTickets = new List<PremiumTicket>();
    }
}
