using Creat_Object.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Creat_Object
{
    public class CreateTickets
    {

        CreateRandomNum CreateRandomNum = new CreateRandomNum();

        public void createPremiumTicket(int qnt1)                     //Sukuriu metoda kuris gauna kintamuosius is Program
        {
            for (int i=0; i<qnt1; i++)                         
            {
                Ticket ticket = new Ticket()                     // Sukuriu Objekta, kuris ima kintamuosius is Ticket
                {
                    Title = "Premium",                         // Sie kriterijai skirtingi kiekvienai grupei
                    Price = 30,
                    id = CreateRandomNum.GetRandomNumber(99)        //ID preiskiriu Random Numeri
                };
                TicketRepository.allTicket.Add(ticket);        // Sudedu i bendra lista
            }
        }

        public void createStandardTicket(int qnt2)
        {
            for (int i = 0; i < qnt2; i++)
            {
                Ticket ticket = new Ticket
                {
                    Title = "Standard",
                    Price = 20
                };
                TicketRepository.allTicket.Add(ticket);
            }
        }


        public void CreateEconomyTicket(int qnt3)
        {
            for (int i = 0; i < qnt3; i++)
            {
                Ticket ticket = new Ticket
                {
                    Title = "Economy",
                    Price = 10
                };
                TicketRepository.allTicket.Add(ticket);
            }
        }
    }
}