using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Models.Tickets
{
    public class EconomyTicket : Ticket
    {
        public override int id { get { return 2; } }

        public override decimal price { get { return 20.00m; } }
    }
}
