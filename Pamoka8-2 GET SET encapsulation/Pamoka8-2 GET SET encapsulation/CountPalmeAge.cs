using Pamoka8_2_GET_SET_encapsulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka8_2_GET_SET_encapsulation
{

    public class CountPalmeAge
    {
        private int i = 1;
        private int d = 0;


        private int countMonnth()
        {
           return i++;
        }

       public void countUntilPalmeDie()
        {
            do
            {
                d = countMonnth();
                Palme palme = new Palme(d);
                Console.WriteLine("Age: {0}, Fruit: {1}", palme.age, palme.fruitQNT);
            } while (d<12);

            Console.WriteLine("Pasodink nauja palme");
        }

       


    }
}
