using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListExample
{
    public class ListData
    {
        public void addlist(List<ListSample> listitem)    //function named adlist used to add data into list
        {
            ListSample obj = new ListSample();    //creating object
            


            obj.name = "apupu";         //adding data to object
            obj.age = 25;


            listitem.Add(obj);          //adding data to list



            foreach (var item in listitem)         //display list items
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.age);
            }

        }
    }
}