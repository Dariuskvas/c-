using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka4
{
    internal class Class5
    {
        public void uzduotis5()
        {



            int[] allNumbers = new int[20];
            Double id = 0;
          
            for(int i=0; i<=allNumbers.Length-1; i++) 
            {
                Random rnd = new Random();
                int numberRandom = rnd.Next(999);
                allNumbers[i] = numberRandom;
            }

            int maxValue = allNumbers.Max();                                        //MAX reiksme indekse
            int maxIndex = allNumbers.ToList().IndexOf(maxValue);                   //indeksas kuriame yra MAX reiksme

            int minValue = allNumbers.Min();

            Console.WriteLine("Didziauses skaicius masyve: {0}",maxValue);
            Console.WriteLine("Maziauses skaicius masyve: {0}", minValue);

            Array.Sort(allNumbers);                                                 //Rusiuojam Array su Default nustatymais

            foreach(var Numbers in allNumbers)
            {
                Console.WriteLine("[{0}]: {1}",id, Numbers);
                id++;
            }
        }
    }
}
