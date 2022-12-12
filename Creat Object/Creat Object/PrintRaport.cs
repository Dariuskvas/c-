using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creat_Object
{
    public class PrintRaport
    {
        public void printList()
        {
            foreach (var ticket in TicketRepository.allTicket) 
            {
                Console.WriteLine("Title: {0}  | Price: {1}  | Place: {2}  | Sold: {3}  | di: {4}", ticket.Title, ticket.Price, ticket.Place, ticket.Sold, ticket.id);
            }

            Console.WriteLine("-- Count free Premium ------------------------------------------------------------------------------------------------");         
            var freePremiumTicket = TicketRepository.allTicket.Count(x => x.Sold == false && x.Title == "Premium");
            Console.WriteLine(freePremiumTicket);

            Console.WriteLine("-- Count free Standard ------------------------------------------------------------------------------------------------");
            var freeStandardTicket = TicketRepository.allTicket.Count(x => x.Sold == false && x.Title == "Standard");
            Console.WriteLine(freeStandardTicket);

            Console.WriteLine("-- Count free Economy ------------------------------------------------------------------------------------------------");
            var freeEconomyTicket = TicketRepository.allTicket.Count(x => x.Sold == false && x.Title == "Economy");
            Console.WriteLine(freeEconomyTicket);

            

        }
    }
}