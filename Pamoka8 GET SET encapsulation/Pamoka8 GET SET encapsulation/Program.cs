// See https://aka.ms/new-console-template for more information
using Pamoka8_GET_SET_encapsulation;

Console.WriteLine("Hello, World!");

CreateInvoiceSender invoiceSender3 = new CreateInvoiceSender();
invoiceSender3.creatinvoice2();
invoiceSender3.creatinvoice1();


foreach (var x in InvoiceRespository.allInvoice)
{
    Console.WriteLine(x.Sender, x.Receiver);
}
