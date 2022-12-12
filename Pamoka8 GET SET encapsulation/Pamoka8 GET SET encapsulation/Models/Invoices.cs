using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka8_GET_SET_encapsulation.Models
{
    public class Invoices
    {
       // field
        private string receiver;
        private string sender;
        private double totalAmount;
        private string invoiceNo;

        //properties
        public string Receiver 
        {
            get {return receiver;}
            set {receiver = value;} 
        }
        public string Sender
        {
            get {return sender;}
            set {sender = value;}
        }
        public double TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }
        public string InvoiceNo
        {
            get { return invoiceNo; }
            set { invoiceNo = value; }
        }

        public Invoices()
        {
            Receiver ="";
            Sender = "";
            TotalAmount = 0;
            InvoiceNo = "";
        }

    }
}
