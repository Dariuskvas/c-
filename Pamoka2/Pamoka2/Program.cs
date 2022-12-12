
using System;

namespace pamoka_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*- 1 -------------------------------------------*/
            Console.WriteLine(" - 1 ------------------------------------------------");
            Console.WriteLine("Ivesk bet koki simboli ir ji atspausdins 4 kartus eiluteje");
            int i = 0;
            String uzd1 = Console.ReadLine();
            for (i = 0; i <= 3; i++)
            {
                Console.Write("{0}", uzd1);
            }
            Console.WriteLine("");

            /*- 2 -------------------------------------------*/
            Console.WriteLine(" - 2 ------------------------------------------------");
            Console.WriteLine("APKEIČIA DVIEJŲ KINTAMŲJŲ REIKŠMES:");
            int a = 1;
            int b = 5;
            Console.WriteLine("Pradiniai duopmenys: A = {0}; B={1}", a, b);

            int[] newMasyvas = new int[2];
            newMasyvas[1] = a;
            newMasyvas[0] = b;
            a = newMasyvas[0];
            b = newMasyvas[1];
            
            Console.WriteLine("Sukeisti duomenys: A={0}; B={1}", a, b);


            /*- 3 -------------------------------------------*/
            Console.WriteLine(" - 3 ------------------------------------------------");
            Console.WriteLine("Ivestidu skaicius ir palyginti ar vie lygus");
            Console.WriteLine("Ivesk du skaiciusvienoje eiluteje atskira tarpais arba kableliais:");
            String stringas3 = Console.ReadLine();
            char[] separatoriai = { ' ', ',' };                                    // teksto atskirimo simboliai
            String[] strlist = stringas3.Split(separatoriai);                        // Ivesta skaicviu eilute skaido i skaicius ir sukisai Array
            Console.WriteLine(strlist[0] == strlist[1]);


            /*- 4 -------------------------------------------*/
            Console.WriteLine(" - 4 ------------------------------------------------");
            Console.WriteLine("Pirm1 skaiciu padidina +1. Antra pamazina -1");
            Console.WriteLine("Ivesk du skaiciusvienoje eiluteje atskira tarpais arba kableliais:");
            String stringas4 = Console.ReadLine();
            char[] separatoriai4 = { ' ', ','};                                    // teksto atskirimo simboliai
            String[] strlist4 = stringas4.Split(separatoriai4);                     // Ivesta skaicviu eilute skaido i skaicius ir sukisai Array
            int pirmas = Int32.Parse(strlist4[0]);                                  // Paverciu is String i Int
            int antras = Int32.Parse(strlist4[1]);
            pirmas++;
            antras--;
            Console.WriteLine("Pirmas skaicius: {0}  |  Antras skaicius: {1}", pirmas, antras);

            /*- 6 -------------------------------------------*/
            Console.WriteLine(" - 5 ------------------------------------------------");
            Console.WriteLine("Tikrina ar eilute tuscia, Ivesk bet koki simboli");
            string xxx = Console.ReadLine();
            string yyy = (String.IsNullOrEmpty(xxx)) ? (" - Eilute tuscia - ") : (" - Eilutes ne tuscia - ");   //IsNullOrEmpty() jei stringas null arba tuscias bus true;
            Console.WriteLine(yyy);

            /*- 6 -------------------------------------------*/
            Console.WriteLine(" - 5 ------------------------------------------------");
            Console.WriteLine("Tikrina ar eilute tuscia, Ivesk bet koki simboli");


            Console.ReadLine();
            
        }
    }
}