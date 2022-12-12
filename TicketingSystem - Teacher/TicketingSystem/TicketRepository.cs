using TicketingSystem.Models;
using TicketingSystem.Models.Tickets;

namespace TicketingSystem
{
    public static class TicketRepository
    {
        public static List<SoldItem> soldItems = new List<SoldItem>();

        public static List<Ticket> products = new List<Ticket>();
    }
}
