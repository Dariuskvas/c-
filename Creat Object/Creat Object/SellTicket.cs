using Creat_Object.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creat_Object
{
    public class SellTicket
    {
        public int SoldPremiumTicket { get; set; }

        public void sellPremiumTicket(int PremiumSellQnt)
        {
            var freePremiumTicket = TicketRepository.allTicket.Count(tictek => tictek.Sold == false && tictek.Title == "Premium");

            if (freePremiumTicket >= PremiumSellQnt)
            {
                foreach (var xcv in TicketRepository.allTicket)
                {
                    if (xcv.Sold == false && xcv.Title == "Premium" && TicketRepository.allTicket.Count(tictek => tictek.Sold == true && tictek.Title == "Premium") <= PremiumSellQnt)
                    {
                        xcv.Sold = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Bilietu kiekis nepakamkamas, Premium turime tik {0}", freePremiumTicket);
                PremiumSellQnt = freePremiumTicket;
                foreach (var xcv in TicketRepository.allTicket.Where(tictek => tictek.Sold == false && tictek.Title == "Premium"))
                {
                    xcv.Sold = true;
                }
            }

            int soldPremiumTicket = TicketRepository.allTicket.Count(tictek => tictek.Sold == true && tictek.Title == "Premium");
        }

        public void sellStandardTicket(int StandardSellQnt)
        {
            var freeStandardTicket = TicketRepository.allTicket.Count(tictek => tictek.Sold == false && tictek.Title == "Standard");

            if (freeStandardTicket >= StandardSellQnt)
            {
                foreach (var xcv in TicketRepository.allTicket)
                {
                    if (xcv.Sold == false && xcv.Title == "Standard" && TicketRepository.allTicket.Count(tictek => tictek.Sold == true && tictek.Title == "Standard") <= StandardSellQnt)
                    {
                        xcv.Sold = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Bilietu kiekis nepakamkamas, Premium turime tik {0}", freeStandardTicket);
                StandardSellQnt = freeStandardTicket;
                foreach (var xcv in TicketRepository.allTicket.Where(tictek => tictek.Sold == false && tictek.Title == "Standard"))
                {
                    xcv.Sold = true;
                }
            }
        }
    }
}
