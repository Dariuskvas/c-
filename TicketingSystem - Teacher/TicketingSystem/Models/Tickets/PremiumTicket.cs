using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Models.Tickets
{
    public class PremiumTicket : Ticket
    {
        public override int id { get { return 3; } }

        public override decimal price { get { return 30.00m; } }

    }
}
