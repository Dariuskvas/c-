using Pamoka8_GET_SET_encapsulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka8_GET_SET_encapsulation
{
    public class CreateInvoiceSender
    {
        public void creatinvoice1() 
        {

            Invoices invoices = new Invoices()
            {
                Receiver = "UAB verslas nuo nulio",
                Sender = "Mokeswciu inspekcija",
                TotalAmount = 10000000,
                InvoiceNo = "AAA 111111"
            };

            InvoiceRespository.allInvoice.Add(invoices);
        }

        public void creatinvoice2()
        {

            Invoices invoices = new Invoices()
            {
                Receiver = "UAB verslas nuo nulio2",
                Sender = "Mokeswciu inspekcija2",
                TotalAmount = 9999999,
                InvoiceNo = "AAA 222222"
            };

            InvoiceRespository.allInvoice.Add(invoices);
        }
    }
}
