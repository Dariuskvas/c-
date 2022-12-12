using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Models;
using TicketingSystem.Models.Tickets;

namespace TicketingSystem
{
    public class TicketReportService
    {
        public void GenerateReport(DateTime from, DateTime to)
        {

        }

        public void GenerateReport()
        {
            Report report = new Report();
            decimal price = 0;
            foreach (SoldItem soldItem in TicketRepository.soldItems)
            {
                foreach (Ticket ticket in TicketRepository.products) {
                    if(ticket.id == soldItem.soldItemId)
                    {
                        price += ticket.price;
                    }
                }
            }
        }
    }
}
