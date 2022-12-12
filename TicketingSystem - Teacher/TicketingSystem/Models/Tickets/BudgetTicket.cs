using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Models.Tickets
{
    public class BudgetTicket : Ticket
    {
        public override int id { get { return 1; } }

        public override decimal price { get { return 10.00m; } }
    }
}
