using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Models.Tickets
{
    public class Ticket
    {
        public virtual int id { get; set; }
        public virtual decimal price { get; set; }
    }
}
