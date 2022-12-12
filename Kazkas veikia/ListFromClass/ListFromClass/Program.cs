using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ListSample> itemlist = new List<ListSample>();   //creating a list

            ListData objlist = new ListData();

            for (int i=0; i<2; i++) {
                objlist.addlist(itemlist);
            }

            Console.WriteLine("----{0}", itemlist[0].name);
            Console.ReadLine();
        }
    }
}


// First you create a list in the main function. |ListData| is the class name in which we are using this list.

//|itemlist| is the name of list created.  |ListSample| is another class where we are getting data